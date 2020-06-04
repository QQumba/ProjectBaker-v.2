namespace ProjectBaker.Domain.Entities
{
    public class ProjectAccount
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int Amount { get; set; }
        public string Deadline { get; set; }
        public string LastUpdate { get; set; }

        public virtual Project Project { get; set; }
    }
}