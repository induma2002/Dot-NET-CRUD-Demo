using DemoApi.model;

namespace DemoApi.service
{
    public interface StudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student?> GetStudentById(int id);
        Task<Student> AddStudent(Student student);
        Task<bool> DeleteStudent(int id);

    }
}
