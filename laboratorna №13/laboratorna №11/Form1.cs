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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void createMyStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateObjectMyString myString = new CreateObjectMyString();
            myString.ShowDialog();
        }

        private void checkEqualsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EqualsForm equalsForm = new EqualsForm();
            equalsForm.ShowDialog();
        }

        private void plusNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlusNumberForm plusNumberForm = new PlusNumberForm();
            plusNumberForm.ShowDialog();
        }

        private void minusNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinusNumberForm minusNumberForm = new MinusNumberForm();
            minusNumberForm.ShowDialog();
        }

        private void multiplicationNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiplicationForm multiplicationForm = new MultiplicationForm();
            multiplicationForm.ShowDialog();
        }

        private void divindingNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DivindingForm divindingForm = new DivindingForm();
            divindingForm.ShowDialog();
        }

        private void resultLab11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultLab12Form resultLab11Form = new resultLab12Form();
            resultLab11Form.ShowDialog();
        }

        private void resultLab13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultLab13 form = new resultLab13();  
            form.ShowDialog();
        }
    }
}
