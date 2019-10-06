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
    /// Interaction logic for MotherUserControl.xaml
    /// </summary>
    public partial class MotherUserControl : UserControl
    {
        public MotherUserControl()
        {
            InitializeComponent();
        }
        private void AddMother_button_Click(object sender, RoutedEventArgs e)
        {
            new AddMother().Show();
        }

        private void RemoveMother_button_Click(object sender, RoutedEventArgs e)
        {
            new RemoveMother().Show();
        }


        private void UpdateMother_button_Click(object sender, RoutedEventArgs e)
        {
            new UpdateMother().Show();
        }
    }
}
