namespace Student.Winform
{
    public partial class Home : Form
    {
        List<Student> _students = new();
        APIServices _aPIServices = new();
        public Home()
        {
            InitializeComponent();
            InitializeDataGridView();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var form = new UpdateStudent();
            form.Show();
            Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new AddStudent();
            form.Show();
            Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var form = new DeleteStudent();
            form.Show();
            Hide();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void InitializeDataGridView()
        {
            var dataGridView = new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill
            };

            _students = _aPIServices.GetAllStudentsAsync();
            dataGridView.DataSource = _students;

            #region updateButtonColumn
            //DataGridViewButtonColumn updateButtonColumn
            //        = new DataGridViewButtonColumn
            //        {
            //            Name = "Update",
            //            HeaderText = "Update",
            //            Text = "Update",
            //            UseColumnTextForButtonValue = true
            //        };

            //dataGridView.Columns
            //    .Add(updateButtonColumn); 
            #endregion


            this.Controls.Add(dataGridView);


        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var form = new Search();
            form.Show();
            Hide();
        }
    }
}
