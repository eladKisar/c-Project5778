using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
namespace BE
{
    [Serializable]
    public class Contract
    {


        #region propertys
      
        [PropertyDisplay("Number Of Contract")]
        public long _NumberOfContract { get; set; }
        [PropertyDisplay("Id Of Nanny")]
        public int _IdOfNanny { get; set; }
        [PropertyDisplay("Id Of Mother")]
        public int _IdOfMother { get; set; }
        [PropertyDisplay("Id Of Child")]
        public int _IdOfChild { get; set; }
        [PropertyDisplay("Start Date")]
        public DateTime _StartDate { get; set; }
        [PropertyDisplay("End Date")]
        public DateTime _EndDate { get; set; }

        [PropertyDisplay("Contract Hourly Payment")]
        public bool _ContractHourlyPayment { get; set; }//true=per hour ,false= per mounth
        [PropertyDisplay("Sallry Per Hour")]
        public double _SallryPerHour { get; set; }
        [PropertyDisplay("Sallry Per Month")]
        public double _SallryPerMonth { get; set; }
        [PropertyDisplay("Final Monthly Wages")]
        public double _FinalMonthlyWages { get; set; }
        [PropertyDisplay("Was Mitting")]
        public bool _WasMitting { get; set; }
        [PropertyDisplay("Signed Contract")]
        public bool _SignedContract { get; set; }
       

        #endregion
        #region function
        public override string ToString()
        {
            return AttributeClass1.ToStringProperty(this);
        }
        public Contract GetCopy()
        {
            return (Contract)this.MemberwiseClone();
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