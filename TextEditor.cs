using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Тестирование_по_общим_дисциплинам
{
    public partial class TextEditor : Form
    {
        public Form ReturnForm;
        string openfile = String.Empty;
        public TextEditor(string FullName)
        {
            InitializeComponent();
            this.Text = "Создание/редактирование тестов - " + FullName;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            openfile = openFileDialog1.FileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(openfile, textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Файла не существует!", "Ошибка");
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }

        

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для создания/редактирования тестов используйте следующую структуру:\n Название вопроса\n 1) - Первый вариант ответа \n 2) - Второй вариант ответа \n 3) - Третий вариант ответа \nНомер правильного вопроса от 1 до 3 \nМаксимальное количество вопросов - 100.\nЕсли вы новый преподаватель, то после создания своего теста не забудьте обратиться к администратору для того, чтобы он добавил ваш тест в программу!", "Структура тестов");
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {

        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnForm.Show();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnForm.Show();
        }
    }
}
