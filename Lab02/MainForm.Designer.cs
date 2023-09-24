﻿using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab02
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadingToolStripMenuItem = new ToolStripMenuItem();
            task1ToolStripMenuItem = new ToolStripMenuItem();
            task2ToolStripMenuItem = new ToolStripMenuItem();
            task3ToolStripMenuItem = new ToolStripMenuItem();
            task4ToolStripMenuItem = new ToolStripMenuItem();
            task5ToolStripMenuItem = new ToolStripMenuItem();
            task6ToolStripMenuItem = new ToolStripMenuItem();
            task7ToolStripMenuItem = new ToolStripMenuItem();
            task8ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusNumber = new ToolStripStatusLabel();
            rtbResult = new RichTextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            tb1Surname = new TextBox();
            groupBox2 = new GroupBox();
            tb2Surname = new TextBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            tbName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tb3Surname = new TextBox();
            groupBox5 = new GroupBox();
            tbNumberGrade = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            tbNumberBus = new TextBox();
            label6 = new Label();
            groupBox6 = new GroupBox();
            tbNumberClassroom = new TextBox();
            label7 = new Label();
            groupBox7 = new GroupBox();
            tb1NumberClassroom = new TextBox();
            label8 = new Label();
            groupBox8 = new GroupBox();
            tb1NumberGrade = new TextBox();
            label9 = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1041, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = SystemColors.Control;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadingToolStripMenuItem, task1ToolStripMenuItem, task2ToolStripMenuItem, task3ToolStripMenuItem, task4ToolStripMenuItem, task5ToolStripMenuItem, task6ToolStripMenuItem, task7ToolStripMenuItem, task8ToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(49, 25);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadingToolStripMenuItem
            // 
            loadingToolStripMenuItem.Name = "loadingToolStripMenuItem";
            loadingToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            loadingToolStripMenuItem.Size = new Size(606, 26);
            loadingToolStripMenuItem.Text = "Loading";
            loadingToolStripMenuItem.Click += loadingToolStripMenuItem_Click;
            // 
            // task1ToolStripMenuItem
            // 
            task1ToolStripMenuItem.Name = "task1ToolStripMenuItem";
            task1ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D1;
            task1ToolStripMenuItem.Size = new Size(606, 26);
            task1ToolStripMenuItem.Text = "Task 1: Знайти клас студента та його викладача";
            task1ToolStripMenuItem.Click += task1ToolStripMenuItem_Click;
            // 
            // task2ToolStripMenuItem
            // 
            task2ToolStripMenuItem.Name = "task2ToolStripMenuItem";
            task2ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D2;
            task2ToolStripMenuItem.Size = new Size(606, 26);
            task2ToolStripMenuItem.Text = "Task 2: Знайти автобусний маршрут, яким їде студент";
            task2ToolStripMenuItem.Click += task2ToolStripMenuItem_Click;
            // 
            // task3ToolStripMenuItem
            // 
            task3ToolStripMenuItem.Name = "task3ToolStripMenuItem";
            task3ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D3;
            task3ToolStripMenuItem.Size = new Size(606, 26);
            task3ToolStripMenuItem.Text = "Task 3: Знайти список студентів за викладачем";
            task3ToolStripMenuItem.Click += task3ToolStripMenuItem_Click;
            // 
            // task4ToolStripMenuItem
            // 
            task4ToolStripMenuItem.Name = "task4ToolStripMenuItem";
            task4ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D4;
            task4ToolStripMenuItem.Size = new Size(606, 26);
            task4ToolStripMenuItem.Text = "Task 4: Знайти студентів за автобусним маршрутом";
            task4ToolStripMenuItem.Click += task4ToolStripMenuItem_Click;
            // 
            // task5ToolStripMenuItem
            // 
            task5ToolStripMenuItem.Name = "task5ToolStripMenuItem";
            task5ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D5;
            task5ToolStripMenuItem.Size = new Size(606, 26);
            task5ToolStripMenuItem.Text = "Task 5: Знайти студентів за рівнем класу";
            task5ToolStripMenuItem.Click += task5ToolStripMenuItem_Click;
            // 
            // task6ToolStripMenuItem
            // 
            task6ToolStripMenuItem.Name = "task6ToolStripMenuItem";
            task6ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D6;
            task6ToolStripMenuItem.Size = new Size(606, 26);
            task6ToolStripMenuItem.Text = "Task 6: Знайти студентів за класною кімнатою";
            task6ToolStripMenuItem.Click += task6ToolStripMenuItem_Click;
            // 
            // task7ToolStripMenuItem
            // 
            task7ToolStripMenuItem.Name = "task7ToolStripMenuItem";
            task7ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D7;
            task7ToolStripMenuItem.Size = new Size(606, 26);
            task7ToolStripMenuItem.Text = "Task 7: Знайти викладачів за класною кімнатою";
            task7ToolStripMenuItem.Click += task7ToolStripMenuItem_Click;
            // 
            // task8ToolStripMenuItem
            // 
            task8ToolStripMenuItem.Name = "task8ToolStripMenuItem";
            task8ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D8;
            task8ToolStripMenuItem.Size = new Size(606, 26);
            task8ToolStripMenuItem.Text = "Task 8: Знайти викладачів за деякою оцінкою";
            task8ToolStripMenuItem.Click += task8ToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusNumber });
            statusStrip1.Location = new Point(0, 798);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1041, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(80, 20);
            toolStripStatusLabel1.Text = "Line count:";
            // 
            // toolStripStatusNumber
            // 
            toolStripStatusNumber.Name = "toolStripStatusNumber";
            toolStripStatusNumber.Size = new Size(60, 20);
            toolStripStatusNumber.Text = "number";
            // 
            // rtbResult
            // 
            rtbResult.BackColor = SystemColors.InactiveCaption;
            rtbResult.Dock = DockStyle.Right;
            rtbResult.Font = new Font("Ink Free", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rtbResult.Location = new Point(461, 29);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(580, 769);
            rtbResult.TabIndex = 2;
            rtbResult.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb1Surname);
            groupBox1.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 83);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 37);
            label1.Name = "label1";
            label1.Size = new Size(184, 18);
            label1.TabIndex = 1;
            label1.Text = "Enter student's last name";
            // 
            // tb1Surname
            // 
            tb1Surname.Location = new Point(200, 34);
            tb1Surname.Name = "tb1Surname";
            tb1Surname.Size = new Size(182, 25);
            tb1Surname.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSlateGray;
            groupBox2.Controls.Add(tb2Surname);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(443, 83);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task 2";
            // 
            // tb2Surname
            // 
            tb2Surname.Location = new Point(200, 34);
            tb2Surname.Name = "tb2Surname";
            tb2Surname.Size = new Size(182, 25);
            tb2Surname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 37);
            label2.Name = "label2";
            label2.Size = new Size(184, 18);
            label2.TabIndex = 0;
            label2.Text = "Enter student's last name";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.DarkSeaGreen;
            groupBox4.Controls.Add(tbName);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(tb3Surname);
            groupBox4.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(12, 209);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(443, 129);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Task 3";
            // 
            // tbName
            // 
            tbName.Location = new Point(200, 82);
            tbName.Name = "tbName";
            tbName.Size = new Size(182, 25);
            tbName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 85);
            label4.Name = "label4";
            label4.Size = new Size(175, 17);
            label4.TabIndex = 2;
            label4.Text = "Enter teacher's first name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 37);
            label3.Name = "label3";
            label3.Size = new Size(176, 17);
            label3.TabIndex = 1;
            label3.Text = "Enter teacher's last name";
            // 
            // tb3Surname
            // 
            tb3Surname.Location = new Point(200, 34);
            tb3Surname.Name = "tb3Surname";
            tb3Surname.Size = new Size(182, 25);
            tb3Surname.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.DarkSeaGreen;
            groupBox5.Controls.Add(tbNumberGrade);
            groupBox5.Controls.Add(label5);
            groupBox5.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(12, 434);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(443, 83);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Task 5";
            // 
            // tbNumberGrade
            // 
            tbNumberGrade.Location = new Point(200, 34);
            tbNumberGrade.Name = "tbNumberGrade";
            tbNumberGrade.Size = new Size(182, 25);
            tbNumberGrade.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 37);
            label5.Name = "label5";
            label5.Size = new Size(149, 18);
            label5.TabIndex = 0;
            label5.Text = "Enter student grade";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightSlateGray;
            groupBox3.Controls.Add(tbNumberBus);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 345);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(443, 83);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Task 4";
            // 
            // tbNumberBus
            // 
            tbNumberBus.Location = new Point(200, 34);
            tbNumberBus.Name = "tbNumberBus";
            tbNumberBus.Size = new Size(182, 25);
            tbNumberBus.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 37);
            label6.Name = "label6";
            label6.Size = new Size(176, 18);
            label6.TabIndex = 0;
            label6.Text = "Enter bus route number";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.LightSlateGray;
            groupBox6.Controls.Add(tbNumberClassroom);
            groupBox6.Controls.Add(label7);
            groupBox6.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(12, 523);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(443, 83);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Task 6";
            // 
            // tbNumberClassroom
            // 
            tbNumberClassroom.Location = new Point(200, 34);
            tbNumberClassroom.Name = "tbNumberClassroom";
            tbNumberClassroom.Size = new Size(182, 25);
            tbNumberClassroom.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 37);
            label7.Name = "label7";
            label7.Size = new Size(145, 18);
            label7.TabIndex = 0;
            label7.Text = "Enter class number";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.DarkSeaGreen;
            groupBox7.Controls.Add(tb1NumberClassroom);
            groupBox7.Controls.Add(label8);
            groupBox7.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(12, 612);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(443, 83);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Task 7";
            // 
            // tb1NumberClassroom
            // 
            tb1NumberClassroom.Location = new Point(200, 34);
            tb1NumberClassroom.Name = "tb1NumberClassroom";
            tb1NumberClassroom.Size = new Size(182, 25);
            tb1NumberClassroom.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 37);
            label8.Name = "label8";
            label8.Size = new Size(145, 18);
            label8.TabIndex = 0;
            label8.Text = "Enter class number";
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.LightSlateGray;
            groupBox8.Controls.Add(tb1NumberGrade);
            groupBox8.Controls.Add(label9);
            groupBox8.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox8.Location = new Point(12, 701);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(443, 83);
            groupBox8.TabIndex = 10;
            groupBox8.TabStop = false;
            groupBox8.Text = "Task 8";
            // 
            // tb1NumberGrade
            // 
            tb1NumberGrade.Location = new Point(200, 34);
            tb1NumberGrade.Name = "tb1NumberGrade";
            tb1NumberGrade.Size = new Size(182, 25);
            tb1NumberGrade.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 37);
            label9.Name = "label9";
            label9.Size = new Size(149, 18);
            label9.TabIndex = 0;
            label9.Text = "Enter student grade";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 824);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(rtbResult);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Task5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Task4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadingToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusNumber;
        private RichTextBox rtbResult;
        private ToolStripMenuItem task1ToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tb1Surname;
        private GroupBox groupBox2;
        private TextBox tb2Surname;
        private Label label2;
        private ToolStripMenuItem task2ToolStripMenuItem;
        private GroupBox groupBox4;
        private TextBox tb3Surname;
        private Label label3;
        private ToolStripMenuItem task3ToolStripMenuItem;
        private TextBox tbName;
        private Label label4;
        private GroupBox groupBox5;
        private TextBox tbNumberGrade;
        private Label label5;
        private ToolStripMenuItem task5ToolStripMenuItem;
        private ToolStripMenuItem task4ToolStripMenuItem;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox tbNumberBus;
        private GroupBox groupBox6;
        private TextBox tbNumberClassroom;
        private Label label7;
        private ToolStripMenuItem task6ToolStripMenuItem;
        private GroupBox groupBox7;
        private TextBox tb1NumberClassroom;
        private Label label8;
        private ToolStripMenuItem task7ToolStripMenuItem;
        private ToolStripMenuItem task8ToolStripMenuItem;
        private GroupBox groupBox8;
        private TextBox tb1NumberGrade;
        private Label label9;
    }
}