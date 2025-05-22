using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorna__11
{
    public partial class CreateObjectMyString : Form
    {
        public CreateObjectMyString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyString myString = new MyString(textBox1.Text);
            textBox2.Text = myString.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
