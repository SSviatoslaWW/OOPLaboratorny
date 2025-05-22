using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorna__14
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        private void searchPersonWhichStayMoreThanOneHours(GuestBook guestBook)
        {
            richTextBox1.Text = "";
            foreach(GuestRecord guest in guestBook)
            {
                if (guest.stayMoreThanOneHours())
                {
                    richTextBox1.Text += guest.ToString() + "\n";
                }
            }
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            GuestBook guestBook = new GuestBook();
            GuestBook guestBook1 = new GuestBook();
            createGuesrBook(guestBook);
            guestBook.SaveToFile("MyFile.txt");
            richTextBox4.Text = guestBook.dispalyGuestsBook();
            guestBook.sortedByRoomNumber();
            richTextBox3.Text = guestBook.dispalyGuestsBook();
            searchPersonWhichStayMoreThanOneHours(guestBook);
            guestBook1.LoadFromFile("MyFile.txt");
            richTextBox2.Text = guestBook1.dispalyGuestsBook();
        }

        private void createGuesrBook(GuestBook guestBook)
        {
            guestBook.addGuest(new GuestRecord("Петренюк Сергій Степанови", new DateTime(2025, 5, 20, 17, 25,0),
                                                                            new DateTime(2025, 6, 10, 13, 55, 0), 3));

            guestBook.addGuest(new GuestRecord("Степаненко Петро Андрійович", new DateTime(2025, 8, 20, 17, 25, 0),
                                                                            new DateTime(2025, 8, 20, 17, 45, 0), 1));

            guestBook.addGuest(new GuestRecord("Варяж Микола Дмитрович", new DateTime(2025, 10, 8, 17, 15, 0),
                                                                            new DateTime(2025, 10, 10, 13, 0, 0), 7));

        }
    }
}
