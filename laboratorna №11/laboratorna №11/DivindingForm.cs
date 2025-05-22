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
    public partial class DivindingForm : Form
    {
        public DivindingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            try
            {
                ComplexNumber first = new ComplexNumber(textBox1.Text);
                ComplexNumber second = new ComplexNumber(textBox2.Text);

                textBox3.Text = (first / second).ToString();
            }
            catch(Exception ex)
            {
                label6.Visible = true;
                label6.Text = ex.Message;
            }
        }
    }
}
