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
    public partial class EqualsForm : Form
    {
        public EqualsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComplexNumber first = new ComplexNumber(textBox1.Text);
            ComplexNumber second = new ComplexNumber(textBox2.Text);
            if(first == second)
            {
                MessageBox.Show($"{first.ToString()} == {second.ToString()}");
            }
            else
            {
                MessageBox.Show($"{first.ToString()} != {second.ToString()}");
            }
            this.Close();
        }
    }
}
