using Calculo;
using Funcoes;
using Diretorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTE = 4;
       
        public static void Criar()
        {
            while (true)
            {
                string msg = "\n Digite uma das opções a baixo: \n" +
                    "\n     0 - Sair do programa \n" +
                    "\n     1 - Para ler aquivos \n" +
                    "\n     2 - Para executar a tabuada \n" +
                    "\n     3 - Caluclar a media dos alunos \n" +
                    "\n     4 - Cadastrar Clientes \n";

            Console.WriteLine(msg);

                int valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 0:
                        return;                        
                    case 1:
                        Console.WriteLine("\n ================ Opção Ler Arquivos ================ \n");
                        Arquivo.Ler(1);
                        break;
                    case 2:
                        Console.WriteLine("\n ================ Opção Tabuada ================ \n");
                        Console.WriteLine("\n Digite o número que queira calcular a tabuada: \n");
                        int numero = int.Parse(Console.ReadLine());
                        Tabuada.Calcular(numero);
                        break;
                    case 3:
                        Media.CalcularMediaAluno();
                        break;
                    case 4:
                        TelaCliente.Chamar();
                        break;
            }


            }
        }
    }
}
