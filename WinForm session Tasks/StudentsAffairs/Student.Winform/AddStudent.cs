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
    public partial class AddStudent : Form
    {
        APIServices _aPIServices = new();
        Student _student = new();
        public AddStudent()
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
            _student.Name = NameTextBox.Text;
            _student.Email = EmailTextBox.Text;
            _student.Mobile = MobileTextBox.Text;
            _student.Age = age;

            if (string.IsNullOrEmpty(_student.Name)
                || string.IsNullOrEmpty(_student.Email)
                || string.IsNullOrEmpty(_student.Mobile))
            {
                MessageBox.Show("Please enter Information");
                return;
            }
            else
            {
                var result = _aPIServices.AddStudentAsync(_student);
                if (result)
                {
                    MessageBox.Show("Student added successfully");
                    _student = new();
                }
                else
                {
                    MessageBox.Show("Failed to add student");
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _student = new();
            NameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            MobileTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;
        }
    }
}
