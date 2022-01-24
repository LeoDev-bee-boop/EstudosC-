using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Dispensa
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

        private void fcnCarregaGrid()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(ofd.FileName);
                string linha;
                string[] campo;

                while ((linha = sr.ReadLine()) != null)
                {
                    campo = linha.Split(';');
                    dataGridView1.Rows.Add(campo);
                }
            }
        }

        

        private void butMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void butAdicionarAlimento_Click(object sender, EventArgs e)
        {
            fcnCarregaGrid();
        }

        private void butCapturaLinha_Click(object sender, EventArgs e)
        {
            var a = dataGridView1.Rows[1].Cells[2].Value;
            txtTeste.Text = (string)a;
        }
    }
}
