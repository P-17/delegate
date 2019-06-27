using System;
using System.Windows.Forms;
using Cal1;
namespace CalForm
{
    delegate void ArithmaticOperation(int num1,int num2);
    public partial class Form1 : Form
    {
        string foperator = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
