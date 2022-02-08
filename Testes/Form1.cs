using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (File.Exists(CaminhoBaseEmail()))
            {
                StreamWriter sr = new StreamWriter(CaminhoBaseEmail());
                string email = cbEmail.Text;
                sr.WriteLine(email);
                sr.Close();
            }
        }

        private static string CaminhoBaseEmail()
        {
            return ConfigurationManager.AppSettings["CaminhoEmail"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlimentarGrid();
        }

        private void AlimentarGrid()
        {
            if (File.Exists(CaminhoBaseEmail()))
            {
                var sr = new StreamReader(CaminhoBaseEmail());
                string linha;               

                while ((linha = sr.ReadLine()) != null)
                {
                    cbEmail.Items.Add(linha);
                }
            }
        }
    }
}
