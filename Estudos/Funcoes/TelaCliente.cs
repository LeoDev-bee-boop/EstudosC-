using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {

            Console.WriteLine(" ==================== Cadastro de Cliente ==================== \n");

            while (true)
            {
                string msg = "\n Digite uma das opções a baixo: \n" +
                    "\n     0 - Sair do programa \n" +
                    "\n     1 - Para cadastrar clientes \n" +
                    "\n     2 - Para listar clientes \n";

                Console.WriteLine(msg);
                int valor = int.Parse(Console.ReadLine());

                if(valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var cliente = new Cliente();
                    Console.WriteLine("\n Digite o nome do cliente: \n");
                    
                    cliente.Nome = Console.ReadLine();
                    Console.WriteLine("\n Digite o telefone do cliente: \n");
                    
                    cliente.Telefone = Console.ReadLine();
                    Console.WriteLine("\n Digite o CPF do cliente: \n");
                    cliente.CPF = Console.ReadLine();

                    cliente.Gravar();
                }
                else
                {
                    var clientes = Cliente.LerClientes();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine(c.Nome);
                        Console.WriteLine(c.Telefone);
                        Console.WriteLine(c.CPF);
                    }
                }
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
