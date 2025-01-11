using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BussinessLogic.Interfaces
{
    public interface IAlquilerService
    {
        Task<HistorialAlquiler> GetHistorialByIdAsync(int id);
        Task<IEnumerable<HistorialAlquiler>> GetAllHistorialAsync();
        Task AddHistorialAsync(HistorialAlquiler historial);
        Task UpdateHistorialAsync(HistorialAlquiler historial);
        Task DeleteHistorialAsync(int id);
        Task<IEnumerable<HistorialAlquiler>> GetAlquilerWithRelationsAsnc();

    }
}
