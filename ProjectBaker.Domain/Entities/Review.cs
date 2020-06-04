namespace ProjectBaker.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string Text { get; set; }
        public string PostDate { get; set; }

        public virtual User User { get; set; }
    }
}