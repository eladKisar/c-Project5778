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
    /// Interaction logic for UpDataChild.xaml
    /// </summary>
    public class NotBooleanToVisibilityConverterUpdate : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool boolValue = (bool)value; if (boolValue)
            { return Visibility.Collapsed; }
            else
            { return Visibility.Visible; }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        { throw new NotImplementedException(); }
    }
    public partial class UpDataChild : Window
    {
        Child childToUpdate;
        IBL bl;
        public UpDataChild()
        {
            InitializeComponent();
            childToUpdate = null;

            bl = Bl_Singleton.GetBl();



          
            this.UpDataComboBox.ItemsSource = bl.GetChildList();
            this.UpDataComboBox.DisplayMemberPath = "_IdOfChild";
            this.UpDataComboBox.SelectedValuePath = "_IdOfChild";

        }
     
        private void UpDataComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (this.UpDataComboBox.SelectedItem is Child)
            {
                this.childToUpdate = ((Child)this.UpDataComboBox.SelectedItem).GetCopy();
                this.DataContext = childToUpdate;

        
               
            }
          
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.DisabilitiesCheckBox.IsChecked == false)
                    childToUpdate._TypeOfDisabilities = " ";

            
                
                bl.UpdatingChild(childToUpdate);
                MessageBox.Show(bl.GetChildList().FirstOrDefault(fd=>fd._IdOfChild== childToUpdate._IdOfChild).ToString(), "This child has been update:");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            
        }
     
    }
}
