using System;
using System.Collections.Generic;
using System.Collections;
using BE;
using DAL;
using System.Linq;

namespace BL
{
    public interface IBL
    {
        //function for Nanny
        void AddNanny(Nanny n);
        bool RemoveNanny(int NannyId);
        void UpdatingNanny(Nanny nanny);
        IEnumerable<Nanny> GetNannyList(Func<Nanny, bool> func = null);
        Nanny GetNanny(int id);
        /// <summary>
        /// //////////////
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        IEnumerable<IGrouping<int, Contract>> GroupingByDistance(bool flag = false);
        List<Nanny> RangeNanny(int id,int d=0);
        /// <summary>
        /// ///////////////////////
        /// </summary>
        /// <param name="mother"></param>
        //function for mother
        void AddMother(Mother mother);
        bool RemoveMother(int id);
        void UpdatingMother(Mother mother);
        IEnumerable<Mother> GetMotherList(Func<Mother, bool> func = null);
        Mother GetMother(int id);

        //function of Child
        void AddChild(Child child);
        bool RemoveChild(int id);
        void UpdatingChild(Child child);
        IEnumerable<Child> GetChildList(Func<Child, bool> func = null);
        Child GetChild(int id);

        //function of Contract
        void AddContract(Contract contract);
        bool RemoveContract(long id);
        void UpdatingContract(Contract contract);
        IEnumerable<Contract> GetContractList(Func<Contract, bool> func = null);
        Contract Getcontract(long number);

        List<Nanny> CoordinationNannysForMother(int id,bool p);
        List<Nanny> FindNanny(Mother mother, int distance, bool perMounth, double MaxPrice, int MaxAge, int MinYears, bool elevator);
        double CalculationOfWage(int Idnanny, int Idmother, int IdChild);
         List<Nanny> nannyWithExperience(int num);
         List<Child> noNanniesFound();
        int CalculateDistance(string source, string dest);

        List<Child> childSpecialNeeds();
        IEnumerable<IGrouping<int, Contract>> GroupingByAge(bool flag = false);
    }
}
