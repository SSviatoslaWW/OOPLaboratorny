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
    public partial class resultLab13 : Form
    {
        public resultLab13()
        {
            InitializeComponent();
        }
        private void createRandomComplexNumber(ComplexNumber[] arrayNumber)
        {
            Random random = new Random();

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = new ComplexNumber($"{random.Next(-20, 21)}+{random.Next(1, 21)}i");
            }
        }

        private void resultLab13_Load(object sender, EventArgs e)
        {
            ComplexCollection myCollection = new ComplexCollection();
            ComplexNumber[] arrayNumber = new ComplexNumber[10];
            createRandomComplexNumber(arrayNumber);
            addObjectInMyCollections(myCollection, arrayNumber);
            printResultForm(myCollection);
        }

        private void addObjectInMyCollections(ComplexCollection myCollection, ComplexNumber[] arrayNumber)
        {
            myCollection.addObjectInCollectionsStack(12);
            myCollection.addObjectInCollectionsStack("Рядок");

            for(int i = 0; i < arrayNumber.Length; i++)
            {
                myCollection.addObjectInCollectionsStack(arrayNumber[i]);
                myCollection.addObjectCollectionsGenericStack(arrayNumber[i]);
            }
        }

        private void printResultForm(ComplexCollection myCollection)
        {
            richTextBox1.Text = myCollection.printCollectionsStack();
            richTextBox2.Text = myCollection.printCollectionsGenericStack();
        }
    }
}
