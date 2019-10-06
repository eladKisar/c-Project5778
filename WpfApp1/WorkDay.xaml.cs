using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BE;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for WorkDay.xaml
    /// </summary>
    public partial class WorkDay : UserControl
    {
        
        public WorkHours[] workHours;
        public WorkDay()
        {
           InitializeComponent();
        }
      
        public WorkHours[] update()
        {
            //foreach (Control item in printersGrid.Children)
            //{
            //    if (item is PrinterUserControl)
            //    {
            //        PrinterUserControl printer = item as PrinterUserControl;
            //        printer.PageMissing += OverPage;
            //        printer.InkEmpty += OverInk;
            //        queue.Enqueue(printer);
            //    }
            //}
            
            workHours = new WorkHours[6];
            if (this.SundayCheckBox.IsChecked == true && this.a0.Value != null && this.a1.Value != null)
              this.workHours[0] = new WorkHours(this.a0.Value.Value.TimeOfDay, this.a1.Value.Value.TimeOfDay, true);
            
           

           if (this.MondayCheckBox.IsChecked == true && this.b0.Value != null && this.b1.Value != null)
                this.workHours[1] = new WorkHours(this.b0.Value.Value.TimeOfDay, this.b1.Value.Value.TimeOfDay, true);
               
          if (this.TusedayCheckBox.IsChecked == true && this.c0.Value != null && this.c1.Value != null)
               this.workHours[2] = new WorkHours( this.c0.Value.Value.TimeOfDay, this.c1.Value.Value.TimeOfDay,true);
              
            if (this.WendnesdayCheckBox.IsChecked == true && this.d0.Value != null && this.d1.Value != null)
               this.workHours[3] = new WorkHours(this.d0.Value.Value.TimeOfDay, this.d1.Value.Value.TimeOfDay, true);
         
            if (this.ThurstdayCheckBox.IsChecked == true && this.e0.Value != null && this.e1.Value != null)
                 this.workHours[4] = new WorkHours(this.e0.Value.Value.TimeOfDay, this.e1.Value.Value.TimeOfDay,true);
               
            if (this.FridayCheckBox.IsChecked == true && this.f0.Value != null && this.f1.Value != null)
                  this.workHours[5] = new WorkHours(this.f0.Value.Value.TimeOfDay, this.f1.Value.Value.TimeOfDay,true);
            Clear();
             return workHours;
        }
       
       public void Show(WorkHours[] wh)
        {
            if (wh[0]!=null && wh[0].DayWork == true )
            {
                this.SundayCheckBox.IsChecked = true;
                this.a0.Value =DateTime.Parse( wh[0].StartHour.ToString());
                this.a1.Value = DateTime.Parse(wh[0].EndHour.ToString());
            }
            if (wh[1] != null && wh[1].DayWork == true)
            {
                this.MondayCheckBox.IsChecked = true;
                this.b0.Value = DateTime.Parse(wh[1].StartHour.ToString());
                this.b1.Value = DateTime.Parse(wh[1].EndHour.ToString());
            }
            if (wh[2] != null && wh[2].DayWork == true)
            {
                this.TusedayCheckBox.IsChecked = true;
                this.c0.Value = DateTime.Parse(wh[2].StartHour.ToString());
                this.c1.Value = DateTime.Parse(wh[2].EndHour.ToString());
            }
            if (wh[3] != null && wh[3].DayWork == true)
            {
                this.WendnesdayCheckBox.IsChecked = true;
                this.d0.Value = DateTime.Parse(wh[3].StartHour.ToString());
                this.d1.Value = DateTime.Parse(wh[3].EndHour.ToString());
            }
            if (wh[4] != null && wh[4].DayWork == true)
            {
                this.ThurstdayCheckBox.IsChecked = true;
                this.e0.Value = DateTime.Parse(wh[4].StartHour.ToString());
                this.e1.Value = DateTime.Parse(wh[4].EndHour.ToString());
            }
            if (wh[5] != null && wh[5].DayWork == true)
            {
                this.FridayCheckBox.IsChecked = true;
                this.f0.Value = DateTime.Parse(wh[5].StartHour.ToString());
                this.f1.Value = DateTime.Parse(wh[5].EndHour.ToString());
            }

            

        }
        public void Clear()
        {
            this.a0.Value = a1.Value= null;
            SundayCheckBox.IsChecked = false;

            this.b0.Value = b1.Value = null;
            MondayCheckBox.IsChecked = false;

            this.c0.Value = this.c1.Value = null;
            TusedayCheckBox.IsChecked = false;

            this.d0.Value = this.d1.Value = null;
            WendnesdayCheckBox.IsChecked = false;

            this.e0.Value = this.e1.Value = null;
            ThurstdayCheckBox.IsChecked = false;

            this.f0.Value = this.f1.Value = null;
            FridayCheckBox.IsChecked = false;

            
        }

    }
}
