using LMS.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
    public class EmpLeaveApplication : ModelBase
    {
        [Key]
        public int EmpLeaveApplication_Id { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }

        //[ForeignKey("MGR_ID")]

        public DateOnly Applied_Date { get; set; }  
         
        public int LeaveTypeId { get; set; }
        [ForeignKey("LeaveTypeId")]

        public virtual LeaveTypeMaster LeaveType { get; set; }

        public DateOnly Leave_From_Date { get; set; }

        public DateOnly Leave_To_Date { get; set; } 

        public decimal No_Of_Days { get; set; } 

        public string Leave_Reason { get; set; }    

        public string status { get; set; }

        public DateOnly status_date { get; set; }

        public string Manager_Remarks { get; set; }

        public List<EmpComp_offRequest> employeeComp_offRequest { get; set; }






    }
}
