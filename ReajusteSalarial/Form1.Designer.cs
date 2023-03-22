
namespace ReajusteSalarial
{
    partial class FormCalculoDeSalario
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
            this.components = new System.ComponentModel.Container();
            this.lblSalarioMinimo = new System.Windows.Forms.Label();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.rbnVeterano = new System.Windows.Forms.RadioButton();
            this.rbnCalouro = new System.Windows.Forms.RadioButton();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.rbnNoturno = new System.Windows.Forms.RadioButton();
            this.rbnVespetino = new System.Windows.Forms.RadioButton();
            this.rbnMatutino = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCategoria.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioMinimo
            // 
            this.lblSalarioMinimo.AutoSize = true;
            this.lblSalarioMinimo.Location = new System.Drawing.Point(13, 13);
            this.lblSalarioMinimo.Name = "lblSalarioMinimo";
            this.lblSalarioMinimo.Size = new System.Drawing.Size(80, 13);
            this.lblSalarioMinimo.TabIndex = 0;
            this.lblSalarioMinimo.Text = "Salário Mínimo:";
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(13, 38);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(96, 13);
            this.lblHorasTrabalhadas.TabIndex = 1;
            this.lblHorasTrabalhadas.Text = "Horas trabalhadas:";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(113, 10);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioMinimo.TabIndex = 2;
            this.txtSalarioMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtSalarioMinimo, "Informe o valor atual para o salário mínimo");
            this.txtSalarioMinimo.TextChanged += new System.EventHandler(this.txtSalarioMinimo_TextChanged);
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(113, 36);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabalhadas.TabIndex = 3;
            this.txtHorasTrabalhadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip2.SetToolTip(this.txtHorasTrabalhadas, "Informe o valor de horas trabalhadas");
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.rbnVeterano);
            this.gbxCategoria.Controls.Add(this.rbnCalouro);
            this.gbxCategoria.Location = new System.Drawing.Point(16, 76);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(200, 67);
            this.gbxCategoria.TabIndex = 4;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // rbnVeterano
            // 
            this.rbnVeterano.AutoSize = true;
            this.rbnVeterano.Location = new System.Drawing.Point(98, 36);
            this.rbnVeterano.Name = "rbnVeterano";
            this.rbnVeterano.Size = new System.Drawing.Size(68, 17);
            this.rbnVeterano.TabIndex = 1;
            this.rbnVeterano.TabStop = true;
            this.rbnVeterano.Text = "Veterano";
            this.rbnVeterano.UseVisualStyleBackColor = true;
            // 
            // rbnCalouro
            // 
            this.rbnCalouro.AutoSize = true;
            this.rbnCalouro.Location = new System.Drawing.Point(7, 36);
            this.rbnCalouro.Name = "rbnCalouro";
            this.rbnCalouro.Size = new System.Drawing.Size(61, 17);
            this.rbnCalouro.TabIndex = 0;
            this.rbnCalouro.TabStop = true;
            this.rbnCalouro.Text = "Calouro";
            this.rbnCalouro.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.rbnNoturno);
            this.gbxTurno.Controls.Add(this.rbnVespetino);
            this.gbxTurno.Controls.Add(this.rbnMatutino);
            this.gbxTurno.Location = new System.Drawing.Point(245, 13);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(92, 130);
            this.gbxTurno.TabIndex = 5;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // rbnNoturno
            // 
            this.rbnNoturno.AutoSize = true;
            this.rbnNoturno.Location = new System.Drawing.Point(7, 99);
            this.rbnNoturno.Name = "rbnNoturno";
            this.rbnNoturno.Size = new System.Drawing.Size(63, 17);
            this.rbnNoturno.TabIndex = 2;
            this.rbnNoturno.TabStop = true;
            this.rbnNoturno.Text = "Noturno";
            this.rbnNoturno.UseVisualStyleBackColor = true;
            // 
            // rbnVespetino
            // 
            this.rbnVespetino.AutoSize = true;
            this.rbnVespetino.Location = new System.Drawing.Point(7, 63);
            this.rbnVespetino.Name = "rbnVespetino";
            this.rbnVespetino.Size = new System.Drawing.Size(72, 17);
            this.rbnVespetino.TabIndex = 1;
            this.rbnVespetino.TabStop = true;
            this.rbnVespetino.Text = "Vespetino";
            this.rbnVespetino.UseVisualStyleBackColor = true;
            // 
            // rbnMatutino
            // 
            this.rbnMatutino.AutoSize = true;
            this.rbnMatutino.Location = new System.Drawing.Point(7, 27);
            this.rbnMatutino.Name = "rbnMatutino";
            this.rbnMatutino.Size = new System.Drawing.Size(66, 17);
            this.rbnMatutino.TabIndex = 0;
            this.rbnMatutino.TabStop = true;
            this.rbnMatutino.Text = "Matutino";
            this.rbnMatutino.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(272, 299);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.BackColor = System.Drawing.Color.Yellow;
            this.txtClassificacao.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassificacao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtClassificacao.Location = new System.Drawing.Point(23, 297);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(227, 25);
            this.txtClassificacao.TabIndex = 7;
            this.txtClassificacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbxResumo
            // 
            this.lbxResumo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 16;
            this.lbxResumo.Location = new System.Drawing.Point(16, 166);
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.Size = new System.Drawing.Size(345, 116);
            this.lbxResumo.TabIndex = 8;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Ajuda";
            // 
            // FormCalculoDeSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 341);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.lblSalarioMinimo);
            this.Name = "FormCalculoDeSalario";
            this.Text = "Cálculo de Salário";
            this.Load += new System.EventHandler(this.FormCalculoDeSalario_Load);
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioMinimo;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton rbnVeterano;
        private System.Windows.Forms.RadioButton rbnCalouro;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton rbnNoturno;
        private System.Windows.Forms.RadioButton rbnVespetino;
        private System.Windows.Forms.RadioButton rbnMatutino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

