using pao_simulator.Classes;
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

namespace pao_simulator
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirLista_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var file = new StreamReader(ofd.FileName);
                string linha;
                
                List<Usuario> usuarios = new List<Usuario>();

                while((linha = file.ReadLine()) != null)
                {
                    Usuario usuario = new Usuario();
                    var values = linha.Split(';');

                    usuario.Pessoa = values[0];
                    usuario.Data = DateTime.Parse(DateTime.Parse(values[1]).ToString("MM/dd/yyyy"));

                    usuarios.Add(usuario);
                }
                dgvPrincipal.DataSource = usuarios;
            }
        }
    }
}
