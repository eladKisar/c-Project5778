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
    /// Interaction logic for UpdateNanny.xaml
    /// </summary>
    public partial class UpdateNanny : Window
    {
        Nanny nannyToUpdate;
        IBL bl;
        public UpdateNanny()
        {
            InitializeComponent();
            nannyToUpdate = null;

            bl = Bl_Singleton.GetBl();


            this.nannyUpDataComboBox.ItemsSource = bl.GetNannyList();
            this.nannyUpDataComboBox.DisplayMemberPath = "_id";
            this.nannyUpDataComboBox.SelectedValuePath = "_id";

        }
        private void nannyUpDataComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.nannyUpDataComboBox.SelectedItem is Nanny)
            {
                this.userWorkHours.Clear();
               
                this.nannyToUpdate = ((Nanny)this.nannyUpDataComboBox.SelectedItem).
                DeepClone<Nanny>((Nanny)this.nannyUpDataComboBox.SelectedItem);
                this.DataContext = nannyToUpdate;
              
                if (this.nannyToUpdate._YearsOfExperience>=5)////////
                this.nannyToUpdate.NumOfStars = 3;/////////////////
                if (this.nannyToUpdate.NumOfStars == 3&& this.nannyToUpdate._YearsOfExperience >= 5)///
                {
                    this.star1.Fill = Brushes.Yellow;////
                    this.star2.Fill = Brushes.Yellow;///
                    this.star3.Fill = Brushes.Yellow;////
                }
               


                string[] arr = new string[6];
                int j = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (!(i == 1 || i == 6 || i == 7))
                    {
                        
                        arr[j] = "05" + i;
                        if (arr[j] == this.nannyToUpdate._NumberOfphone.Substring(0, 3))
                            this.numberFonComboBox.SelectedItem = arr[j];
                            j++;
                    }
                }
                this.numberFonComboBox.ItemsSource = arr;
                
                this.FonNannyTaxtBox.Text = this.nannyToUpdate._NumberOfphone.Substring(3);
                this.userWorkHours.Show(this.nannyToUpdate.workHours);
            }

        }
        
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

               this.nannyToUpdate._NumberOfphone = this.numberFonComboBox.SelectedItem.ToString() + this.FonNannyTaxtBox.Text;

                nannyToUpdate.workHours = this.userWorkHours.update();

                this.star1.Fill = Brushes.Gray;////
                this.star2.Fill = Brushes.Gray;////
                this.star3.Fill = Brushes.Gray;////
             

                bl.UpdatingNanny(nannyToUpdate);
                MessageBox.Show(bl.GetNannyList().LastOrDefault().ToString(), "This nanny has been update:");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        
    }
}
