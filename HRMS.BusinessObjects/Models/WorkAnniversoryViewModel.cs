using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.BusinessObjects.Models
{
    public class WorkAnniversoryViewModel
    {
        public string  EmployeeName { get; set; }
        public string PhotoPath { get; set; }
        public string Designation { get; set; }
        public int YearsCompleted { get; set; }
    }
}
