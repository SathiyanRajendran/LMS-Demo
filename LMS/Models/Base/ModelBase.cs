using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models.Base
{
    public class ModelBase : IModelBase
    {
        public DateTimeOffset CreatedOn { get; set; }

        [Required]
        public int CreatedBy { get; set; }
        [ForeignKey(nameof(CreatedBy))]

        public virtual UserMaster CreatedByUser { get; set; }   
        public DateTimeOffset UpdatedOn { get; set; }

        [Required]  
        public int UpdatedBy { get; set ; }
        [ForeignKey("UpdatedBy")]

        public virtual UserMaster UpdatedByUser { get; set; }   
    }
}
