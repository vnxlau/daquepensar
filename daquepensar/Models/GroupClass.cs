namespace daquepensar
{
    public class GroupClass : AuditField
    {
        public int Id { get; set; } 

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public Boolean Active { get; set; }  

    }
}