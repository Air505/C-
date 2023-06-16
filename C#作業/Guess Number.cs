using System;
using System.Windows.Forms;

namespace C_作業
{
    public partial class Guess_Number : Form
    {
        private Random random;
        private int password;
        private int min;
        private int max;

        public Guess_Number()
        {
            InitializeComponent();
            random = new Random();
            min = 1;
            max = 100;
            password = random.Next(min + 1, max);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                int number = 0;
                string input = Microsoft.VisualBasic.Interaction.InputBox("Please input a number.",
                    "Guess", "0");

                if (int.TryParse(input, out number))
                {
                    if (number < min || number >= max)
                    {
                        MessageBox.Show("Invalid input! Try a number between " + (min + 1) + " and " + (max - 1));
                    }
                    else if (number == password)
                    {
                        MessageBox.Show("Bingo! You guessed the correct number!");
                        break;
                    }
                    else if (number < password)
                    {
                        min = number;
                        label1.Text = "Too small! Try a number between " + (min + 1) + " and " + max;
                    }
                    else if (number > password)
                    {
                        max = number;
                        label1.Text = "Too large! Try a number between " + min + " and " + (max - 1);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input! Try a number between " + (min + 1) + " and " + (max - 1));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string answer = password.ToString();
            MessageBox.Show("Answer: " + answer);
        }
    }
}
