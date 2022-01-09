using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VTickets.Models;

namespace VTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly ApplicationDbContext _db;

        public ActorsService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Actor actor)
        {
           await _db.Actors.AddAsync(actor);
           await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var actor = await _db.Actors.FirstOrDefaultAsync(a => a.Id == id);
            _db.Actors.Remove(actor);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result =await _db.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var actor =await _db.Actors.FirstOrDefaultAsync(a=>a.Id==id);
            return actor;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _db.Actors.Update(newActor);
            await _db.SaveChangesAsync();
            return newActor;
        }
    }
}
