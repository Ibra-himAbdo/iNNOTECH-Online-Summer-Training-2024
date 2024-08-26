namespace Student.Winform
{
    partial class AddStudent
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
            SaveButton = new Button();
            SuspendLayout();
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
            // MobileTextBox
            // 
            MobileTextBox.Location = new Point(158, 206);
            MobileTextBox.Name = "MobileTextBox";
            MobileTextBox.Size = new Size(210, 23);
            MobileTextBox.TabIndex = 38;
            // 
            // MobileLabel
            // 
            MobileLabel.AutoSize = true;
            MobileLabel.ImeMode = ImeMode.NoControl;
            MobileLabel.Location = new Point(101, 209);
            MobileLabel.Name = "MobileLabel";
            MobileLabel.Size = new Size(44, 15);
            MobileLabel.TabIndex = 37;
            MobileLabel.Text = "Mobile";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(158, 121);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(210, 23);
            EmailTextBox.TabIndex = 36;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.ImeMode = ImeMode.NoControl;
            EmailLabel.Location = new Point(101, 124);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 35;
            EmailLabel.Text = "Email";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(158, 165);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(210, 23);
            AgeTextBox.TabIndex = 34;
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.ImeMode = ImeMode.NoControl;
            Agelabel.Location = new Point(101, 168);
            Agelabel.Name = "Agelabel";
            Agelabel.Size = new Size(28, 15);
            Agelabel.TabIndex = 33;
            Agelabel.Text = "Age";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(158, 73);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(210, 23);
            NameTextBox.TabIndex = 32;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.ImeMode = ImeMode.NoControl;
            NameLabel.Location = new Point(101, 76);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 31;
            NameLabel.Text = "Name";
            // 
            // ClearButton
            // 
            ClearButton.ImeMode = ImeMode.NoControl;
            ClearButton.Location = new Point(266, 247);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(102, 23);
            ClearButton.TabIndex = 29;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.ImeMode = ImeMode.NoControl;
            SaveButton.Location = new Point(158, 247);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(102, 23);
            SaveButton.TabIndex = 28;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 353);
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
            Controls.Add(SaveButton);
            Name = "AddStudent";
            Text = "AddStudent";
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
        private Button SaveButton;
    }
}