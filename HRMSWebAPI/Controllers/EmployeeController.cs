using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRMS.BusinessObjects.Models;
using HRMS.DAL.Context;
using HRMS.BLL;

namespace HRMSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeService _employeeService;
       
        public EmployeeController(HRMSContext context)
        {
            _employeeService = new EmployeeService(context);
           

        }
        //GET: api/<EmployeeController>
        //[HttpGet("")]
        //public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
        //{
        //    return await _context.Employee.ToListAsync();
        //}

        //// GET: api/<EmployeeController>
        //[HttpGet("GetEmployeeUsingSP/{name}")]   
        //public  List<Employee> GetEmployeeUsingSP(string name)
        //{           
        //    return  _context.Employee.FromSqlRaw($"GetEmployees {name}").ToList();
        //}

        //[HttpGet("GetEmployeeUsingSP2/{name}")]
        //public List<Employee> GetEmployeeUsingSP2(string name)
        //{            
        //    return _context.Database.FromSqlRaw($"GetEmployees {name}").ToList();
        //}
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Employee>> GetEmployeeOld(int id)
        //{

        //    var Employee = await _context.Employee.FindAsync(id);
        //    if (Employee == null)
        //    {
        //        return NotFound();
        //    }
        //    return Employee;


        //}
        [HttpGet("{id}")]
        public CustomBO GetEmployee(int id)
        {
            _employeeService.GetEmployee(id);
            CustomBO customBO =  _employeeService.GetEmployee(id);           
            return customBO;
        }

        //[HttpGet("GetEmployeeUsingSP/{name}")]
        //public CustomBO GetEmployeeUsingSP(string  name)
        //{
        //    _employeeService.GetEmployeeUsingSP(name);
        //    CustomBO customBO = _employeeService.GetEmployee(id);
        //    return customBO;
        //}

        //[HttpPost]
        //public async Task<ActionResult<Employee>> AddEmployee(Employee employee)
        //{
        //    _context.Employee.Add(employee);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetEmployee", new { id = employee.EmployeeID }, employee);

        //}

        //[HttpPut("{id}")]
        //public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        //{
        //    if (id != employee.EmployeeID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(employee).State = EntityState.Modified;

        //    try
        //    {

        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EmployeeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }

        //    }
        //    return NoContent();
        //    var Employee = await _context.Employee.FindAsync(id);
        //    if (Employee == null)
        //    {
        //        return NotFound();
        //    }
        //    return Employee;
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteEmployee(int id)
        //{
        //    var Employee = await _context.Employee.FindAsync(id);
        //    if (Employee == null)
        //    {
        //        return NotFound();
        //    }
        //    _context.Remove(Employee);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        //private bool EmployeeExists(int id)
        //{
        //    return _context.Employee.Any(e => e.EmployeeID == id);
        //}
    }
}
