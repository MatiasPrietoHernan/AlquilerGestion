using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Interfaces
{
    public interface IGlobalSearchServices
    {
        Task<List<object>> BuscarGlobalAsync(string term);
    }
}
