using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for add_Child.xaml
    /// </summary>
    public class NotBooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        { bool boolValue = (bool)value; if (boolValue)
            { return true; }
            else
            { return false; } }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        { throw new NotImplementedException(); }
    }

public partial class add_Child : Window
    {
        Child child;
        IBL bl;
        private List<string> errorMessages;
       
        public add_Child()
        {
            InitializeComponent();
            child = new BE.Child();
            this.DataContext = child;

          
            bl = Bl_Singleton.GetBl();
           
            errorMessages = new List<string>();
         
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
                    if (this.DisabilitiesCheckBox.IsChecked == true)
                        this.TypeOfDisabilitiesTaxtBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();

                    bl.AddChild(child);
                  
                    MessageBox.Show(bl.GetChildList().LastOrDefault().ToString(), "This child has been added:");
                    this.Close();
                 
                  
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
