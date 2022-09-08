using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1() //форма создается
        {
            InitializeComponent();

            FindPolly("adada");
        }

        public string FindMyText(string text)
        {            
            string returnValue = (" ");
      
            if (text.Length > 0)
            {
                // Получить расположение строки поиска в richTextBox1.
                int indexToText = gridOfNumbers.Find(text);
                // Определяем, был ли текст найден в richTextBox1.
                if (indexToText >= 0)
                {
                    returnValue = richTextBox1.Text;
                }
            }

            return returnValue;
        }



        private void byFileButton_Click(object sender, EventArgs e)// взятие массива из файла
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = "c:\\";
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;

            var fileContent = string.Empty;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = dialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream)) //считывание из файла 
                {
                    fileContent = reader.ReadToEnd(); //записываем в fileContent
                }

                gridOfNumbers.Text = fileContent;
            }
        }




        private string FindPolly(string word)
        {
            string firstHalf = "";
            string secondHalf = "";

            if (word.Length % 2 == 0)
            {
                for (int i = 0; i < word.Length / 2; i++)
                {
                    firstHalf += word[i];
                }
                for (int i = word.Length - 1; i >= word.Length / 2; i--)
                {
                    secondHalf += word[i];
                }

                if (firstHalf == secondHalf)
                {
                    return word;
                }
            }
            else
            {
                for (int i = 0; i < word.Length / 2; i++)
                {
                    firstHalf += word[i];
                }
                for (int i = word.Length - 1; i > word.Length / 2; i--)
                {
                    secondHalf += word[i];
                }

                if (firstHalf == secondHalf)
                {
                    return word;
                }
            }

            return "";
        }





        private void button1_Click(object sender, EventArgs e)
        {
            string word = richTextBox2.Text;

            string row = gridOfNumbers.Text;

            string[] lol = gridOfNumbers.Text.Split();

            int k = 0;

            for (int i = 0; i < lol.Length; i++)
            {
               
                if (lol[i] == word)
                {
                    k++;
                }

            }

            richTextBox1.Text = k.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";

            string[] lol = gridOfNumbers.Text.Split();

            for (int i = 0; i < lol.Length; i++)
            {
                result += FindPolly(lol[i]) + " ";
            }

            richTextBox1.Text = result;
        }
    }
}