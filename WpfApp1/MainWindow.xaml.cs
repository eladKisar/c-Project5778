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
using WpfApp1.Grouping;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closing += MainWindow_Closed;
        }
        private void MainWindow_Closed(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void child_Button_Click(object sender, RoutedEventArgs e)
        {
            ChildUserControl uc = new ChildUserControl();
            this.contentControl.Content = uc;




        }
        private void nanny_Button_Click(object sender, RoutedEventArgs e)
        {
            NannyUserControl1 uc = new NannyUserControl1();
            this.contentControl.Content = uc;
        }

        private void mother_Button_Click(object sender, RoutedEventArgs e)
        {
            MotherUserControl uc = new MotherUserControl();
            this.contentControl.Content = uc;
        }

        private void contract_Button_Click(object sender, RoutedEventArgs e)
        {
            ContractUserControl1 uc = new ContractUserControl1();
            this.contentControl.Content = uc;
        }

        private void Grpubing_Button_Click(object sender, RoutedEventArgs e)
        {
            new GroupingWindow().Show();
        }
    }
}
