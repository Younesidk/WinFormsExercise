namespace TeachingOuns
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GradeLabel = new Label();
            CC1TextBox = new TextBox();
            CC1Label = new Label();
            CC2Label = new Label();
            ExamLabel = new Label();
            CC2TextBox = new TextBox();
            ExamTextBox = new TextBox();
            GradeResultLabel = new Label();
            CalculateButton = new Button();
            SuspendLayout();
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(245, 313);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(44, 15);
            GradeLabel.TabIndex = 0;
            GradeLabel.Text = "Grade :";
            // 
            // CC1TextBox
            // 
            CC1TextBox.Location = new Point(147, 134);
            CC1TextBox.Name = "CC1TextBox";
            CC1TextBox.Size = new Size(100, 23);
            CC1TextBox.TabIndex = 1;
            // 
            // CC1Label
            // 
            CC1Label.AutoSize = true;
            CC1Label.Location = new Point(147, 100);
            CC1Label.Name = "CC1Label";
            CC1Label.Size = new Size(35, 15);
            CC1Label.TabIndex = 2;
            CC1Label.Text = "CC1 :";
            // 
            // CC2Label
            // 
            CC2Label.AutoSize = true;
            CC2Label.Location = new Point(314, 100);
            CC2Label.Name = "CC2Label";
            CC2Label.Size = new Size(35, 15);
            CC2Label.TabIndex = 3;
            CC2Label.Text = "CC2 :";
            // 
            // ExamLabel
            // 
            ExamLabel.AutoSize = true;
            ExamLabel.Location = new Point(501, 100);
            ExamLabel.Name = "ExamLabel";
            ExamLabel.Size = new Size(41, 15);
            ExamLabel.TabIndex = 4;
            ExamLabel.Text = "Exam :";
            // 
            // CC2TextBox
            // 
            CC2TextBox.Location = new Point(314, 134);
            CC2TextBox.Name = "CC2TextBox";
            CC2TextBox.Size = new Size(100, 23);
            CC2TextBox.TabIndex = 5;
            // 
            // ExamTextBox
            // 
            ExamTextBox.Location = new Point(501, 134);
            ExamTextBox.Name = "ExamTextBox";
            ExamTextBox.Size = new Size(100, 23);
            ExamTextBox.TabIndex = 6;
            // 
            // GradeResultLabel
            // 
            GradeResultLabel.AutoSize = true;
            GradeResultLabel.Location = new Point(336, 313);
            GradeResultLabel.Name = "GradeResultLabel";
            GradeResultLabel.Size = new Size(0, 15);
            GradeResultLabel.TabIndex = 7;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(327, 230);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(75, 23);
            CalculateButton.TabIndex = 8;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalculateButton);
            Controls.Add(GradeResultLabel);
            Controls.Add(ExamTextBox);
            Controls.Add(CC2TextBox);
            Controls.Add(ExamLabel);
            Controls.Add(CC2Label);
            Controls.Add(CC1Label);
            Controls.Add(CC1TextBox);
            Controls.Add(GradeLabel);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GradeLabel;
        private TextBox CC1TextBox;
        private Label CC1Label;
        private Label CC2Label;
        private Label ExamLabel;
        private TextBox CC2TextBox;
        private TextBox ExamTextBox;
        private Label GradeResultLabel;
        private Button CalculateButton;
    }
}
