using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(" Deseja mesmo sair? ", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void pbFechar_Click_1(object sender, EventArgs e)
        {
            //fechar
            if (MessageBox.Show("Deseja mesmo sair", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                Application.Exit();                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //maximizar
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            panelSelecao.Top = btnCliente.Top;

            panelCentral.Controls.Add(cliente);
            cliente.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();

            panelSelecao.Top = btnInicio.Top;
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = btnRaca.Top;
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = btnAnimais.Top;
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = btnServicos.Top;
        }
    }
}
