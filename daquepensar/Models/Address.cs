namespace daquepensar
{
    public class Address : AuditField
    {
        public int Id { get; set; } 

        public string? Street { get; set; }
        
        public string? Stree2 { get; set; }
        
        public string? City { get; set; }
        
        public string? PostalCode { get; set; }
        
        public Boolean Active { get; set; }  

    }
}