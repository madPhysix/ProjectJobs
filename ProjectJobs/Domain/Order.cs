using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectJobs.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        
    }
}
