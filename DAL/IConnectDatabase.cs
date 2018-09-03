using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using EventSourcing.Enums.Data;
using EventSourcing.Models.Data;

namespace DAL
{
    public interface IConnectDatabase
    {
        Task<DataTable> ExecuteToTable(string storeName, SqlParameters parameters,ExecutionType type );
    }
}
