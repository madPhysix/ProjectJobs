namespace ProjectJobs.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
