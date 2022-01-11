using console_app.Classes;
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
            //Menu.Criar();

            var cliente = new Cliente();
            cliente.Nome = "geraldo";
            cliente.Telefone = "14992345231";
            cliente.CPF = "13456789013";
            cliente.Gravar();


            var clientes = Cliente.LerClientes();
            foreach (Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
                Console.WriteLine(c.Telefone);
                Console.WriteLine(c.CPF);
            }

            Console.ReadLine();

            /*
            var cliente2 = new Cliente();
            cliente2.Nome = "sheila";
            cliente2.Telefone = "14992345231";
            cliente2.CPF = "13456789013";
            cliente.Gravar();
            */
        }

    }
}
