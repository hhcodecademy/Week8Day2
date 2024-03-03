using EMSApp.Models;
using EMSApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSApp.Operations
{
    internal class WorkManagement
    {
        internal void AddWorkTime()
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
                        PersonWork personWork = new PersonWork();
                        personWork.EmployeeNumber = int.Parse(item.EmployeeNumber);
                        Console.Write($"{item.EmployeeNumber} Nomreli iscinin islediyi gunu daxil edin (1-31): ");
                        personWork.Day = int.Parse(Console.ReadLine());
                        Console.Write($"{item.EmployeeNumber} Nomreli iscinin {personWork.Day} gununde giris saatini daxil edin (1-24): ");
                        personWork.EntranceHour = int.Parse(Console.ReadLine());
                        Console.Write($"{item.EmployeeNumber} Nomreli iscinin {personWork.Day} gununde giris deqiqesini daxil edin (1-60): ");
                        personWork.EntranceMinute = int.Parse(Console.ReadLine());
                        Console.Write($"{item.EmployeeNumber} Nomreli iscinin {personWork.Day} gununde cixis saatini daxil edin (1-24): ");
                        personWork.ExitHour = int.Parse(Console.ReadLine());
                        Console.Write($"{item.EmployeeNumber} Nomreli iscinin {personWork.Day} gununde cixis deqiqesini daxil edin (1-60): ");
                        personWork.ExitMinute = int.Parse(Console.ReadLine());
                        DataStore.PersonWorks.Add( personWork );
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
    }
}
