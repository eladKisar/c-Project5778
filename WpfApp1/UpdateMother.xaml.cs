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
    /// Interaction logic for UpdateMother.xaml
    /// </summary>
    public partial class UpdateMother : Window
    {
       
        Mother MotherToUpdate;
        IBL bl;
        public UpdateMother()
        {
            InitializeComponent();
            MotherToUpdate = null;

            bl = Bl_Singleton.GetBl();


            this.MotherUpDataComboBox.ItemsSource = bl.GetMotherList();
            this.MotherUpDataComboBox.DisplayMemberPath = "_id";
            this.MotherUpDataComboBox.SelectedValuePath = "_id";

        }
        private void MotherUpDataComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.MotherUpDataComboBox.SelectedItem is Mother)
            {
                this.userWorkHours.Clear();
                // this.MotherToUpdate = ((Mother)this.MotherUpDataComboBox.SelectedItem).GetCopy();
                this.MotherToUpdate = ((Mother)this.MotherUpDataComboBox.SelectedItem).
                    DeepClone<Mother>((Mother)this.MotherUpDataComboBox.SelectedItem);
                this.DataContext = MotherToUpdate;

                string[] arr = new string[6];
                int j = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (!(i == 1 || i == 6 || i == 7))
                    {

                        arr[j] = "05" + i;
                        if (arr[j] == this.MotherToUpdate._NumberOfphone.Substring(0, 3))
                            this.numberFonComboBox.SelectedItem = arr[j];
                        j++;
                    }
                }
                this.numberFonComboBox.ItemsSource = arr;
                this.FonNannyTaxtBox.Text = this.MotherToUpdate._NumberOfphone.Substring(3);
                this.userWorkHours.Show(this.MotherToUpdate.workHours);
            }

        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                this.MotherToUpdate._NumberOfphone = this.numberFonComboBox.SelectedItem.ToString() + this.FonNannyTaxtBox.Text;

                MotherToUpdate.workHours = this.userWorkHours.update();


                bl.UpdatingMother(MotherToUpdate);
                MessageBox.Show(bl.GetMotherList().LastOrDefault().ToString(), "This mother has been update:");
                this.Close();
                //this.numberFonComboBox.ItemsSource = null;
                //this.DataContext = MotherToUpdate = null;
                //this.MotherUpDataComboBox.ItemsSource = bl.GetMotherList().ToArray();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

       
    }
   
    }

