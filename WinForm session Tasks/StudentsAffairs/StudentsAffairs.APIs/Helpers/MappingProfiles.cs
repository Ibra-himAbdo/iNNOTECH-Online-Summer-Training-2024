namespace StudentsAffairs.APIs.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<AddStudentDto, Student>();
    }
}
