namespace daquepensar
{
    public class Teacher : AuditField
    {
        public int Id { get; set; } 

        public int UserId { get; set; }

        public string? Name { get; set; }

        public Boolean Active { get; set; }  

    }
}