using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BussinessLogic.Interfaces
{
    public interface IInquilinosService
    {
        Task<Inquilinos> GetInquilinoByIdAsync(int id);
        Task<IEnumerable<Inquilinos>> GetAllInquilinosAsync();
        Task AddInquilinosAsync(Inquilinos inquilino);
        Task UpdateInquilinosAsync(Inquilinos inquilino);
        Task DeleteInquilinoAsync(int id);


    }
}
