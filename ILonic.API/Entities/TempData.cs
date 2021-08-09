using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILonic.API.Entities
{
    public class TempData
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}
