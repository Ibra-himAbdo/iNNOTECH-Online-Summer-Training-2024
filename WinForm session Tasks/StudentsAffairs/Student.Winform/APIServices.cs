using System.Net.Http.Json;
using System.Text.Json;

namespace Student.Winform
{
    public class APIServices
    {
        const string BaseUrl = "http://localhost:5000";
        readonly HttpClient _httpClient = new HttpClient();
        public bool AddStudentAsync(Student student)
        {
            var addedStudent = new { 
                Name = student.Name,
                Age = student.Age,
                Email = student.Email,
                Mobile = student.Mobile
            };

            var httpResponseMessage = _httpClient.PostAsJsonAsync(BaseUrl + $"/api/Students", addedStudent).GetAwaiter().GetResult();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public List<Student> GetAllStudentsAsync()
        {
            var httpResponseMessage = _httpClient.GetAsync(BaseUrl + "/api/Students").GetAwaiter().GetResult(); 
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string responseContent = httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var students = JsonSerializer.Deserialize<List<Student>>(responseContent);
                return students;
            }
            else
            {
                return new List<Student>();
            }
        }

        public Student? GetStudentByIdAsync(int id)
        {
            var httpResponseMessage = _httpClient.GetAsync(BaseUrl + $"/api/Students/{id}").GetAwaiter().GetResult(); 
            Student? student = null;
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string responseContent = httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                student = JsonSerializer.Deserialize<Student>(responseContent);
            }
            return student;
        }

        public bool UpdateStudentAsync(Student student)
        {
            var httpResponseMessage = _httpClient.PutAsJsonAsync(BaseUrl + $"/api/Students", student).GetAwaiter().GetResult();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public bool DeleteStudentAsync(int id)
        {
            var httpResponseMessage = _httpClient.DeleteAsync(BaseUrl + $"/api/Students/{id}").GetAwaiter().GetResult();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public bool DeleteAllStudentsAsync()
        {
            var httpResponseMessage = _httpClient.DeleteAsync(BaseUrl + "/api/Students").GetAwaiter().GetResult();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
