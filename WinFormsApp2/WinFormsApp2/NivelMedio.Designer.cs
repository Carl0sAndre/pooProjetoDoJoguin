namespace WinFormsApp2
{
    partial class NivelMedio
    {
        private Label lblWord;
        private TextBox textBox1;
        private Label lblInfo;
        private Label lblGuessed;
        private Button button1;

        private void InitializeComponent()
        {
            lblWord = new Label();
            textBox1 = new TextBox();
            lblInfo = new Label();
            lblGuessed = new Label();
            button1 = new Button();
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
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(796, 547);
            button1.Size = new Size(106, 41);
            button1.Text = "DICA!!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(lblGuessed);
            Controls.Add(lblInfo);
            Controls.Add(textBox1);
            Controls.Add(lblWord);
            BackColor = Color.DimGray;
            Text = "Modo Médio";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
