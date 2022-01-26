using Models;
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
        int aux = 0;
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
                List<Alimento> alimentos = new List<Alimento>();

                while ((linha = sr.ReadLine()) != null)
                {
                    Alimento alimento = new Alimento();
                    var values = linha.Split(';');

                    alimento.Tipo = values[0];
                    alimento.Marca = values[1];
                    alimento.Quantidade = Int32.Parse(values[2]);
                    alimento.Validade = DateTime.Parse(DateTime.Parse(values[3]).ToString("MM/dd/yyyy"));
                    txtTeste.Text = alimento.Validade.ToString();
                    alimento.Tamanho = values[4];

                    alimentos.Add(alimento);
                    
                }
                dgvDispensa.DataSource = alimentos;

            }
        }

        

        private void butMaximize_Click(object sender, EventArgs e)
        {
            if(aux == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                aux = 1;
            } else
            {
                this.WindowState =  FormWindowState.Normal;
                aux = 0;
            }

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
            fcnCustomizaGrid();
        }

        private void fcnCustomizaGrid()
        {
            foreach(DataGridViewRow row in this.dgvDispensa.Rows)
            {
                if(Convert.ToDateTime(row.Cells[3].Value) > DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                } else
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }
    }
}
