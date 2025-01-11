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
    public class GlobalSearch : IGlobalSearch
    {
        private readonly AppDbContext context;

        public GlobalSearch(AppDbContext _context)
        {
            context = _context ?? throw new ArgumentNullException(nameof(_context));
        }


        public async Task<List<object>> GlobalSearching(string term)
        {
            var results = new List<object>();

            var departamentos = await context.Set<Departamentos>()
                .Where(d => d.Nombre.Contains(term)).ToListAsync();

            var inquilinos = await context.Set<Inquilinos>()
                .Where(i => i.Nombre.Contains(term) || i.Correo.Contains(term)).ToListAsync();

            var pagos = await context.Set<Pago>()
                .Where(p => p.FechaPago.ToString("yyyy-MM-dd").Contains(term)).ToListAsync();


            var alquiler = await context.Set<HistorialAlquiler>()
                .Where(a => a.FechaInicio.ToString("yyyy-MM-dd").Contains(term)).ToListAsync();

            results.AddRange(departamentos);
            results.AddRange(inquilinos);
            results.AddRange(pagos);
            results.AddRange(alquiler);

            return results;
        }

    }
}
