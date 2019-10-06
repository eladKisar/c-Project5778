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
namespace WpfApp1.Grouping
{
    /// <summary>
    /// Interaction logic for GroupingWindow.xaml
    /// </summary>
    public partial class GroupingWindow : Window
    {
        IBL bl;
        public GroupingWindow()
        {
            InitializeComponent();
            bl = Bl_Singleton.GetBl();
        }

        private void ContractByDistanceButton_Click(object sender, RoutedEventArgs e)
        {
            ByDistanceUserControl1 uc = new ByDistanceUserControl1();
            this.page.Content = uc;
        }

        private void NannyWithExpButton_Click(object sender, RoutedEventArgs e)
        {
            NannyWithExperienceUserControl1 uc = new NannyWithExperienceUserControl1();
            this.page.Content = uc;

        }

        private void ChildrenByAgeMinButton_Click(object sender, RoutedEventArgs e)
        {
            MinimalAgeUserControl1 uc = new MinimalAgeUserControl1();
            uc.Source = bl.GroupingByAge(false);
            this.page.Content = uc;
        }

        private void ChildrenByAgeMaxButton_Click(object sender, RoutedEventArgs e)
        {
            MaxAgeUserControl1 uc = new MaxAgeUserControl1();
            uc.Source = bl.GroupingByAge(true);
            this.page.Content = uc;
        }

        private void ChildrenWithoutButton_Click(object sender, RoutedEventArgs e)
        {
            ChildrenWithourNannyUserControl1 uc = new ChildrenWithourNannyUserControl1();
            uc.Source = bl.noNanniesFound();
            this.page.Content = uc;
        }

        private void ChildrenWithSpecButton_Click(object sender, RoutedEventArgs e)
        {
            ChildrenWithSpecialNeedsUserControl1 uc = new ChildrenWithSpecialNeedsUserControl1();
            uc.Source = bl.childSpecialNeeds();
            this.page.Content = uc;

        }
    }
}
