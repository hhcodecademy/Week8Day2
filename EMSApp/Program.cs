using EMSApp.Operations;
using EMSApp.Stores;

namespace EMSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectMenu();
        }

        static void SelectMenu()
        {
            MenuManagement menu = new MenuManagement();
            menu.SelectOperation();
            Console.WriteLine("Zehmet olmasa sechim edin: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                WorkManagement workManagement = new WorkManagement();
                PersonManagement personManagement = new PersonManagement();
                bool isContinue = true;
                while (isContinue)
                {
                    int doOption = menu.SearchOperation();
                    switch (doOption)
                    {
                        case 1:
                            personManagement.ShowPerson();
                            break;
                        case 2:
                            personManagement.ShowPersonsByNumber();
                            break;
                        case 3:
                            personManagement.ShowPersonsByTitle();
                            break;

                        case 7:
                            isContinue = false;
                            SelectMenu();
                            break;

                    }
                }


            }
            else if (option == 2)
            {
                WorkManagement workManagement = new WorkManagement();
                PersonManagement personManagement = new PersonManagement();
                bool isContinue = true;
                while (isContinue)
                {
                    int doOption = menu.DoOperation();
                    switch (doOption)
                    {
                        case 1:
                            personManagement.AddPerson();
                            Console.WriteLine(DataStore.Employees.Count);
                            break;
                        case 2:
                            personManagement.UpdatePerson();
                            break;
                        case 3:
                            workManagement.AddWorkTime();
                            break;
                        case 4:
                            personManagement.RemovePerson();
                            Console.WriteLine(DataStore.Employees.Count);
                            break;
                        case 6:
                            isContinue = false;
                            SelectMenu();
                            break;
                    }
                }
            }
            else if (option == 3)
            {
                return;
            }
            else
            {
                Console.WriteLine("Yeniden secim edin");
                SelectMenu();
            }

        }

    }
}


