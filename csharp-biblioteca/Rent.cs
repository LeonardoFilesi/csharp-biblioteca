using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Rent
    {
        public string RentingUserSurname { get; set; }
        public string ItemIdCode { get; set; }
        public DateTime RentBeginDate { get; set; }
        public DateTime RentEndDate { get; set; }

        public Rent(string rentingUserSurname, string itemIdCode, DateTime rentBeginDate, DateTime rentEndDate)
        {
            this.RentingUserSurname = rentingUserSurname;
            this.ItemIdCode = itemIdCode;
            this.RentBeginDate = rentBeginDate;
            this.RentEndDate = rentEndDate;
        }
    }
}
