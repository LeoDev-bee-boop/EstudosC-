﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Media
    {
        public static void CalcularMediaAluno()
        {
            Console.WriteLine("\n Digite o nome do aluno");
            String nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("\n Digite as " + qtdNotas + " notas do aluno");
            List<int> notas = new List<int>();
            int totalNotas = 0;

            for (int i = 1; i<=qtdNotas; i++)
            {
                Console.WriteLine("\n Digite a nota numero " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            int media = totalNotas / qtdNotas;
            Console.WriteLine("\n A média do aluno " + nome + " é: " + media);
            Console.WriteLine("\n Suas notas são: ");

            foreach (int nota in notas)
            {
                Console.WriteLine("\n Nota:" + nota + " \n");
            }
        }
    }
}
