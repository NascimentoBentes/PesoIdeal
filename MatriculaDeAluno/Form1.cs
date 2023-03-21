using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaDeAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAnoUltimoAniversario_Enter(object sender, EventArgs e)
        {
            if(txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE " +
                    "NASCIMENTO com 4 digitos", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
        }

        private void txtAnoUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if(Convert.ToInt32(txtAnoUltimoAniversario.Text) <=
                Convert.ToInt32(txtAnoNascimento.Text))
            {
                MessageBox.Show("ANO DO ÚLTIMO ANIVERSÁRIO" +
                    "deve ser superior ao do ANO DE NASCIMENTO.","Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtAnoUltimoAniversario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
