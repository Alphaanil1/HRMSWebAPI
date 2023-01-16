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
    public class EmployeeRepository
    {
        public readonly HRMSContext _context;
        public EmployeeRepository(HRMSContext context)
        {
            _context = context;
        }
        public Employee GetEmployee(int id)
        {
            var employee = _context.Employee.Find(id);           
            return employee;
        }
       
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = _context.Employee.ToList();
            return employees;
        }
      


        //public List<Employee> GetEmployeeUsingSP(string name)
        //{
        //    return _context.Employee.FromSqlRaw($"GetEmployees {name}").ToList();
        //}

        //public List<Employee> GetEmployeeUsingSP(string name)
        //{
        //    List<SqlParameter> paramList = new List<SqlParameter>();
        //    paramList.Add(new SqlParameter("name", name));
        //    return _context.Database.sql
        //}


    }
}
