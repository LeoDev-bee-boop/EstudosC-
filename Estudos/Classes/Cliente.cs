using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    {
        /// <summary>
        /// Construtor da Classe
        /// </summary>
        /// <param name="nome">Para preencher o nome do objeto</param>
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public Cliente() { }

        public string Nome;
        public string Telefone;
        public string CPF;

        public void Gravar()
        {
            if(this.GetType() == typeof(Cliente)) 
                {
            
                var clientes = Cliente.LerClientes();
                clientes.Add(this);

                if (File.Exists(caminhoBaseClientes()))
                {
                    StreamWriter r = new StreamWriter(caminhoBaseClientes());
                    string conteudo = "nome;telefone;cpf;";
                    r.WriteLine(conteudo);

                    foreach (Cliente c in clientes)
                    {
                        var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                        r.WriteLine(linha);
                    }

                    r.Close();
                }
            } else
            {
                var usuario = Usuario.LerClientes();
                usuario.Add(this);

                if (File.Exists(caminhoBaseClientes()))
                {
                    StreamWriter r = new StreamWriter(caminhoBaseClientes());
                    string conteudo = "nome;telefone;cpf;";
                    r.WriteLine(conteudo);

                    foreach (Usuario c in usuario)
                    {
                        var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                        r.WriteLine(linha);
                    }

                    r.Close();
                }
            }
        }

        private void Olhar()
        {
            Console.WriteLine("O cliente" + this.Nome + " está olhando para mim");
        }

        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        private static string caminhoBaseUsuario()
        {
            return ConfigurationManager.AppSettings["BaseDeUsuarios"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(caminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');
                        
                        //var cliente = new Cliente { Nome = clienteArquivo[0], Telefone = clienteArquivo[1], CPF = clienteArquivo[2] };
                        //ou
                        var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]);
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }
    }
}
