namespace Uto1_2014
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Polumjer = new System.Windows.Forms.Label();
            this.Površina = new System.Windows.Forms.Label();
            this.Opseg = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.IstRezultati = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Izračunaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Obriši";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Polumjer
            // 
            this.Polumjer.AutoSize = true;
            this.Polumjer.Location = new System.Drawing.Point(28, 33);
            this.Polumjer.Name = "Polumjer";
            this.Polumjer.Size = new System.Drawing.Size(50, 13);
            this.Polumjer.TabIndex = 2;
            this.Polumjer.Text = "Polumjer:";
            this.Polumjer.Click += new System.EventHandler(this.label1_Click);
            // 
            // Površina
            // 
            this.Površina.AutoSize = true;
            this.Površina.Location = new System.Drawing.Point(28, 59);
            this.Površina.Name = "Površina";
            this.Površina.Size = new System.Drawing.Size(51, 13);
            this.Površina.TabIndex = 3;
            this.Površina.Text = "Površina:";
            // 
            // Opseg
            // 
            this.Opseg.AutoSize = true;
            this.Opseg.Location = new System.Drawing.Point(28, 87);
            this.Opseg.Name = "Opseg";
            this.Opseg.Size = new System.Drawing.Size(41, 13);
            this.Opseg.TabIndex = 4;
            this.Opseg.Text = "Opseg:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0.00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0.00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0.00";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(81, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Spremi u listu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // IstRezultati
            // 
            this.IstRezultati.FormattingEnabled = true;
            this.IstRezultati.Location = new System.Drawing.Point(220, 30);
            this.IstRezultati.Name = "IstRezultati";
            this.IstRezultati.Size = new System.Drawing.Size(122, 173);
            this.IstRezultati.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 239);
            this.Controls.Add(this.IstRezultati);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Opseg);
            this.Controls.Add(this.Površina);
            this.Controls.Add(this.Polumjer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Glavna forma aplikacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Polumjer;
        private System.Windows.Forms.Label Površina;
        private System.Windows.Forms.Label Opseg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox IstRezultati;
    }
}

