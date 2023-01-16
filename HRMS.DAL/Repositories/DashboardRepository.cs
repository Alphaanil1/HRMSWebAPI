using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.BusinessObjects.Models;
using HRMS.DAL.Context;
using Microsoft.EntityFrameworkCore;
namespace HRMS.DAL.Repositories
{
    public class DashboardRepository
    {
        public readonly HRMSContext _context;
        public DashboardRepository(HRMSContext context)
        {
            _context = context;
        }
        //public DashboardViewModel GetDetailsForDashboard(string str)
        //{
        //    DashboardViewModel objDashboardViewModel = new DashboardViewModel();
        //    objDashboardViewModel= _context.DashboardViewModel.FromSqlRaw($"GetEmployees {str}").ToList();
        //    //_context.Database.sql

        //    return objDashboardViewModel;
        //}
    }
}
