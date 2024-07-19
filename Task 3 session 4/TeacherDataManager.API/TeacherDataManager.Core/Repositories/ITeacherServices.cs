using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherDataManager.Core.Repositories
{
    public interface ITeacherServices
    {
        public Task<ServiceResponse<List<Teacher>>> GetAllAsync();

        public Task<ServiceResponse<Teacher>> GetByIdAsync(int id);

        public Task<ServiceResponse<List<Teacher>>> AddAsync(Teacher teacher);

        public Task<ServiceResponse<Teacher>> UpdateAsync(Teacher teacher);

        public Task<ServiceResponse<List<Teacher>>> DeleteAsync(int id);
    }
}
