using Design_dashboardATM_AIFile.CommonControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Design_dashboardATM_AIFile
{
    /// <summary>
    /// Interaction logic for Design_dashboardATM.xaml
    /// </summary>
    public partial class Design_dashboardATM : CustomWindow
    {
        public ObservableCollection<string> CalculationCollection { get; set; }
        public Design_dashboardATM()
        {
            InitializeComponent();

            CalculationCollection = new ObservableCollection<string>();
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1"); 
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            searchListbox.ItemsSource = CalculationCollection;
        }
    }
}
