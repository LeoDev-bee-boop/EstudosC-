using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace console_app
{
    /*
        Programa destinado a estudo de Programação Orientada a Função
        Link da aula: https://www.youtube.com/watch?v=SpW5neODPag&list=PLEdPHGYbHhlcxWx-_LrVVYZ2RRdqltums&index=9
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Cadastro de Cliente==============");
            Cliente c = new Cliente();

            c.Nome = "cliente 1";
            c.Telefone = "123";
            c.CPF = "123";

            c.Gravar();

            foreach (Cliente us in Cliente.lerUsuario())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("==============================");
            }

            Console.WriteLine("==============Cadastro de Usuário==============");
            Usuario u = new Usuario();

            u.Nome = "usuario 1";
            u.Telefone = "234";
            u.CPF = "234";

            u.Gravar();

            foreach(Usuario us in Usuario.lerUsuario())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("==============================");
            }

        }

    }
}
