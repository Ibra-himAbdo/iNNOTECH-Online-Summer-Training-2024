using Mapster;
using TeacherDataManager.API.Dtos;

namespace TeacherDataManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherServices _teacherServices;

        public TeachersController(ITeacherServices teacherServices)
        {
            _teacherServices = teacherServices;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Teacher>>> GetAll()
        {
            var response = await _teacherServices.GetAllAsync();

            if (!response.Success) return NotFound(response.Message ?? "Teachers not found");

            return Ok(response.Data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetById(int id)
        {
            var response = await _teacherServices.GetByIdAsync(id);
            if (!response.Success) return NotFound(response.Message);
            return Ok(response.Data);
        }

        [HttpPost]
        public async Task<ActionResult<Teacher>> Create(AddTeacherDto addedTeacherDto)
        {
            var addedTeacher = addedTeacherDto.Adapt<Teacher>();
            var response = await _teacherServices.AddAsync(addedTeacher);
            if (!response.Success) return BadRequest(response.Message);
            return Ok(response.Data);
        }

        [HttpPut]
        public async Task<ActionResult<Teacher>> Update(Teacher updatedTeacher)
        {
            var response = await _teacherServices.UpdateAsync(updatedTeacher);
            if (!response.Success) return BadRequest(response.Message);
            return Ok(response.Data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Teacher>> Delete(int id)
        {
            var response = await _teacherServices.DeleteAsync(id);
            if (!response.Success) return NotFound(response.Message);
            return Ok(response.Data);
        }
    }
}
