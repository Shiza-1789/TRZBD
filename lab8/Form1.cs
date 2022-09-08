using System;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();

            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 6)
            {
                label1.Text += "\nДоброй ночи";
            }
            else if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                label1.Text += "\nДоброе утро";
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                label1.Text += "\nДобрый день";
            }
            else
            {
                label1.Text += "\nДобрый вечер";
            }
        }


    }
}
