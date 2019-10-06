using BL;
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

namespace WpfApp1.Grouping
{
    /// <summary>
    /// Interaction logic for NannyWithExperienceUserControl1.xaml
    /// </summary>
    public partial class NannyWithExperienceUserControl1 : UserControl
    {
        IBL bl;
        public NannyWithExperienceUserControl1()
        {

            InitializeComponent();
            bl = Bl_Singleton.GetBl();
            for (int i = 0; i < 21; i++)
                comboBox.Items.Add(i);


        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                listView.ItemsSource = bl.nannyWithExperience((int)comboBox.SelectedItem);

            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }
       
    }
}
