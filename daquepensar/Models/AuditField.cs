namespace daquepensar
{
    public class AuditField
    {
        public DateTime CreatedOn { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime ModifiedAt { get; set; }

        public string? ModifiedBy { get; set; }
    }
}