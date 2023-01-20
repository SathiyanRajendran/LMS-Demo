using LMS.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    public class LeaveTypeMaster : ModelBase
    {
        [Key]
        public int LeaveTypeId { get; set; }  
        
        public string LeaveTypeSH { get; set; }

        public string LeaveTypeName { get; set; }   

        public int No_of_Days { get; set; }
        public List<EmpLeaveRegister> employeeLeaveRegister { get; set; }

        public List<EmpLeaveApplication> employeeLeaveApplication { get; set;}

        public List<EmpComp_offRequest> employeeComp_offRequest { get;set; }    


    }
}
