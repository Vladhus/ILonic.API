using ILonic.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILonic.API.Repositories
{
    public interface IDataRepository
    {
        Task<IReadOnlyList<TempData>> DataList();
    }
}
