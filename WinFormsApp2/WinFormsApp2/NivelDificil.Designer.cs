namespace WinFormsApp2
{
    partial class NivelDificil
    {
        private Label lblWord;
        private TextBox textBox1;
        private Label lblInfo;
        private Label lblGuessed;

        private void InitializeComponent()
        {
            lblWord = new Label();
            textBox1 = new TextBox();
            lblInfo = new Label();
            lblGuessed = new Label();
            SuspendLayout();
            // 
            lblWord.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWord.ForeColor = Color.White;
            lblWord.Location = new Point(57, 67);
            lblWord.Size = new Size(800, 80);
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(229, 200);
            textBox1.Size = new Size(457, 52);
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += KeyIsPressed;
            // 
            lblInfo.Font = new Font("Segoe UI", 16F);
            lblInfo.ForeColor = Color.LightCyan;
            lblInfo.Location = new Point(57, 307);
            lblInfo.Size = new Size(800, 53);
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            lblGuessed.Font = new Font("Segoe UI", 16F);
            lblGuessed.ForeColor = Color.Yellow;
            lblGuessed.Location = new Point(57, 373);
            lblGuessed.Size = new Size(800, 53);
            lblGuessed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            ClientSize = new Size(914, 600);
            Controls.Add(lblGuessed);
            Controls.Add(lblInfo);
            Controls.Add(textBox1);
            Controls.Add(lblWord);
            BackColor = Color.DimGray;
            Text = "Modo Difícil";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
