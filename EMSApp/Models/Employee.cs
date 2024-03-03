using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSApp.Models
{
    internal class Employee:Person
    {
        public string EmployeeNumber { get; set; }
        public DateOnly StartWorkDate { get; set; }
        public decimal SalaryRatio { get; set; }
        public int MonthlyTotalMinute { get; set;}
    }
}
