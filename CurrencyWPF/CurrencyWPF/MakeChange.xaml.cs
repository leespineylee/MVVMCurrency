using Currency;
using CurrencyWPF.ViewModels;
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
using System.Windows.Shapes;

namespace CurrencyWPF
{
    /// <summary>
    /// Interaction logic for MakeChange.xaml
    /// </summary>
    public partial class MakeChange : Window
    {

        

        public MakeChange(ICurrencyRepo repo)
        {
            InitializeComponent();
            this.MakeChangeView1.DataContext = new MakeChangeViewModel(repo);
            
       
        }

    }
}
