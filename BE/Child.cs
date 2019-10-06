using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
namespace BE
{
    public class Child
    {
        public Child()
        {
            _TypeOfDisabilities = "";
        }
        #region propertys
        [PropertyDisplay("Fitst Name")]
        public string _FitstName { get; set; }
        [PropertyDisplay("Id Of Child")]
        public int _IdOfChild { get; set; }
        [PropertyDisplay("Id Of Mather")]
        public int _IdOfMather { get; set; }
        [PropertyDisplay("Date Of Birth")]
        public DateTime _DateOfBirth { get; set; }
        [PropertyDisplay("Have Disabilities")]
        public bool _Disabilities { get; set; }
        [PropertyDisplay("Type Of Disabilities")]
        public string _TypeOfDisabilities { get; set; }
    
        #endregion
        #region function
        public override string ToString()
        {
            return AttributeClass1.ToStringProperty(this);
        }
        public Child GetCopy()
        {
            return (Child)this.MemberwiseClone();
        }
        //public T DeepClone<T>(T obj)
        //{
        //    using (var ms = new MemoryStream())
        //    {
        //        var formatter = new BinaryFormatter();
        //        formatter.Serialize(ms, obj);
        //        ms.Position = 0;

        //        return (T)formatter.Deserialize(ms);
        //    }
        //}
        #endregion
    }
}