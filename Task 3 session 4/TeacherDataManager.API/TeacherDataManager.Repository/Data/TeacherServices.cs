namespace TeacherDataManager.Repository.Data
{
    public class TeacherServices : ITeacherServices
    {
        static readonly string filePath =
            Path.Combine("..", "TeacherDataManager.Repository", "Data", "JsonData", "teachers.json");

        public async Task<ServiceResponse<List<Teacher>>> AddAsync(Teacher teacher)
        {
            var serviceResponse = new ServiceResponse<List<Teacher>>();
            try
            {
                var teachers = await GetAllAsync();

                // Check if teacher already exists
                if (teachers.Data!.Any(t => t.Name.ToLower().Equals(teacher.Name.ToLower())
                                    || t.UserName.ToLower().Equals(teacher.UserName.ToLower())
                                    || t.Email.ToLower().Equals(teacher.Email.ToLower())))
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Teacher already exists.";
                    return serviceResponse;
                }
                var lastTeacher = teachers.Data!.LastOrDefault();
                teacher.Id = lastTeacher.Id + 1;

                teachers.Data!.Add(teacher);

                // Save updated list to file
                await SaveToFileAsync(teachers.Data);

                serviceResponse.Data = teachers.Data;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Teacher>>> DeleteAsync(int id)
        {
            var serviceResponse = new ServiceResponse<List<Teacher>>();
            try
            {
                var teachers = await GetAllAsync();

                var teacherToRemove = teachers.Data.FirstOrDefault(t => t.Id == id);
                if (teacherToRemove is null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Teacher not found.";
                    return serviceResponse;
                }

                teachers.Data.Remove(teacherToRemove);

                // Save updated list to file
                await SaveToFileAsync(teachers.Data);

                serviceResponse.Data = teachers.Data;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<Teacher>> GetByIdAsync(int id)
        {
            var serviceResponse = new ServiceResponse<Teacher>();
            try
            {
                var teachers = await GetAllAsync();

                var teacher = teachers.Data.FirstOrDefault(t => t.Id == id);
                if (teacher is null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Teacher not found.";
                    return serviceResponse;
                }

                serviceResponse.Data = teacher;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<Teacher>> UpdateAsync(Teacher updatedTeacher)
        {
            var serviceResponse = new ServiceResponse<Teacher>();
            try
            {
                var teachers = await GetAllAsync();

                var existingTeacher = teachers.Data.FirstOrDefault(t => t.Id == updatedTeacher.Id);
                if (existingTeacher is null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Teacher not found.";
                    return serviceResponse;
                }

                existingTeacher.Name = updatedTeacher.Name;
                existingTeacher.Email = updatedTeacher.Email;
                existingTeacher.UserName = updatedTeacher.UserName;

                // Save updated list to file
                await SaveToFileAsync(teachers.Data);

                serviceResponse.Data = existingTeacher;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        private async Task SaveToFileAsync(List<Teacher> teachers)
        {
            try
            {
                var jsonString = JsonSerializer.Serialize(teachers, new JsonSerializerOptions { WriteIndented = true });
                await File.WriteAllTextAsync(filePath, jsonString);
            }
            catch (Exception ex)
            {
                throw new IOException("An error occurred while saving data to the file.", ex);
            }
        }

        public async Task<ServiceResponse<List<Teacher>>> GetAllAsync()
        {
            var serviceResponse = new ServiceResponse<List<Teacher>>();
            try
            {
                var teachers = new List<Teacher>();

                if (File.Exists(filePath))
                {
                    var jsonString = await File.ReadAllTextAsync(filePath);
                    if (!string.IsNullOrEmpty(jsonString))
                    {
                        teachers = JsonSerializer.Deserialize<List<Teacher>>(jsonString) ?? new List<Teacher>();
                    }
                }
                else
                {
                    teachers = CreateTeachers();
                    await SaveToFileAsync(teachers);
                }

                serviceResponse.Data = teachers;
            }
            catch (Exception ex)
            {
                serviceResponse.Data = null;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        static List<Teacher> CreateTeachers()
        {
            int teacherCount = 15;
            var teachers = new List<Teacher>();

            for (int i = 0; i < teacherCount; i++)
            {
                teachers.Add(new Teacher
                {
                    Id = i + 1,
                    Name = $"Teacher {i + 1}",
                    Email = $"teacher{i + 1}@gmail.com",
                    UserName = $"teacher{i + 1}"
                });
            }

            return teachers;
        }
    }

}
