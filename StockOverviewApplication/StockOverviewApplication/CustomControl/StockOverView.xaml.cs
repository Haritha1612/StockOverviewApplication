using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockOverviewApplication.CustomControl
{
    /// <summary>
    /// Interaction logic for StockOverView.xaml
    /// </summary>
    public partial class StockOverView : UserControl
    {



        public string TotalNumber
        {
            get { return (string)GetValue(TotalNumberProperty); }
            set { SetValue(TotalNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalNumberProperty =
            DependencyProperty.Register("TotalNumber", typeof(string), typeof(StockOverView));




        public string TotalStockWeight
        {
            get { return (string)GetValue(TotalStockWeightProperty); }
            set { SetValue(TotalStockWeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalStockWeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalStockWeightProperty =
            DependencyProperty.Register("TotalStockWeight", typeof(string), typeof(StockOverView));


        public string TotalMarketValue
        {
            get { return (string)GetValue(TotalMarketValueProperty); }
            set { SetValue(TotalMarketValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalStockWeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalMarketValueProperty =
            DependencyProperty.Register("TotalMarketValue", typeof(string), typeof(StockOverView));

        public StockOverView()
        {
            InitializeComponent();
            DataContext = this.DataContext;
        }
    }
}
