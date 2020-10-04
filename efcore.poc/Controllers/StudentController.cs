using System.Collections.Generic;
using System.Threading.Tasks;
using efcore.poc.Domain;
using efcore.poc.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace efcore.poc.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly SchoolContext _context;

        public StudentController(
            ILogger<StudentController> logger,
            SchoolContext context)
        {
            _logger = logger;
            _context = context;        
        }

        [EnableCors("Policy")]
        [HttpGet]
        public async Task<IEnumerable<Student>> GetAsync()
        {
            _logger.LogInformation("Getting students");

            var students = _context.Students.ToListAsync();

            return await students;
        }
    }
}
