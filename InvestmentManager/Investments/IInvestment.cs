using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentManager.Investments
{
    public interface IInvestment
    {
        int PriceCalculate();

        string InvestSummary();
    }
}
