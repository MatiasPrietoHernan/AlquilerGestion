using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BussinessLogic.Interfaces
{
    public interface IDepartamentosServices
    {
        Task<Departamentos> GetDepartamentosByIdAsync(int id);
        Task<IEnumerable<Departamentos>> GetAllDepartamentosAsync();
        Task AddDepartamentoAsync(Departamentos departamento);
        Task UpdateDepartamentoAsync(Departamentos departamento);
        Task DeleteDepartamentoAsync(int id);
    }
}
