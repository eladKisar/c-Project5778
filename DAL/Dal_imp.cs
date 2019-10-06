using System;
using System.Collections.Generic;
using System.Text;
using BE;
using DS;
using System.Linq;

namespace DAL
{
    public class Dal_imp : IDAL
    {

        public static long numberOfContract = 10000000;
      


        DataSource DS;
        /// <summary>
        /// Initializes the number of contracts
        /// and build the variable of data Source
        /// </summary>
        public Dal_imp()
        {
            numberOfContract++;
         
             DS = new DataSource();
        }
        #region nanny function
        /// <summary>
        /// check if the new nanny not exists in the nanny list
        /// and if true add him else throw Exception
        /// Exception:
        ///     nanny with the same id already exists...
        /// </summary>
        /// <param name="nanny">the nanny that wonts add to the nanny list</param>
        public void AddNanny(Nanny nanny)
        {
            Nanny help = GetNanny(nanny._id);
            if (help != null)
                throw new Exception("nanny with the same id already exists...");

            DS.NannysList.Add(nanny);
        }
        /// <summary>
        ///   check if nanny with the same id exists in the nanny list
        ///   and if true remove him and all his contracts 
        ///   else throw exception
        /// Exception:
        ///   nanny with the same id not found... 
        /// </summary>
        /// <param name="NannyId">the id of the nanny that wants remove him</param>
        /// <returns>true if item is successfully removed; otherwise, false.</returns>
        public bool RemoveNanny(int NannyId)
        {
            Nanny help = GetNanny(NannyId);
            if (help == null)
                throw new Exception("nanny with the same id not found...");
            DS.ContractsList.RemoveAll(cl => cl._IdOfNanny == NannyId); //we are assumed that the erased item had also been erased from her contract

            return DS.NannysList.Remove(help);
        }
        /// <summary>
        /// check if nanny with the same id exists in the nanny list
        /// and if true updating him else throw exception
        /// Exception:
        ///    nanny with the same id not found...
        /// </summary>
        /// <param name="nanny">the nanny that wants updating him</param>
        public void UpdatingNanny(Nanny nanny)
        {
           
            int index = DS.NannysList.FindIndex(nl => nl._id == nanny._id);
            if (index == -1)
                throw new Exception("nanny with the same id not found...");
            DS.NannysList[index] = nanny;
        }

       
        /// <summary> 
        ///  the function get delegate and about him return the nanny list as enumerable
        /// </summary>
        /// <param name="func">delegate that encapsulates any method </param>
        /// <returns>if the delegate be equal null the function return  the nanny list as enumerable without any proviso ;
        /// else  return IEnumerable that contains elements from the nanny list that satisfy the condition.</returns>
        public IEnumerable<Nanny> GetNannyList(Func<Nanny, bool> func = null)
        {
            if (func == null)
                return DS.NannysList.AsEnumerable();
            return DS.NannysList.Where(func);
        }
        /// <summary>
        ///     Returns the first element in the nanny list that be with the same id  or a default
        ///     value if no such element is found.   
        /// </summary>
        /// <param name="id">the id of the nanny that looking for him</param>
        /// <returns>default(TSource) if the nanny list is empty or if no element passes the test ;
        /// otherwise, the first element in the nanny list that passes the test</returns>
        public Nanny GetNanny(int id)
        {
         
            return DS.NannysList.FirstOrDefault(n => n._id == id);
        }
        #endregion
        #region mother function
        /// <summary>
        /// check if the new mother not exists in the mother list
        /// and if true add him else throw Exception
        /// Exception:
        ///     mother with the same id already exists...
        /// </summary>
        /// <param name="mother">the mother that wonts add to the mother list</param>
        public void AddMother(Mother mother)
        {
            Mother m = GetMother(mother._id);
            if (m != null)
                throw new Exception("mother with the same id already exists...");
            DS.MothersList.Add(mother);
        }
        /// <summary>
        ///   check if mother with the same id exists in the mother list
        ///   and if true remove him 
        ///   else throw exception
        /// Exception:
        ///   mother with the same id not found... 
        /// </summary>
        /// <param name="id">the id of the mother that wants remove him</param>
        /// <returns>true if item is successfully removed; otherwise, false.</returns>
        public bool RemoveMother(int id)
        {
            Mother m = GetMother(id);
            if (m == null)
                throw new Exception("mother with the same id not found... ");

           
return DS.MothersList.Remove(m);
        }
    /// <summary>
    /// check if mother with the same id exists in the mother list
    /// and if true updating him else throw exception
    /// Exception:
    ///    mother with the same id not found...
    /// </summary>
    /// <param name="mother">the mother that wants updating him</param>
    public void UpdatingMother(Mother mother)
    {
          
        int index = DS.MothersList.FindIndex(ml => ml._id == mother._id);
        if (index == -1)
            throw new Exception("mother with the same id not found... ");
        DS.MothersList[index] = mother;
    }
    /// <summary>
    ///  the function get delegate and about him return the mother list as enumerable
    /// </summary>
    /// <param name="func">delegate that encapsulates any method </param>
    /// <returns>if the delegate be equal null the function return  the mother list as enumerable without any proviso ;
    /// else  return IEnumerable that contains elements from the mother list that satisfy the condition.</returns>
    public IEnumerable<Mother> GetMotherList(Func<Mother, bool> func = null)
    {
        if (func == null)
            return DS.MothersList.AsEnumerable();
        return DS.MothersList.Where(func);
    }
    /// <summary>
    ///     Returns the first element in the mother list that be with the same id  or a default
    ///     value if no such element is found.   
    /// </summary>
    /// <param name="id">the id of the mother that looking for him</param>
    /// <returns>default(TSource) if the mother list is empty or if no element passes the test ;
    /// otherwise, the first element in the mother list that passes the test</returns>
    public Mother GetMother(int id)
    {
        return DS.MothersList.FirstOrDefault(ml => ml._id == id);
    }
    #endregion
    #region child function
    /// <summary>
    /// check if the new child not exists in the child list
    /// and if true add him else throw Exception
    /// Exception:
    ///     child with the same id already exists...
    /// </summary>
    /// <param name="child">the child that wonts add to the child list</param>
    public void AddChild(Child child)
    {
            Child c = GetChild(child._IdOfChild);
            if (c != null)
                throw new Exception("child with the same id already exists");
            DS.ChildsList.Add(child);
        
           
        }
/// <summary>
///   check if child with the same id exists in the child list
///   and if true remove him and all his contracts 
///   else throw exception
/// Exception:
///   child with the same id not found... 
/// </summary>
/// <param name="id">the id of the child that wants remove him</param>
/// <returns>true if item is successfully removed; otherwise, false.</returns>
public bool RemoveChild(int id)
{
    Child c = GetChild(id);
    if (c == null)
        throw new Exception("child with the same id not found...");
           
    DS.ContractsList.RemoveAll(cl => cl._IdOfChild == id);
    return DS.ChildsList.Remove(c);
}
/// <summary>
/// check if child with the same id exists in the child list
/// and if true updating him else throw exception
/// Exception:
///    child with the same id not found...
/// </summary>
/// <param name="child">the child that wants updating him</param>
public void UpdatingChild(Child child)
{
         
    int index = DS.ChildsList.FindIndex(cl => cl._IdOfChild == child._IdOfChild);
    if (index == -1)
        throw new Exception("child with the same id not found...");
    DS.ChildsList[index] = child;
}
/// <summary>
///  the function get delegate and about him return the child list as enumerable
/// </summary>
/// <param name="func">delegate that encapsulates any method </param>
/// <returns>if the delegate be equal null the function return  the child list as enumerable without any proviso ;
/// else  return IEnumerable that contains elements from the child list that satisfy the condition.</returns>
public IEnumerable<Child> GetChildList(Func<Child, bool> func = null)
{
    if (func == null)
        return DS.ChildsList.AsEnumerable();
    return DS.ChildsList.Where(func);
}
/// <summary>
///     Returns the first element in the child list that be with the same id  or a default
///     value if no such element is found.   
/// </summary>
/// <param name="id">the id of the child that looking for him</param>
/// <returns>default(TSource) if the child list is empty or if no element passes the test ;
/// otherwise, the first element in the child list that passes the test</returns>
public Child GetChild(int id)
{
          
    return DS.ChildsList.FirstOrDefault(cl => cl._IdOfChild == id);
}
#endregion
#region contract function
/// <summary>
/// check if the new contract not exists in the contract list
/// and mother with the same id of the mother in the contract exists in the mother list 
/// and nanny with the same id of the nanny in the contract  exists in the nanny list 
/// and child with the same id of the child in the contract  exists in the child list
/// and if true add him else throw Exception
/// else throw Exception  
/// </summary>
/// <param name="contract">the contract that wonts add to the contract list</param>
public void AddContract(Contract contract)
{
    Contract c = GetContract(contract._NumberOfContract);
    if (c != null)
                throw new Exception("contract with the same number already exists");


            if (!(DS.MothersList.FindAll(ml => ml._id == contract._IdOfMother).Any()))
                throw new Exception("mother with the same id of the mother in the contract is not found...");
            if (!(DS.NannysList.FindAll(nl => nl._id == contract._IdOfNanny).Any()))
                throw new Exception("nanny with the same id of the nanny in the contract is not found...");
            if (!(DS.ChildsList.FindAll(nl => nl._IdOfChild == contract._IdOfChild).Any()))
                throw new Exception("child with the same id of the child in the contract is not found...");
contract._NumberOfContract= ++numberOfContract;

            DS.ContractsList.Add(contract);
        }
        /// <summary>
        ///   check if contract with the same id exists in the contract list
        ///   and if true remove him 
        ///   else throw exception
        /// Exception:
        ///   contract with the same number not found... 
        /// </summary>
        /// <param name="number">the id of the contract that wants remove him</param>
        /// <returns>true if item is successfully removed; otherwise, false.</returns>
        public bool RemoveContract(long number)
{
    Contract c = GetContract(number);
    if (c == null)
        throw new Exception("contract with the same number not found...");
    return DS.ContractsList.Remove(c);
}
/// <summary>
/// check if contract with the same number exists in the contract list 
/// and mother with the same id of the mother in the contract exists in the mother list 
/// and nanny with the same id of the nanny in the contract  exists in the nanny list 
/// and if true updating him else throw exception
/// </summary>
/// <param name="contract">the contract that wants updating him</param>
public void UpdatingContract(Contract contract)
{
          
    int index = DS.ContractsList.FindIndex(cl => cl._NumberOfContract == contract._NumberOfContract);
    if (index == -1)
        throw new Exception("contract with the same number not found...");
    if (!(DS.MothersList.FindAll(ml => ml._id == contract._IdOfMother).Any()))
        throw new Exception("mother with the same id of the mother in the contract is not found...");
    if (!(DS.NannysList.FindAll(nl => nl._id == contract._IdOfNanny).Any()))
        throw new Exception("nanny with the same id of the nanny in the contract is not found...");

   
DS.ContractsList[index] = contract;
        }
        /// <summary>
        ///  the function get delegate and about him return the contract list as enumerable
        /// </summary>
        /// <param name="func">delegate that encapsulates any method </param>
        /// <returns>if the delegate be equal null the function return  the contract list as enumerable without any proviso ;
        /// else  return IEnumerable that contains elements from the contract list that satisfy the condition.</returns>
        public IEnumerable<Contract> GetContractList(Func<Contract, bool> func = null)
{
    if (func == null)
        return DS.ContractsList.AsEnumerable();
    return DS.ContractsList.Where(func);
}
/// <summary>
///     Returns the first element in the contract list that be with the same id  or a default
///     value if no such element is found.   
/// </summary>
/// <param name="number">the id of the contract that looking for him</param>
/// <returns>default(TSource) if the contract list is empty or if no element passes the test ;
/// otherwise, the first element in the contract list that passes the test</returns>
public Contract GetContract(long number)
{
    return DS.ContractsList.FirstOrDefault(cl => cl._NumberOfContract == number);
}
        #endregion
    }
}