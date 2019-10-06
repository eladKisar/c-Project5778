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
    /// Interaction logic for NannyUserControl1.xaml
    /// </summary>
    public partial class NannyUserControl1 : UserControl
    {
        public NannyUserControl1()
        {
            InitializeComponent();
        }
        private void AddNanny_button_Click(object sender, RoutedEventArgs e)
        {
            new AddNanny().Show();
        }

        private void RemoveNanny_button_Click(object sender, RoutedEventArgs e)
        {
            new RemoveNanny().Show();
        }
        private void UpdateNanny_button_Click(object sender, RoutedEventArgs e)
        {
            new UpdateNanny().Show();
        }
    }
}
