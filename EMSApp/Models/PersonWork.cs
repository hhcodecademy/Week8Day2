using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSApp.Models
{
    internal class PersonWork
    {
        public int EmployeeNumber { get; set; }
        public int Day { get; set; }
        public int EntranceHour { get; set; }
        public int EntranceMinute { get; set; }
        public int ExitHour { get; set; }
        public int ExitMinute { get; set; }

    }
}
