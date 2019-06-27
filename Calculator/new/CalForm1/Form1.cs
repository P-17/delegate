using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cal1;

namespace CalForm1
{
    delegate void ArithmaticOperation(int num1, int num2);
    public partial class Form1 : Form
    {
        string foperator = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            Cal1.CalBOL cal = new CalBOL();
            switch (foperator)
            {
                case "+":
                    ArithmaticOperation op1 = new ArithmaticOperation(cal.Add);
                    op1(num1,num2);
                    break;

                case "-":
                    ArithmaticOperation op2 = new ArithmaticOperation(cal.Sub);
                    op2(num1, num2);
                    break;

                case "*":
                    ArithmaticOperation op3 = new ArithmaticOperation(cal.Mul);
                    op3(num1, num2);
                    break;

                case "/":
                    ArithmaticOperation op4 = new ArithmaticOperation(cal.Div);
                    op4(num1, num2);
                    break;
            }
            int result = cal.Result;
            label1.Text=result.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foperator= comboBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
