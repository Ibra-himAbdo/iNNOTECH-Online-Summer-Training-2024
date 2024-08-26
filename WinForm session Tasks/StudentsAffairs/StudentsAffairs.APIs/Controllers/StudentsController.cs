namespace StudentsAffairs.APIs.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _service;
    private readonly IMapper _mapper;

    public StudentsController(IStudentService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] AddStudentDto AddedStudent)
    {
        var studentToAdd = _mapper.Map<AddStudentDto, Student>(AddedStudent);
        var result = await _service.AddStudentAsync(studentToAdd);
        if (result == 0) return BadRequest();
        return Created();
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<Student>>> GetAll()
    {
        var students = await _service.GetAllStudentsAsync();
        return Ok(students);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> Get([FromRoute] int id)
    {
        var student = await _service.GetStudentByIdAsync(id);

        if (student is null) return NotFound();

        return Ok(student);
    }

    [HttpPut]
    public async Task<ActionResult> Put(Student updateStudent)
    {
        var result = await _service.UpdateStudentAsync(updateStudent);
        if (result == 0) return BadRequest(result);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        var result = await _service.DeleteStudentAsync(id);
        if (result == 0) return BadRequest(result);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteAll()
    {
        var result = await _service.DeleteAllStudentsAsync();
        if (result == 0) return BadRequest(result);
        return Ok(result);
    }
}
