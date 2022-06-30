using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Тестирование_по_общим_дисциплинам.MyButton;

namespace Тестирование_по_общим_дисциплинам
{
    public partial class Authorization : Form
    {
        public string FullName;
        int lvl = 0;


        public Authorization()
        {
            InitializeComponent();

            LoginBtn.Focus();

            Animator.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        
        private void myButton11_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Bd_test.mdb");

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select Уровень From Аккаунты where Логин ='" + textBox1.Text + "' and Пароль ='" + textBox2.Text + "'", con);
            OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter("Select ФИО From Аккаунты where Логин ='" + textBox1.Text + "' and Пароль ='" + textBox2.Text + "'", con);

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            dataAdapter.Fill(dt);
            dataAdapter1.Fill(dt1);

            if (dt.Rows.Count > 0)
            {
                lvl = Convert.ToInt32(dt.Rows[0][0]);
                if (lvl == 2)
                {
                    FullName = Convert.ToString(dt1.Rows[0][0]);
                   
                    new TextEditor(FullName) { ReturnForm = this }.Show();
                    this.Hide();
                    
                    
                }
                else if (lvl == 3)
                {
                    new Student() { ReturnForm = this }.Show();
                    this.Hide();
                }
                else if (lvl == 1)
                {
                    new Admin() { ReturnForm = this }.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Введён неверный логин или пароль", "Ошибка авторизации");
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
