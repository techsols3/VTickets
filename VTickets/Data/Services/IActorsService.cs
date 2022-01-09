using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VTickets.Models;

namespace VTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();

        Task<Actor> GetByIdAsync(int id);

        Task AddAsync(Actor actor);

        Task<Actor> UpdateAsync(int id,Actor newActor);

        Task DeleteAsync(int id);
    }
}
