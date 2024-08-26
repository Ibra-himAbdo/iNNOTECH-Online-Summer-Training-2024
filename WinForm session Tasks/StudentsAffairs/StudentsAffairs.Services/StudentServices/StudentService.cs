using StudentsAffairs.Core.Entities;
using StudentsAffairs.Core.Repositroies.Contract;

namespace StudentsAffairs.Services.StudentServices;

//TODO : Add Service Response 
public class StudentService : IStudentService
{
    private readonly IUnitOfWork _unitOfWork;

    public StudentService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<int> AddStudentAsync(Student student)
    {
        await _unitOfWork.Students.AddAsync(student);
        return await _unitOfWork.CompleteAsync();
    }

    public async Task<IReadOnlyList<Student>> GetAllStudentsAsync()
    {
        return await _unitOfWork.Students.GetAllAsync();
    }

    public async Task<Student?> GetStudentByIdAsync(int id)
    {
        return await _unitOfWork.Students.GetAsync(id);
    }

    public async Task<int> UpdateStudentAsync(Student student)
    {
        await _unitOfWork.Students.UpdateAsync(student);
        return await _unitOfWork.CompleteAsync();
    }

    public async Task<int> DeleteStudentAsync(int id)
    {
        await _unitOfWork.Students.DeleteAsync(id);
        return await _unitOfWork.CompleteAsync();
    }
    public async Task<int> DeleteAllStudentsAsync()
    {
        await _unitOfWork.Students.DeleteAllAsync();
        return await _unitOfWork.CompleteAsync();
    }
}
