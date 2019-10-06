using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BE
{
    [Serializable]
    public class Mother
    {
                                      
                                           
        public WorkHours[] workHours = new WorkHours [6];
        public Mother()
        {

            for (int i = 0; i < 6; i++)
            {
                bool flag = false;
                if (i % 2 == 0)
                    flag = true;
                workHours[i] = new WorkHours(new TimeSpan(i + 8, 0, 0), new TimeSpan(i + 16, 0, 0), flag);
            }
        }

        #region property
        [PropertyDisplay("id")]
        public int _id { get; set; }
        [PropertyDisplay("Last Name")]
        public string _LastName { get; set; }
        [PropertyDisplay("Fitst Name")]
        public string _FitstName { get; set; }
        [PropertyDisplay("Number phone")]
        public string _NumberOfphone { get; set; }
        [PropertyDisplay("Address")]
        public string _Address { get; set; }
        [PropertyDisplay("Area Addres")]
        public string _AreaAddres { get; set; }
        [PropertyDisplay("Range")]
        public double _Range { get; set; }
        //[PropertyDisplay("Signed Contract")]
        //public int _MyProperty { get; set; }
        [PropertyDisplay("Hourly Payment")]
        public bool _HourlyPayment { get; set; }//true=per hour ,false= per mounth
        [PropertyDisplay("Notes")]
        public string _Notes { get; set; }
        #endregion
        #region function
        public override string ToString()
        {
            string[] Days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            string str = null;
            for (int i = 0; i < 6; i++)
                if (workHours[i].DayWork)
                {
                    str += Days[i] + ": From " + workHours[i].StartHour.ToString(@"hh\:mm") + " to "
                        + workHours[i].EndHour.ToString(@"hh\:mm") + "\n";

                }
            return AttributeClass1.ToStringProperty(this) + "\n" + "days that need nanny:" + "\n" + str;
        }
        public Mother GetCopy()
        {
            return (Mother)this.MemberwiseClone();
        }

        public T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
        #endregion

    }
}
