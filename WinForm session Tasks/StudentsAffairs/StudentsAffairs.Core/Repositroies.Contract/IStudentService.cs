
namespace StudentsAffairs.Core.Repositroies.Contract
{
    public interface IStudentService
    {
        Task<int> AddStudentAsync(Student student);
        Task<int> DeleteAllStudentsAsync();
        Task<int> DeleteStudentAsync(int id);
        Task<IReadOnlyList<Student>> GetAllStudentsAsync();
        Task<Student?> GetStudentByIdAsync(int id);
        Task<int> UpdateStudentAsync(Student student);
    }
}