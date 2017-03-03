namespace StockOverviewApplication.Model
{
    /// <summary>
    /// Class that represents Equity summary
    /// </summary>
    public class EquityOverview
    {
        /// <summary>
        /// Gets or sets total number of Equity funds
        /// </summary>
        public int TotalNumberOfEquityStock { get; set; }

        /// <summary>
        /// Gets or sets total stock weight
        /// </summary>
        public float TotalStockWeight { get; set; }

        /// <summary>
        /// Gets or sets total market value
        /// </summary>
        public float TotalMarketValue { get; set; }
    }

}
