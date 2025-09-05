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

        public static implicit operator MenuInicial(NivelDificil v)
        {
            throw new NotImplementedException();
        }
    }
}
