using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class HireDate
    {
        #region properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        #endregion
        #region Constructor
        public HireDate(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"HireDate : {Day}/{Month}/{Year}";
        }
        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }

        #endregion
    }
}
