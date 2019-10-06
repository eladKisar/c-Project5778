using DAL;
using BE;
using System.Linq;
using System;
using GoogleMapsApi;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi.Entities.Directions.Response;
using System.Collections.Generic;
using BL;

namespace Bl
{
    public class Ibl_imp : IBL
    {
        IDAL dal;
        public Ibl_imp()
        {
            dal = Factory_Dal.GetDal();
            initialize();
        }
       void initialize()
        {
            AddNanny(new Nanny
            {
                _Address = "10, avenue de la paix, strasbourg, france",
                _DateOfBirth = new DateTime(1990, 3, 3),
                _Elevators = true,
                _YearsOfExperience = 12,
                _HourlyWage = 23,
                _LastName = "Baya",
                _FitstName = "sari",
                _FloorNumber = 2,
                _id = 300,
                _NumberOfphone = "0548455555",
                _HourlyPayment = true,
                _VacationKind = false,
                _MaxAge = 36,
                _MinAge = 6,
                _MaxChild = 5,
                _MonthWage = 4000,
                
       
        workHours = new WorkHours[]
{
                   new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
},

            });
            AddNanny(new Nanny
            {
                _Address = "14, avenue de la paix, strasbourg,france",
                _DateOfBirth = new DateTime(1990, 3, 3),
                _Elevators = true,
                _YearsOfExperience = 8,
                _HourlyWage = 23,
                _LastName = "gutman5",
                _FitstName = "sari5",
                _FloorNumber = 2,
                _id = 301,
                _NumberOfphone = "0548455555",
                _HourlyPayment = true,
                _VacationKind = false,
                _MaxAge = 35,
                _MaxChild = 5,
                _MonthWage = 4000,
                _MinAge = 5,

                workHours = new WorkHours[]
                {
                   new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
                },

            });
            AddNanny(new Nanny
            {
                _Address = "20 rue de la paix, paris,france",
                _DateOfBirth = new DateTime(1990, 3, 3),
                _Elevators = true,
                _YearsOfExperience = 12,
                _HourlyWage = 23,
                _LastName = "gutman1",
                _FitstName = "sari1",
                _FloorNumber = 2,
                _id = 302,
                _NumberOfphone = "0548455555",
                _HourlyPayment = true,
                _VacationKind = false,
                _MaxAge = 34,
                _MaxChild = 5,
                _MonthWage = 4000,
                _MinAge = 4,

                workHours = new WorkHours[]
              {
                  new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
              },

            });
            AddNanny(new Nanny
            {
                _Address = "10 rue des arquebusiers,strasbourg,france",
                _DateOfBirth = new DateTime(1990, 3, 3),
                _Elevators = true,
                _YearsOfExperience = 12,
                _HourlyWage = 23,
                _LastName = "gutman3",
                _FitstName = "sari3",
                _FloorNumber = 2,
                _id = 303,
                _NumberOfphone = "0548455555",
                _HourlyPayment = false,
                _VacationKind = false,
                _MaxAge = 33,
                _MaxChild = 5,
                _MonthWage = 4000,
                _MinAge = 3,
               
                workHours = new WorkHours[]
             {
                  new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
             },

            });
            AddNanny(new Nanny
            {
                _Address = "5 rue turenne,strasbourg,france",
                _DateOfBirth = new DateTime(1990, 3, 3),
                _Elevators = true,
                _YearsOfExperience = 12,
                _HourlyWage = 23,
                _LastName = "gutman2",
                _FitstName = "sari2",
                _FloorNumber = 2,
                _id = 304,
                _NumberOfphone = "0548455555",
                _HourlyPayment = false,
                _VacationKind = false,
                _MaxAge = 32,
                _MaxChild = 5,
                _MonthWage = 4000,
                _MinAge = 1,

                workHours = new WorkHours[]
           {
                  new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
           },

            });
            AddNanny(new Nanny
            {
                _Address = "40 avenue des vosges,strasbourg,france",
                _DateOfBirth = new DateTime(1990, 3, 3),
                _Elevators = true,
                _YearsOfExperience = 1,
                _HourlyWage = 23,
                _LastName = "gutman4",
                _FitstName = "sari4",
                _FloorNumber = 2,
                _id = 305,
                _NumberOfphone = "0548455555",
                _HourlyPayment = false,
                _VacationKind = false,
                _MaxAge = 31,
                _MaxChild = 5,
                _MonthWage = 4000,
                _MinAge = 4,

                workHours = new WorkHours[]
             {
                  new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
             },

            });

            AddNanny(new Nanny
            {
                _Address = "120 Pesach Chevroni,Jerusalem",
                _FitstName = "Ruhami",
                _LastName = "Vorona",
                _id = 306,

                //rangeOfAge="gg",

                _DateOfBirth = new DateTime(1996, 09, 22),
                _MaxChild = 8,
                _MinAge = 0,
                _MaxAge = 6,
                _Elevators = false,
                _HourlyWage = 40,
                _MonthWage = 4000,
              
                _NumberOfphone = "0543216766",
                _YearsOfExperience = 0,
                _FloorNumber = 1,
                _HourlyPayment = true,
                _VacationKind = false,
                workHours = new WorkHours[]
                {
                   new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
                },
              

            });
            AddNanny(new Nanny
            {
                _Address = "10 avenue des vosges,strasbourg",
                _FitstName = "Sarah",
                _LastName = "Cohen",
                _id = 307,

                //rangeOfAge="gg",

                _DateOfBirth = new DateTime(1970, 09, 22),
                _MaxChild = 8,
                _MinAge = 0,
                _MaxAge = 6,
                _Elevators = false,
                _HourlyWage = 40,
                _MonthWage = 4000,
               
                _NumberOfphone = "0543216766",
                _YearsOfExperience = 0,
                _FloorNumber = 1,
                _HourlyPayment = false,
                _VacationKind = true,
                workHours = new WorkHours[]
                {
                  new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
                 },
              

            });


            AddMother(new Mother
            {
                _Address = "14 avenue de la paix,strasbourg,france",
                _id = 203,
                _FitstName = "Avia",
                _LastName = "Abitan",
                _NumberOfphone = "0525787677",
                _Range = 10000,
                _AreaAddres = "14 avenue de la paix,strasbourg,france",
                _Notes = "not good",
                workHours = new WorkHours[]
                {
                   new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
                },
             

            });
            AddMother(new Mother
            {
                _Address = "12 allee de la robertsau,strasbourg",
                _id = 202,
                _FitstName = "Chaya",
                _LastName = "Levi",
                _Range = 10000,
                _NumberOfphone = "055787677",
                _AreaAddres = "Jerusalem Pesach Chevroni 120 Israel",
                _Notes = "not good",
                workHours = new WorkHours[]
                {
                   new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
                },
               
            });
            AddMother(new Mother
            {
                _LastName = "geleer",
                _NumberOfphone = "0556691448",
                _Address = "4 rue strauss durkheim,strasbourg",
                _FitstName = "chaya",
                _id = 200,
                _Range = 10000,
                _AreaAddres = "פסח חברוני 120, ירושלים",
                workHours
    = new WorkHours[]
    {
                  new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
    },
             

            });
            AddMother(new Mother
            {
                _LastName = "cohen",
                _NumberOfphone = "0556691448",
                _Address = "2 avenue des vosges, strasbourg",
                _FitstName = "rivki",
                _id = 201,
                _Range=10000,
                _AreaAddres = "פסח חברוני 120, ירושלים",
                workHours
                = new WorkHours[]
                {
                  new WorkHours(new TimeSpan(8, 0, 0),new TimeSpan(8, 30, 0),true),
                   new WorkHours (new TimeSpan(9, 0, 0),new TimeSpan(9, 20, 0),true ) ,
                   new WorkHours (new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0), true) ,
                   new WorkHours (new TimeSpan(8, 0, 0) ,new TimeSpan(9, 0, 0),true) ,
                   new WorkHours ( new TimeSpan(8, 0, 0),new TimeSpan(9, 0, 0),true) ,
                   new WorkHours(new TimeSpan(7, 0, 0) ,new TimeSpan(8, 0, 0),true) ,
                },
              

            });

