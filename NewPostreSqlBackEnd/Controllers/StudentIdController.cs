using Microsoft.AspNetCore.Mvc;
using NewPostreSqlBackEnd.Data;
using NewPostreSqlBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPostreSqlBackEnd.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentIdController : Controller
    {
        private readonly postgresContext _context;

        public StudentIdController(postgresContext context)
        {
            _context = context;
        }

        [HttpPost("Add")]
        public IActionResult Add ([FromBody] StudentId request)
        {
            var a = new StudentId
            {
                StudentId1 = request.StudentId1,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Password = request.Password,
                Email = request.Email,
                Country = request.Country,
                City = request.City,
                UserName = request.UserName,
                Gender = request.Gender,
                BirthDate = request.BirthDate
            };
            _context.Add(a);
            _context.SaveChanges();
            return Ok("Basarili");

        }
        //[HttpGet("Show")]
        //public IActionResult Show([FromBody] StudentId request)
        //{
        //    var a = new StudentId
        //    {
        //        StudentId1 = request.StudentId1,
        //        FirstName = request.FirstName,
        //        LastName = request.LastName,
        //        Password = request.Password,
        //        Email = request.Email,
        //        Country = request.Country,
        //        City = request.City,
        //        UserName = request.UserName,
        //        Gender = request.Gender,
        //        BirthDate = request.BirthDate
        //    };
        //    _context.Show(a);
        //    _context.SaveChanges();
        //    return OkResult;

        //}

        public IActionResult Index()
        {
            List<StudentId> studentIds = _context.StudentIds.ToList();
            return View(studentIds);
        }
    }
}
