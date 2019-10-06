using System;
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
using System.Windows.Shapes;
using BE;
using BL;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddContract.xaml
    /// </summary>
    public partial class AddContract : Window
    {
        Contract contract;
        Mother mother;
        IBL bl;
        public AddContract()
        {
            InitializeComponent();

            bl = Bl_Singleton.GetBl();

            for (int i = 0; i < 51; i++)
            {
                this.DistanceComboBox.Items.Add(i);
                if (i <= 13)
                    this.MaxAgeCheckBox.Items.Add(i);
                if (i <= 20)
                    this._YearsOfExperienceComboBox.Items.Add(i);
            }
            contract = new Contract();
            this.DataContext = contract;
          



            this.ChooceMotherComboBox.ItemsSource = bl.GetMotherList();
            this.ChooceMotherComboBox.DisplayMemberPath = "_id";
            this.ChooceMotherComboBox.SelectedValuePath = "_id";
        }
        private void ChooceMotherComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            mother = (Mother)this.ChooceMotherComboBox.SelectedItem;
           this.DistanceLabel.Visibility=this.DistanceComboBox.Visibility=Visibility.Visible;
           this.PerKindLabel.Visibility=this.PerKind.Visibility  = Visibility.Visible;
           this.MAxPriceLabel.Visibility=this.MaxPriceTextBox.Visibility = Visibility.Visible;
           this.MAxAgeLAbel.Visibility=this.MaxAgeCheckBox.Visibility= Visibility.Visible;
           this.MinYearsLabel.Visibility=this._YearsOfExperienceComboBox.Visibility = Visibility.Visible;
           this.ElevatorLabel.Visibility=this.ElevatorCheckbox.Visibility = Visibility.Visible;
            this.SearchIcon.Visibility = this.SearchButton.Visibility = Visibility.Visible;
}
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            int distance=0;
            bool perMounth=false;
            double MaxPrice=0;
            int MaxAge=0;
            int MinYears=0;
            bool elevator=false;

            try
            {
                distance = int.Parse(this.DistanceComboBox.SelectedItem.ToString());
                perMounth = this.PerKind.SelectedIndex == 0 ? true : false;
                MaxPrice = double.Parse(this.MaxPriceTextBox.Text.ToString());
                MaxAge = int.Parse(this.MaxAgeCheckBox.SelectedItem.ToString());
                MinYears = int.Parse(this._YearsOfExperienceComboBox.SelectedItem.ToString());
                elevator = (bool)ElevatorCheckbox.IsChecked;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
           new Thread(() => 
                {
                    List<Nanny> ln1=new List<Nanny>();
                    try
                    {
                       ln1 = bl.FindNanny(mother, distance, perMounth, MaxPrice, MaxAge, MinYears, elevator);
                        Dispatcher.BeginInvoke(new Action(() =>
                        {
                         
                            if (ln1.Any())
                            {
                                this.StudentDataGrid.Visibility = Visibility.Visible;
                                this.StudentDataGrid.ItemsSource = ln1;
                            }
                              
                            else
                                MessageBox.Show("not found nanny with the same request");
                             
                          }));
                    }
                    catch (Exception n)
                    {
                        MessageBox.Show(n.Message);
                    }
                }).Start();
             }

        private void ChooceButton_Click(object sender, RoutedEventArgs e)
        {
            Nanny n = (Nanny)this.StudentDataGrid.SelectedItem;
            contract._IdOfNanny = n._id;
            contract._SallryPerHour = n._HourlyWage;
            contract._SallryPerMonth = n._MonthWage;
            new SigningContract(contract).ShowDialog();
           
          //  this.Close();
        }
    }
}
