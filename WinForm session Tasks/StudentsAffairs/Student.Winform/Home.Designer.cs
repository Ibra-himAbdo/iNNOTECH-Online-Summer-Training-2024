namespace Student.Winform
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            SearchButton = new Button();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(117, 382);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(137, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add Student";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(270, 382);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(137, 23);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Update Student";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(427, 382);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(137, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete Student";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(580, 382);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(137, 23);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 417);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button SearchButton;
    }
}