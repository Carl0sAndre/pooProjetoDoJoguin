namespace Butterfly_Catching_Game_MOO_ICT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameWindow game = new GameWindow();
            game.Show();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Escreva as regras aqui!!");
        }
    }
}