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
    /// Interaction logic for UpdateContract.xaml
    /// </summary>
    public partial class UpdateContract : Window
    {
       
        Contract ContractToUpdate;
        IBL bl;
        public UpdateContract()
        {
            InitializeComponent();
            ContractToUpdate = null;

            bl = Bl_Singleton.GetBl();


            this.ContractNumber.ItemsSource = bl.GetContractList();
            this.ContractNumber.DisplayMemberPath = "_NumberOfContract";
            this.ContractNumber.SelectedValuePath = "_NumberOfContract";

           

        }
        private void ContractNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.ContractNumber.SelectedItem is Contract)
            {
              
                
                this.ContractToUpdate = ((Contract)this.ContractNumber.SelectedItem).
                DeepClone<Contract>((Contract)this.ContractNumber.SelectedItem);
                this.DataContext = ContractToUpdate;
                this.IdOfChildCOmboBoxkBox.ItemsSource = bl.GetChildList();
                this.IdOfChildCOmboBoxkBox.DisplayMemberPath = "_IdOfChild";
                this.IdOfChildCOmboBoxkBox.SelectedValuePath = "_IdOfChild";

                this.IdOfChildCOmboBoxkBox.SelectedValue = ContractToUpdate._IdOfChild;

                this._FinalMonthlyWagesCheckBox.Text= bl.CalculationOfWage(ContractToUpdate._IdOfNanny, 
                    ContractToUpdate._IdOfMother,ContractToUpdate._IdOfChild).ToString();

            
            }

        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               


                bl.UpdatingContract(ContractToUpdate);
                MessageBox.Show(bl.GetContractList().FirstOrDefault(fl=>fl._NumberOfContract==ContractToUpdate._NumberOfContract).ToString(), "This contract has been update:");
                this.Close();
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

     
    }
}
