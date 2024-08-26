using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.Winform
{
    public partial class Search : Form
    {
        APIServices _aPIServices = new();
        Student _student = new();
        public Search()
        {
            InitializeComponent();
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

        private void SearchForStudent(int studentId)
        {
            _student = _aPIServices.GetStudentByIdAsync(studentId);
            if (_student is null)
            {
                MessageBox.Show("Student not found");
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

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void BackToHomeButton_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
