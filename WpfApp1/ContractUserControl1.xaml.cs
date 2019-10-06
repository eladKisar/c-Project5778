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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ContractUserControl1.xaml
    /// </summary>
    public partial class ContractUserControl1 : UserControl
    {
        public ContractUserControl1()
        {
            InitializeComponent();
        }
        private void Removecontract_button_Click(object sender, RoutedEventArgs e)
        {
            new RemoveContract().Show();
        }

        private void Addcontract_button_Click(object sender, RoutedEventArgs e)
        {
            new AddContract().Show();
        }

        private void Updatecontract_button_Click(object sender, RoutedEventArgs e)
        {
            new UpdateContract().Show();
        }
    }
}
