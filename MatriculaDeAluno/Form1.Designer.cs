
namespace MatriculaDeAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.lblAnoUltimoAniversario = new System.Windows.Forms.Label();
            this.txtAnoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.btnIdentificaCategoria = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNome.Location = new System.Drawing.Point(17, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "&Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(289, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnoNascimento.Location = new System.Drawing.Point(17, 52);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(88, 15);
            this.lblAnoNascimento.TabIndex = 2;
            this.lblAnoNascimento.Text = "&Ano nascimento:";
            this.lblAnoNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(111, 49);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(57, 20);
            this.txtAnoNascimento.TabIndex = 3;
            this.txtAnoNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoUltimoAniversario_Validating);
            // 
            // lblAnoUltimoAniversario
            // 
            this.lblAnoUltimoAniversario.AutoSize = true;
            this.lblAnoUltimoAniversario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnoUltimoAniversario.Location = new System.Drawing.Point(174, 52);
            this.lblAnoUltimoAniversario.Name = "lblAnoUltimoAniversario";
            this.lblAnoUltimoAniversario.Size = new System.Drawing.Size(115, 15);
            this.lblAnoUltimoAniversario.TabIndex = 4;
            this.lblAnoUltimoAniversario.Text = "An&o último aniversário:";
            this.lblAnoUltimoAniversario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnoUltimoAniversario
            // 
            this.txtAnoUltimoAniversario.Location = new System.Drawing.Point(295, 49);
            this.txtAnoUltimoAniversario.Name = "txtAnoUltimoAniversario";
            this.txtAnoUltimoAniversario.Size = new System.Drawing.Size(57, 20);
            this.txtAnoUltimoAniversario.TabIndex = 5;
            this.txtAnoUltimoAniversario.TextChanged += new System.EventHandler(this.txtAnoUltimoAniversario_TextChanged);
            this.txtAnoUltimoAniversario.Enter += new System.EventHandler(this.txtAnoUltimoAniversario_Enter);
            this.txtAnoUltimoAniversario.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoUltimoAniversario_Validating);
            // 
            // btnIdentificaCategoria
            // 
            this.btnIdentificaCategoria.Location = new System.Drawing.Point(17, 83);
            this.btnIdentificaCategoria.Name = "btnIdentificaCategoria";
            this.btnIdentificaCategoria.Size = new System.Drawing.Size(120, 23);
            this.btnIdentificaCategoria.TabIndex = 6;
            this.btnIdentificaCategoria.Text = "Identificar Categoria";
            this.btnIdentificaCategoria.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoria.Location = new System.Drawing.Point(164, 88);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 15);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Yellow;
            this.textBox4.Location = new System.Drawing.Point(227, 88);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 127);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnIdentificaCategoria);
            this.Controls.Add(this.txtAnoUltimoAniversario);
            this.Controls.Add(this.lblAnoUltimoAniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAnoNascimento;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.Label lblAnoUltimoAniversario;
        private System.Windows.Forms.TextBox txtAnoUltimoAniversario;
        private System.Windows.Forms.Button btnIdentificaCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox textBox4;
    }
}

