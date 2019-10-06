using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BE;
namespace DAL
{
    class Dal_xml : IDAL
    {

        public static long numberOfContract = 10000000;

        XElement ChildRoot;
        string ChildPath = @"childXml1.xml";

        XElement NannyRoot;
        string NannyPath = @"nannyXml1.xml";

        XElement MotherRoot;
        string MotherPath = @"motherXml1.xml";

        XElement ContractRoot;
        string ContractPath = @"contractXml1.xml";
        public Dal_xml()
        {
            numberOfContract++;
            if (!File.Exists(ChildPath))
                CreateFiles();
            else
                LoadData();

        }
        void CreateFiles()
        {
            ChildRoot = new XElement("Child");
            ChildRoot.Save(ChildPath);

            NannyRoot = new XElement("Nanny");
            NannyRoot.Save(NannyPath);

            MotherRoot = new XElement("Mother");
            MotherRoot.Save(MotherPath);

            ContractRoot = new XElement("Contract");
            ContractRoot.Save(ContractPath);
        }
        void LoadData()
        {
            try
            {
                ChildRoot = XElement.Load(ChildPath);
                NannyRoot = XElement.Load(NannyPath);
                MotherRoot = XElement.Load(MotherPath);
                ContractRoot = XElement.Load(ContractPath);

                ChildRoot.RemoveAll();
                NannyRoot.RemoveAll();
                MotherRoot.RemoveAll();
                ContractRoot.RemoveAll();
            }
            catch (Exception)
            {

                throw new Exception("File upload problem");
            }
        }
        XElement ConvertToXml<T>(T x) 
        {
            XElement Element=null;
            if (x is Child)
                Element = new XElement("child");
            if (x is Contract)
                Element = new XElement("contract");
            try
            {
                foreach (PropertyInfo item in typeof(T).GetProperties())
                    Element.Add
                        (
                        new XElement(item.Name, item.GetValue(x, null).ToString())
                        );   
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            return Element;
        }
        T ConvertFromXml<T>(XElement element) where T:new()
        {
            T x = new T();

            foreach (PropertyInfo item in typeof(T).GetProperties())
            {
                TypeConverter typeConverter = TypeDescriptor.GetConverter(item.PropertyType);
                object convertValue = typeConverter.ConvertFromString(element.Element(item.Name).Value);

                if (item.CanWrite)
                    item.SetValue(x, convertValue);
            }

            return x;
        }
        XElement convertWorkHours(WorkHours[] wh, string str)
        {
            XElement xElementWorkHours = new XElement(str);
            string[] strDay = { "Sunday", "Monday", "Tuseday", "Wednesday", "Thursday", "Friday", "Saturday" };

            for (int i = 0; i < 6; i++)
            {
                if (wh[i] != null)
                {
                    XElement DayWork = new XElement("DayWork", wh[i].DayWork);
                    XElement StartHour = new XElement("StartHour", wh[i].StartHour.ToString());
                    XElement EndHour = new XElement("EndHour", wh[i].EndHour.ToString());
                    XElement Day = new XElement(strDay[i], DayWork, StartHour, EndHour);
                    xElementWorkHours.Add(Day);
                }
                else
                {
                    XElement DayWork = new XElement("DayWork", "false");
                    XElement StartHour = new XElement("StartHour", "00:00:00");
                    XElement EndHour = new XElement("EndHour", "00:00:00");
                    XElement Day = new XElement(strDay[i], DayWork, StartHour, EndHour);
                    xElementWorkHours.Add(Day);
                }


            }
            return xElementWorkHours;
        }
        WorkHours[] convertWorkHours(XElement x)
        {
            WorkHours[] wh = new WorkHours[6];
            int i = 0;
            foreach (var item in x.Elements())
                {
                    TimeSpan start = TimeSpan.Parse(item.Element("StartHour").Value);
                    TimeSpan end = TimeSpan.Parse(item.Element("EndHour").Value);
                    bool day = Convert.ToBoolean(item.Element("DayWork").Value);
                    wh[i] = new WorkHours(start, end, day);
                     i++;
                }
            
            return wh;
        }
        #region Child
        public void AddChild(Child child)
        {
          Child c = GetChild(child._IdOfChild);
          if (c != null)
             throw new Exception("child with the same id already exists");

            ChildRoot.Add(ConvertToXml<Child>(child));
            ChildRoot.Save(ChildPath);
        }
        public bool RemoveChild(int id)
        {
            XElement chilToRemove = (from item in ChildRoot.Elements()
                                     where int.Parse(item.Element("_IdOfChild").Value) == id
                                     select item).FirstOrDefault();
            if(chilToRemove==null)
                throw new Exception("child with the same id not found...");

            chilToRemove.Remove();
            ChildRoot.Save(ChildPath);
            return true;
        }
        public void UpdatingChild(Child child)
        { 
            XElement childToUpdate = (from item in ChildRoot.Elements()
                                      where int.Parse(item.Element("_IdOfChild").Value) == child._IdOfChild
                                      select item).FirstOrDefault();
            if(childToUpdate==null)
                throw new Exception("child with the same id not found...");

            foreach (PropertyInfo item in typeof(Child).GetProperties())
                childToUpdate.Element(item.Name).SetValue(item.GetValue(child).ToString());

            ChildRoot.Save(ChildPath);
        }
        public IEnumerable<Child> GetChildList(Func<Child, bool> func = null)
        {
           
            if (func == null)
            {
                return from item in ChildRoot.Elements()
                       select ConvertFromXml<Child>(item);
            }
              return from item in ChildRoot.Elements()
                   let s = ConvertFromXml<Child>(item)
                   where func(s)
                   select s;
        }
        public Child GetChild(int id)
        {
            XElement child=null;
            try
            {
                child = (from item in ChildRoot.Elements()
                         where int.Parse(item.Element("_IdOfChild").Value) == id
                         select item).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
            if (child == null)
                return null;

            return ConvertFromXml<Child>(child);

        }

        #endregion
        #region Nanny
        XElement convertNanny(Nanny nanny)
        {
            XElement nannyXElement = new XElement("nanny");
            nannyXElement.Add(new XElement("_id", nanny._id.ToString()));
            nannyXElement.Add(new XElement("_FitstName", nanny._FitstName));
            nannyXElement.Add(new XElement("_LastName", nanny._LastName));
            nannyXElement.Add(new XElement("_NumberOfphone", nanny._NumberOfphone));
            nannyXElement.Add(new XElement("_Address", nanny._Address));
            nannyXElement.Add(new XElement("_Recommendations", nanny._Recommendations));
            nannyXElement.Add(new XElement("_YearsOfExperience", nanny._YearsOfExperience.ToString()));
            nannyXElement.Add(new XElement("_MaxChild", nanny._MaxChild.ToString()));
            nannyXElement.Add(new XElement("_MinAge", nanny._MinAge.ToString()));
            nannyXElement.Add(new XElement("_MaxAge", nanny._MaxAge.ToString()));
            nannyXElement.Add(new XElement("_FloorNumber", nanny._FloorNumber.ToString()));
            nannyXElement.Add(new XElement("_HourlyPayment", nanny._HourlyPayment.ToString()));
            nannyXElement.Add(new XElement("_Elevators", nanny._Elevators.ToString()));
            nannyXElement.Add(new XElement("_VacationKind", nanny._VacationKind.ToString()));
            nannyXElement.Add(new XElement("_DateOfBirth", nanny._DateOfBirth.ToString()));
            nannyXElement.Add(new XElement("_HourlyWage", nanny._HourlyWage.ToString()));
            nannyXElement.Add(new XElement("_MonthWage", nanny._MonthWage.ToString()));
            nannyXElement.Add(new XElement("NumOfStars", nanny.NumOfStars.ToString()));
            nannyXElement.Add(convertWorkHours(nanny.workHours, "workHours"));
            return nannyXElement;
        }
       
        Nanny convertNanny(XElement xElement)
        {
            Nanny nanny = new Nanny();
            nanny._id = int.Parse(xElement.Element("_id").Value);
            nanny._LastName = xElement.Element("_LastName").Value;
            nanny._FitstName = xElement.Element("_FitstName").Value;
            nanny._NumberOfphone = xElement.Element("_NumberOfphone").Value;
            nanny._Address = xElement.Element("_Address").Value;
            nanny._Recommendations = xElement.Element("_Recommendations").Value;
            nanny._YearsOfExperience = int.Parse(xElement.Element("_YearsOfExperience").Value);
            nanny._MaxChild = int.Parse(xElement.Element("_MaxChild").Value);
            nanny._MinAge = int.Parse(xElement.Element("_MinAge").Value);
            nanny._MaxAge = int.Parse(xElement.Element("_MaxAge").Value);
            nanny._FloorNumber = int.Parse(xElement.Element("_FloorNumber").Value);
            nanny._HourlyPayment = bool.Parse(xElement.Element("_HourlyPayment").Value);
            nanny._Elevators = bool.Parse(xElement.Element("_Elevators").Value);
            nanny._VacationKind = bool.Parse(xElement.Element("_VacationKind").Value);
            nanny._DateOfBirth = DateTime.Parse(xElement.Element("_DateOfBirth").Value);
            nanny._HourlyWage = double.Parse(xElement.Element("_HourlyWage").Value);
            nanny._MonthWage = double.Parse(xElement.Element("_MonthWage").Value);
            nanny.workHours = convertWorkHours(xElement.Element("workHours"));
            return nanny;
        }
       


        public void AddNanny(Nanny nanny)
        {
            Nanny help = GetNanny(nanny._id);
            if (help != null)
                throw new Exception("nanny with the same id already exists...");

            NannyRoot.Add(convertNanny(nanny));
            NannyRoot.Save(NannyPath);
        }
        public bool RemoveNanny(int NannyId)
        {
            XElement nannyToRemove = (from item in NannyRoot.Elements()
                                      where int.Parse(item.Element("_id").Value) == NannyId
                                      select item).FirstOrDefault();
            if(nannyToRemove==null)
                throw new Exception("nanny with the same id not found...");
            nannyToRemove.Remove();
            NannyRoot.Save(NannyPath);
            return true;
        }
        public void UpdatingNanny(Nanny nanny)
        {
            RemoveNanny(nanny._id);
            AddNanny(nanny);
        }
        public IEnumerable<Nanny> GetNannyList(Func<Nanny, bool> func = null)
        {
            if (func == null)
            {
                return from item in NannyRoot.Elements()
                       select convertNanny(item);
            }
            return from item in NannyRoot.Elements()
                   let s = convertNanny(item)
                   where func(s)
                   select s;
        }
        public Nanny GetNanny(int id)
        {
            XElement nanny = null;
            try
            {
                nanny = (from item in NannyRoot.Elements()
                         where int.Parse(item.Element("_id").Value) == id
                         select item).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
            if (nanny == null)
                return null;
        return convertNanny(nanny);


        }
        #endregion

        #region Mother
        XElement convertMother(Mother mother)
        {
            XElement motherElement = new XElement("mother");
            motherElement.Add(new XElement("_id", mother._id.ToString()));
            motherElement.Add(new XElement("_LastName", mother._LastName));
            motherElement.Add(new XElement("_FitstName", mother._FitstName));
            motherElement.Add(new XElement("_Address", mother._Address));
            motherElement.Add(new XElement("_AreaAddres", mother._AreaAddres));
            motherElement.Add(new XElement("_NumberOfphone", mother._NumberOfphone));
            motherElement.Add(new XElement("_HourlyPayment", mother._HourlyPayment));
            motherElement.Add(convertWorkHours(mother.workHours, "workHours"));
            motherElement.Add(new XElement("_Notes", mother._Notes));
            return motherElement;
        }

        Mother convertMother(XElement xElement)
        {
            Mother mother = new Mother();
            mother._id = Convert.ToInt32(xElement.Element("_id").Value);
            mother._LastName = xElement.Element("_LastName").Value;
            mother._FitstName = xElement.Element("_FitstName").Value;
            mother._Address = xElement.Element("_Address").Value;
            mother._AreaAddres = xElement.Element("_AreaAddres").Value;
            mother._HourlyPayment =bool.Parse( xElement.Element("_HourlyPayment").Value);
            mother._NumberOfphone = xElement.Element("_NumberOfphone").Value;
            mother._Notes = xElement.Element("_Notes").Value;
            mother.workHours = convertWorkHours(xElement.Element("workHours"));
            return mother;
        }
        public void AddMother(Mother mother)
        {
            Mother help = GetMother(mother._id);
            if (help != null)
                throw new Exception("mother with the same id already exists...");

            MotherRoot.Add(convertMother(mother));
            MotherRoot.Save(MotherPath);
        }
        public bool RemoveMother(int id)
        {
            XElement motherToRemove = (from item in MotherRoot.Elements()
                                      where int.Parse(item.Element("_id").Value) == id
                                      select item).FirstOrDefault();
            if (motherToRemove == null)
                throw new Exception("nanny with the same id not found...");
            motherToRemove.Remove();
            MotherRoot.Save(MotherPath);
            return true;
        }
        public void UpdatingMother(Mother mother)
        {
            RemoveMother(mother._id);
            AddMother(mother);
        }
        public IEnumerable<Mother> GetMotherList(Func<Mother, bool> func = null)
        {

            if (func == null)
            {
                return from item in MotherRoot.Elements()
                       select convertMother(item);
            }
            return from item in MotherRoot.Elements()
                   let s = convertMother(item)
                   where func(s)
                   select s;
        }
        public Mother GetMother(int id)
        {
            XElement mother = null;
            try
            {
                mother = (from item in MotherRoot.Elements()
                         where int.Parse(item.Element("_id").Value) == id
                         select item).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
            if (mother == null)
                return null;
            return convertMother(mother);
        }
        #endregion
      
        #region Contract
        public void AddContract(Contract contract)
        {
            Contract c = GetContract(contract._NumberOfContract);
            if(c!=null)
                throw new Exception("contract with the same number already exists");

            XElement xElementContract = null;
            xElementContract = (from item in ChildRoot.Elements()
                                    where long.Parse(item.Element("_IdOfChild").Value) == contract._IdOfChild
                                    select item).FirstOrDefault();
            if(xElementContract==null)
                throw new Exception("child with the same id of the child in the contract is not found...");

            contract._NumberOfContract = ++numberOfContract;
            ContractRoot.Add(ConvertToXml<Contract>(contract));
            ContractRoot.Save(ContractPath);
        }
        public bool RemoveContract(long number)
        {
            XElement contractXlm = (from item in ContractRoot.Elements()
                                    where long.Parse(item.Element("_NumberOfContract").Value) == number
                                    select item).FirstOrDefault();
            if(contractXlm==null)
                throw new Exception("contract with the same number not found...");
            contractXlm.Remove();

            ContractRoot.Save(ContractPath);
            return true;
        }
        public void UpdatingContract(Contract contract)
        {
            XElement contractToUpdate = (from item in ContractRoot.Elements()
                                      where long.Parse(item.Element("_NumberOfContract").Value) == contract._NumberOfContract
                                      select item).FirstOrDefault();
            if (contractToUpdate == null)
                throw new Exception("child with the same id not found...");

            foreach (PropertyInfo item in typeof(Contract).GetProperties())
                contractToUpdate.Element(item.Name).SetValue(item.GetValue(contract).ToString());

            ContractRoot.Save(ContractPath);
        }
        public IEnumerable<Contract> GetContractList(Func<Contract, bool> func = null)
        {
            if(func==null)
            {
                return from item in ContractRoot.Elements()
                       select ConvertFromXml<Contract>(item);
           }
            return from item in ContractRoot.Elements()
                   let s = ConvertFromXml<Contract>(item)
                   where func(s)
                   select s;
        }
        public Contract GetContract(long id)
        {
            XElement xElementContract = null;
            try
            {
                xElementContract = (from item in ContractRoot.Elements()
                                    where long.Parse(item.Element("_NumberOfContract").Value) == id
                                    select item).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
            if (xElementContract == null)
                return null;
            return ConvertFromXml<Contract>(xElementContract);


        }
        #endregion

       

      

      

       
    }
}
