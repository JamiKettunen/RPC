using System;
using System.Windows.Forms;
using RandomPassCreator.Properties;

namespace RandomPassCreator
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            tbGeneratedPassword.Text = "";

            string generatedPass = GeneratePassword();
            tbGeneratedPassword.Text = generatedPass;
        }

        private string GeneratePassword()
        {
            string tmp = "";

            /* Create each char by looping */
            for (int i = 0; i < valPassLen.Value; i++)
            {
                int chanceForSpecialChar = rnd.Next(1, 8);
                int chanceForNumber = rnd.Next(1, 5);
                int chanceForUppercaseAlphabet = rnd.Next(1, 3);

                if(chkSpecialChars.Checked && chanceForSpecialChar == 1)
                {
                    /* Generate special char */
                    tmp += GenerateChar(Resources.special_chars);
                }
                else if(chkNumbers.Checked && chanceForNumber == 1)
                {
                    /* Generate number */
                    tmp += GenerateChar(Resources.numbers);
                }
                else if(chkUppercaseAlphabets.Checked && chanceForUppercaseAlphabet == 1)
                {
                    /* Generate uppercase letters */
                    tmp += GenerateChar(Resources.uppercase_alphabets);
                }
                else
                {
                    /* Generate lowercase letters */
                    tmp += GenerateChar(Resources.lowercase_alphabets);
                }
            }

            Console.WriteLine();

            return tmp;
        }

        private char GenerateChar(string contents)
        {
            string[] splitUp = contents.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int idx = rnd.Next(0, splitUp.Length);

            Console.Write(splitUp[idx]);
            return char.Parse(splitUp[idx]);
        }
    }
}
