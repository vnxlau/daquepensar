using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daquepensar.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public StudentsController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            string fileName = "..\\..\\db.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            Console.WriteLine(jsonString);

            return Enumerable.Range(1, 5).Select(index => new Student
            {
                Name = "Jack"
            })
            .ToArray();
        }
    }
}