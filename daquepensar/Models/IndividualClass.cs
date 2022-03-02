namespace daquepensar
{
    public class IndividualClass : AuditField
    {
        public int Id { get; set; } 

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public Student? Student { get; set; }

        public Teacher? Teacher { get; set; }

        public Boolean Active { get; set; }  

    }
}