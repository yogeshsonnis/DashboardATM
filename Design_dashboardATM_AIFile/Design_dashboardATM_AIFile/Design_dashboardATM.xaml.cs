using Design_dashboardATM_AIFile.Classes;
using Design_dashboardATM_AIFile.CommonControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

        public Design_dashboardATM()
        {
            InitializeComponent();
            this.DataContext = new ATM_ViewModel();
        }
        
        private void prevButton_Click(object sender, RoutedEventArgs e)
        {
            if (sliderListbox.SelectedIndex > 0)
                sliderListbox.SelectedIndex--;
            sliderListbox.ScrollIntoView(sliderListbox.SelectedItem);

        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (sliderListbox.SelectedIndex < sliderListbox.Items.Count - 1)
                sliderListbox.SelectedIndex++;
            sliderListbox.ScrollIntoView(sliderListbox.SelectedItem);
        }
    }
}
