using Currency;
using Currency.US;
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

namespace CurrencyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static USCurrencyRepo repo;
        public static USCurrencyRepo Repo
        {
            get
            {

                return repo;
            }
            set { repo = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            repo = new USCurrencyRepo()
            {
                Coins = new List<ICoin> { new Penny(), new Quarter(), new Dime(), new Nickel(), new HalfDollar(), new DollarCoin() }
            };

        }

        private void ButtonRepo_Click_1 (object sender, RoutedEventArgs e)
        {
            WindowRepo window = new WindowRepo(repo);
            window.Show();
            
        }

        private void ButtonMakeChange_Click_1(object sender, RoutedEventArgs e)
        {
            MakeChange window = new MakeChange(repo);
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ControlGraphicWindow window = new ControlGraphicWindow(repo);
            window.Show();
        }
    }
}
