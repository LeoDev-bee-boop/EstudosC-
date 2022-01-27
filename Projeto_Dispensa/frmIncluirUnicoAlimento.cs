using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Dispensa
{
    public partial class frmIncluirUnicoAlimento : Form
    {
        public frmIncluirUnicoAlimento()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSalvar_Click(object sender, EventArgs e)
        {
            fcnSalvarAlimento();
        }

        private void fcnSalvarAlimento()
        {
            frmPrincipal principal = new frmPrincipal();

            Alimento alimento = new Alimento();
            
            alimento.Tipo = txtTipo.Text;
            alimento.Marca = txtMarca.Text;
            alimento.Quantidade = Int32.Parse(txtQuantidade.Text);
            alimento.Validade = Convert.ToDateTime(txtValidade.Text);
            alimento.Tamanho = txtTamanho.Text;

            principal.fcnPassaInfo(alimento);
            
        }
    }
}
