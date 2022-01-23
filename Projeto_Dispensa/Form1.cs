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
            fcnCarregaGrid();
        }

        private void fcnCarregaGrid()
        {
            StreamReader csv = new StreamReader(@"C:\Users\User\Desktop\TESTE_CSV.csv");

            string linha;
            string[] campo;

            while((linha = csv.ReadLine()) != null)
            {
                campo = linha.Split(';');
                dataGridView1.Rows.Add(campo);
            }
        }
    }
}
