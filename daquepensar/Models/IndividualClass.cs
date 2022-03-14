namespace daquepensar
{
    public class IndividualClass : AuditField
    {
        public int Id { get; set; } 

        public string date {get { return StartTime.ToShortDateString();}}

        public string starttimehour { get {return StartTime.ToLongTimeString();}}

        public string endtimehour { get {return EndTime.ToLongTimeString();}}

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Student? Student { get; set; }

        public Teacher? Teacher { get; set; }

        public Boolean Active { get; set; }  

    }
}