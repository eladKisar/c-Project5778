using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Address
    {
        public string city { get; set; }
        public string Street { get; set; }
        public string buildingNumber { get; set; }
        public override string ToString()
        {
            return city + "," + Street + "," + buildingNumber;
        }
    }
}
