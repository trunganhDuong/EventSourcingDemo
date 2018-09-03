using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EventSoucing.Repositories.Ship.Domain;
using EventSourcing.Enums.Data;
using EventSourcing.Models.Data;

namespace EventSourcing.Repositories.Ship.Infrastructure
{
    public class ShipRepository:IShipRepository
    {
        private readonly IConnectDatabase _connectDatabase;

        public ShipRepository(IConnectDatabase connectDatabase)
        {
            _connectDatabase = connectDatabase;
        }
        public async Task<List<Models.Ship>> GetListShip()
        {
            var data = await _connectDatabase.ExecuteToTable("Ship_Get_List", new SqlParameters(),
                ExecutionType.StoreProcedure);
            var result = new List<Models.Ship>();

            if (data != null)
            {
                result = AutoMapper<Models.Ship>.Map(data);
            }

            return result;
        }

        public async Task<Models.Ship> GetShipById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
