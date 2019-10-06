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
    /// Interaction logic for RemoveContract.xaml
    /// </summary>
    public partial class RemoveContract : Window
    {
        
        BL.IBL bl;
        public RemoveContract()
        {
            InitializeComponent();
            bl = BL.Bl_Singleton.GetBl();
            this.RemoveContractComboBox.ItemsSource = bl.GetContractList().Select(it => it._NumberOfContract).ToArray(); ;

        }
        private string GetSelectedChildId()
        {
            object result = this.RemoveContractComboBox.SelectedValue;
            if (result == null)
                throw new Exception("must select number contract First");
            return result.ToString();
        }
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            bool b = false;
            try
            {
                if (this.RemoveContractComboBox.IsEnabled == true)
                    b = bl.RemoveContract(int.Parse(GetSelectedChildId()));
                else
                    b = bl.RemoveContract(int.Parse(this.numberContractTaxtBox.Text));

                if (b)
                    MessageBox.Show("Deletion succeeded");
                else
                    MessageBox.Show("Deletion not succeeded");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.RemoveContractComboBox.ItemsSource = bl.GetContractList().Select(it => it._NumberOfContract);
            this.numberContractTaxtBox.IsEnabled = true;
            this.numberContractTaxtBox.Text = "";
        }
        private void numberContractTaxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.numberContractTaxtBox.Text != "")
                 this.RemoveContractComboBox.IsEnabled = false;
            else
                this.RemoveContractComboBox.IsEnabled = true;
        }
        private void RemoveContractComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            this.numberContractTaxtBox.IsEnabled = false;
        }
       
      
    }
}
