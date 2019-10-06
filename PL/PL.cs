using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;
namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {

            IBL bl = Bl_Singleton.GetBl();
            




            Console.WriteLine(@"to add child / nanny / mother / contract enter 1,
to remove child / nanny / mother / contract enter 2,
to update child / nanny / mother /contract enter 3,
to print all childrens / nanneis / mothers / contract enter 4, 
to end enter zero");
            string choice = Console.ReadLine();
            while (int.Parse(choice) != 0)
            {
                try
                {
                    switch (int.Parse(choice))
                    {

                        case 1:
                            Console.WriteLine("to add child enter 1,to add nanny enter 2,to add mother enter 3,to add contract enter 4");
                            string choice1 = Console.ReadLine();
                            switch (int.Parse(choice1))
                            {
                                case 1:
                                    
                                    Child child = new Child();
                                    Console.WriteLine();
                                    Console.WriteLine("enter id of child");
                                    child._IdOfChild = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter id of mother");
                                    child._IdOfMather = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter first name of child");
                                    child._FitstName = Console.ReadLine();
                                    Console.WriteLine("enter year Of Birth ");
                                    int yearChild = int.Parse(Console.ReadLine()); ;
                                    Console.WriteLine("enter month Of Birth");
                                    int monthChild = int.Parse(Console.ReadLine()); ;
                                    Console.WriteLine("enter day Of Birth");
                                    int dayChild = int.Parse(Console.ReadLine()); ;
                                    child._DateOfBirth = new DateTime(yearChild, monthChild, dayChild);
                                    Console.WriteLine("enter if has Disabilities (true or false)");
                                    child._Disabilities = bool.Parse(Console.ReadLine());
                                    Console.WriteLine("enter the Disabilities kind or enter");
                                    child._TypeOfDisabilities = Console.ReadLine();
                                    bl.AddChild(child);
                                    break;
                                case 2:
                                    Nanny nanny = new Nanny();
                                    Address addre1 = new Address();
                                    Console.WriteLine("enter id of nanny");
                                    nanny._id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter last name of nanny");
                                    nanny._LastName = Console.ReadLine();
                                    Console.WriteLine("enter first name of nanny");
                                    nanny._FitstName = Console.ReadLine();
                                    int yearNanny = int.Parse(Console.ReadLine()); ;
                                    Console.WriteLine("enter year Of Birth");
                                    int monthNanny = int.Parse(Console.ReadLine()); ;
                                    Console.WriteLine("enter mounth Of Birth");
                                    int dayNanny = int.Parse(Console.ReadLine()); ;


                                    nanny._DateOfBirth = new DateTime(yearNanny, monthNanny, dayNanny);
                                    Console.WriteLine("enter phone number of nanny(for xample: 058-780-6-771");
                                    nanny._NumberOfphone = Console.ReadLine();
                                    Console.WriteLine("enter addresss of nanny:citi street buildingNumber ");
                                    addre1.city = Console.ReadLine();
                                    addre1.Street = Console.ReadLine();
                                    addre1.buildingNumber = Console.ReadLine();
                                    nanny._Address = addre1.ToString();
                                    Console.WriteLine("enter if has elevator (true or false)");
                                    nanny._Elevators = bool.Parse(Console.ReadLine());
                                    Console.WriteLine("enter floor number  ");
                                    nanny._FloorNumber = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter Years Of Experience  ");
                                    nanny._YearsOfExperience = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter Max Child  ");
                                    nanny._MaxChild = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter Max Age  ");
                                    nanny._MaxAge = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter Min Age ");
                                    nanny._MinAge = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter if get Hourly Payment (true or false) ");
                                    nanny._HourlyPayment = bool.Parse(Console.ReadLine());
                                    if (nanny._HourlyPayment)
                                    {
                                        Console.WriteLine("enter Hourly Wage");
                                        nanny._HourlyWage = int.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        Console.WriteLine("enter Month Wage");
                                        nanny._MonthWage = int.Parse(Console.ReadLine());
                                    }
                                    Console.WriteLine("enter if take free of TMT (true or false) ");
                                    nanny._VacationKind = bool.Parse(Console.ReadLine());
                                    nanny.NumOfStars = 0;
                                    bl.AddNanny(nanny);

                                    break;
                                case 3:
                                    Mother mother = new Mother();
                                    Address addre = new Address();
                                    Console.WriteLine("enter id of mother  ");
                                    mother._id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter last name of mother");
                                    mother._LastName = Console.ReadLine();
                                    Console.WriteLine("enter first name of mother");
                                    mother._FitstName = Console.ReadLine();
                                    Console.WriteLine("enter number fon of mother (for xample: 058-780-6-771");
                                    mother._NumberOfphone = Console.ReadLine();
                                    Console.WriteLine("enter addresss of mother:citi street buildingNumber ");
                                    addre.city = Console.ReadLine();
                                    addre.Street = Console.ReadLine();
                                    addre.buildingNumber = Console.ReadLine();
                                    mother._Address = addre.ToString();
                                    Console.WriteLine("if you want area address enter 1 else 0");
                                    if (bool.Parse(Console.ReadLine()))
                                    {
                                        Console.WriteLine("enter area addresss :citi street buildingNumber ");
                                        addre.city = Console.ReadLine();
                                        addre.Street = Console.ReadLine();
                                        addre.buildingNumber = Console.ReadLine();
                                        mother._AreaAddres = addre.ToString();
                                    }
                                    else
                                        mother._AreaAddres = null;
                                    Console.WriteLine("enter mother notes");
                                    mother._Notes = Console.ReadLine();
                                    Console.WriteLine("enter if mother want Hourly Payment (true or false) ");
                                    mother._HourlyPayment = bool.Parse(Console.ReadLine());
                                    Console.WriteLine("enter range");
                                    mother._Range = int.Parse(Console.ReadLine());
                                    bl.AddMother(mother);
                                    break;


                                case 4:
                                    Contract contract = new Contract();
                                    Console.WriteLine("enter id of nanny to add ");
                                    int IdOfNanny = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter id of mother to add ");
                                    int IdOfMother = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter id of child to add ");
                                    int IdOfChild = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter year Of start");
                                    int YearStart = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter mounth Of start");
                                    int MonthStart = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter day Of start");
                                    int dayStart = int.Parse(Console.ReadLine());
                                    contract._StartDate = new DateTime(YearStart, MonthStart, dayStart);
                                    Console.WriteLine("enter if was mitting (true or false) ");
                                    contract._WasMitting = bool.Parse(Console.ReadLine());
                                    Console.WriteLine("enter if was _Signed(true or false) ");
                                    contract._SignedContract = bool.Parse(Console.ReadLine());
                                    Console.WriteLine("enter year Of end");
                                    int YearEnd = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter mounth Of end");
                                    int MonthEnd = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter day Of end");
                                    int dayEnd = int.Parse(Console.ReadLine());
                                    contract._EndDate = new DateTime(YearEnd, MonthEnd, dayEnd);
                                    bl.AddContract(contract);
                                    break;
                                default:
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine(@"to remove child enter 1,
to remove nanny enter 2,
to remove mother enter 3,
to remove contract enter 4");
                            string choice2 = Console.ReadLine();
                            switch (int.Parse(choice2))
                            {
                              
                                case 1:
                                   
                                    Console.WriteLine("enter id of child to remove ");
                                    int idChild = int.Parse(Console.ReadLine());
                                  if(bl.RemoveChild(idChild))
                                        Console.WriteLine("remove succeeded ");
                                  else
                                        Console.WriteLine("remove unsuccessful " );
                                    break;
                                case 2:
                                    Console.WriteLine("enter id of nanny to remove ");
                                    int idNanny = int.Parse(Console.ReadLine());
                                    if(bl.RemoveNanny(idNanny))
                                        Console.WriteLine("remove succeeded ");
                                    else
                                        Console.WriteLine("remove unsuccessful ");
                                    break;
                                case 3:
                                    Console.WriteLine("enter id of mother to remove ");
                                    int idMother = int.Parse(Console.ReadLine());
                                   if(bl.RemoveMother(idMother))
                                        Console.WriteLine("remove succeeded ");
                                    else
                                        Console.WriteLine("remove unsuccessful ");
                                    break;
                                case 4:
                                    Console.WriteLine("enter number of contract to remove ");
                                    int number = int.Parse(Console.ReadLine());
                                    if(bl.RemoveContract(number))
                                        Console.WriteLine("remove succeeded ");
                                    else
                                        Console.WriteLine("remove unsuccessful ");
                                    break;
                                default:
                                    break;
                            }
                            break;


                        case 3:
                            Console.WriteLine(@"to update child enter 1,
to update nanny enter 2,
to update mother enter 3,
to update contract enter 4");
                            string choice3 = Console.ReadLine();
                            switch (int.Parse(choice3))
                            {

                                case 1:
                                 
                                    Console.WriteLine("enter id of child to updating ");
                                    Child child1 = bl.GetChild(int.Parse(Console.ReadLine()));
                                    if (child1 == null)
                                        throw new Exception("not found child with the same id...");
                                    Console.WriteLine("enter if has Disabilities (true or false)");
                                    child1._Disabilities = bool.Parse(Console.ReadLine());
                                    Console.WriteLine("enter the Disabilities kind or enter");
                                    child1._TypeOfDisabilities = Console.ReadLine();
                                    bl.UpdatingChild(child1);
                                    break;

                                case 2:
                                  Console.WriteLine("enter id of nanny to updating ");
                                  Nanny nanny = bl.GetNanny(int.Parse(Console.ReadLine()));
                                    if(nanny==null)
                                        throw new Exception("not found nanny with the same id...");
                                    Address addre1 = new Address();
                                    Console.WriteLine("enter if you want change phone number of nanny (true or false)");
                                    if(bool.Parse(Console.ReadLine()))
                                    {
                                        Console.WriteLine("enter phone number of nanny(for xample: 058-780-6-771");
                                        nanny._NumberOfphone = Console.ReadLine();
                                    }
                                    Console.WriteLine("enter if you want changeaddress of nanny (true or false)");
                                    if (bool.Parse(Console.ReadLine()))
                                    {
                                        Console.WriteLine("enter addresss of nanny:citi street buildingNumber ");
                                        addre1.city = Console.ReadLine();
                                        addre1.Street = Console.ReadLine();
                                        addre1.buildingNumber = Console.ReadLine();
                                        nanny._Address = addre1.ToString();
                                    }
                                    Console.WriteLine("enter if you want change if has elevato (true or false)");
                                    if (bool.Parse(Console.ReadLine()))
                                    {
                                        Console.WriteLine("enter if has elevator (true or false)");
                                        nanny._Elevators = bool.Parse(Console.ReadLine());
                                    }
                                    Console.WriteLine("enter floor number  ");
                                    nanny._FloorNumber = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter Years Of Experience  ");
                                    nanny._YearsOfExperience = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter Max Child  ");
                                    nanny._MaxChild = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter Max Age  ");
                                    nanny._MaxAge = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter Min Age ");
                                    nanny._MinAge = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter if get Hourly Payment (true or false) ");
                                    nanny._HourlyPayment = bool.Parse(Console.ReadLine());
                                    if (nanny._HourlyPayment)
                                    {
                                        Console.WriteLine("enter Hourly Wage");
                                        nanny._HourlyWage = int.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        Console.WriteLine("enter Month Wage");
                                        nanny._MonthWage = int.Parse(Console.ReadLine());
                                    }
                                    Console.WriteLine("enter if take free of TMT (true or false) ");
                                    nanny._VacationKind = bool.Parse(Console.ReadLine());
                                    bl.UpdatingNanny(nanny);
                                    break;
                                case 3:
                                    Address addre = new Address();
                                    Console.WriteLine("enter id of mother to updating ");
                                    Mother mother = bl.GetMother(int.Parse(Console.ReadLine()));
                                    if (mother == null)
                                        throw new Exception("not found mother with the same id...");
                                    Console.WriteLine("enter number fon of mother (for xample: 058-780-6-771");
                                    mother._NumberOfphone = Console.ReadLine();
                                    Console.WriteLine("enter addresss of mother:citi street buildingNumber ");
                                    addre.city = Console.ReadLine();
                                    addre.Street = Console.ReadLine();
                                    addre.buildingNumber = Console.ReadLine();
                                    mother._Address = addre.ToString();
                                    Console.WriteLine("if you want area address enter 1 else 0");
                                    if (bool.Parse(Console.ReadLine()))
                                    {
                                        Console.WriteLine("enter area addresss :citi street buildingNumber ");
                                        addre.city = Console.ReadLine();
                                        addre.Street = Console.ReadLine();
                                        addre.buildingNumber = Console.ReadLine();
                                        mother._AreaAddres = addre.ToString();
                                    }
                                    else
                                        mother._AreaAddres = null;
                                    Console.WriteLine("enter mother notes");
                                    mother._Notes = Console.ReadLine();
                                    Console.WriteLine("enter if mother want Hourly Payment (true or false) ");
                                    mother._HourlyPayment = bool.Parse(Console.ReadLine());
                                    Console.WriteLine("enter range");
                                    mother._Range = int.Parse(Console.ReadLine());
                                    bl.UpdatingMother(mother);
                                    
                                    break;
                                case 4:
                                   
                                    Console.WriteLine("enter number of contract to updating ");
                                    Contract contract = bl.Getcontract( int.Parse(Console.ReadLine()));
                                    if (contract == null)
                                        throw new Exception("not found contract with the same number...");
                                    int YearEnd = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter mounth Of end");
                                    int MonthEnd = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter day Of end");
                                    int dayEnd = int.Parse(Console.ReadLine());
                                    contract._EndDate = new DateTime(YearEnd, MonthEnd, dayEnd);
                                    bl.UpdatingContract(contract);
                                   
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine(@"to print all the childrens enter 1,
to print all the nanneis enter 2,
to print all the mothers enter 3,
to add contracts enter 4");
                            string choice4 = Console.ReadLine();
                            switch (int.Parse(choice4))
                            {

                                case 1:
                                    int x = 0;
                                    foreach (Child child in bl.GetChildList())
                                    {
                                        x++;
 Console.WriteLine(@"child nuber {0} :,IdOfChild {1}, IdOfMather {2}, FitstName {3},_DateOfBirth {4}
,_Disabilities {5},_TypeOfDisabilitie {6}",x, child._IdOfChild, child._IdOfMather, child._FitstName
, child._DateOfBirth, child._Disabilities, child._TypeOfDisabilities);
                                        Console.WriteLine();
                                    }
                                    break;
                                case 2:
                                    x = 0;
//                                    foreach (var nannny in bl.GetChildList())
//                                    {
//                                        x++;
//                                        Console.WriteLine(@"child number {0} :,IdOfChild {1}, IdOfMather {2}, FitstName {3},_DateOfBirth {4}
//,_Disabilities {5},_TypeOfDisabilitie {6}", x, nannny._IdOfChild, nannny._IdOfMather, nannny._FitstName
//                                       , nannny._DateOfBirth, nannny._Disabilities, child._TypeOfDisabilities);
//                                        Console.WriteLine();
//                                    }
                                    break;
                                case 3:
                                    x = 0;
                                    foreach (var child in bl.GetChildList())
                                    {
                                        x++;
                                        Console.WriteLine(@"mother number {0} :,IdOfmother {1}, IdOfMather {2}, FitstName {3},_DateOfBirth {4}
,_Disabilities {5},_TypeOfDisabilitie {6}", x, child._IdOfChild, child._IdOfMather, child._FitstName
                                       , child._DateOfBirth, child._Disabilities, child._TypeOfDisabilities);
                                        Console.WriteLine();
                                    }
                                    break;
                                case 4:



                                    break;
                           
                                default:
                                    break;
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(@"to add child/nanny/mother/contract enter 1,
to remove child/nanny/mother/contract ente 2,
to update child/nanny/mother/contract 3,
to print all child/nanny/mother/contract 4,
to end enter zero");
                choice = Console.ReadLine();
            }
            IEnumerable<IGrouping<int, Contract>> v = bl.GroupingByDistance();
            foreach (IGrouping<int, Contract> item in v)
            {
                switch (item.Key)
                {
                    case 5:
                        foreach (Contract it in item)
                        {
                            Console.WriteLine(it);
                        }

                        break;


                    default:
                        break;
                }
            }












        }
    }
}