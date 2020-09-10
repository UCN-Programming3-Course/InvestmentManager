using InvestmentManager.Investments;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IInvestment> investmentList = new List<IInvestment>();

            // TODO: 1. Create house and boat obejcts and add them to the inventmentList ArrayList
            investmentList.Add(new Boat(10, 12995, "Exellent", "A very nice vessel", 2003));
            investmentList.Add(new Boat(22, 1000, "Holed", "An old tub", 1935));
            investmentList.Add(new House("999 Snobb Alley", 150, 995, "Modern", "A very nice house"));
            investmentList.Add(new House("Killmotor Hill", 250, 1290, "Safe", "Not a place I would vac"));
            investmentList.Add(new House("1313 Webfoot Street", 96, 1100, "Craftsman offer", "A quite small house"));

            // TODO: 2. Iterate through the investmentList ArrayList and call the InvestSummary method on each object. Write the result for each investment on the list.
            foreach (var item in investmentList)
            {
                string summary = item.InvestSummary();
                Console.WriteLine(summary);
            }
        }
    }
}
