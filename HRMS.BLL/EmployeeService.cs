using System;
using HRMS.BusinessObjects.Models;
using System.Linq;
using System.Threading.Tasks;
using HRMS.DAL.Repositories;
using HRMS.DAL.Context;
using System.Collections.Generic;

namespace HRMS.BLL
{
    public class EmployeeService
    {
        private EmployeeRepository _employeeRepo;
        public EmployeeService(HRMSContext context)
        {
            _employeeRepo = new EmployeeRepository(context);
        }
        public CustomBO GetEmployee(int id)
        {
            CustomBO objCustomBO = new CustomBO();

            if (id < 0)
            {
                return new CustomBO() { Response = "", ResponseCode = 200, Message = "", UserMessage = "Employee ID can not be less than 0" };                
            }
           Employee  employee= _employeeRepo.GetEmployee(id);
            if (employee == null)
            {
                return new CustomBO() { Response = "", ResponseCode = 200, Message = "", UserMessage = "Record not found..!!" };
            }
            else
            {
                return new CustomBO() { Response = employee, ResponseCode = 200, Message = "", UserMessage = "Success" };
            }

          
        }
        //[HttpGet("GetEmployeeUsingSP2/{name}")]
        //public List<Employee> GetEmployeeUsingSP2(string name)
        //{
        //    return _context.Database.FromSqlRaw($"GetEmployees {name}").ToList();
        //}

        //public CustomBO GetEmployeeUsingSP(string name)
        //{
        //    CustomBO objCustomBO = new CustomBO();
        //    List<Employee> employees = _employeeRepo.GetEmployeeUsingSP(name);
        //    if (employees == null)
        //    {
        //        return new CustomBO() { Response = "", ResponseCode = 200, Message = "", UserMessage = "Record not found..!!" };
        //    }
        //    else
        //    {
        //        return new CustomBO() { Response = employees, ResponseCode = 200, Message = "", UserMessage = "Success" };
        //    }
        //}
    }
}
