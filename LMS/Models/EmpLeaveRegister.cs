using LMS.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
    public class EmpLeaveRegister : ModelBase
    {
        [Key]
        public int EmpLeave_Id { get; set; }    

        public int Year { get; set; }
        
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }  

        public int LeaveTypeId { get; set; }
        [ForeignKey("LeaveTypeId")]

        public virtual LeaveTypeMaster LeaveType { get; set;}

        public decimal No_of_Leaves { get; set; }   

        public decimal Availed_Leaves { get; set; }  
        
        public decimal Balance { get; set; }    





    }
}
