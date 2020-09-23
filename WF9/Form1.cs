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

namespace WF9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lihg = Convert.ToInt32(textBox1.Text);
            string file = File.ReadAllText(@"C:\Users\egora\Desktop\Текст.txt");
            file = file.Replace(".", "");
            string[] person = file.Split(' ');
            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].Length == lihg)
                {
                    textBox2.Text += person[i] + Environment.NewLine;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lihg = Convert.ToInt32(textBox3.Text);
            string file = File.ReadAllText(@"C:\Users\egora\Desktop\Текст.txt");
            file = file.Replace(".", "");
            string[] person = file.Split(' ');
            var SW = new StreamWriter(@"C:\Users\egora\Desktop\Файл записи.txt", true);
            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].Length > lihg)
                {
                    SW.WriteLine(person[i]);

                }
            }
            SW.Close();
        }
    }
}
