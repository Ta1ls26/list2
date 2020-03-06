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



namespace FileList2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string lastpath;                                                 //Общая переменная текущего пути
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void metroButton2_Click(object sender, EventArgs e)                         //кнопка Next
        {
            listBox1.Items.Clear();
                DirectoryInfo pathnow = new DirectoryInfo(metroTextBox1.Text);
                DirectoryInfo[] pathfiles = pathnow.GetDirectories();
                FileInfo[] pathfiles2 = pathnow.GetFiles();
                foreach (DirectoryInfo aww in pathfiles)
                    listBox1.Items.Add(aww);
                foreach (FileInfo aff in pathfiles2)
                    listBox1.Items.Add(aff);
            lastpath = metroTextBox1.Text;
        }


        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)              //выбор следущей папки
        { string lastpath2 = listBox1.Text;
            metroTextBox1.Text = lastpath + lastpath2 + @"\";
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text.Remove(metroTextBox1.Text.Length-1,1);
           string alfminus = metroTextBox1.Text[metroTextBox1.Text.Length-2].ToString();   // объявляем для образования в string
            while (alfminus != @"\")
            {
                metroTextBox1.Text = metroTextBox1.Text.Remove(metroTextBox1.Text.Length-1, 1);         //удаление по каждому символу
                alfminus = metroTextBox1.Text[metroTextBox1.Text.Length-1].ToString();
            };
            {
                listBox1.Items.Clear();
                DirectoryInfo pathnow = new DirectoryInfo(metroTextBox1.Text);
                DirectoryInfo[] pathfiles = pathnow.GetDirectories();                   //все папки
                FileInfo[] pathfiles2 = pathnow.GetFiles();                             //все файлы
                foreach (DirectoryInfo aww in pathfiles)                                //вывод папок
                    listBox1.Items.Add(aww);
                foreach (FileInfo aff in pathfiles2)                                    //вывод файлов
                    listBox1.Items.Add(aff);
                lastpath = metroTextBox1.Text;                                          //Изменение глобальной переменной
            }
         
        }
           
        }
    }
