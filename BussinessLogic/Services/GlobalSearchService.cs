using BussinessLogic.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Services
{
    public class GlobalSearchService : IGlobalSearchServices
    {
        private readonly GlobalSearch globalSearch;

        public GlobalSearchService(GlobalSearch _globalSearch)
        {
            globalSearch = _globalSearch;
        }
        public async Task<List<object>> BuscarGlobalAsync(string term)
        {
            return await globalSearch.GlobalSearching(term);
        }
    }
}
