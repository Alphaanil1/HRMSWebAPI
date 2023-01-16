using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.BusinessObjects.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string EmployeeCode { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MiddleName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string PermanentAddress { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string correspondenceAddress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ContactNo { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string EmergencyContactNo { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PinCode { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string EmailID { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Gender { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string MaritialStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime JoiningDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Nationality { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string BloodGroup { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string MedicalHistory { get; set; }
        [Column(TypeName = "int")]
        public int DesignationID { get; set; }
        [Column(TypeName = "int")]
        public int RoleID { get; set; }
        [Column(TypeName = "int")]        
        public int UserID { get; set; }
        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }



        [Column(TypeName = "nvarchar(50)")]
        public string EnteredBy { get; set; }

    }
}
