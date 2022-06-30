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
using static System.Random;
using System.Data.OleDb;

namespace Тестирование_по_общим_дисциплинам
{
    public partial class Exammode : Form
    {
        string test;

        int quection_count = 0;
        int balls = 0;
        int wrong_answer = 0;

       public List<QuestionItem> questions ;

        List<QuestionItem> result = new List<QuestionItem>();

        string[] array;

        int select;
        int prav_otvet;

        Timer timer = new Timer();

        int timerCounter = 0;
        int timerMinutes = 0;
        
        Random rndGenerator = new Random();

        int index;
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
                myButton11.Text = "Следующий вопрос";



                quection_count = 0;
                balls = 0;
                
                

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
            index = rndGenerator.Next(questions.Count());
            QuestionItem questionItem = questions[index];
            label1.Text = questionItem.Question;

            radioButton1.Text = questionItem.Radio1;
            radioButton2.Text = questionItem.Radio2;
            radioButton3.Text = questionItem.Radio3;
           

            prav_otvet = questionItem.Answer;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            myButton11.Enabled = false;
            quection_count = quection_count + 1;

            questions.Remove(questions[index]);

            if (quection_count >= 15) myButton11.Text = "Завершить";
        }
        void Switching(object sender, EventArgs e)
        {
            myButton11.Enabled = true;
            myButton11.Focus();
            RadioButton Switch = (RadioButton)sender;
            var tmp = Switch.Name;

            select = int.Parse(tmp.Substring(11));
        }
        public Exammode(Discipline discipline)
        {
            InitializeComponent();
            

            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);

            string name = File.ReadAllLines(discipline.File).First();
            this.Text = name;

            test = discipline.File;
            questions = ReadTestFile(test).ToList();

            this.BackgroundImage = Image.FromFile(discipline.Image);
            this.BackColor = ColorTranslator.FromHtml(discipline.BackGround);
            myButton11.BackColor = ColorTranslator.FromHtml(discipline.BackColorBtn);
            Closebtn.BackColor = ColorTranslator.FromHtml(discipline.BackColorBtn);

            QuectionNumber.Text = $"{1}/{15}";
        }
        private IEnumerable<QuestionItem>ReadTestFile(string testFile)
        {
            var lines = File.ReadAllLines(testFile).Skip(1).ToList();
            for(int i=0;i<lines.Count;i+=5)
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

        private void Exammode_Load(object sender, EventArgs e)
        {
            myButton11.Enabled = false;

            radioButton1.CheckedChanged += new EventHandler(Switching);
            radioButton2.CheckedChanged += new EventHandler(Switching);
            radioButton3.CheckedChanged += new EventHandler(Switching);

            start();
            timer.Start();

        }
        
        private void Exammode_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnForm.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Text != "60с")
            {
                this.label2.Text = (++timerCounter).ToString() + "с";
            }
            else
            {
                timerCounter = 0;
                timerMinutes += 1;
                label3.Text = timerMinutes + "м";
                label2.Text = 0 + "с";
            }
            if (label3.Text == "25м")
            {
                timer.Stop();
                myButton11.Text = "Завершить";

                label2.Visible = false;
                label3.Visible = false;
            }
        }

        private void myButton11_Click(object sender, EventArgs e)
        {
            int number = quection_count + 1;

            if (select == prav_otvet) balls = balls + 1;
            if (select != prav_otvet)
            {
                wrong_answer = wrong_answer + 1;

            }
           
            if (myButton11.Text == "Завершить")
            {
                int grade;
                grade = (balls * 100)/quection_count;
                if(grade>=0 && grade <50)
                {
                    grade = 2;
                }
                else if(grade>51 && grade<70)
                {
                    grade = 3;
                }
                else if(grade>71 && grade<85)
                {
                    grade = 4;
                }
                else if(grade>86 && grade<=100)
                {
                    grade = 5;
                }

                myButton11.Visible = false;

                label2.Visible = false;
                label3.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                QuectionNumber.Visible = false;
                groupBox1.Visible = false;

                label1.Text = $"Вы завершили тестирование.\nПравильных ответов: {balls} из {quection_count} = {(balls * 100) / quection_count}%\nВаша оценка: {grade}";
            }

            if (myButton11.Text == "Следующий вопрос")
            {
                Question();

                QuectionNumber.Text = $"{number}/{15}";
            }
        }

        private void myButton12_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnForm.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
