namespace Student.Winform
{
    public partial class UpdateStudent : Form
    {
        APIServices _aPIServices = new();
        Student _student = new();
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void BackToHomeButton_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool isValidAge = int.TryParse(AgeTextBox.Text, out int age);
            if (!isValidAge)
            {
                MessageBox.Show("Please enter valid age");
                return;
            }
            var updatedStudent = new Student();
            updatedStudent.Id = _student.Id;
            updatedStudent.Name = NameTextBox.Text;
            updatedStudent.Email = EmailTextBox.Text;
            updatedStudent.Mobile = MobileTextBox.Text;
            updatedStudent.Age = age;

            if (string.IsNullOrEmpty(updatedStudent.Name)
                || string.IsNullOrEmpty(updatedStudent.Email)
                || string.IsNullOrEmpty(updatedStudent.Mobile))
            {
                MessageBox.Show("Please enter Information");
                return;
            }
            else
            {
                var result = _aPIServices.UpdateStudentAsync(updatedStudent);
                if (result)
                {
                    MessageBox.Show("Student updated successfully");
                    _student = new();
                }
                else
                {
                    MessageBox.Show("Failed to updated student");
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool isIdValid = int.TryParse(SearchBox.Text, out int studentId);
            if (!isIdValid)
            {
                MessageBox.Show("Please enter valid Id");
                return;
            }
            SearchForStudent(studentId);
        }

        private void SearchForStudent(int studentId)
        {
            _student = _aPIServices.GetStudentByIdAsync(studentId);
            if (_student is null)
            {
                MessageBox.Show("Student not found");
                return;
            }
            else
            {
                IdDataLable.Text = _student.Id.ToString();
                NameTextBox.Text = _student.Name;
                EmailTextBox.Text = _student.Email;
                MobileTextBox.Text = _student.Mobile;
                AgeTextBox.Text = _student.Age.ToString();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _student = new();
            IdDataLable.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            MobileTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;
        }
    }
}
