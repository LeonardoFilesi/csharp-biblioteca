using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Rent
    {
        public int RentId { get; set; } = new Random().Next(00001, 99999);
        public string RentDates { get; set; }
        public string IdCode { get; set; }

        public Rent(string rentDates)
        {
            this.RentDates = rentDates;
        }
    }
}
