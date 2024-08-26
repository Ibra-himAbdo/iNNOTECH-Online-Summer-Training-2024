namespace Student.Winform
{
    partial class DeleteStudent
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
            SearchBox = new TextBox();
            SearchButton = new Button();
            IdLabel = new Label();
            BackToHomeButton = new Button();
            MobileLabel = new Label();
            EmailLabel = new Label();
            Agelabel = new Label();
            NameLabel = new Label();
            DeleteLabel = new Label();
            ClearButton = new Button();
            DeleteButton = new Button();
            IdDataLable = new Label();
            MobileDataLable = new Label();
            EmailDataLable = new Label();
            AgeDataLable = new Label();
            NameDataLable = new Label();
            DeleteAllButton = new Button();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(105, 73);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(210, 23);
            SearchBox.TabIndex = 43;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // SearchButton
            // 
            SearchButton.ImeMode = ImeMode.NoControl;
            SearchButton.Location = new Point(341, 73);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(82, 23);
            SearchButton.TabIndex = 42;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.ImeMode = ImeMode.NoControl;
            IdLabel.Location = new Point(105, 117);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(17, 15);
            IdLabel.TabIndex = 40;
            IdLabel.Text = "Id";
            // 
            // BackToHomeButton
            // 
            BackToHomeButton.ImeMode = ImeMode.NoControl;
            BackToHomeButton.Location = new Point(12, 12);
            BackToHomeButton.Name = "BackToHomeButton";
            BackToHomeButton.Size = new Size(143, 23);
            BackToHomeButton.TabIndex = 39;
            BackToHomeButton.Text = "Back To Home";
            BackToHomeButton.UseVisualStyleBackColor = true;
            BackToHomeButton.Click += BackToHomeButton_Click;
            // 
            // MobileLabel
            // 
            MobileLabel.AutoSize = true;
            MobileLabel.ImeMode = ImeMode.NoControl;
            MobileLabel.Location = new Point(105, 290);
            MobileLabel.Name = "MobileLabel";
            MobileLabel.Size = new Size(44, 15);
            MobileLabel.TabIndex = 37;
            MobileLabel.Text = "Mobile";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.ImeMode = ImeMode.NoControl;
            EmailLabel.Location = new Point(105, 205);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 35;
            EmailLabel.Text = "Email";
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.ImeMode = ImeMode.NoControl;
            Agelabel.Location = new Point(105, 249);
            Agelabel.Name = "Agelabel";
            Agelabel.Size = new Size(28, 15);
            Agelabel.TabIndex = 33;
            Agelabel.Text = "Age";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.ImeMode = ImeMode.NoControl;
            NameLabel.Location = new Point(105, 157);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 31;
            NameLabel.Text = "Name";
            // 
            // DeleteLabel
            // 
            DeleteLabel.AutoSize = true;
            DeleteLabel.ImeMode = ImeMode.NoControl;
            DeleteLabel.Location = new Point(12, 52);
            DeleteLabel.Name = "DeleteLabel";
            DeleteLabel.Size = new Size(84, 15);
            DeleteLabel.TabIndex = 30;
            DeleteLabel.Text = "Delete Student";
            DeleteLabel.Click += label1_Click;
            // 
            // ClearButton
            // 
            ClearButton.ImeMode = ImeMode.NoControl;
            ClearButton.Location = new Point(233, 334);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(102, 23);
            ClearButton.TabIndex = 29;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.ImeMode = ImeMode.NoControl;
            DeleteButton.Location = new Point(105, 334);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 23);
            DeleteButton.TabIndex = 28;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // IdDataLable
            // 
            IdDataLable.AutoSize = true;
            IdDataLable.ImeMode = ImeMode.NoControl;
            IdDataLable.Location = new Point(190, 117);
            IdDataLable.Name = "IdDataLable";
            IdDataLable.Size = new Size(0, 15);
            IdDataLable.TabIndex = 48;
            IdDataLable.Click += label1_Click_1;
            // 
            // MobileDataLable
            // 
            MobileDataLable.AutoSize = true;
            MobileDataLable.ImeMode = ImeMode.NoControl;
            MobileDataLable.Location = new Point(190, 290);
            MobileDataLable.Name = "MobileDataLable";
            MobileDataLable.Size = new Size(0, 15);
            MobileDataLable.TabIndex = 47;
            // 
            // EmailDataLable
            // 
            EmailDataLable.AutoSize = true;
            EmailDataLable.ImeMode = ImeMode.NoControl;
            EmailDataLable.Location = new Point(190, 205);
            EmailDataLable.Name = "EmailDataLable";
            EmailDataLable.Size = new Size(0, 15);
            EmailDataLable.TabIndex = 46;
            // 
            // AgeDataLable
            // 
            AgeDataLable.AutoSize = true;
            AgeDataLable.ImeMode = ImeMode.NoControl;
            AgeDataLable.Location = new Point(190, 249);
            AgeDataLable.Name = "AgeDataLable";
            AgeDataLable.Size = new Size(0, 15);
            AgeDataLable.TabIndex = 45;
            // 
            // NameDataLable
            // 
            NameDataLable.AutoSize = true;
            NameDataLable.ImeMode = ImeMode.NoControl;
            NameDataLable.Location = new Point(190, 157);
            NameDataLable.Name = "NameDataLable";
            NameDataLable.Size = new Size(0, 15);
            NameDataLable.TabIndex = 44;
            // 
            // DeleteAllButton
            // 
            DeleteAllButton.ImeMode = ImeMode.NoControl;
            DeleteAllButton.Location = new Point(105, 374);
            DeleteAllButton.Name = "DeleteAllButton";
            DeleteAllButton.Size = new Size(230, 23);
            DeleteAllButton.TabIndex = 49;
            DeleteAllButton.Text = "Delete All";
            DeleteAllButton.UseVisualStyleBackColor = true;
            DeleteAllButton.Click += DeleteAllButton_Click;
            // 
            // DeleteStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 430);
            Controls.Add(DeleteAllButton);
            Controls.Add(IdDataLable);
            Controls.Add(MobileDataLable);
            Controls.Add(EmailDataLable);
            Controls.Add(AgeDataLable);
            Controls.Add(NameDataLable);
            Controls.Add(SearchBox);
            Controls.Add(SearchButton);
            Controls.Add(IdLabel);
            Controls.Add(BackToHomeButton);
            Controls.Add(MobileLabel);
            Controls.Add(EmailLabel);
            Controls.Add(Agelabel);
            Controls.Add(NameLabel);
            Controls.Add(DeleteLabel);
            Controls.Add(ClearButton);
            Controls.Add(DeleteButton);
            Name = "DeleteStudent";
            Text = "DeleteStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private Button SearchButton;
        private Label IdLabel;
        private Button BackToHomeButton;
        private Label MobileLabel;
        private Label EmailLabel;
        private Label Agelabel;
        private Label NameLabel;
        private Label DeleteLabel;
        private Button ClearButton;
        private Button DeleteButton;
        private Label IdDataLable;
        private Label MobileDataLable;
        private Label EmailDataLable;
        private Label AgeDataLable;
        private Label NameDataLable;
        private Button DeleteAllButton;
    }
}