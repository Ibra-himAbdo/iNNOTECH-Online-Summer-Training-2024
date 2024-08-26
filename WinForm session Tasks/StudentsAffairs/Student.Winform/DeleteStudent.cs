namespace Student.Winform
{
    public partial class DeleteStudent : Form
    {
        APIServices _aPIServices = new();
        Student _student = new();
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_student is null)
            {
                MessageBox.Show("Please select a student");
                return;
            }
            var result = _aPIServices.DeleteStudentAsync(_student.Id);
            if (result)
            {
                MessageBox.Show("Student deleted successfully");
                _student = new();
            }
            else
            {
                MessageBox.Show("Failed to delete student");
            }
        }

        private void BackToHomeButton_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Hide();
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
                NameDataLable.Text = _student.Name;
                EmailDataLable.Text = _student.Email;
                MobileDataLable.Text = _student.Mobile;
                AgeDataLable.Text = _student.Age.ToString();
            }

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

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

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            var result = _aPIServices.DeleteAllStudentsAsync();
            if (result)
            {
                MessageBox.Show("All students deleted successfully");
            }
            else
            {
                MessageBox.Show("Failed to delete students");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _student = new();
        }
    }
}
