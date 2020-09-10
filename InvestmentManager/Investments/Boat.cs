using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentManager.Investments
{
    public class Boat
    {
        public int Length { get; set; }
        public int MeterPrice { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public int RegYear { get; set; }

        public Boat(int length, int meterPrice, string condition, string description, int regYear)
        {
            Length = length;
            MeterPrice = meterPrice;
            Condition = condition;
            Description = description;
            RegYear = regYear;
        }

        public int CalculatePrice()
        {
            int foundPrice = Length * MeterPrice;
            return foundPrice;
        }

        public string InvestSummary()
        {
            return string.Format("Boat: {0}\nLength: {1}", Description, Length);
        }
    }
}
