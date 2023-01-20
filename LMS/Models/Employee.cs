using LMS.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
    public class Employee : ModelBase
    {
        [Key]
        public int EmployeeId { get; set; }

        public int EmpId { get; set; }  

        public string Emp_First_Name { get; set; }  

        public string Emp_Middle_Name { get; set; } 

        public string Emp_LastName { get; set;}

        public string Name { get; set;} 

        public string Emp_Short_Name { get; set;} 

        public DateOnly Emp_DOJ { get; set;}

      //  [ForeignKey("Emp_MGR")]

        public List<EmpLeaveRegister> employeeLeaveRegister { get; set; }

        public List<EmpLeaveApplication> employeeLeaveApplication { get; set;}

        public List<EmpComp_offRequest> employeeComp_offRequest { get; set; }

        
    }
}
