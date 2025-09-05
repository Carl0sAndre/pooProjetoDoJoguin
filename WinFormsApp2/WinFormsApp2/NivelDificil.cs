using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class NivelDificil : Form
    {
        List<string> words = new List<string>()
        {
            "Computador", "Programacao", "Microfone", "Laboratorio", "Matematica",
            "Eletricidade", "Astronomia", "Geometria", "Cibernetica", "Linguistica",
            "Fotografia", "Quimica", "Filatelia", "Ornitologia", "Hipotese"
        };

        string scrambledWord;
        int currentIndex = 0;
        int guessed = 0;

        public NivelDificil()
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
            var random = new Random();
            return new string(word.ToCharArray().OrderBy(x => random.Next()).ToArray());
        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string answer = textBox1.Text.Trim();

                if (answer.Equals(words[currentIndex], StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Correto!", "Modo Difícil:");
                    currentIndex++;
                    guessed = 0;
                    textBox1.Text = "";

                    if (currentIndex >= words.Count)
                    {
                        lblWord.Text = "Você venceu o modo difícil!";
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
