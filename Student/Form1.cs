using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Students : Form
    {
        string text = "";
        string studentname = "";
        int studentage = 0;
        string studentschool = "";
        int studentgrade = 0;
        public Students()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            studentname = textBox1.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox5.Text, out studentage))
            {
                studentage = studentage;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            studentschool = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           if(Int32.TryParse(textBox3.Text, out studentgrade))
            {
                studentgrade = studentgrade;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student1 = new Student(studentname, studentage, studentschool, studentgrade);
            text += (student1.ReturnInfo() + "\n");
            textBox2.Text = text;
            ClearAll();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void ClearAll()
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox5.Clear();
        }
    }
}
