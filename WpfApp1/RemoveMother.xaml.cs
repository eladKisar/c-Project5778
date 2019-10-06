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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for RemoveMother.xaml
    /// </summary>
    public partial class RemoveMother : Window
    {
        BL.IBL bl;
        public RemoveMother()
        {
            InitializeComponent();
            bl = BL.Bl_Singleton.GetBl();
            this.RemoveMotherComboBox.ItemsSource = bl.GetMotherList().Select(it => it._id).ToArray();
          
        }
        private string GetSelectedChildId()
        {
            object result = this.RemoveMotherComboBox.SelectedValue;
            if (result == null)
                throw new Exception("must select mother id First");
            return result.ToString();
        }
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            bool b = false;
            try
            {
                if (this.RemoveMotherComboBox.IsEnabled == true)
                    b = bl.RemoveMother(int.Parse(GetSelectedChildId()));
                else
                    b = bl.RemoveMother(int.Parse(this.idMotherTaxtBox.Text));


                if (b)
                    MessageBox.Show("Deletion succeeded");
                else
                    MessageBox.Show("Deletion not succeeded");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            this.RemoveMotherComboBox.ItemsSource = bl.GetMotherList().Select(it => it._id).ToArray();
            this.idMotherTaxtBox.IsEnabled = true;
            this.idMotherTaxtBox.Text = "";
        }


       private void idMotherTaxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.idMotherTaxtBox.Text != "")
            {
                this.RemoveMotherComboBox.IsEnabled = false;
            }
            else
                this.RemoveMotherComboBox.IsEnabled = true;
        }

        private void RemoveMotherComboBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (this.RemoveMotherComboBox.Text != "")
            {
                this.idMotherTaxtBox.IsEnabled = false;
            }
        }
    }
}
