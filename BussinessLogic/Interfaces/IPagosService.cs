using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BussinessLogic.Interfaces
{
    public interface IPagosService
    {
        Task<Pago> GetPagoByIdAsync(int id);
        Task<IEnumerable<Pago>> GetAllPagoAsync();
        Task AddPagoAsync(Pago pago);
        Task UpdatePagoAsync(Pago pago);
        Task DeletePagoAsync(int id);
        Task<IEnumerable<Pago>> GetPagosConRelacionesAsync();
    }
}
