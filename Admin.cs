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

namespace Тестирование_по_общим_дисциплинам
{
    public partial class Admin : Form
    {

        public Form ReturnForm;

        public Admin()
        {
            InitializeComponent();
            FrmAddBat.Focus();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountsDataSet.Аккаунты". При необходимости она может быть перемещена или удалена.
            this.аккаунтыTableAdapter.Fill(this.accountsDataSet.Аккаунты);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnForm.Show();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            аккаунтыTableAdapter.Update(accountsDataSet);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для удаления записи выделите всю строку и нажмите клавишу Delete(Del)", "Справка");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmAddBat_Click(object sender, EventArgs e)
        {
            AddAkk frm4 = new AddAkk();
            frm4.Owner = this;
            frm4.Show();
        }
    }
    
}
