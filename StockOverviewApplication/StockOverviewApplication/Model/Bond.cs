namespace StockOverviewApplication.Model
{
    /// <summary>
    /// Class that represents Bond summary
    /// </summary>
    public class BondOverview
    {
        /// <summary>
        /// Gets or sets total number of bonds
        /// </summary>
        public int TotalNumberOfBondStock { get; set; }

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