            AddChild(new Child
            {
                _IdOfChild = 100,

                _DateOfBirth = new DateTime(2014, 1, 7),
                _FitstName = "yosi",
                _Disabilities = false,
                _IdOfMather = 200,
                _TypeOfDisabilities=""
            });
            AddChild(new Child
            {
                _IdOfChild = 101,
                _DateOfBirth = new DateTime(1990, 4, 8),
                _FitstName = "yosi2",
                _Disabilities = false,
                _IdOfMather = 200,
                _TypeOfDisabilities = ""
            });
            AddChild(new Child
            {
                _IdOfChild = 102,
                _DateOfBirth = new DateTime(2015, 5, 9),
                _FitstName = "yosi5",
                _Disabilities = true,
                _IdOfMather = 201,
                _TypeOfDisabilities = "satlan"
            });
            AddChild(new Child
            {
                _IdOfChild = 103,
                _DateOfBirth = new DateTime(2016, 4, 2),
                _FitstName = "yosi7",
                _Disabilities = false,
                _IdOfMather = 201,
                _TypeOfDisabilities = ""
            });



            AddContract(contract: new Contract
            {
                _IdOfNanny = 300,
                _IdOfChild = 100,
                _IdOfMother=200,
                _EndDate = new DateTime(2017, 2, 3),
                _StartDate = new DateTime(2017, 1, 3),
                _ContractHourlyPayment = true,
                _SignedContract = true,
                _SallryPerHour = 30,
                _SallryPerMonth = CalculationOfWage(300,200,100),
                _WasMitting = false
            });
            AddContract(contract: new Contract
            {
                _IdOfNanny = 301,
                _IdOfChild = 101,
                _IdOfMother=200,
                _EndDate = new DateTime(2017, 1, 3),
                _StartDate = new DateTime(2017, 1, 3),
                _ContractHourlyPayment = true,
                _SignedContract = true,
                _SallryPerHour = 30,
                _SallryPerMonth = CalculationOfWage(301, 200, 101),
                _WasMitting = false
            });
            AddContract(contract: new Contract
            {
                _IdOfNanny = 302,
                _IdOfChild = 102,
                _IdOfMother=201,
                _EndDate = new DateTime(2015, 9, 9),
                _StartDate = new DateTime(2017, 1, 3),
                _ContractHourlyPayment = true,
                _SignedContract = true,
                _SallryPerHour = 30,
                _SallryPerMonth = CalculationOfWage(302, 201, 102),
                _WasMitting = false
            });


        }
        public  int CalculateDistance(string source, string dest)
        {
            
            var drivingDirectionRequest = new DirectionsRequest
            {
                TravelMode = TravelMode.Walking,
                Origin = source,
                Destination = dest,
            };
            DirectionsResponse drivingDirections = GoogleMaps.Directions.Query(drivingDirectionRequest);
            Route route = drivingDirections.Routes.First();
            Leg leg = route.Legs.First();
            return leg.Distance.Value;
            
          
        }
        /// <summary>
        /// </summary>
        /// <param name="m"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public List<Nanny> RangeNanny(int id,int distance=0)
        {
            Mother mother = this.GetMother(id);
            if (mother == null)
                throw new Exception("not found mother with the same id...");
            List<Nanny> ln = new List<Nanny>();
            if(distance==0)
            {
                if (mother._AreaAddres != null)
                    ln = dal.GetNannyList(gn =>
                    CalculateDistance(mother._AreaAddres, gn._Address) <= mother._Range).
                        ToList();
                else
                    ln = dal.GetNannyList(gn =>
                    CalculateDistance(mother._Address, gn._Address) <= mother._Range).
                        ToList();
            }
            else
            {
                if (mother._AreaAddres != null)
                    ln = dal.GetNannyList(gn =>
                    CalculateDistance(mother._AreaAddres, gn._Address) <= distance * 1000).
                        ToList();
                else
                    ln = dal.GetNannyList(gn =>
                    CalculateDistance(mother._Address, gn._Address) <= distance * 1000).
                        ToList();
            }
            if (ln.Count == 0)
                throw new Exception("Not found nanny in the requested area");
            return ln;
        }
        public List<Nanny> FindNanny(Mother mother, int distance, bool perMounth, double MaxPrice, int MaxAge, 
            int MinYears, bool elevator)
        {
            try
            {
                List<Nanny> ln1 = RangeNanny(mother._id, distance);
                List<Nanny> ln2 = CoordinationNannysForMother(mother._id, perMounth);
                ln1 = (from item1 in ln1
                       from item2 in ln2
                       where item1._id == item2._id
                       select item1).ToList();
                if (perMounth == true)
                    ln1 = ln1.FindAll(fl => fl._HourlyPayment != perMounth &&
                         fl._MonthWage <= MaxPrice && fl._MaxAge <= MaxAge*12 && fl._YearsOfExperience >= MinYears);
                else
                    ln1 = ln1.FindAll(fl => fl._HourlyPayment != perMounth &&
                 fl._HourlyWage <= MaxPrice && fl._MaxAge <= MaxAge*12 && fl._YearsOfExperience >= MinYears);
                if (elevator == true)
                    ln1 = ln1.FindAll(fl => fl._Elevators == true);

                return ln1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        #region nanny function
        /// <summary>
        /// check if the age of the new nanny older then 18 years
        /// and if true send to the Add nanny function in the dal the nanny that wants add him else throw Exception;
        /// Exception:
        ///     the age of the nanny more less than 18 years...
        /// </summary>
        /// <param name="nanny">the nanny that wants add to the nanny list</param>
        public void AddNanny(Nanny nanny)
    {
         
            //if (nanny._id.ToString(). Length < 8)
            //    throw new Exception("invalid id of nanny number  more less then 8 digits ...");
            //if (nanny._id.ToString(). Length > 8)
            //    throw new Exception("invalid id of nanny number  more  then 8 digits ...");
            if (DateTime.Now.AddMonths(-18*12) < nanny._DateOfBirth)
            throw new Exception("invalid age nanny more less than 18 years...  ");
        dal.AddNanny(nanny);
    }
    /// <summary>
    /// send to the Remove nanny function in the dal the nanny that wants remove him;
    /// </summary>
    /// <param name="NannyId">the id of the nanny that wants remove him</param>
    /// <returns>true if item is successfully removed; otherwise, false.</returns>
    public bool RemoveNanny(int NannyId)
    {
        return dal.RemoveNanny(NannyId);
    }
    /// <summary>
    /// send to the Updating nanny function in the dal the nanny that wants updating him;
    /// </summary>
    /// <param name="nanny">the nanny that wants updating him</param>
    public void UpdatingNanny(Nanny nanny)
    {
        dal.UpdatingNanny(nanny);
    }
    /// <summary>
    /// send to the Get nanny list function in the dall,
    /// the delegete that wants about him return the nanny list as enumerable
    /// </summary>
    /// <param name="func">delegate that encapsulates any method </param>
    /// <returns>if the delegate be equal null the function return  the nanny list as enumerable without any proviso ;
    /// else  return IEnumerable that contains elements from the nanny list that satisfy the condition.</returns>
    public IEnumerable<Nanny> GetNannyList(Func<Nanny, bool> func = null)
    {
        return dal.GetNannyList(func);
    }
       public Nanny GetNanny(int id)
        {
            
            return dal.GetNanny(id);
        }
        #endregion
        #region mother function
    /// <summary>
    /// send to the Add mother function in the dal the mother that wants add him;
    /// </summary>
    /// <param name="mother">the mother that wants add him to the mother list</param>
    public void AddMother(Mother mother)
    {
            //if (mother._id.ToString(). Length < 8)
            //    throw new Exception("invalid id of mother number  more less then 8 digits ...");
            //if (mother._id.ToString(). Length > 8)
            //    throw new Exception("invalid id of mother number  more  then 8 digits ...");
            dal.AddMother(mother);
    }
    /// <summary>
    ///  send to the Remove mother function in the dal the mother that wants remove him
    ///  if the remove succeed so the function remove  all his children and all  his contacts ;
    /// </summary>
    /// <param name="id">the id of the mother that wants remove him</param>
    /// <returns>true if item is successfully removed; otherwise, false.</returns>
    public bool RemoveMother(int id)
    {
        bool flag = false;
        flag = dal.RemoveMother(id);
        if (flag)
        {
                
                    var item = from d in dal.GetChildList()
                               where d._IdOfMather == id
                               select d;
                    foreach (Child c in item)
                    {
                          List<Contract> help =dal.GetContractList(gc => gc._IdOfChild == c._IdOfChild).ToList();
                          foreach (var t in help)
                          {
                                 dal.RemoveContract(t._NumberOfContract);
                          }

                         dal.RemoveChild(c._IdOfChild);
                        break;
                    }
               
               
            }
        return flag;
    }

    
    /// <summary>
    /// send to the Updating mother function in the dal the mother that wants updating him;
    /// </summary>
    /// <param name="mother">the mother that wants updating him</param>
    public void UpdatingMother(Mother mother)
    {
        dal.UpdatingMother(mother);
    }
    /// <summary>
    /// send to the Get  mother list function in the dall, 
    /// the delegete that wants about him return the mother list as enumerable
    /// </summary>
    /// <param name="func">delegate that encapsulates any method </param>
    /// <returns>if the delegate be equal null the function return  the mother list as enumerable without any proviso ;
    /// else  return IEnumerable that contains elements from the mother list that satisfy the condition.</returns>
    public IEnumerable<Mother> GetMotherList(Func<Mother, bool> func = null)
    {
        return dal.GetMotherList(func);
    }
        public Mother GetMother(int id)
        {
           
            return dal.GetMother(id);
        }

        #endregion
        #region child function


        /// <summary>
        /// check if the age of the new child older then 3 mounts 
        /// and check if be mothar with same id  in child.id of mother 
        /// if true send to the _Add child function in  dal_ the child that wants add him 
        /// else throw Exception;
        /// Exception:
        /// if the age of the child not older then 3 month
        /// throw exception: the age of the child more less than 3 mounts...
        /// if not found mother
        /// not found mother with the same id of the id in child.id of mother...
        /// </summary>
        /// <param name="child">the child that wants add to the child list</param>
        public void AddChild(Child child)
    {
           
            //     if(child._IdOfChild.ToString().Length<8)
            //      throw new Exception("invalid id of child number  more less then 8 digits ...");
            //if (child._IdOfChild.ToString().Length > 8)
            //    throw new Exception("invalid id of child  number  more  then 8 digits ...");
            if (!dal.GetMotherList(gn => gn._id == child._IdOfMather).Any())
                throw new Exception("not found mother with the same id of the id in child.id of mother...  ");
               if (DateTime.Now.AddMonths(-3) < child._DateOfBirth)
                throw new Exception("the age of the child more less then 3 mounts...  ");
             dal.AddChild(child);
           
        }
    /// <summary>
    ///  send to the Remove child function in the dal the child that wants remove him
    /// </summary>
    /// <param name="id">the id of the child that wants remove him</param>
    /// <returns>true if item is successfully removed; otherwise, false.</returns>
    public bool RemoveChild(int id)
    {
        return dal.RemoveChild(id);
    }
    /// <summary>
    /// send to the Updating child function in the dal the child that wants updating him;
    /// </summary>
    /// <param name="child">the child that wants updating him</param>
    public void UpdatingChild(Child child)
    {
        dal.UpdatingChild(child);
    }
    /// <summary>
    /// send to the Get child list function in the dall, 
    /// the delegete that wants about him return the mother list as enumerable
    /// </summary>
    /// <param name="func">delegate that encapsulates any method </param>
    /// <returns>if the delegate be equal null the function return  the child list as enumerable without any proviso ;
    /// else  return IEnumerable that contains elements from the child list that satisfy the condition.</returns>
    public IEnumerable<Child> GetChildList(Func<Child, bool> func = null)
    {
        return dal.GetChildList(func);
    }
        public Child GetChild(int id)
        {
            
            return dal.GetChild(id);
        }
        #endregion
        #region contract function
        /// <summary>
        /// check if the wage per hour or per mounth
        /// and about its calculates the wage of the nanny to mount
        /// inaddition calculates the bonus for all child in two present
        /// </summary>
        /// <param name="nanny">the mother of the child </param>
        /// <param name="mother">the nanny of the child </param>
        /// <returns>the wage of the nanny to mount</returns>
    public double CalculationOfWage(int Idnanny, int Idmother,int IdChild)
    {
            Nanny nanny = GetNanny(Idnanny);
            Mother mother = GetMother(Idmother);
            Child child=GetChild(IdChild);
            double sallry = 0;
            TimeSpan t = new TimeSpan();
            //the wage per hour
            if (mother._HourlyPayment)
            {
                foreach (var item in nanny.workHours)
                {
                    if (item.DayWork)
                    {
                        t += item.EndHour - item.StartHour;
                    }
                }
                t = t + t + t + t;
                sallry = t.Hours* nanny._HourlyWage + t.Minutes* (nanny._HourlyWage / 60);
            }
            //the wage per moun
            else
                sallry = nanny._MonthWage;
            //calculates bonus for all child in two present
            var v = from item in dal.GetContractList()
                    where item._IdOfMother == child._IdOfMather&&item._IdOfChild!=child._IdOfChild
                    select item;
            foreach (var item in v)
            {
                sallry = sallry* 0.98;
            }

          return sallry;

        }
        /// <summary>
        /// check if has to the nanny maximum child
        /// if true throw exception else build contract and send him to Add Contract function in the dall
        /// and after send the nany to  Add Starfunction
        /// Exception:
        /// The nanny has a maximum of children...
        /// </summary>
        /// <param name="nanny">the nanny that wants add to the contracrt</param>
        /// <param name="mother">the mother that wants add to the contracrt</param>
        /// <param name="child">the child that wants add to the contracrt</param>
        public void AddContract(Contract contract)
        {
            
            Nanny nanny = this.GetNanny(contract._IdOfNanny);
            if (nanny == null)
                throw new Exception("not found nanny with same id...");
            Mother mother = this.GetMother(contract._IdOfMother);
            if (mother == null)
                throw new Exception("not found mother with same id...");
            Child child = this.GetChild(contract._IdOfChild);
            if (child == null)
                throw new Exception("not found child with same id...");
            int x = 0;
            foreach (var i in dal.GetContractList(item => item._IdOfNanny == nanny._id))
                x++;
            if (x >= nanny._MaxChild)
                throw new Exception("The nanny has a maximum of children...");
            //if (!(DateTime.Now.AddMonths(-nanny._MaxAge)<=child._DateOfBirth  && 
            //    DateTime.Now.AddMonths(-nanny._MinAge)>= child._DateOfBirth))
            //    throw new Exception("The child is not within the age range that the nanny receives....");
           
            dal.AddContract(contract);
            AddStar(nanny);
        }
        /// <summary>
        /// send to the Remove contract list in the dall the contract that wants remove him
        /// </summary>
        /// <param name="number">the number of contract that wants remove him</param>
        /// <returns>true if item is successfully removed; otherwise, false.</returns>
        public bool RemoveContract(long number)
{
    return dal.RemoveContract(number);
}
        /// <summary>
        /// send to the Updating contract function in the dal the contract that wants updating him;
        /// </summary>
        /// <param name="contract">the number of contract that wants updating him</param>
        public void UpdatingContract(Contract contract)
        {
            dal.UpdatingContract(contract);
        }

/// <summary>
/// send to the Get contract list function in the dall, 
/// the delegete that wants about him return the contract list as enumerable
/// </summary>
/// <param name="func">delegate that encapsulates any method </param>
/// <returns>if the delegate be equal null the function return  the contract list as enumerable without any proviso ;
/// else  return IEnumerable that contains elements from the contract list that satisfy the condition.</returns>
public IEnumerable<Contract> GetContractList(Func<Contract, bool> func = null)
{
    return dal.GetContractList(func);
}
        public Contract Getcontract(long number)
        {
            
            return dal.GetContract(number);
        }
        #endregion
        #region  function
        public IEnumerable<IGrouping<int, Contract>> GroupingByDistance(bool flag=false)
        {
           
            IEnumerable<IGrouping<int, Contract>> Ie;
            if (flag)
            {
                Ie = from item in dal.GetContractList()
                     let distance = CalculateDistance(this.GetMother(item._IdOfMother)._Address, 
                     this.GetNanny(item._IdOfNanny)._Address)
                     orderby distance
                     group item by distance / 5 into g
                     select g;
            }
            else
            {
                Ie = from item in dal.GetContractList()
                let distance = CalculateDistance(this.GetMother(item._IdOfMother)._Address,
                this.GetNanny(item._IdOfNanny)._Address)
                group item by distance / 5 into g
                select g;
            }
           
            return Ie;
        }


       public IEnumerable<IGrouping<int, Contract>> GroupingByAge(bool flag = false)
        {
          
          
            IEnumerable<IGrouping<int, Contract>> Ie;
            if (flag)
            {
                Ie = from item in dal.GetContractList()
                     orderby item._NumberOfContract
                     group item by this.GetNanny(item._IdOfNanny)._MaxAge;
            }
            else
            {
                Ie = from item in dal.GetContractList()
                     group item by this.GetNanny(item._IdOfNanny)._MinAge;
            }
        return Ie;
        }
       
        /// <summary>
        /// the function make the first match between the mother and nanny
        /// the function check if the work hors of the nanny and her working days matching to the mother request,
        /// if true she return the nanny in list of all the nannies that be matchs
        /// else she call to -Coordination Nannys For Mother 2 function- that check for more matches, 
        /// </summary>
        /// <param name="mother">the mother that wants maching him nanny</param>
        /// <returns>list of all the nannies that maches to the mother</returns>
public List<Nanny> CoordinationNannysForMother(int id,bool perMounth)
{
     Mother mother = GetMother(id);
    List<Nanny> ln = new List<Nanny>();
            bool flag = false;
            foreach (var item in GetNannyList(x => x._HourlyPayment != perMounth))
            {
                for (int i = 0; i < 6; i++)
                {
                    if (item.workHours[i].DayWork == mother.workHours[i].DayWork &&
                                item.workHours[i].StartHour <= mother.workHours[i].StartHour
                        && item.workHours[i].EndHour >= mother.workHours[i].EndHour)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                       
                }
                if (flag)
                    ln.Add(item);
            }
    if (ln.Count == 0)
        return CoordinationNannysForMother2(mother,perMounth);
    return ln;
}
        /// <summary>
        /// the function make the secound match between the mother and nanny
        /// the function check if the work hours of the nanny matching to the mother request up to two hours apart , 
        /// if true she return the nanny in list of all the nannies that be matchs (the list contains maximum 5 nannies)
        /// else she throw exception;
        /// Exception:
        /// not found nanny for this mother... 
        /// </summary>
        /// <param name="mother">the mother that wants mach him nanny</param>
        /// <returns>list of the five nannies that maches to the mother</returns>
        List<Nanny> CoordinationNannysForMother2(Mother mother, bool perMounth)
        {

            List<Nanny> ln = new List<Nanny>();
            TimeSpan t = new TimeSpan(00, 30, 00);
            for (int j = 0; j < 3; j++)
            {


                foreach (var nanny in GetNannyList(x => x._HourlyPayment != perMounth))
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if ((nanny.workHours[i].DayWork && mother.workHours[i].DayWork) &&
                            (nanny.workHours[i].StartHour - mother.workHours[i].StartHour) <= t &&
                           (mother.workHours[i].EndHour - nanny.workHours[i].EndHour) <= t)
                        {
                            ln.Add(nanny);
                            break;
                        }
                    }
                }
                if (ln.Count >= 5)
                    break;
                t = t + t;
            }
            if (ln.Count == 0)
                throw new Exception("not found nanny for this mother... ");
            return ln;
        }
        /// <summary>
        /// build list with all the children that not found  nanny
        /// and check him if the list be empty the function throw exception else the function return the list;
        /// Exception:
        ///  not have children that not found nanny...  
        /// </summary>
        /// <returns>list with all the children that not found  nanny </returns>
  List<Child> NotFoundNanny()
{
    List<Child> lc = new List<Child>();
    foreach (var item in dal.GetChildList())
    {
        if (dal.GetContractList().FirstOrDefault(gt => gt._IdOfChild == item._IdOfChild) == null)
            lc.Add(item);
    }
    if (lc.Count == 0)
        throw new Exception("not have children that not found nanny...");
    return lc;

}
/// <summary>
/// build list with all the nannys  that receive vacation according to the TMT
/// and check him if the list be empty the function throw exception else the function return the list;
/// Exception:
///    not found nannys that receive vacation according to the TMT...
/// </summary>
/// <returns>list with all the nannys  that receive vacation according to the TMT </returns>
List<Nanny> TmtVaction()
{
    List<Nanny> ln = new List<Nanny>();
    foreach (var item in dal.GetNannyList(gn => gn._VacationKind))
    {
        ln.Add(item);
    }
    if (ln.Count == 0)
        throw new Exception("not found nannys that receive vacation according to the TMT...");
    return ln;

    
}
        /// <summary>
        /// build list with all Contracts that fulfill the condition
        /// and check him if the list be empty the function throw exception else the function return the list;
        /// Exception:
        /// not found contract that fulfill the condition...
        /// </summary>
        /// <param name="func">delegate that encapsulates any method </param>
        /// <returns>list with all the Contracts  that fulfill the condition</returns>
 List<Contract> ListContractOfAnyProviso(Func<Contract, bool> func = null)
{
    List<Contract> lc = new List<Contract>();
    foreach (var item in dal.GetContractList(func))
    {
        lc.Add(item);
    }
    if (lc.Count == 0)
        throw new Exception("not found contract that fulfill the condition... ");
    return lc;
}
/// <summary>
/// build list with all Contracts that fulfill the condition
/// and check him if the list be empty the function throw exception 
/// else the function return the count of the contracts that fulfill the condition;
/// Exception:
/// not found contract that fulfill the condition...
/// </summary>
/// <param name="func">delegate that encapsulates any method </param>
/// <returns>the count of the contracts that fulfill the condition</returns>
List<long> NumListContractOfAnyProviso(Func<Contract, bool> func = null)
{
    List<long> lc = new List<long>();
    foreach (var item in dal.GetContractList(func))
    {
        lc.Add(item._NumberOfContract);
    }
    if (lc.Count == 0)
        throw new Exception("not found contract that fulfill the condition... ");
    return lc;
}
#endregion
#region UsFuncion
/// <summary>
/// build list with all  chidren with disabilities
/// and check him if the list be empty the function throw exception else the function return the list;
/// Exception:
/// not found child with Disabilities...
/// </summary>
/// <returns>list with all the chidren with disabilities</returns>
List<Child> ListDisabilities()
{
    List<Child> a1 = dal.GetChildList(x => x._Disabilities).ToList();
    if (a1.Count == 0)
        throw new Exception("not found child with Disabilities...");
    return a1;
}
/// <summary>
/// caheck the num of the children being treated by the nanny and for every 5 children 
/// the nanny receives one star
/// </summary>
/// <param name="nanny">the nanny that wants add him star</param>
void AddStar(Nanny nanny)
{
    int x = 0;
    IEnumerable<Contract> v = from item in dal.GetContractList()
            where item._IdOfNanny == nanny._id
            select item;
    foreach (var item in v)
    {
        x++;
    }
    if (x - nanny.NumOfStars * 5 == 5)
        nanny.NumOfStars++;

    
}
        /// <summary>
        /// return num the stars of the nanny
        /// </summary>
        /// <param name="n">the nanny that wants his num of Stars</param>
        /// <returns>the num of the stars</returns>
        int NumOfStars(Nanny nanny)
{
    return nanny.NumOfStars;
}
/// <summary>
/// build list with all nannies that takes specific mount wages
/// and check him if the list be empty the function throw exception else the function return the list;
/// Exception:
///  not found nanny that take maximimum this wages per mount... 
/// </summary>
/// <param name="sallrPerHour">the maximimum wage per mount</param>
/// <returns> list with all the nannys that takes specific mount wages </returns>
List<Nanny> SamePaymentPerHour(double sallrPerHour = 0)
{
    List<Nanny> ln = dal.GetNannyList(item => item._HourlyWage <= sallrPerHour).ToList();
    if (ln.Count == 0)
        throw new Exception("not found nanny that take maximimum this wages per mount... ");
    return ln;
}
/// <summary>
/// build list with all nannies that takes specific hourly wages
/// and check him if the list be empty the function throw exception else the function return the list;
/// Exception:
///  not found nanny that take maximimum this wages per hour... 
/// </summary>
/// <param name="SallryPerMounth">the maximimum wage per hour</param>
/// <returns> list with all the nannies that takes specific hourly wages </returns>
List<Nanny> SamePaymentPerMounth(double SallryPerMounth)
{
    List<Nanny> ln = dal.GetNannyList(item => item._MonthWage <= SallryPerMounth).ToList();
    if (ln.Count == 0)
        throw new Exception("not found nanny that take maximimum this wages per hour... ");
    return ln;
}
/// <summary>
/// the function get nanny and recommendation for this nanny and 
/// add the recommendation to the nanny
/// </summary>
/// <param name="nany">the nanny that wants add him recommendation</param>
/// <param name="Recommendation">the recommendation that wants add to th nanny</param>
void AddRecommendations(Nanny nany, string Recommendation)
{
    nany._Recommendations= Recommendation;

}
/// <summary>
/// the function get id and return the recommendation of thw nanny with the same id
/// </summary>
/// <param name="id">the id of the nanny that wants his recommendation</param>
/// <returns>the recommendation of the nanny with the same id</returns>
string RecommendationsOfNanny(int id)
{
    Nanny n = new Nanny();
    
    return n._Recommendations;
}
        public List<Nanny> nannyWithExperience(int num)
        {
            try
            {
                List<Nanny> nannyWithExperience = dal.GetNannyList(item => item._YearsOfExperience >= num).ToList();
                if (nannyWithExperience.Count() == 0)
                    throw new Exception("There is no nanny with minimum " + num.ToString() + " years of experience");
                return nannyWithExperience;

            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<Child> noNanniesFound()
        {
            try
            {
                List<Child> noNanniesFound = new List<Child>();
                foreach (var item in dal.GetChildList())
                {
                    bool flag = false;
                    foreach (var i in dal.GetContractList())
                    {
                        if (item._IdOfChild == i._IdOfChild)
                            flag = true;
                    }
                    if (!flag)
                        noNanniesFound.Add(item);
                }
                if (noNanniesFound.Count() == 0)
                    throw new Exception("All the children have a nanny");
                return noNanniesFound;

            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<Child> childSpecialNeeds()
        {
            try
            {
                List<Child> specialNeeds = dal.GetChildList(item => item._Disabilities).ToList();
                if (specialNeeds.Count() == 0)
                    throw new Exception("There is no child with special needs");
                return specialNeeds;

            }
            catch (Exception e)
            {

                throw e;
            }
        }
        /// <summary>
        /// Looking for all the nannies who live on a specific floor
        ///  or are on higher floors but have an elevator 
        /// </summary>
        /// <param name="Max"></param>
        /// <returns></returns>
        List<Nanny> MaxNumOfFloor(int Max)
{
    List<Nanny> a = dal.GetNannyList(gn => gn._FloorNumber <= Max || gn._Elevators == true).ToList();
    if (a.Count == 0)
        throw new Exception("not found nanny...");
    return a;
}

      
        #endregion
    }


}