using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class NivelFacil : Form
    {
        List<string> words = new List<string>()
        {
            "Terra", "Cachorro", "Flor", "Peixe", "Gato",
            "Cadeira", "Copo", "Árvore", "Fogo", "Chuva"
        };

        string scrambledWord;
        int currentIndex = 0;
        int guessed = 0;

        public NivelFacil()
        {
            InitializeComponent();
            SetupWord();
        }

        private void SetupWord()
        {
            scrambledWord = ScrambleWord(words[currentIndex]);
            lblWord.Text = scrambledWord;
            lblInfo.Text = $"Palavra {currentIndex + 1} de {words.Count}";
            lblGuessed.Text = $"Erros: {guessed}";
        }

        private string ScrambleWord(string word)
        {
            if (word.Length <= 1) return word;

            var letters = word.ToCharArray();
            var random = new Random();
            letters = letters.OrderBy(x => random.Next()).ToArray();

            return new string(letters);
        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string answer = textBox1.Text.Trim();

                if (answer.Equals(words[currentIndex], StringComparison.OrdinalIgnoreCase))
                {
                    if (currentIndex < words.Count - 1)
                    {
                        MessageBox.Show("Correto!", "Fácil Says:");
                        textBox1.Text = "";
                        currentIndex++;
                        guessed = 0;
                        SetupWord();
                    }
                    else
                    {
                        lblWord.Text = "Você venceu!";
                        return;
                    }
                }
                else
                {
                    guessed++;
                    lblGuessed.Text = $"Erros: {guessed}";
                }

                e.Handled = true;
            }
            if (guessed == 3)
            {
                MessageBox.Show("Você Perdeu!");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentWord = words[currentIndex];
            char firstLetter = currentWord[0];
            char lastLetter = currentWord[currentWord.Length - 1];
            string message = $"DICA!!\nPrimeira letra: {firstLetter}!\nÚltima letra: {lastLetter}!";
            MessageBox.Show(message, "Dica");
        }
    }
}
