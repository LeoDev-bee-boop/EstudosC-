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
            AlimentarComboBox();
        }

        private void Gravar()
        {
            //capturando todos os email já presentes no arquivo
            List<string> emails = LerEmail();

            //Verifica se o email na combo á foi digitado
            if (fcnRetornaEmailExistente(emails))
                return;

            //Limpando a combo box
            fcnLimparArquivoeCombo();

            if (File.Exists(CaminhoBaseEmail()))
            {
                using (StreamWriter writer = new StreamWriter(CaminhoBaseEmail()))
                {
                    string emailNome = cbEmail.Text;

                    emails.Add(emailNome);

                    foreach (string email in emails)
                    {
                        writer.WriteLine(email);
                    }
                    
                    writer.Close();
                }
                //Atualizando Grid  
                AlimentarComboBox();
            }
            else
            {
                string path = CaminhoBaseEmail();
                FileStream fs = File.Create(path);
                fs.Close();
                Gravar();
            }
        }

        private List<string> LerEmail()
        {
            var emails = new List<string>();

            if (File.Exists(CaminhoBaseEmail()))
            {
                using(StreamReader arquivo  = File.OpenText(CaminhoBaseEmail()))
                {
                    string linha;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                        var linhaEmail = linha.Trim();
                        emails.Add(linhaEmail);
                    }
                    arquivo.Close();
                }
            }
            return emails;
        }

        private void AlimentarComboBox()
        {
            if (File.Exists(CaminhoBaseEmail()))
            {
                var sr = new StreamReader(CaminhoBaseEmail());
                string linha;               

                while ((linha = sr.ReadLine()) != null)
                {
                    cbEmail.Items.Add(linha);
                }
                sr.Close();
            }
        }

        private bool fcnRetornaEmailExistente(List<string> emails)
        {
            string emailComboBox = cbEmail.Text;

            foreach(string email in emails)
            {
                if (email == emailComboBox)
                    return true;
            }

            return false;
        }

        public void fcnLimparArquivoeCombo()
        {
            System.IO.File.WriteAllText(CaminhoBaseEmail(), string.Empty);
            cbEmail.Items.Clear();
        }
    }
}
