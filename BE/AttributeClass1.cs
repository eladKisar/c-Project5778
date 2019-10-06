using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    [AttributeUsage(AttributeTargets.Property)]
    class PropertyDisplayAttribute : Attribute
    {
        public String DisplayValue { get; set; }
        public PropertyDisplayAttribute(string displayName)
        {
            DisplayValue = displayName;
        }
    }
    class AttributeClass1
    {
        public static string ToStringProperty<T>(T t)
        {
            string str = "";
            PropertyInfo[] T_properties = t.GetType().GetProperties();

            foreach (PropertyInfo item in T_properties)
            {
                Type myAttributeType = typeof(PropertyDisplayAttribute);
                object[] itemDisplayAtt = item.GetCustomAttributes(myAttributeType, false);

                if (itemDisplayAtt.Length == 1)
                {
                    PropertyDisplayAttribute att = (PropertyDisplayAttribute)itemDisplayAtt[0];
                    str += string.Format("\nname: {0,-15} value: {1,-15}",
                        att.DisplayValue,
                        item.GetValue(t, null));

                }
                else
                {
                    str += string.Format("\nname: {0,-15} value: {1,-15}",
                        item.Name,
                        item.GetValue(t, null));
                }
            }
          
          
            return str;
        }





    }
}
