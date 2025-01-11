using BussinessLogic.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Services
{
    public class PagosServices : IPagosService
    {
        private readonly IGenericRepositry<Pago> pagoRepository;

        private readonly IGenericRelations<Pago> genericRelations;

        public PagosServices(IGenericRepositry<Pago> _pagoRepository, IGenericRelations<Pago> _genericRelations)
        {
            pagoRepository = _pagoRepository;
            genericRelations = _genericRelations;
        }

        public async Task<Pago> GetPagoByIdAsync(int id)
        {
            return await pagoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Pago>> GetAllPagoAsync()
        {
            return await pagoRepository.GetAllAsync();
        }

        public async Task AddPagoAsync(Pago pago)
        {
            await pagoRepository.AddAsync(pago);
        }

        public async Task UpdatePagoAsync(Pago pago)
        {
            await pagoRepository.UpdateAsync(pago);
        }

        public async Task DeletePagoAsync(int id)
        {
            await pagoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Pago>> GetPagosConRelacionesAsync()
        {
            return await genericRelations.GetAllWithRelations();
        }
    }
}
