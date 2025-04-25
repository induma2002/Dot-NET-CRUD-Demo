using DemoApi.databases;
using DemoApi.model;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DemoApi.service.impl
{
    public class StudentServiceImpl : StudentService
    {
       public AppDbContext Db;
       public StudentServiceImpl(AppDbContext Db) 
       {
            this.Db = Db;
       }

        public async Task<Student> AddStudent(Student student)
        {
            try
            {
                EntityEntry<Student> SavedStudent = Db.Student.Add(student);
                await Db.SaveChangesAsync();
                return student;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()+ "Sutdent Saved Unsuccessfull" + student.ToString());

            }



            return null;
        }

        public Task<bool> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Task<Student?> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
