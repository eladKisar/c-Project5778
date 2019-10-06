using System;
using System.Collections.Generic;
using System.Collections;
using BE;
namespace DAL
{

    public interface IDAL
    {

        //function of Nanny
        void AddNanny(Nanny n);
        bool RemoveNanny(int NannyId);
        void UpdatingNanny(Nanny nanny);
        IEnumerable<Nanny> GetNannyList(Func<Nanny, bool> func = null);
        Nanny GetNanny(int id);

        //function of mother
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
        bool RemoveContract(long number);
        void UpdatingContract(Contract contract);
        IEnumerable<Contract> GetContractList(Func<Contract, bool> func = null);
        Contract GetContract(long id);
    }
}