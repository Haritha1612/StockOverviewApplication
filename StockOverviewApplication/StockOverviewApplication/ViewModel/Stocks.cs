using StockOverviewApplication.Helper;
using StockOverviewApplication.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;

namespace StockOverviewApplication.ViewModel
{
    public class StockOverview : INotifyPropertyChanged
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Sock Type
        /// </summary>
        public StockType StockType { get { return stockType; } set { stockType = value; OnPropertyChanged("StockType"); } }
        
        /// <summary>
        /// Gets or sets stock price
        /// </summary>
        public float? Price { get { return price; } set { price = value; OnPropertyChanged("Price"); } }

        /// <summary>
        /// Gets or sets stock quantity
        /// </summary>
        public float? Quantity { get { return quantity; } set { quantity = value; OnPropertyChanged("Quantity"); } }

        /// <summary>
        /// Gets or sets the list of Stocks created.
        /// </summary>
        public ObservableCollection<Stock> Stocks { get { return stocks; } set { stocks = value; OnPropertyChanged("Stocks"); } }

        /// <summary>
        /// Gets or sets Equity details.
        /// </summary>
        public EquityOverview EquitySummary { get { return equitySummary; } set { equitySummary = value; OnPropertyChanged("EquitySummary"); } }

        /// <summary>
        /// Gets or sets Bonds details.
        /// </summary>
        public BondOverview BondSummary { get { return bondSummary; } set { bondSummary = value; OnPropertyChanged("BondSummary"); } }

        /// <summary>
        /// Gets or sets total number of stocks created.
        /// </summary>
        public int TotalNumberOfStocks { get { return totalNumberOfStocks; } set { totalNumberOfStocks = value; OnPropertyChanged("TotalNumberOfStocks"); } }

        /// <summary>
        /// Gets or sets total stocks weight.
        /// </summary>
        public float TotalStockWeight { get { return totalStockWeight; } set { totalStockWeight = value; OnPropertyChanged("TotalStockWeight"); } }

        /// <summary>
        /// Gets or sets total market value.
        /// </summary>
        public float TotalMarketValue { get { return totalMarketValue; } set { totalMarketValue = value; OnPropertyChanged("TotalMarketValue"); } }
        
        #endregion

        #region Commands

        public ICommand AddStockCommand { get; private set; }
        #endregion

        public StockOverview()
        {
            AddStockCommand = new RelayCommand(AddStock);
            Stocks = new ObservableCollection<Stock>();
        }

        #region Private Methods

        /// <summary>
        /// Method to add stocks to the collection
        /// </summary>
        /// <param name="obj"></param>
        private void AddStock(object obj)
        {
            if (Price == null)
            {
                return;
            }
            if (Price == null)
            {
                return;
            }
            if (Stocks == null)
            {
                Stocks = new ObservableCollection<Stock>();
            }
            try
            {
                string name = $"{StockType.ToString()}{Stocks.Where(x => x.StockType == stockType).Count() + 1}";
                Stocks.Add(new Stock()
                {
                    StockType = this.StockType,
                    Name = name,
                    Price = (float)this.Price,
                    Quantity = (float)this.Quantity
                });

                UpdateEquitySummary();
                UpdateBondSummary();
                TotalMarketValue = Stocks.Select(x => x.MarketValue).Sum();
                TotalNumberOfStocks = Stocks.Count();
                TotalStockWeight = Stocks.Select(x => x.StockWeight).Sum();
                UpdateStockWeight();
                OnPropertyChanged("Stocks");
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"Exception - AddStock, Details : {ex.Message}");
            }
        }

        /// <summary>
        /// Method that updates total stock weight
        /// </summary>
        private void UpdateStockWeight()
        {
            foreach (var Stock in Stocks)
            {
                Stock.UpdateStockWeight(TotalMarketValue);
            }
        }

        /// <summary>
        /// Method that updates Bond summary
        /// </summary>
        private void UpdateBondSummary()
        {
            if (Stocks == null) return;

            if (Stocks.Count == 0) return;

            if (BondSummary == null)
            {
                BondSummary = new Model.BondOverview();
            }

            BondSummary.TotalMarketValue = Stocks.Where(x => x.StockType == StockType.Bond).Sum(x => x.MarketValue);
            BondSummary.TotalNumberOfBondStock = Stocks.Where(x => x.StockType == StockType.Bond).Count();
            BondSummary.TotalStockWeight = Stocks.Where(x => x.StockType == StockType.Bond).Sum(x => x.StockWeight);

            OnPropertyChanged("BondSummary");
        }

        /// <summary>
        /// Method that updates Equity summary
        /// </summary>
        private void UpdateEquitySummary()
        {
            if (Stocks == null) return;

            if (Stocks.Count == 0) return;

            if (EquitySummary == null)
            {
                EquitySummary = new Model.EquityOverview();
            }

            EquitySummary.TotalMarketValue = Stocks.Where(x => x.StockType == StockType.Equity).Sum(x => x.MarketValue);
            EquitySummary.TotalNumberOfEquityStock = Stocks.Where(x => x.StockType == StockType.Equity).Count();
            EquitySummary.TotalStockWeight = Stocks.Where(x => x.StockType == StockType.Equity).Sum(x => x.StockWeight);

            OnPropertyChanged("EquitySummary");
        }

        #endregion

        #region Private members

        private StockType stockType;
        private ObservableCollection<Stock> stocks;
        private float? price;
        private float? quantity;
        private EquityOverview equitySummary;
        private BondOverview bondSummary;
        private int totalNumberOfStocks;
        private float totalStockWeight;
        private float totalMarketValue;
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
        #endregion
    }
}
