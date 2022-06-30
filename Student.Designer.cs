
namespace Тестирование_по_общим_дисциплинам
{
    partial class Student
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseBtn = new Тестирование_по_общим_дисциплинам.MyButton1();
            this.ExamModBtn = new Тестирование_по_общим_дисциплинам.MyButton1();
            this.TestModBtn = new Тестирование_по_общим_дисциплинам.MyButton1();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Английский язык - Фазаева",
            "Русский язык - Марченко",
            "Математика - Либникова",
            "Математика - Гранд",
            "Астрономия - Галка",
            "Литература - Марченко",
            "Обществознание - Козлова",
            "ОБЖ - Илюзина",
            "Химия - Бойко",
            "Химия - Гранд",
            "Биология - Бойко",
            "География - Бойко",
            "Информатика - Галка",
            "Информатика - Киров",
            "Информатика - Терёшин",
            "История - Козлова",
            "Физика - Гранд"});
            this.comboBox1.Location = new System.Drawing.Point(40, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "Справка";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(100, 172);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Rounding = 100;
            this.CloseBtn.RoundingEnable = true;
            this.CloseBtn.Size = new System.Drawing.Size(100, 30);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "Выход";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ExamModBtn
            // 
            this.ExamModBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.ExamModBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamModBtn.Location = new System.Drawing.Point(186, 91);
            this.ExamModBtn.Name = "ExamModBtn";
            this.ExamModBtn.Rounding = 100;
            this.ExamModBtn.RoundingEnable = true;
            this.ExamModBtn.Size = new System.Drawing.Size(100, 55);
            this.ExamModBtn.TabIndex = 5;
            this.ExamModBtn.Text = "Режим экзамена";
            this.ExamModBtn.Click += new System.EventHandler(this.ExamModBtn_Click);
            // 
            // TestModBtn
            // 
            this.TestModBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.TestModBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestModBtn.Location = new System.Drawing.Point(12, 91);
            this.TestModBtn.Name = "TestModBtn";
            this.TestModBtn.Rounding = 100;
            this.TestModBtn.RoundingEnable = true;
            this.TestModBtn.Size = new System.Drawing.Size(100, 51);
            this.TestModBtn.TabIndex = 4;
            this.TestModBtn.Text = "Учебный режим";
            this.TestModBtn.Click += new System.EventHandler(this.TestModBtn_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(298, 214);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ExamModBtn);
            this.Controls.Add(this.TestModBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор теста";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Student_FormClosing);
            this.Load += new System.EventHandler(this.Student_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private MyButton1 TestModBtn;
        private MyButton1 ExamModBtn;
        private MyButton1 CloseBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}