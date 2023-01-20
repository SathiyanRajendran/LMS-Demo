namespace LMS.Models.Base
{
    interface IModelBase
    {
        DateTimeOffset CreatedOn { get; set; }  

        int CreatedBy { get; set; } 

        DateTimeOffset UpdatedOn { get; set; }  

        int UpdatedBy { get; set; }
    }
}
