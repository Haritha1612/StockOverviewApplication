using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOverviewApplication.Helper
{
    /// <summary>
    /// Class that represents possible constants
    /// </summary>
   public static class Constants
    {
        public static float BondTolerence = 1000000;
        public static float EquityTolerence = 200000;
        public static float TransactionCostForBonds = 0.2F;
        public static float TransactionCostForEquity = 0.5F;
    }
}
