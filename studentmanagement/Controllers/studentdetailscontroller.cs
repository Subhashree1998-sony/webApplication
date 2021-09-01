using businesslogicclass;
using entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentmanagement.Controllers
{
    public class studentController : Controller
    {
        private ILogger<studentController> _logger;
        public studentController(ILogger<studentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        
            public IEnumerable<studentEntity> Get()
        {
            var result = new studentbilogic().getfilteredstudentrecord(5);
            return Enumerable.Range(1, 5).Select(Index => new studentEntity
            {
                name = result.name,
                rollno = result.rollno



            });
             
           
        }
    }
}
