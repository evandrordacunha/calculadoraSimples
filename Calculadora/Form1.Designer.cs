namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_ecram = new System.Windows.Forms.TextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_ce = new System.Windows.Forms.Button();
            this.bt_percent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.bt_mult = new System.Windows.Forms.Button();
            this.bt_sub = new System.Windows.Forms.Button();
            this.bt_sum = new System.Windows.Forms.Button();
            this.bt_equal = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_virgula = new System.Windows.Forms.Button();
            this.bt_mais_menos = new System.Windows.Forms.Button();
            this.bt_raiz = new System.Windows.Forms.Button();
            this.bt_um_meio = new System.Windows.Forms.Button();
            this.bt_quadrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_ecram
            // 
            this.tb_ecram.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ecram.Location = new System.Drawing.Point(12, 44);
            this.tb_ecram.Name = "tb_ecram";
            this.tb_ecram.Size = new System.Drawing.Size(275, 38);
            this.tb_ecram.TabIndex = 0;
            this.tb_ecram.Text = "0";
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.White;
            this.bt_clear.ForeColor = System.Drawing.Color.Red;
            this.bt_clear.Location = new System.Drawing.Point(108, 101);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(46, 36);
            this.bt_clear.TabIndex = 1;
            this.bt_clear.Text = "C";
            this.bt_clear.UseVisualStyleBackColor = false;
            // 
            // bt_ce
            // 
            this.bt_ce.BackColor = System.Drawing.Color.White;
            this.bt_ce.ForeColor = System.Drawing.Color.Red;
            this.bt_ce.Location = new System.Drawing.Point(60, 101);
            this.bt_ce.Name = "bt_ce";
            this.bt_ce.Size = new System.Drawing.Size(46, 36);
            this.bt_ce.TabIndex = 2;
            this.bt_ce.Text = "CE";
            this.bt_ce.UseVisualStyleBackColor = false;
            // 
            // bt_percent
            // 
            this.bt_percent.BackColor = System.Drawing.Color.White;
            this.bt_percent.ForeColor = System.Drawing.Color.Red;
            this.bt_percent.Location = new System.Drawing.Point(12, 101);
            this.bt_percent.Name = "bt_percent";
            this.bt_percent.Size = new System.Drawing.Size(46, 36);
            this.bt_percent.TabIndex = 3;
            this.bt_percent.Text = "%";
            this.bt_percent.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(160, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "BACKSPACE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bt_7
            // 
            this.bt_7.BackColor = System.Drawing.Color.White;
            this.bt_7.ForeColor = System.Drawing.Color.Red;
            this.bt_7.Location = new System.Drawing.Point(12, 193);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(46, 36);
            this.bt_7.TabIndex = 5;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = false;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_8
            // 
            this.bt_8.BackColor = System.Drawing.Color.White;
            this.bt_8.ForeColor = System.Drawing.Color.Red;
            this.bt_8.Location = new System.Drawing.Point(60, 193);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(46, 36);
            this.bt_8.TabIndex = 6;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = false;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_9
            // 
            this.bt_9.BackColor = System.Drawing.Color.White;
            this.bt_9.ForeColor = System.Drawing.Color.Red;
            this.bt_9.Location = new System.Drawing.Point(108, 193);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(46, 36);
            this.bt_9.TabIndex = 7;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = false;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_div
            // 
            this.bt_div.BackColor = System.Drawing.Color.White;
            this.bt_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_div.ForeColor = System.Drawing.Color.Red;
            this.bt_div.Location = new System.Drawing.Point(160, 155);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(127, 36);
            this.bt_div.TabIndex = 8;
            this.bt_div.Text = "/";
            this.bt_div.UseVisualStyleBackColor = false;
            // 
            // bt_mult
            // 
            this.bt_mult.BackColor = System.Drawing.Color.White;
            this.bt_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mult.ForeColor = System.Drawing.Color.Red;
            this.bt_mult.Location = new System.Drawing.Point(160, 193);
            this.bt_mult.Name = "bt_mult";
            this.bt_mult.Size = new System.Drawing.Size(127, 36);
            this.bt_mult.TabIndex = 9;
            this.bt_mult.Text = "X";
            this.bt_mult.UseVisualStyleBackColor = false;
            // 
            // bt_sub
            // 
            this.bt_sub.BackColor = System.Drawing.Color.White;
            this.bt_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sub.ForeColor = System.Drawing.Color.Red;
            this.bt_sub.Location = new System.Drawing.Point(160, 231);
            this.bt_sub.Name = "bt_sub";
            this.bt_sub.Size = new System.Drawing.Size(127, 36);
            this.bt_sub.TabIndex = 10;
            this.bt_sub.Text = "-";
            this.bt_sub.UseVisualStyleBackColor = false;
            // 
            // bt_sum
            // 
            this.bt_sum.BackColor = System.Drawing.Color.White;
            this.bt_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sum.ForeColor = System.Drawing.Color.Red;
            this.bt_sum.Location = new System.Drawing.Point(160, 269);
            this.bt_sum.Name = "bt_sum";
            this.bt_sum.Size = new System.Drawing.Size(127, 36);
            this.bt_sum.TabIndex = 11;
            this.bt_sum.Text = "+";
            this.bt_sum.UseVisualStyleBackColor = false;
            // 
            // bt_equal
            // 
            this.bt_equal.BackColor = System.Drawing.Color.White;
            this.bt_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_equal.ForeColor = System.Drawing.Color.Red;
            this.bt_equal.Location = new System.Drawing.Point(160, 307);
            this.bt_equal.Name = "bt_equal";
            this.bt_equal.Size = new System.Drawing.Size(127, 36);
            this.bt_equal.TabIndex = 12;
            this.bt_equal.Text = "=";
            this.bt_equal.UseVisualStyleBackColor = false;
            // 
            // bt_4
            // 
            this.bt_4.BackColor = System.Drawing.Color.White;
            this.bt_4.ForeColor = System.Drawing.Color.Red;
            this.bt_4.Location = new System.Drawing.Point(12, 231);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(46, 36);
            this.bt_4.TabIndex = 13;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = false;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_5
            // 
            this.bt_5.BackColor = System.Drawing.Color.White;
            this.bt_5.ForeColor = System.Drawing.Color.Red;
            this.bt_5.Location = new System.Drawing.Point(60, 231);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(46, 36);
            this.bt_5.TabIndex = 14;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = false;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_6
            // 
            this.bt_6.BackColor = System.Drawing.Color.White;
            this.bt_6.ForeColor = System.Drawing.Color.Red;
            this.bt_6.Location = new System.Drawing.Point(108, 231);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(46, 36);
            this.bt_6.TabIndex = 15;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = false;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.Color.White;
            this.bt_1.ForeColor = System.Drawing.Color.Red;
            this.bt_1.Location = new System.Drawing.Point(12, 269);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(46, 36);
            this.bt_1.TabIndex = 16;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.BackColor = System.Drawing.Color.White;
            this.bt_2.ForeColor = System.Drawing.Color.Red;
            this.bt_2.Location = new System.Drawing.Point(60, 269);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(46, 36);
            this.bt_2.TabIndex = 17;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = false;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.BackColor = System.Drawing.Color.White;
            this.bt_3.ForeColor = System.Drawing.Color.Red;
            this.bt_3.Location = new System.Drawing.Point(108, 269);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(46, 36);
            this.bt_3.TabIndex = 18;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = false;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(60, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_virgula
            // 
            this.bt_virgula.BackColor = System.Drawing.Color.White;
            this.bt_virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_virgula.ForeColor = System.Drawing.Color.Red;
            this.bt_virgula.Location = new System.Drawing.Point(108, 307);
            this.bt_virgula.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.bt_virgula.Name = "bt_virgula";
            this.bt_virgula.Size = new System.Drawing.Size(46, 36);
            this.bt_virgula.TabIndex = 20;
            this.bt_virgula.Text = ".";
            this.bt_virgula.UseVisualStyleBackColor = false;
            // 
            // bt_mais_menos
            // 
            this.bt_mais_menos.BackColor = System.Drawing.Color.White;
            this.bt_mais_menos.ForeColor = System.Drawing.Color.Red;
            this.bt_mais_menos.Location = new System.Drawing.Point(12, 307);
            this.bt_mais_menos.Name = "bt_mais_menos";
            this.bt_mais_menos.Size = new System.Drawing.Size(46, 36);
            this.bt_mais_menos.TabIndex = 21;
            this.bt_mais_menos.Text = "+/-";
            this.bt_mais_menos.UseVisualStyleBackColor = false;
            // 
            // bt_raiz
            // 
            this.bt_raiz.BackColor = System.Drawing.Color.White;
            this.bt_raiz.ForeColor = System.Drawing.Color.Red;
            this.bt_raiz.Location = new System.Drawing.Point(12, 155);
            this.bt_raiz.Name = "bt_raiz";
            this.bt_raiz.Size = new System.Drawing.Size(46, 36);
            this.bt_raiz.TabIndex = 22;
            this.bt_raiz.Text = "√\t";
            this.bt_raiz.UseVisualStyleBackColor = false;
            // 
            // bt_um_meio
            // 
            this.bt_um_meio.BackColor = System.Drawing.Color.White;
            this.bt_um_meio.ForeColor = System.Drawing.Color.Red;
            this.bt_um_meio.Location = new System.Drawing.Point(60, 155);
            this.bt_um_meio.Name = "bt_um_meio";
            this.bt_um_meio.Size = new System.Drawing.Size(46, 36);
            this.bt_um_meio.TabIndex = 23;
            this.bt_um_meio.Text = "½";
            this.bt_um_meio.UseVisualStyleBackColor = false;
            // 
            // bt_quadrado
            // 
            this.bt_quadrado.BackColor = System.Drawing.Color.White;
            this.bt_quadrado.ForeColor = System.Drawing.Color.Red;
            this.bt_quadrado.Location = new System.Drawing.Point(108, 155);
            this.bt_quadrado.Name = "bt_quadrado";
            this.bt_quadrado.Size = new System.Drawing.Size(46, 36);
            this.bt_quadrado.TabIndex = 24;
            this.bt_quadrado.Text = "x²";
            this.bt_quadrado.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(51, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "By Evandro Rocha da Cunha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(299, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_quadrado);
            this.Controls.Add(this.bt_um_meio);
            this.Controls.Add(this.bt_raiz);
            this.Controls.Add(this.bt_mais_menos);
            this.Controls.Add(this.bt_virgula);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_equal);
            this.Controls.Add(this.bt_sum);
            this.Controls.Add(this.bt_sub);
            this.Controls.Add(this.bt_mult);
            this.Controls.Add(this.bt_div);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_percent);
            this.Controls.Add(this.bt_ce);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.tb_ecram);
            this.Name = "Form1";
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ecram;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_ce;
        private System.Windows.Forms.Button bt_percent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Button bt_mult;
        private System.Windows.Forms.Button bt_sub;
        private System.Windows.Forms.Button bt_sum;
        private System.Windows.Forms.Button bt_equal;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_virgula;
        private System.Windows.Forms.Button bt_mais_menos;
        private System.Windows.Forms.Button bt_raiz;
        private System.Windows.Forms.Button bt_um_meio;
        private System.Windows.Forms.Button bt_quadrado;
        private System.Windows.Forms.Label label1;
    }
}

