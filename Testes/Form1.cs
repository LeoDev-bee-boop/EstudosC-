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
            Gravar();
        }

        private static string CaminhoBaseEmail()
        {
            return ConfigurationManager.AppSettings["CaminhoEmail"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlimentarGrid();
        }

        private void Gravar()
        {
            //capturando todos os email já presentes no arquivo
            var emails = LerEmail();
            
            if (File.Exists(@"C:\Users\Leonardosevalhos\Documents\teste\emails.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Leonardosevalhos\Documents\teste\emails.txt"))
                {
                    string email = cbEmail.Text;
                    emails.Add(email);
                    writer.WriteLine(emails);
                    writer.Close();
                }
            }
            else
            {
                string path = @"C:\Users\Leonardosevalhos\Documents\teste\emails.txt";
                FileStream fs = File.Create(path);
                Gravar();
            }
        }

        private List<string> LerEmail()
        {
            var emails = new List<string>();

            if (File.Exists(@"C:\Users\Leonardosevalhos\Documents\teste\emails.txt"))
            {
                using(StreamReader arquivo  = File.OpenText(@"C:\Users\Leonardosevalhos\Documents\teste\emails.txt"))
                {
                    string linha;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                        var linhaEmail = linha.Trim();
                        emails.Add(linhaEmail);
                    }
                }
            }
            return emails;
        }

        private void AlimentarGrid()
        {
            if (File.Exists(@"C:\Users\Leonardosevalhos\Documents\teste\emails.txt"))
            {
                var sr = new StreamReader(@"C:\Users\Leonardosevalhos\Documents\teste\emails.txt");
                string linha;               

                while ((linha = sr.ReadLine()) != null)
                {
                    cbEmail.Items.Add(linha);
                }
            }
        }
    }
}
