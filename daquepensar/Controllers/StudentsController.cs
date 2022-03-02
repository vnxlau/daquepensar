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
                Address = new Address(){Id=1, Active= true, Street="rua do crl", Stree2="ap 1. n2", City="Leiria", PostalCode="1234-123" }
            })
            .ToArray();
        }
    }
}