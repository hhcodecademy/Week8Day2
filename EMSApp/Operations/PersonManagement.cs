using EMSApp.Models;
using EMSApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSApp.Operations
{
    internal class PersonManagement
    {
        public void AddPerson()
        {
            char answer = 'x';
            do
            {
                bool hasEmployee = false;
                Console.WriteLine("Isci nomresini daxil edin:");
                string empNumber = Console.ReadLine();

                foreach (var item in DataStore.Employees)
                {
                    if (item.EmployeeNumber == empNumber)
                    {
                        hasEmployee = true;
                        break;
                    }
                }
                if (hasEmployee)
                {
                    Console.WriteLine("Isci nomresi artiq sistemde movcuddur!");
                }
                else
                {
                    Employee emp = new Employee();
                    emp.EmployeeNumber = empNumber;

                    Console.WriteLine("Iscinin adini daxil edin:");
                    emp.Name = Console.ReadLine();

                    Console.WriteLine("Iscinin soyadini daxil edin:");
                    emp.Surname = Console.ReadLine();

                    Console.WriteLine("Iscinin vezifesini daxil edin:");
                    emp.Title = Console.ReadLine();

                    Console.WriteLine("Iscinin ise baslama tarixini daxil edin:");
                    emp.StartWorkDate = DateOnly.Parse(Console.ReadLine());

                    Console.WriteLine("Iscinin maas emsalini daxil edin:");
                    emp.SalaryRatio = decimal.Parse(Console.ReadLine());

                    DataStore.Employees.Add(emp);
                }
                Console.WriteLine("Davam etmek isteyirsenmi? b/x");
                answer = char.Parse(Console.ReadLine());
            } while (answer == 'b');

        }

        public void UpdatePerson()
        {
            char answer = 'x';
            do
            {
                bool hasEmployee = false;
                Console.WriteLine("Isci nomresini daxil edin:");
                string empNumber = Console.ReadLine();

                foreach (var item in DataStore.Employees)
                {
                    if (item.EmployeeNumber == empNumber)
                    {
                        hasEmployee = true;
                        Console.WriteLine("Iscinin adini daxil edin:");
                        item.Name = Console.ReadLine();

                        Console.WriteLine("Iscinin soyadini daxil edin:");
                        item.Surname = Console.ReadLine();

                        Console.WriteLine("Iscinin vezifesini daxil edin:");
                        item.Title = Console.ReadLine();

                        Console.WriteLine("Iscinin ise baslama tarixini daxil edin:");
                        item.StartWorkDate = DateOnly.Parse(Console.ReadLine());

                        Console.WriteLine("Iscinin maas emsalini daxil edin:");
                        item.SalaryRatio = decimal.Parse(Console.ReadLine());
                        break;
                    }
                }
                if (!hasEmployee)
                {
                    Console.WriteLine("Isci nomresi  sistemde movcud deyildir!");
                }
                Console.WriteLine("Davam etmek isteyirsenmi? b/x");
                answer = char.Parse(Console.ReadLine());
            } while (answer == 'b');
        }

        public void RemovePerson()
        {
            char answer = 'x';
            do
            {
                bool hasEmployee = false;
                Console.WriteLine("Isci nomresini daxil edin:");
                string empNumber = Console.ReadLine();

                foreach (var item in DataStore.Employees)
                {
                    if (item.EmployeeNumber == empNumber)
                    {
                        hasEmployee = true;
                        DataStore.Employees.Remove(item);                        
                        break;
                    }
                }
                if (!hasEmployee)
                {
                    Console.WriteLine("Isci nomresi  sistemde movcud deyildir!");
                }
                Console.WriteLine("Davam etmek isteyirsenmi? b/x");
                answer = char.Parse(Console.ReadLine());
            } while (answer == 'b');
        }
        public void ShowPerson()
        {
            Console.WriteLine("Per no  Ad Soyad        Ise Gir Tar  Vezife   Maas Emsali ");
            Console.WriteLine("------  --------        -----------  ------   ------------");

            foreach (var item in DataStore.Employees)
            {
            
                string fullDesc = item.EmployeeNumber + "    " + item.Name+ " " +item.Surname + "     " + item.StartWorkDate + "   "+ item.Title+ "   " + item.SalaryRatio;
                Console.WriteLine(fullDesc);
            }
            Console.WriteLine();
        }

        public void ShowPersonsByNumber()
        {
            Console.WriteLine("Isci nomresini daxil edin:");
            string empNumber = Console.ReadLine();

            foreach (var item in DataStore.Employees)
            {
                if (item.EmployeeNumber == empNumber)
                {
                    Console.WriteLine("Per no  Ad Soyad        Ise Gir Tar  Vezife   Maas Emsali ");
                    Console.WriteLine("------  --------        -----------  ------   ------------");                                                     

                        string fullDesc = item.EmployeeNumber + "    " + item.Name + " " + item.Surname + "     " + item.StartWorkDate + "   " + item.Title + "   " + item.SalaryRatio;
                        Console.WriteLine(fullDesc);
                    
                    Console.WriteLine();
                    break;
                }
            }
           
        }

        public void ShowPersonsByTitle()
        {
            Console.WriteLine("Isci vezifesini daxil edin:");
            string empTitle = Console.ReadLine();
            Console.WriteLine("Per no  Ad Soyad        Ise Gir Tar  Vezife   Maas Emsali ");
            Console.WriteLine("------  --------        -----------  ------   ------------");
            foreach (var item in DataStore.Employees)
            {
                if (item.Title == empTitle)
                {
                  

                    string fullDesc = item.EmployeeNumber + "    " + item.Name + " " + item.Surname + "     " + item.StartWorkDate + "   " + item.Title + "   " + item.SalaryRatio;
                    Console.WriteLine(fullDesc);

                    
                    
                }
            }
            Console.WriteLine();

        }
    }
}
