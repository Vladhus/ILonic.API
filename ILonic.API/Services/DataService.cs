using ILonic.API.Data;
using ILonic.API.Entities;
using ILonic.API.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILonic.API.Services
{
    public class DataService : IDataRepository
    {
        private readonly DataContext _context;
        public DataService(DataContext context)
        {
            _context = context;
        }
        public async Task<IReadOnlyList<TempData>> DataList()
        {
            return await _context.TempDatas.ToListAsync() ;
        }
    }
}
