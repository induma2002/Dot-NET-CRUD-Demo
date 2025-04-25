using System.Threading.Tasks;
using DemoApi.databases;
using DemoApi.model;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

   
    public class StudentController : ControllerBase
    {
        private AppDbContext Db;
        public StudentController(AppDbContext db) 
        { 
            Db = db;
        }

        [HttpGet]public string getHelloworld()
        {
            return "This is student API base path please add resource path";
        }

        [HttpPost] public async Task<int> postHelloworld([FromBody]Student student) 
        {
            Db.Student.Add(student);
            int forTreturn = await Db.SaveChangesAsync(); // ✅ Ensure SaveChangesAsync() is called
            //return CreatedAtAction(nameof(AddStudent), new { id = student.Id }, student);
            return forTreturn;
        }
        [HttpGet("{id}")]public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var student = await Db.Student.FindAsync(id); // ✅ Ensure plural "Students" for DbSet

            if (student == null)
                return NotFound(); // ✅ Proper 404 response

            return Ok(student); // ✅ Returns HTTP 200 with the student data
        }

    }
}
