using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class AlquilerRepository : IGenericRelations<HistorialAlquiler>
    {
        private readonly AppDbContext appDbContext;

        public AlquilerRepository(AppDbContext _context)
        {
            appDbContext = _context;
        }

        public async Task<IEnumerable<HistorialAlquiler>> GetAllWithRelations()
        {
            return await appDbContext.HitorialAlquilers.Include(h => h.Departamento)
                .Include(i => i.Inquilino).ToListAsync();
        }
    }
}
