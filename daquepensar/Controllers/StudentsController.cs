using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daquepensar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<StudentManagementController> _logger;

        public StudentsController(ILogger<StudentManagementController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            string fileName = "..\\db.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            Console.WriteLine(jsonString);

            return Enumerable.Range(1, 5).Select(index => new Student
            {
                Name = "Jack",
                Address = new Address(){Id=index, Active= true, Street="rua do crl", Street2="ap 1. n2", City="Leiria", PostalCode="1234-123" },
                Active= true,
                Id= index,
                Plan = new Plan() { Id=index, Name = "Tempo inteiro" },
                IndividualClasses = new List<IndividualClass>(){ new IndividualClass() { StartTime = DateTime.Now, EndTime = DateTime.Now, Teacher = new Teacher () {Id = index, Name = "prf "+index }} }
            })
            .ToArray();
        }
    }
}