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
    public partial class resultLab11Form : Form
    {
        public resultLab11Form()
        {
            InitializeComponent();
        }

        private string printArrayComplexNumber(ComplexNumber[] arrayObject)
        {
            string printValue = "";
            for(int i = 0; i < arrayObject.Length; i++)
            {
                if (arrayObject[i] == null)
                {
                    break;
                }
                else
                {
                    printValue += arrayObject[i].ToString() + "\n";
                }
            }
            return printValue;
        }

        private void resultLab11Form_Load(object sender, EventArgs e)
        {
            ComplexNumber[] arrayObject = new ComplexNumber[10];
            createArrayObject(arrayObject);
            resultRichTextBox.Text = $"Половина масиву: \n{printArrayComplexNumber(arrayObject)}";
            clonableArrayObject(arrayObject);
            resultRichTextBox.Text += $"Весь масив: \n{printArrayComplexNumber(arrayObject)}";
            sortedAarayComplexNumber(arrayObject);
        }

        private void createArrayObject(ComplexNumber[] arrayObject)
        {
            Random random = new Random();

            for(int i = 0; i < arrayObject.Length / 2; i++)
            {
                arrayObject[i] = new ComplexNumber($"{random.Next(-20, 21)}+{random.Next(1, 21)}i");
            }
        }

        private void clonableArrayObject(ComplexNumber[] arrayObject)
        {
            for(int i = arrayObject.Length / 2; i < arrayObject.Length; i++)
            {
                arrayObject[i] = (ComplexNumber)arrayObject[i - arrayObject.Length / 2].Clone();
            }
        }

        private void sortedAarayComplexNumber(ComplexNumber[] arrayObject)
        {
            Array.Sort(arrayObject);
            resultRichTextBox.Text += $"Сортування за зростанням: \n{printArrayComplexNumber(arrayObject)}";
            Array.Reverse(arrayObject);
            resultRichTextBox.Text += $"Сортування за спаданням: \n{printArrayComplexNumber(arrayObject)}";
        }
    }
}
