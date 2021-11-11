using System;

namespace AppLogicaExerciciosPropostos_04
{
    /// <summary>
    /// Exercícios sobre Estrutura Condicional (if-else)
    /// Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
    /// começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
    /// </summary>

    class Program
    {
        public static int totalHoras(int inicio, int fim)
        {
            int total;

            if (inicio == fim) 
            {
                total = 24;
            }
            else if (inicio>fim)
            {
                total = (24 - inicio) + fim;
            }
            else
            {
                total = (24 - fim) + inicio; 
            }
            return total;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores das horas do jogo: ");
            
            string[] vet = Console.ReadLine().Split(" ");
            int hInicial = int.Parse(vet[0]);
            int hFinal = int.Parse(vet[1]);
            int total = totalHoras(hInicial, hFinal);

            Console.Clear();
            
            Console.WriteLine("Total de horas jogadas é: {0} hora(s)", total);
            Console.ReadLine();
        }
    }
}
