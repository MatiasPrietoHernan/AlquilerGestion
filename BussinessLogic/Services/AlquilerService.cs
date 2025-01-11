using BussinessLogic.Interfaces;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BussinessLogic.Services
{
    public class AlquilerService : IAlquilerService
    {
        private readonly IGenericRepositry<HistorialAlquiler> alquilerRepository;

        private readonly IGenericRelations<HistorialAlquiler> genericRelations;

        public AlquilerService(IGenericRepositry<HistorialAlquiler> _alquilerRepository, IGenericRelations<HistorialAlquiler> _genericRelations)
        {
            alquilerRepository = _alquilerRepository;
            genericRelations = _genericRelations;
        }

        public async Task<HistorialAlquiler> GetHistorialByIdAsync(int id)
        {
            return await alquilerRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<HistorialAlquiler>> GetAllHistorialAsync()
        {
            return await alquilerRepository.GetAllAsync();
        }

        public async Task AddHistorialAsync(HistorialAlquiler alquiler)
        {
            await alquilerRepository.AddAsync(alquiler);
        }

        public async Task UpdateHistorialAsync(HistorialAlquiler alquiler)
        {
            await alquilerRepository.UpdateAsync(alquiler);
        }

        public async Task DeleteHistorialAsync(int id)
        {
            await alquilerRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<HistorialAlquiler>> GetAlquilerWithRelationsAsnc()
        {
            return await genericRelations.GetAllWithRelations();
        }
    }
}
