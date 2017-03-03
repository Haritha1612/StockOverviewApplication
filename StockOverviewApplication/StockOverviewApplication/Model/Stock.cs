using StockOverviewApplication.Helper;
using System;
using System.ComponentModel;

namespace StockOverviewApplication.Model
{
    /// <summary>
    /// Class that represents stock properties
    /// </summary>
    public class Stock : INotifyPropertyChanged
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Sock Type
        /// </summary>
        public StockType StockType { get; set; }

        /// <summary>
        /// Gets stock name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets stock price
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Gets or sets stock quantity
        /// </summary>
        public float Quantity { get; set; }

        /// <summary>
        /// Gets the market value
        /// </summary>
        public float MarketValue { get { return GetMarketValue(); } }

        /// <summary>
        /// Gets the transaction cost
        /// </summary>
        public float TransactionCost { get { return GetTransactionCost(); } }

        /// <summary>
        /// Gets the stock weight in percentage
        /// </summary>
        public float StockWeight { get; private set; }

        /// <summary>
        /// Returns <c>true</c> if the market value is negative
        /// </summary>
        public bool IsMarketValueNegative { get { return ValidateMarketValue(); } }

        /// <summary>
        /// Returns <c>true</c> if the transaction cost is above tolerence
        /// </summary>
        public bool IsAcceptableTolerence { get { return ValidateTolerence(); } }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Method to validate tolenrence according to the stock type
        /// </summary>
        /// <returns><c>true</c> if acceptable tolerence, else <c>false</c></returns>
        private bool ValidateTolerence()
        {
            if (StockType == StockType.Bond)
            {
                return TransactionCost <= Constants.TransactionCostForBonds;
            }

            return TransactionCost <= Constants.TransactionCostForEquity;
        }

        /// <summary>
        /// Method to validate Market value for negative data
        /// </summary>
        /// <returns><c>true</c> if negative, else <c>false</c></returns>
        private bool ValidateMarketValue()
        {
            return MarketValue < 0;
        }

        private float GetTransactionCost()
        {
            return (MarketValue * (StockType == StockType.Bond ?
                                    Constants.TransactionCostForBonds :
                                    Constants.TransactionCostForEquity));
        }

        private float GetMarketValue()
        {
            return Price * Quantity;
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        internal void UpdateStockWeight(float totalMarketValue)
        {
            StockWeight = (MarketValue / totalMarketValue) * 100;
            OnPropertyChanged("StockWeight");
        }
        #endregion

    }

    /// <summary>
    /// Enumeration that represents stock type
    /// </summary>
    public enum StockType
    {
        None,
        Bond,
        Equity,
    }
}
