using ILonic.API.Entities;
using ILonic.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILonic.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly IDataRepository _dataRepository;
        public DataController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet("get-data-list")]
        public async Task<ActionResult<IReadOnlyList<TempData>>> Register()
        {
            var result = await _dataRepository.DataList();
            return Ok(result);
        }
    }
}
