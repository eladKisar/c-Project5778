using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using BL;
using BE;
namespace WpfApp1.Grouping
{
    /// <summary>
    /// Interaction logic for ByDistanceUserControl1.xaml
    /// </summary>
    public partial class ByDistanceUserControl1 : UserControl
    {
        private IEnumerable source;
        IBL bl;
        public IEnumerable Source
        {
            get { return source; }
            set
            {
                source = value;
                this.listView.ItemsSource = source;
            }
        }
        public ByDistanceUserControl1()
        {
            InitializeComponent();
            bl = Bl_Singleton.GetBl();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           if(this.ComboBoxorder.SelectedIndex==0)
            {
                new Thread(() =>
                {
                    var v = bl.GroupingByDistance(true).ToList();
                    Dispatcher.BeginInvoke(new Action(() =>
                    {
                        this.listView.ItemsSource = v;
                    }));
                }).Start();
            }
           else
            {
                new Thread(() =>
                {
                    var v = bl.GroupingByDistance().ToList();
                    Dispatcher.BeginInvoke(new Action(() =>
                    {
                        this.listView.ItemsSource = v;
                    }));
                }).Start();

            }
           
        }
    }
}
