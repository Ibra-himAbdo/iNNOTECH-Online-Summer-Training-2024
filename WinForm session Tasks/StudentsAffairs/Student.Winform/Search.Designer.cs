namespace Student.Winform
{
    partial class Search
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
            BackToHomeButton = new Button();
            IdDataLable = new Label();
            MobileDataLable = new Label();
            EmailDataLable = new Label();
            AgeDataLable = new Label();
            NameDataLable = new Label();
            IdLabel = new Label();
            MobileLabel = new Label();
            EmailLabel = new Label();
            Agelabel = new Label();
            NameLabel = new Label();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(166, 70);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(210, 23);
            SearchBox.TabIndex = 47;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // SearchButton
            // 
            SearchButton.ImeMode = ImeMode.NoControl;
            SearchButton.Location = new Point(400, 70);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(82, 23);
            SearchButton.TabIndex = 46;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // BackToHomeButton
            // 
            BackToHomeButton.ImeMode = ImeMode.NoControl;
            BackToHomeButton.Location = new Point(12, 12);
            BackToHomeButton.Name = "BackToHomeButton";
            BackToHomeButton.Size = new Size(143, 23);
            BackToHomeButton.TabIndex = 45;
            BackToHomeButton.Text = "Back To Home";
            BackToHomeButton.UseVisualStyleBackColor = true;
            BackToHomeButton.Click += BackToHomeButton_Click;
            // 
            // IdDataLable
            // 
            IdDataLable.AutoSize = true;
            IdDataLable.ImeMode = ImeMode.NoControl;
            IdDataLable.Location = new Point(251, 108);
            IdDataLable.Name = "IdDataLable";
            IdDataLable.Size = new Size(0, 15);
            IdDataLable.TabIndex = 58;
            // 
            // MobileDataLable
            // 
            MobileDataLable.AutoSize = true;
            MobileDataLable.ImeMode = ImeMode.NoControl;
            MobileDataLable.Location = new Point(251, 281);
            MobileDataLable.Name = "MobileDataLable";
            MobileDataLable.Size = new Size(0, 15);
            MobileDataLable.TabIndex = 57;
            // 
            // EmailDataLable
            // 
            EmailDataLable.AutoSize = true;
            EmailDataLable.ImeMode = ImeMode.NoControl;
            EmailDataLable.Location = new Point(251, 196);
            EmailDataLable.Name = "EmailDataLable";
            EmailDataLable.Size = new Size(0, 15);
            EmailDataLable.TabIndex = 56;
            // 
            // AgeDataLable
            // 
            AgeDataLable.AutoSize = true;
            AgeDataLable.ImeMode = ImeMode.NoControl;
            AgeDataLable.Location = new Point(251, 240);
            AgeDataLable.Name = "AgeDataLable";
            AgeDataLable.Size = new Size(0, 15);
            AgeDataLable.TabIndex = 55;
            // 
            // NameDataLable
            // 
            NameDataLable.AutoSize = true;
            NameDataLable.ImeMode = ImeMode.NoControl;
            NameDataLable.Location = new Point(251, 148);
            NameDataLable.Name = "NameDataLable";
            NameDataLable.Size = new Size(0, 15);
            NameDataLable.TabIndex = 54;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.ImeMode = ImeMode.NoControl;
            IdLabel.Location = new Point(166, 108);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(17, 15);
            IdLabel.TabIndex = 53;
            IdLabel.Text = "Id";
            // 
            // MobileLabel
            // 
            MobileLabel.AutoSize = true;
            MobileLabel.ImeMode = ImeMode.NoControl;
            MobileLabel.Location = new Point(166, 281);
            MobileLabel.Name = "MobileLabel";
            MobileLabel.Size = new Size(44, 15);
            MobileLabel.TabIndex = 52;
            MobileLabel.Text = "Mobile";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.ImeMode = ImeMode.NoControl;
            EmailLabel.Location = new Point(166, 196);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 51;
            EmailLabel.Text = "Email";
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.ImeMode = ImeMode.NoControl;
            Agelabel.Location = new Point(166, 240);
            Agelabel.Name = "Agelabel";
            Agelabel.Size = new Size(28, 15);
            Agelabel.TabIndex = 50;
            Agelabel.Text = "Age";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.ImeMode = ImeMode.NoControl;
            NameLabel.Location = new Point(166, 148);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 49;
            NameLabel.Text = "Name";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 321);
            Controls.Add(IdDataLable);
            Controls.Add(MobileDataLable);
            Controls.Add(EmailDataLable);
            Controls.Add(AgeDataLable);
            Controls.Add(NameDataLable);
            Controls.Add(IdLabel);
            Controls.Add(MobileLabel);
            Controls.Add(EmailLabel);
            Controls.Add(Agelabel);
            Controls.Add(NameLabel);
            Controls.Add(SearchBox);
            Controls.Add(SearchButton);
            Controls.Add(BackToHomeButton);
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private Button SearchButton;
        private Button BackToHomeButton;
        private Label IdDataLable;
        private Label MobileDataLable;
        private Label EmailDataLable;
        private Label AgeDataLable;
        private Label NameDataLable;
        private Label IdLabel;
        private Label MobileLabel;
        private Label EmailLabel;
        private Label Agelabel;
        private Label NameLabel;
    }
}