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
    /// Interaction logic for RemoveNanny.xaml
    /// </summary>
    public partial class RemoveNanny : Window
    {
       
        BL.IBL bl;
       public RemoveNanny()
        {
            InitializeComponent();
            bl = BL.Bl_Singleton.GetBl();
            this.RemoveNannyComboBox.ItemsSource = bl.GetNannyList().Select(it => it._id).ToArray();
            



        }
        private string GetSelectedChildId()
        {
            object result = this.RemoveNannyComboBox.SelectedValue;
            if (result == null)
                throw new Exception("must select nanny id First");
            return result.ToString();
        }
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            bool b = false;
            try
            {
                if (this.RemoveNannyComboBox.IsEnabled == true)//למה אם זה בהערה הרשימה לא מתעדכנת
                    b = bl.RemoveNanny(int.Parse(GetSelectedChildId()));
                else
                    b = bl.RemoveNanny(int.Parse(this.idNannyTaxtBox.Text));
               

                if (b)
                    MessageBox.Show("Deletion succeeded");
                else
                    MessageBox.Show("Deletion not succeeded");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.RemoveNannyComboBox.ItemsSource = bl.GetNannyList().Select(it => it._id).ToArray();
            this.idNannyTaxtBox.IsEnabled = true;
            this.idNannyTaxtBox.Text = "";
        }




       

       
        private void idNannyTaxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.idNannyTaxtBox.Text != "")
            {
                this.RemoveNannyComboBox.IsEnabled = false;
            }
            else
                this.RemoveNannyComboBox.IsEnabled = true;
        }

        private void RemoveNannyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          this.idNannyTaxtBox.IsEnabled = false;
        }
    }
}
