namespace zad2lab2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDzielna;
        private System.Windows.Forms.TextBox txtDzielnik;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.Button btnDivide;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDzielna = new System.Windows.Forms.TextBox();
            this.txtDzielnik = new System.Windows.Forms.TextBox();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // 
            this.txtDzielna.Location = new System.Drawing.Point(12, 12);
            this.txtDzielna.Name = "txtDzielna";
            this.txtDzielna.Size = new System.Drawing.Size(100, 20);
            this.txtDzielna.TabIndex = 0;
            // 
            // 
            this.txtDzielnik.Location = new System.Drawing.Point(12, 38);
            this.txtDzielnik.Name = "txtDzielnik";
            this.txtDzielnik.Size = new System.Drawing.Size(100, 20);
            this.txtDzielnik.TabIndex = 1;
            // 
            // 
            this.txtWynik.Location = new System.Drawing.Point(12, 64);
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.ReadOnly = true;
            this.txtWynik.Size = new System.Drawing.Size(100, 20);
            this.txtWynik.TabIndex = 2;
            // 
            // 
            this.btnDivide.Location = new System.Drawing.Point(12, 90);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(100, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "Podziel";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtWynik);
            this.Controls.Add(this.txtDzielnik);
            this.Controls.Add(this.txtDzielna);
            this.Name = "Form1";
            this.Text = "Aplikacja Dzielenia";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
