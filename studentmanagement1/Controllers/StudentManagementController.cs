using businesslogic;
using entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentmanagement.Controllers     
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class studentController : Controller
    {
        private ILogger<studentController> _logger;

        IBusinesslogic _businesslogic;
        public studentController(ILogger<studentController> logger, IBusinesslogic businesslogic)
        {
            _logger = logger;
            _businesslogic = businesslogic;

        }

        [HttpGet]

        public IEnumerable<studentEntity> Get(int rollno)
        {
            var result = _businesslogic. getfilteredstudentrecord(rollno);
            return Enumerable.Range(1,1).Select(Index => new studentEntity

            {
                name = result.name,
                rollno = result.rollno,
                Emailid = result.Emailid



            });

        }
        [HttpGet]
        public  IEnumerable<studentEntity> GetRandom()
        {
           var result = _businesslogic .getRandomStudent();
           return Enumerable.Range(1, 1).Select(Index => new studentEntity
            {
                name = result.name,
               rollno = result.rollno,
                Emailid = result.Emailid
            });
        }
        [HttpGet]
        public  IEnumerable<studentEntity> Get1(string name)
        {
          var result = _businesslogic.getfilteredstudentrecordbyname(name);
            return Enumerable.Range(1, 1).Select(Index => new studentEntity
            {
               name = result.name,
               rollno = result.rollno,
               Emailid = result.Emailid
            });
       }

        [HttpPost]
        public bool SaveRecord(studentEntity stdEntity)
        {
            return _businesslogic.SaveStudentRecord(stdEntity);           
        }
    }
}
