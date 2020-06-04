using System;

namespace ProjectBaker.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        //public string UserEmail { get; set; }
        public string Text { get; set; }
        public string PostDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}
