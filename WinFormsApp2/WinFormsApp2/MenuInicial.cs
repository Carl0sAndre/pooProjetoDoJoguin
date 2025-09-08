namespace WinFormsApp2
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuDificuldades niveis_dificuldade = new MenuDificuldades(this);
            niveis_dificuldade.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string regras = "Regras do Jogo - Guess The Word\n\n" +
                            "1. Descubra a palavra embaralhada e digite no campo.\n" +
                            "2. Pressione Enter para confirmar sua resposta.\n" +
                            "3. Cada erro aumenta o contador de erros.\n" +
                            "4. Níveis:\n" +
                            "   - Fácil: dica da primeira e última letra.\n" +
                            "   - Médio: dica apenas da primeira letra.\n" +
                            "   - Difícil: sem dicas.\n" +
                            "5. Acertar todas as palavras vence o nível.\n\n" +
                            "Boa sorte!";
            MessageBox.Show(regras, "Regras do Jogo");
        }

        public static implicit operator MenuInicial(NivelDificil v)
        {
            throw new NotImplementedException();
        }
    }
}
