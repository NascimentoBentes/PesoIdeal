
namespace PesoIdeal
{
    partial class FormPesoIdeal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.gboxSex = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.txtCalculoDoPeso = new System.Windows.Forms.TextBox();
            this.gboxSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(255, 29);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura:";
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Location = new System.Drawing.Point(171, 108);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(57, 13);
            this.lblPesoIdeal.TabIndex = 2;
            this.lblPesoIdeal.Text = "Peso Ideal";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(258, 46);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // gboxSex
            // 
            this.gboxSex.Controls.Add(this.rbtnFeminino);
            this.gboxSex.Controls.Add(this.rbtnMasculino);
            this.gboxSex.Location = new System.Drawing.Point(32, 30);
            this.gboxSex.Name = "gboxSex";
            this.gboxSex.Size = new System.Drawing.Size(183, 44);
            this.gboxSex.TabIndex = 4;
            this.gboxSex.TabStop = false;
            this.gboxSex.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(6, 19);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            this.rbtnMasculino.CheckedChanged += new System.EventHandler(this.rbtnMasculino_CheckedChanged);
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(103, 20);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            this.rbtnFeminino.CheckedChanged += new System.EventHandler(this.rbtnMasculino_CheckedChanged);
            // 
            // txtCalculoDoPeso
            // 
            this.txtCalculoDoPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalculoDoPeso.Enabled = false;
            this.txtCalculoDoPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalculoDoPeso.ForeColor = System.Drawing.Color.Red;
            this.txtCalculoDoPeso.Location = new System.Drawing.Point(155, 141);
            this.txtCalculoDoPeso.Name = "txtCalculoDoPeso";
            this.txtCalculoDoPeso.Size = new System.Drawing.Size(100, 22);
            this.txtCalculoDoPeso.TabIndex = 5;
            // 
            // FormPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(388, 175);
            this.Controls.Add(this.txtCalculoDoPeso);
            this.Controls.Add(this.gboxSex);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.lblAltura);
            this.Name = "FormPesoIdeal";
            this.Text = "Cálculo do peso ideal";
            this.gboxSex.ResumeLayout(false);
            this.gboxSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.GroupBox gboxSex;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.TextBox txtCalculoDoPeso;
    }
}

