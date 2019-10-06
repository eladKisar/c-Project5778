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
    /// Interaction logic for AddMother.xaml
    /// </summary>
    public partial class AddMother : Window
    {
        private List<string> errorMessages;
        string[] arr = new string[6];


        Mother mother;
       IBL bl;
        public AddMother()
        {
            int j = 0;
            for (int i = 0; i < 9; i++)
            {
                if (!(i == 1 || i == 6 || i == 7))
                {
                    arr[j] = "05" + i;
                    j++;
                }
            }

            InitializeComponent();
            mother = new BE.Mother();
            this.DataContext = mother;
            errorMessages = new List< string >();


            this.numberFonComboBox.ItemsSource = arr;
            bl = BL.Bl_Singleton.GetBl();


        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                if (errorMessages.Any()) //errorMessages.Count > 0 
                {
                    string err = "Exception:";
                    foreach (var item in errorMessages)
                        err += "\n" + item;

                    MessageBox.Show(err);
                    return;
                }
                else
                {
                  
                    mother._NumberOfphone = this.numberFonComboBox.SelectedItem.ToString() + this.FonNannyTaxtBox.Text;
                    mother.workHours = this.userWorkHours.update();
                    bl.AddMother(mother);
                    MessageBox.Show(bl.GetMotherList().LastOrDefault().ToString(), "This mother has been added:");
                    this.Close();
                    //this.numberFonComboBox.ItemsSource = null;
                    //mother = new BE.Mother();
                    //this.DataContext = mother;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
        private void numberFonComboBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (this.numberFonComboBox.SelectedItem != null)
                this.FonNannyTaxtBox.IsEnabled = true;
        }

        private void numberFonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.FonNannyTaxtBox.IsEnabled = true;
        }
        private void validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errorMessages.Add(e.Error.Exception.Message);
            else
                errorMessages.Remove(e.Error.Exception.Message);

            this.addButton.IsEnabled = !errorMessages.Any();
        }
    }

}

