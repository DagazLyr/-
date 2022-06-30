
namespace Тестирование_по_общим_дисциплинам
{
    partial class Testmode
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.QuectionNumber = new System.Windows.Forms.Label();
            this.CloseBtn = new Тестирование_по_общим_дисциплинам.MyButton1();
            this.NextQuestions = new Тестирование_по_общим_дисциплинам.MyButton1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(12, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(578, 64);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(12, 171);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(578, 64);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(12, 241);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(578, 64);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // QuectionNumber
            // 
            this.QuectionNumber.AutoSize = true;
            this.QuectionNumber.BackColor = System.Drawing.Color.Transparent;
            this.QuectionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuectionNumber.ForeColor = System.Drawing.Color.White;
            this.QuectionNumber.Location = new System.Drawing.Point(298, 357);
            this.QuectionNumber.Name = "QuectionNumber";
            this.QuectionNumber.Size = new System.Drawing.Size(0, 24);
            this.QuectionNumber.TabIndex = 8;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(515, 357);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Rounding = 100;
            this.CloseBtn.RoundingEnable = true;
            this.CloseBtn.Size = new System.Drawing.Size(79, 30);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "Выход";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // NextQuestions
            // 
            this.NextQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.NextQuestions.Enabled = false;
            this.NextQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextQuestions.Location = new System.Drawing.Point(150, 343);
            this.NextQuestions.Name = "NextQuestions";
            this.NextQuestions.Rounding = 100;
            this.NextQuestions.RoundingEnable = true;
            this.NextQuestions.Size = new System.Drawing.Size(117, 44);
            this.NextQuestions.TabIndex = 6;
            this.NextQuestions.Text = "Следующий вопрос";
            this.NextQuestions.Click += new System.EventHandler(this.NextQuestions_Click);
            // 
            // Testmode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(95)))), ((int)(((byte)(151)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 399);
            this.Controls.Add(this.QuectionNumber);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.NextQuestions);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Testmode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testmode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Testmode_FormClosing);
            this.Load += new System.EventHandler(this.Testmode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton3;
        private MyButton1 NextQuestions;
        private MyButton1 CloseBtn;
        private System.Windows.Forms.Label QuectionNumber;
    }
}