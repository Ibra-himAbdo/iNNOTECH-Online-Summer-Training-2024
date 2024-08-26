namespace Student.Winform
{
    partial class UpdateStudent
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
            BackToHomeButton = new Button();
            MobileTextBox = new TextBox();
            MobileLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            AgeTextBox = new TextBox();
            Agelabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            ClearButton = new Button();
            UpdateButton = new Button();
            IdLabel = new Label();
            SearchBox = new TextBox();
            SearchButton = new Button();
            IdDataLable = new Label();
            SuspendLayout();
            // 
            // BackToHomeButton
            // 
            BackToHomeButton.ImeMode = ImeMode.NoControl;
            BackToHomeButton.Location = new Point(12, 12);
            BackToHomeButton.Name = "BackToHomeButton";
            BackToHomeButton.Size = new Size(143, 23);
            BackToHomeButton.TabIndex = 50;
            BackToHomeButton.Text = "Back To Home";
            BackToHomeButton.UseVisualStyleBackColor = true;
            BackToHomeButton.Click += BackToHomeButton_Click;
            // 
            // MobileTextBox
            // 
            MobileTextBox.Location = new Point(148, 268);
            MobileTextBox.Name = "MobileTextBox";
            MobileTextBox.Size = new Size(210, 23);
            MobileTextBox.TabIndex = 49;
            // 
            // MobileLabel
            // 
            MobileLabel.AutoSize = true;
            MobileLabel.ImeMode = ImeMode.NoControl;
            MobileLabel.Location = new Point(91, 271);
            MobileLabel.Name = "MobileLabel";
            MobileLabel.Size = new Size(44, 15);
            MobileLabel.TabIndex = 48;
            MobileLabel.Text = "Mobile";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(148, 183);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(210, 23);
            EmailTextBox.TabIndex = 47;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.ImeMode = ImeMode.NoControl;
            EmailLabel.Location = new Point(91, 186);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 46;
            EmailLabel.Text = "Email";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(148, 227);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(210, 23);
            AgeTextBox.TabIndex = 45;
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.ImeMode = ImeMode.NoControl;
            Agelabel.Location = new Point(91, 230);
            Agelabel.Name = "Agelabel";
            Agelabel.Size = new Size(28, 15);
            Agelabel.TabIndex = 44;
            Agelabel.Text = "Age";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(148, 135);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(210, 23);
            NameTextBox.TabIndex = 43;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.ImeMode = ImeMode.NoControl;
            NameLabel.Location = new Point(91, 138);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 42;
            NameLabel.Text = "Name";
            // 
            // ClearButton
            // 
            ClearButton.ImeMode = ImeMode.NoControl;
            ClearButton.Location = new Point(256, 309);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(102, 23);
            ClearButton.TabIndex = 41;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.ImeMode = ImeMode.NoControl;
            UpdateButton.Location = new Point(148, 309);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(102, 23);
            UpdateButton.TabIndex = 40;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += SaveButton_Click;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.ImeMode = ImeMode.NoControl;
            IdLabel.Location = new Point(91, 98);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(17, 15);
            IdLabel.TabIndex = 51;
            IdLabel.Text = "Id";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(82, 52);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(210, 23);
            SearchBox.TabIndex = 54;
            // 
            // SearchButton
            // 
            SearchButton.ImeMode = ImeMode.NoControl;
            SearchButton.Location = new Point(318, 52);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(82, 23);
            SearchButton.TabIndex = 53;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // IdDataLable
            // 
            IdDataLable.AutoSize = true;
            IdDataLable.ImeMode = ImeMode.NoControl;
            IdDataLable.Location = new Point(148, 98);
            IdDataLable.Name = "IdDataLable";
            IdDataLable.Size = new Size(0, 15);
            IdDataLable.TabIndex = 55;
            // 
            // UpdateStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 356);
            Controls.Add(IdDataLable);
            Controls.Add(SearchBox);
            Controls.Add(SearchButton);
            Controls.Add(IdLabel);
            Controls.Add(BackToHomeButton);
            Controls.Add(MobileTextBox);
            Controls.Add(MobileLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(AgeTextBox);
            Controls.Add(Agelabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(ClearButton);
            Controls.Add(UpdateButton);
            Name = "UpdateStudent";
            Text = "UpdateStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackToHomeButton;
        private TextBox MobileTextBox;
        private Label MobileLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox AgeTextBox;
        private Label Agelabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Button ClearButton;
        private Button UpdateButton;
        private Label IdLabel;
        private TextBox SearchBox;
        private Button SearchButton;
        private Label IdDataLable;
    }
}