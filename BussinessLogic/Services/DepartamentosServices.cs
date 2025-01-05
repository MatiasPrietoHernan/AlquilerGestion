using BussinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.Interfaces;

namespace BussinessLogic.Services
{
    internal class DepartamentosServices : IDepartamentosServices
    {
        private readonly IGenericRepositry<Departamentos> _departamentoRepository;

        public DepartamentosServices(IGenericRepositry<Departamentos> departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        public async Task<Departamentos> GetDepartamentosByIdAsync(int id)
        {
            return await _departamentoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Departamentos>> GetAllDepartamentosAsync()
        {
            return await _departamentoRepository.GetAllAsync();
        }

        public async Task AddDepartamentoAsync(Departamentos departamento)
        {
             await _departamentoRepository.AddAsync(departamento);
        }

        public async Task UpdateDepartamentoAsync(Departamentos departamento)
        {
            await _departamentoRepository.UpdateAsync(departamento);
        }

        public async Task DeleteDepartamentoAsync(int id)
        {
           await _departamentoRepository.DeleteAsync(id);
        }
    }
}
