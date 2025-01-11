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
    public class InquilinosServices : IInquilinosService
    {
        private readonly IGenericRepositry<Inquilinos> _InquilinoRepository;

        public InquilinosServices(IGenericRepositry<Inquilinos> inquilinosRepository)
        {
            _InquilinoRepository = inquilinosRepository;
        }

        public async Task<Inquilinos> GetInquilinoByIdAsync(int id)
        {
            return await _InquilinoRepository.GetByIdAsync(id);
        }
        
        public async Task<IEnumerable<Inquilinos>> GetAllInquilinosAsync()
        {
            return await _InquilinoRepository.GetAllAsync();
        }

        public async Task AddInquilinosAsync(Inquilinos Inquilino)
        {
            await _InquilinoRepository.AddAsync(Inquilino);

        }

        public async Task UpdateInquilinosAsync(Inquilinos inquilino)
        {
            await _InquilinoRepository.UpdateAsync(inquilino);
        }

        public async Task DeleteInquilinoAsync(int id)
        {
            await _InquilinoRepository.DeleteAsync(id);
        }
    }
}
