using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Тестирование_по_общим_дисциплинам
{
    public partial class AddAkk : Form
    {
        public AddAkk()
        {
            InitializeComponent();
            AddBtn.Focus();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem aboutItem = new ToolStripMenuItem("Справка");
            aboutItem.Click += aboutItem_Click;
            menuStrip1.Items.Add(aboutItem);
        }
        void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уровни доступа пользователей:\n 1 - Администратор \n 2 - Преподаватель \n 3 - Студент","Справка");
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            Admin main = this.Owner as Admin;
            if (main != null)
            {
                DataRow nRow = main.accountsDataSet.Tables[0].NewRow();
                nRow[0] = textBox1.Text;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox3.Text;
                nRow[3] = textBox4.Text;
                nRow[4] = textBox5.Text;
                main.accountsDataSet.Tables[0].Rows.Add(nRow);
                main.аккаунтыTableAdapter.Update(main.accountsDataSet.Аккаунты);
                main.accountsDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "3")
            {
                label3.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBox3.Visible = false;
            }
        }
    }
}
