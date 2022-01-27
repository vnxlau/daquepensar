namespace daquepensar
{
    public class Student : AuditField
    {
        public int Id { get; set; } 

        public int UserId { get; set; }

        public string? Name { get; set; }

        public Boolean Active { get; set; }  

        public string? Summary { get; set; }
    }
}