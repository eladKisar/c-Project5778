using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
namespace BE
{
    
    [Serializable]
    public class Nanny
    {
      
        public WorkHours[] workHours = new WorkHours[6];
        public Nanny()
        {
            for (int i = 0; i < 6; i++)
            {
                bool flag = false;
                if (i % 2 == 0)
                    flag = true;
                workHours[i] = new WorkHours(new TimeSpan(i + 8, 0, 0),new TimeSpan(i + 16, 0, 0), flag );


            }

        }

        #region Propertys
        [PropertyDisplay("Fitst Name")]
        public string _FitstName { get; set; }
        [PropertyDisplay("Last Name")]
        public string _LastName { get; set; }
        [PropertyDisplay("person id")]
        public int _id { get; set; }
        [PropertyDisplay("Date Of Birth")]
        public DateTime _DateOfBirth { get; set; }
        [PropertyDisplay("Number phone")]
        public string _NumberOfphone { get; set; }
        [PropertyDisplay("Address")]
        public string _Address { get; set; }
        [PropertyDisplay("Elevator")]
        public bool _Elevators { get; set; }
        [PropertyDisplay("Floor Number")]
        public int _FloorNumber { get; set; }
        [PropertyDisplay("Years Of Experience")]
        public int _YearsOfExperience { get; set; }
        [PropertyDisplay("Max Child")]
        public int _MaxChild { get; set; }
        [PropertyDisplay("Max Age")]
        public int _MaxAge { get; set; }
        [PropertyDisplay("Min Age")]
        public int _MinAge { get; set; }
        [PropertyDisplay("Hourly Payment")]
        public bool _HourlyPayment { get; set; }//true=per hour ,false= per mounth
        [PropertyDisplay("Hourly Wage")]
        public double _HourlyWage { get; set; }
        [PropertyDisplay("Month Wage")]
        public double _MonthWage { get; set; }
        [PropertyDisplay("Vacation Kind tmt")]
        public bool _VacationKind { get; set; }//true=tmt ,false= Ministry of Education
        [PropertyDisplay("Recommendations")]
        public string _Recommendations { get; set; }
        [PropertyDisplay("Num Of Stars")]
        public int NumOfStars { get; set; }

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
            return AttributeClass1.ToStringProperty(this)+"\n"+"days Of Work:"+"\n"+str;

        }
        public Nanny GetCopy()
        {
            return (Nanny)this.MemberwiseClone();
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