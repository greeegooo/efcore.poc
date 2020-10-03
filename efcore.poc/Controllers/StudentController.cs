using System;
using System.Collections.Generic;
using System.Linq;
using efcore.poc.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace efcore.poc.Controllers
{
    [ApiController]
    [Route("[students]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            _logger.LogInformation("Obteniendo pronósticos");

            return null;
        }
    }
}
