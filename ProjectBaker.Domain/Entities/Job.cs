namespace ProjectBaker.Domain.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public string PostDate { get; set; }
        public string EmployeeEmail { get; set; }
        public int? ProjectId { get; set; }

        public virtual User Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}