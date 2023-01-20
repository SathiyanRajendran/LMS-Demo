using LMS.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
    public class EmpComp_offRequest : ModelBase
    {
        [Key]
        public int Emp_CompOff_Id { get; set; }
        
        public DateOnly RequestDate { get; set; }   

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }

        public int LeaveTypeId { get; set; }
        [ForeignKey("LeaveTypeId")]

        public virtual LeaveTypeMaster LeaveType { get; set; }

        public DateOnly Worked_On { get; set; }

        public string Work_Reason { get; set; } 

        public decimal Leave_Days { get; set; } 

        public string Status { get; set; }  // Enum

        public DateOnly Status_Date { get; set; }   

        public string Manager_Remarks { get; set; } 

        public int EmpLeaveApplication_Id { get; set; }
        [ForeignKey("EmpLeaveApplication_Id")]

        public virtual EmpLeaveApplication employeeLeaveApplication { get; set; }





    }
}
