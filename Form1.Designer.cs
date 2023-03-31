namespace FormTest
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_text = new System.Windows.Forms.Button();
            this.lb_texto = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.Color.Navy;
            this.btn_text.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_text.Location = new System.Drawing.Point(306, 86);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(204, 41);
            this.btn_text.TabIndex = 0;
            this.btn_text.Text = "EMBARALHAR";
            this.btn_text.UseVisualStyleBackColor = false;
            this.btn_text.Click += new System.EventHandler(this.btn_canal_Click);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_texto.Location = new System.Drawing.Point(395, 154);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(0, 17);
            this.lb_texto.TabIndex = 1;
            // 
            // tb_text
            // 
            this.tb_text.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_text.Location = new System.Drawing.Point(306, 31);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(204, 21);
            this.tb_text.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(856, 688);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.btn_text);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_text;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.TextBox tb_text;
    }
}

