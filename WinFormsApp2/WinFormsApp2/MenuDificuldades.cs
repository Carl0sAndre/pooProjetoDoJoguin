using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MenuDificuldades : Form
    {
        MenuInicial menu_inicial;
        NivelFacil modo_facil;
        NivelMedio modo_medio;
        NivelDificil modo_dificil;
        public MenuDificuldades()
        {
            InitializeComponent();
        }

        public MenuDificuldades(MenuInicial f1)
        {
            InitializeComponent();
            this.menu_inicial = f1;
        }
        public MenuDificuldades(NivelFacil f3)
        {
            InitializeComponent();
            this.modo_facil = f3;
        }
        public MenuDificuldades(NivelMedio f4)
        {
            InitializeComponent();
            this.modo_medio = f4;
        }
        public MenuDificuldades(NivelDificil f5)
        {
            InitializeComponent();
            this.menu_inicial = f5;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu_inicial = new MenuInicial();
            menu_inicial.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modo_facil = new NivelFacil();
            modo_facil.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modo_medio = new NivelMedio();
            modo_medio.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modo_dificil = new NivelDificil();
            modo_dificil.Show();
            this.Hide();
        }
    }
}
