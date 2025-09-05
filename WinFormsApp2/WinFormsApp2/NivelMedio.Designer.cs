namespace WinFormsApp2
{
    partial class NivelMedio
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWord;
        private TextBox textBox1;
        private Label lblInfo;
        private Label lblGuessed;

        private void InitializeComponent()
        {
            this.lblWord = new Label();
            this.textBox1 = new TextBox();
            this.lblInfo = new Label();
            this.lblGuessed = new Label();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblWord.ForeColor = Color.Green;
            this.lblWord.Location = new Point(50, 50);
            this.lblWord.Size = new Size(700, 60);
            this.lblWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            this.textBox1.Location = new Point(200, 150);
            this.textBox1.Size = new Size(400, 50);
            this.textBox1.KeyPress += new KeyPressEventHandler(this.KeyIsPressed);
            this.textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblInfo.ForeColor = Color.White;
            this.lblInfo.Location = new Point(50, 230);
            this.lblInfo.Size = new Size(700, 40);
            this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGuessed
            // 
            this.lblGuessed.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblGuessed.ForeColor = Color.Red;
            this.lblGuessed.Location = new Point(50, 280);
            this.lblGuessed.Size = new Size(700, 40);
            this.lblGuessed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.BackColor = Color.DimGray;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblGuessed);
            this.Text = "Modo Médio";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
