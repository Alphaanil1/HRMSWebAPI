using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.BusinessObjects.Models
{
    public class DashboardViewModel
    {
        public WorkAnniversoryViewModel todaysWorkAnnivers { get; set; }
        public BirthDayViewModel todaysBirthDays { get; set; }
    }
}
