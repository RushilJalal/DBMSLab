namespace StudentFormQ2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(316, 19);
            label1.Name = "label1";
            label1.Size = new Size(169, 41);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(64, 80);
            label2.Name = "label2";
            label2.Size = new Size(151, 41);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(64, 141);
            label3.Name = "label3";
            label3.Size = new Size(213, 41);
            label3.TabIndex = 2;
            label3.Text = "Registration ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(64, 202);
            label4.Name = "label4";
            label4.Size = new Size(116, 41);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(64, 264);
            label5.Name = "label5";
            label5.Size = new Size(196, 41);
            label5.TabIndex = 4;
            label5.Text = "Exams given: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 31);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(345, 213);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(467, 214);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 31);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(307, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 29);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "JEE";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(393, 276);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(67, 29);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "CET";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(476, 276);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(115, 29);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "MIT Exam";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(216, 330);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 14;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(307, 607);
            button1.Name = "button1";
            button1.Size = new Size(153, 59);
            button1.TabIndex = 15;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 692);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private MonthCalendar monthCalendar1;
        private Button button1;
    }
}
