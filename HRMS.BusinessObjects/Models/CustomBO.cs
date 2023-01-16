using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.BusinessObjects.Models
{
    public class CustomBO
    {
        public object Response { get; set; }
        public int ResponseCode { get; set; }
        public string Message { get; set; }
        public string UserMessage { get; set; }

    }
}
