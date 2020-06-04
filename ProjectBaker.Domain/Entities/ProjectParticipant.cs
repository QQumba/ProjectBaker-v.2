using System;

namespace ProjectBaker.Domain.Entities
{
    public class ProjectParticipant
    {
        public int Id { get; set; }
        //public int ProjectId { get; set; }
        //public string UserEmail { get; set; }
        public string Position { get; set; }

        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}