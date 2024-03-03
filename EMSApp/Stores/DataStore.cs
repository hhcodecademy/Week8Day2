using EMSApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSApp.Stores
{
    internal class DataStore
    {
        public static List<Employee> Employees { get; set; }
        public static List<PersonWork> PersonWorks { get; set; }
        static DataStore()
        {
            Employees = new List<Employee>();
            PersonWorks = new List<PersonWork>();
        }
    }

}
