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
using BE;
using BL;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for SigningContract.xaml
    /// </summary>
 
    public partial class SigningContract : Window
    {

        IBL bl;
        Contract contract;
        public SigningContract( Contract contratSave)
        {
            InitializeComponent();
            contract = contratSave;
            bl = Bl_Singleton.GetBl();
            this.DataContext = contract;
            Nanny nanny = bl.GetNanny(contract._IdOfNanny);
            this.IdOfChildCOmboBox.ItemsSource = (from item in bl.GetChildList()
                                                 where contract._IdOfMother == item._IdOfMather
                                                 select item).ToList();
           
            this.IdOfChildCOmboBox.DisplayMemberPath = "_IdOfChild";
            this.IdOfChildCOmboBox.SelectedValuePath = "_IdOfChild";
           
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              
                bl.AddContract(contract);
              
                MessageBox.Show(bl.GetContractList().LastOrDefault().ToString(), "This contract has been added:");
                this.Close();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void IdOfChildCOmboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this._FinalMonthlyWagesCheckBox.Text = bl.CalculationOfWage(contract._IdOfNanny, contract._IdOfMother, contract.
               _IdOfChild).ToString();
        }
    }
}
