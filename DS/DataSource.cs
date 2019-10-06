using System;
using System.Collections.Generic;
using System.Collections;
using BE;
namespace DS
{
    public class DataSource
    {

        public List<Nanny> NannysList;
        public List<Mother> MothersList;
        public List<Child> ChildsList;
        public List<Contract> ContractsList;
        public DataSource()
        {
            NannysList = new List<Nanny>();
            MothersList = new List<Mother>();
            ChildsList = new List<Child>();
            ContractsList = new List<Contract>();
        }
    }
}