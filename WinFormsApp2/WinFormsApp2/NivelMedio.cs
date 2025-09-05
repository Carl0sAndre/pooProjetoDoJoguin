using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class NivelMedio : Form
    {
        List<string> words = new List<string>()
        {
            "Casa", "Carro", "Computador", "Janela", "Escola",
            "Relogio", "Telefone", "Montanha", "Livro", "Chocolate"
        };

        string scrambledWord;
        int currentIndex = 0;
        int guessed = 0;

        public NivelMedio()
        {
            InitializeComponent();
            SetupWord();
        }

        private void SetupWord()
        {
            scrambledWord = ScrambleWithFirstLetter(words[currentIndex]);
            lblWord.Text = scrambledWord;
            lblInfo.Text = $"Palavra {currentIndex + 1} de {words.Count}";
            lblGuessed.Text = $"Erros: {guessed}";
        }

        private string ScrambleWithFirstLetter(string word)
        {
            if (word.Length <= 1) return word;

            char firstLetter = word[0];
            var rest = word.Substring(1).ToCharArray();
            var random = new Random();
            rest = rest.OrderBy(x => random.Next()).ToArray();

            // Coloca a primeira letra na posição correta
            return firstLetter + new string(rest);
        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string answer = textBox1.Text.Trim();

                if (answer.Equals(words[currentIndex], StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Correto!", "Média Says:");
                    currentIndex++;
                    guessed = 0;
                    textBox1.Text = "";

                    if (currentIndex >= words.Count)
                    {
                        lblWord.Text = "Você venceu!";
                        return;
                    }

                    SetupWord();
                }
                else
                {
                    guessed++;
                    lblGuessed.Text = $"Erros: {guessed}";
                }

                e.Handled = true;
            }
        }
    }
}
