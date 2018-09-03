using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventSoucing.Repositories.Ship.Domain
{
    public interface IShipRepository
    {
        Task<List<EventSourcing.Models.Ship>> GetListShip();

        Task<EventSourcing.Models.Ship> GetShipById(int id);
    }
}
