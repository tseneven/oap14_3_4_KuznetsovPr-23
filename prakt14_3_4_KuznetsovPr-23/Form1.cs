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

namespace prakt14_3_4_KuznetsovPr_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<int> queue = new Queue<int>();
        Queue<string> queueText = new Queue<string>();


        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            string valueQueue = " ";

            if (n != 0 && n>0)
            {

                for (int i = 1; i <= n; i++)
                {
                    queue.Enqueue(i);
                }
                label1.Text = $"n = {n} ";
                label2.Text = $"Размерность стека {n}";
                label3.Text = $"Верхний элемент очереди {queue.Peek()}";
                while(queue.Count != 0) 
                {
                    valueQueue += Convert.ToString(" " + queue.Dequeue()); 
                    n--;
                }
                label4.Text = $"Содержимое очереди{valueQueue}";
                label5.Text = $"Новая размерность {0}";

            }
            else
            {
                MessageBox.Show("Число не может быть меньше 0");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Create("txt1.txt");
            string nameFile = textBox1.Text;

            if(nameFile != " ") 
            {
                if (File.Exists(nameFile))
                {
                    string str = File.ReadAllText(nameFile);
                    string[] strA = str.Split(' '); 
                    for(int i = 0; i<str.Length; i++) 
                    {
                        queueText.Enqueue(strA[i]);
                    }
                }
                else 
                {
                    MessageBox.Show("Такого файла не существет");
                }
            }
            else
            {
                MessageBox.Show("Имя файла не может быть пустым");
            }
        }
    }
}
