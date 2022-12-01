using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int _number;
        private int _counter;
        Random rnd = new Random();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             _number = rnd.Next(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _counter++;
            var choosenNumber = Convert.ToInt32(textBox1.Text);

            if (choosenNumber > _number)
            {
                label1.Text = "Up";
               
            }
            else if (choosenNumber < _number)
            {
                label1.Text = "Down";
            }
            else
            {
                MessageBox.Show($"You guessed the number in {_counter} try");
                _counter = 0;
                _number = rnd.Next(3);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
