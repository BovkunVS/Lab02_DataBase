using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Lab02
{
    public partial class MainForm : Form
    {
        private List<Student> _listStudent;
        private List<Teachers> _listTeacher;

        public MainForm()
        {
            InitializeComponent();
            _listStudent = new List<Student>();
            _listTeacher = new List<Teachers>();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("See you soon!", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // Отмена пир закрытии формы
            }
        }

        private void loadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] linesStudent = File.ReadAllLines(@"list.txt");
                // StLastName, StFirstName, Grade, Classroom, Bus
                // COOKUS,XUAN ,3 ,107,52
                string[] linesTeacher = File.ReadAllLines(@"teachers.txt");
                // TLastName,TFirstName,Classroom
                // FAFARD,ROCIO,107

                foreach (string line in linesStudent)
                {
                    string[] dataStudent = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    Student student = new Student()
                    {
                        StLastName = dataStudent[0],
                        StFirstName = dataStudent[1],
                        Grade = int.Parse(dataStudent[2]),
                        Classroom = int.Parse(dataStudent[3]),
                        Bus = int.Parse(dataStudent[4]),
                    };
                    _listStudent.Add(student);
                }

                foreach (string line in linesTeacher)
                {
                    string[] dataTeacher = line.Split(new char[] { ',' }, StringSplitOptions.TrimEntries);//удаление пробелов!

                    Teachers teacher = new Teachers()
                    {
                        TLastName = dataTeacher[0],
                        TFirstName = dataTeacher[1],
                        Classroom = int.Parse(dataTeacher[2]),
                    };
                    _listTeacher.Add(teacher);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            statusStrip1.Items[1].Text = (_listStudent.Count + _listTeacher.Count).ToString();
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //класс Stopwatch для отсчета времениLIBRANDI
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера

            foreach (var item in _listStudent)
            {
                var stSurname = tb1Surname.Text.Trim();
                if (item.StLastName == stSurname)
                {
                    rtbResult.Text += item.ToStringStudentClassTeacher();
                    foreach (var item1 in _listTeacher)
                    {
                        if (item1.Classroom == item.Classroom)
                        {
                            rtbResult.Text += item1.ToStringStudentClassTeacher();
                            break;
                        }
                    }
                }
            }

            stopwatch.Stop(); //остановка таймер
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Час виконання пошуку: " + elapsedMilliseconds + "мс.", "Інформація щодо часу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера

            foreach (var item in _listStudent)
            {
                var stSurname = tb2Surname.Text.Trim();
                if (item.StLastName == stSurname)
                {
                    rtbResult.Text += item.ToStringStudentBus();
                }
                if (stopwatch.Elapsed.TotalMinutes >= 2)
                {
                    //достигнуто 2 минут - всплывает окно с сообщением
                    MessageBox.Show("Час очікування перевищив 2 хв.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            stopwatch.Stop(); //остановка таймер
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Час виконання пошуку: {elapsedMilliseconds} мс.", "Інформація щодо часу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера

            int count = 0;

            var tSurname = tb3Surname.Text.Trim();
            var tName = tbName.Text.Trim();

            foreach (var item in _listTeacher)
            {
                if (item.TLastName == tSurname && item.TFirstName == tName)
                {

                    foreach (var item1 in _listStudent)
                    {
                        if (item1.Classroom == item.Classroom)
                        {
                            count++;
                            rtbResult.Text += count + " ";
                            rtbResult.Text += item1.ToStringTeacherStudents();
                        }
                    }
                }
            }
            stopwatch.Stop(); //остановка таймер
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Час виконання пошуку: {elapsedMilliseconds} мс.", "Інформація щодо часу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void task4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера

            int count = 0;

            foreach (var item in _listStudent)
            {
                int stBus = Convert.ToInt32(tbNumberBus.Text.Trim());
                if (item.Bus == stBus)
                {
                    count++;
                    rtbResult.Text += count + " ";
                    rtbResult.Text += item.ToStringBusStudent();
                }
            }
            stopwatch.Stop(); //остановка таймер
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Час виконання пошуку: {elapsedMilliseconds} мс.", "Інформація щодо часу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void task5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера

            int count = 0;

            foreach (var item in _listStudent)
            {
                int stGrade = Convert.ToInt32(tbNumberGrade.Text.Trim());
                if (item.Grade == stGrade)
                {
                    count++;
                    rtbResult.Text += count + " ";
                    rtbResult.Text += item.ToStringStudentGrade();
                }
            }
            stopwatch.Stop(); //остановка таймер
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Час виконання пошуку: {elapsedMilliseconds} мс.", "Інформація щодо часу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void task6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера

            int count = 0;

            foreach (var item in _listStudent)
            {
                int stClassroom = Convert.ToInt32(tbNumberClassroom.Text.Trim());
                if (item.Classroom == stClassroom)
                {
                    count++;
                    rtbResult.Text += count + " ";
                    rtbResult.Text += item.ToStringStudentClassroom();
                }
            }
            stopwatch.Stop(); //остановка таймер
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Час виконання пошуку: {elapsedMilliseconds} мс.", "Інформація щодо часу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void task7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера

            int count = 0;

            foreach (var item in _listTeacher)
            {
                int tClassroom = Convert.ToInt32(tb1NumberClassroom.Text.Trim());
                if (item.Classroom == tClassroom)
                {
                    count++;
                    rtbResult.Text += count + " ";
                    rtbResult.Text += item.ToStringTeacherClassroom();
                }
            }
            stopwatch.Stop(); //остановка таймер
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Час виконання пошуку: {elapsedMilliseconds} мс.", "Інформація щодо часу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void task8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            //объект Stopwatch для отсчета времени
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск таймера

            int count = 0;

            int stGrade = Convert.ToInt32(tb1NumberGrade.Text.Trim());

            foreach (var item in _listStudent)
            {
                if (item.Grade == stGrade)
                {
                    foreach (var item1 in _listTeacher)
                    {
                        if (item1.Classroom == item.Classroom)
                        {
                            count++;
                            rtbResult.Text += count + " ";
                            rtbResult.Text += item1.ToStringTeacherGrade();
                        }
                    }
                }
            }
            stopwatch.Stop(); //остановка таймер
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            if (rtbResult.Text == "")
            {
                MessageBox.Show("Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Час виконання пошуку: {elapsedMilliseconds} мс.", "Інформація щодо часу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}