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
    public partial class Testmode : Form
    {
        string test;
        public List<QuestionItem> questions;

        List<QuestionItem> result = new List<QuestionItem>();

        int quection_count = 0;
        int balls = 0;

        int wrong_answer = 0;

        string[] array;

        int select;
        int prav_otvet;

        public Form ReturnForm;

        public class QuestionItem
        {
            public string Question { get; set; }
            public string Radio1 { get; set; }
            public string Radio2 { get; set; }
            public string Radio3 { get; set; }
            public int Answer { get; set; }
        }

        void start()
        {
            
            try
            {
               
               

                quection_count = 0;
                balls = 0;

                wrong_answer = 0;


                array = new string[100];
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка");
            }
            Question();
            
        }
        void Question()
        {

            QuestionItem questionItem = questions[quection_count];
            
            label1.Text = questionItem.Question;

            radioButton1.Text = questionItem.Radio1;
            radioButton2.Text = questionItem.Radio2;
            radioButton3.Text = questionItem.Radio3;

            prav_otvet = questionItem.Answer;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            NextQuestions.Enabled = false;
            quection_count = quection_count + 1;

            if (quection_count == result.Count) NextQuestions.Text = "Завершить";
        }
        void Switching(object sender, EventArgs e)
        {
            NextQuestions.Enabled = true;
            NextQuestions.Focus();
            RadioButton Switch = (RadioButton)sender;
            var tmp = Switch.Name;

            select = int.Parse(tmp.Substring(11));
        }
        public Testmode(Discipline discipline)
        {
            InitializeComponent();

            test = discipline.File;

            questions = ReadTestFile(test).ToList();

            string name = File.ReadAllLines(discipline.File).First();
            this.Text = name;

            this.BackgroundImage = Image.FromFile(discipline.Image);
            this.BackColor = ColorTranslator.FromHtml(discipline.BackGround);
            NextQuestions.BackColor = ColorTranslator.FromHtml(discipline.BackColorBtn);
            CloseBtn.BackColor = ColorTranslator.FromHtml(discipline.BackColorBtn);

            QuectionNumber.Text = $"{1}/{result.Count}";
        }

        private IEnumerable<QuestionItem> ReadTestFile(string testFile)
        {

            var lines = File.ReadAllLines(testFile).Skip(1).ToList();
            for (int i = 0; i < lines.Count; i += 5)
            {
                int offset = i * 5;
                var question = new QuestionItem();

                question.Question = lines[i];
                question.Radio1 = lines[i + 1];
                question.Radio2 = lines[i + 2];
                question.Radio3 = lines[i + 3];
                question.Answer = int.TryParse(lines[i + 4], out int answer) ? answer : 0;

                result.Add(question);
            }
            return result;
        }

        private void Testmode_Load(object sender, EventArgs e)
        {
            NextQuestions.Enabled = false;

            radioButton1.CheckedChanged += new EventHandler(Switching);
            radioButton2.CheckedChanged += new EventHandler(Switching);
            radioButton3.CheckedChanged += new EventHandler(Switching);
            start();

        }

        private void Testmode_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnForm.Show();

        }
        
        private void NextQuestions_Click(object sender, EventArgs e)
        {
            int number = quection_count + 1;

            if (select == prav_otvet) balls = balls + 1;
            if (select != prav_otvet)
            {
                MessageBox.Show("Ответ неверный","Внимание!");

                wrong_answer = wrong_answer + 1;
                array[wrong_answer] = QuectionNumber.Text + ". " + label1.Text;
            }
           if (NextQuestions.Text == "Завершить")
            {
                
                NextQuestions.Visible = false;

                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                QuectionNumber.Visible = false;

                label1.Text = $"Вы завершили тестирование.\nПравильных ответов: {balls} из {quection_count}";

                var str = "Список вопросов, в которых была допущена ошибка " + ":\n\n";
                for (int i = 1; i <= wrong_answer; i++)
                    str = str + array[i] + "\n\n";
                if (wrong_answer != 0) MessageBox.Show(str, "Тестирование звершено");
            }

            if (NextQuestions.Text == "Следующий вопрос")
            {
                Question();

                QuectionNumber.Text = $"{number}/{result.Count}";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnForm.Show();
        }
    }
}
