using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class PagoRepository : IGenericRelations<Pago>
    {
        private readonly AppDbContext appDbContext;
        public PagoRepository(AppDbContext _appDbContext) 
        {
            appDbContext = _appDbContext;
        }

        public async Task<IEnumerable<Pago>> GetAllWithRelations()
        {
            return await appDbContext.Pagos.Include(p => p.HistorialAlquiler)
                .ThenInclude(h => h.Departamento) // Cargar departamento
            .Include(p => p.HistorialAlquiler.Inquilino) // Cargar inquilino
            .ToListAsync();

        }
    }
}
