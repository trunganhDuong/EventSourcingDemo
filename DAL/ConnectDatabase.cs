using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using EventSourcing.Enums.Data;
using EventSourcing.Models.Data;
using System.Configuration;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectDatabase : IConnectDatabase
    {
        private SqlConnection _connection;

        public ConnectDatabase(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public async Task<DataTable> ExecuteToTable(string storeName, SqlParameters parameters, ExecutionType type)
        {
            try
            {
                _connection.Open();
            }
            catch (Exception e)
            {
                _connection.Close();
            }

            var command = new SqlCommand(storeName, _connection);

            switch (type)
            {
                case ExecutionType.StoreProcedure:
                    command.CommandType = CommandType.StoredProcedure;
                    break;
            }

            if (parameters != null && parameters.Parameters != null && parameters.Parameters.Count > 0)
            {
                foreach (var item in parameters.Parameters)
                {
                    command.Parameters.Add(item.Key, item.Value);
                }
            }

            var table = new DataTable();
            var reader = await command.ExecuteReaderAsync();
            table.Load(reader);

            _connection.Close();
            return table;
        }
    }
}
