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
    /// Interaction logic for Remove_Child.xaml
    /// </summary>
    public partial class Remove_Child : Window
    {
        BL.IBL bl;
       
        public Remove_Child()
        {
            InitializeComponent();
            bl = BL.Bl_Singleton.GetBl();
          this.RemoveChildComboBox.ItemsSource = bl.GetChildList().Select(it => it._IdOfChild);
         
        }
        private string GetSelectedChildId()
        {
            object result = this.RemoveChildComboBox.SelectedValue;
            if (result == null)
                throw new Exception("must select child id First");
            return result.ToString();
        }
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            bool b = false;
            try
            {
                if (this.RemoveChildComboBox.IsEnabled == true)
                    b = bl.RemoveChild(int.Parse(GetSelectedChildId()));
                else
                    b = bl.RemoveChild(int.Parse(this.idChildTaxtBox.Text));
                if(b)
                    MessageBox.Show("Deletion succeeded");

                else
                    MessageBox.Show("Deletion not succeeded");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
        private void idChildTaxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.idChildTaxtBox.Text != "")
            {
                this.RemoveChildComboBox.IsEnabled = false;
            }
            else
                this.RemoveChildComboBox.IsEnabled = true;
        }
        private void RemoveChildComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
                this.idChildTaxtBox.IsEnabled = false;
        }
    }
}
