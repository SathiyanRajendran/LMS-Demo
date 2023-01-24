using LMS.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
    public class UserMaster : ModelBase
    {
        [Key]
        public int UserMaster_Id { get; set; }

        public string User_ShortName { get; set; } 

        public string User_Name { get; set;}

        public string Password { get; set;}

        public int EmployeeId { get; set; } 
        [ForeignKey("EmployeeId")]

        public virtual Employee Employee { get; set; }  

        public bool Admin { get; set; } 
    }
}
