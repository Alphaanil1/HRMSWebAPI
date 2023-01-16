using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMS.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
namespace HRMS.DAL.Context
{
    public class HRMSContext:DbContext
    {
        public HRMSContext(DbContextOptions<HRMSContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<DesignationMaster> DesignationMaster { get; set; }
        public DbSet<LeaveReasonMaster> LeaveReasonMaster { get; set; }       
    }
}

