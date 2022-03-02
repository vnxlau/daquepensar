using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace daquepensar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentManagementController : ControllerBase
    {
        private readonly ILogger<StudentManagementController> _logger;

        public StudentManagementController(ILogger<StudentManagementController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<String> Get()
        {
            Console.WriteLine("test one");
            yield return "a";
        }
    }
}