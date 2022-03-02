namespace daquepensar
{
    public class Student : AuditField
    {
        public int Id { get; set; } 

        public int UserId { get; set; }

        public string? Name { get; set; }

        public string? Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public Boolean Active { get; set; }  

        public List<IndividualClass> IndividualClasses { get;}

        public List<GroupClass> GroupClasses  { get; } 

        public Plan? Plan { get; set; }

        public Address? Address { get; set; }

        public Student(){
            IndividualClasses = new List<IndividualClass>();
            GroupClasses = new List<GroupClass>();
        }

    }
}