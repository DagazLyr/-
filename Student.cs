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
    public partial class Student : Form
    {
        public string _predmet;
        public Form ReturnForm;

        public List<Discipline> Disciplines = new List<Discipline>()
        {
            new Discipline("Английский язык - Фазаева", "Английский_язык_Фазаева.txt", "Английский_язык.png","#d64e52","#feae73"),
            new Discipline("Русский язык - Марченко", "Русский_язык_Марченко.txt", "Русский_язык.png","#758ab1","#d4cece"),
            new Discipline("Математика - Либникова", "Математика_Либникова.txt", "Математика.png","#9f9bbc","#ffc145"),
            new Discipline("Математика - Гранд", "Математика_Гранд.txt", "Математика.png ","#9f9bbc","#ffc145"),
            new Discipline("Астрономия - Галка", "Астрономия_Галка.txt", "Астрономия.png","#5c4353","#dab7c7"),
            new Discipline("Литература - Марченко", "Литература_Марченко.txt", "Литература.png","#67917a","#abd2c8"),
            new Discipline("Обществознание - Козлова", "Обществознание_Козлова.txt", "Обществознание.png","#f38894","#ffc145"),
            new Discipline("ОБЖ - Илюзина", "ОБЖ_Илюзина.txt", "ОБЖ.png","#b8b8d1","#ffc145"),
            new Discipline("Химия - Бойко", "Химия_Бойко.txt", "Химия.png","#5b5f97","#b8b8d1"),
            new Discipline("Химия - Гранд", "Химия_Гранд.txt", "Химия.png","#5b5f97","#b8b8d1"),
            new Discipline("Биология - Бойко", "Биология_Бойко.txt", "Биология.png","#41630f","#abca80"),
            new Discipline("Геограифя - Бойко", "География_Бойко.txt", "География.png","#4c7a62","#ffb975"),
            new Discipline("Информатика - Галка", "Информатика_Галка.txt", "Информатика.png","#6d94c4","#abc0df"),
            new Discipline("Информатика - Киров", "Информатика_Киров.txt", "Информатика.png","#6d94c4","#abc0df"),
            new Discipline("Информатика - Терёшин", "Информатика_Терёшин.txt", "Информатика.png","#6d94c4","#abc0df"),
            new Discipline("История - Козлова", "История_Козлова.txt", "История.png","#be867e","#cbc2bb"),
            new Discipline("Физика - Гранд", "Физика_Гранд.txt", "Физика.png","#a087bc","#ffc145")
        };
        
        public Student()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = 0;
        }
       
        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnForm.Show();
        }

        private void TestModBtn_Click(object sender, EventArgs e)
        {
            Discipline discipline = Disciplines[comboBox1.SelectedIndex];
            
             new Testmode(discipline) { ReturnForm = this }.Show();
            this.Hide();
        }

        private void ExamModBtn_Click(object sender, EventArgs e)
        {

            Discipline discipline = Disciplines[comboBox1.SelectedIndex];
            
            new Exammode(discipline) { ReturnForm = this }.Show();
            this.Hide();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дорогой студент, обрати внимание, что возможности вернуться на вопрос назад нет. Потому внимательно читай вопрос и обдумывай его. У тебя одна попытка ответить на вопрос. Также при нажатии на кнопку 'Режим экзамена', начинает иди твоё драгоценное время.\nНа прохождение теста в режиме экзамена даётся 25 минут.\nКритерии оценивания:\n2 = 0 - 50%\n3 = 51 - 70%\n4 = 71 - 85%\n5 = 86 - 100%", "Справка");
        }
    }
}
