using System;

namespace Exercicio_matriz_vizinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;

            int left, right, dow, up;

            Random number = new Random();


            Console.Write("Qual a quantidades de linha da matriz? ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidades de colunas da matriz? ");
            int n = int.Parse(Console.ReadLine());

            mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int numberInt = number.Next(0, 30);
                    Console.Write("Digite um número: ");
                    mat[i, j] = numberInt;


                }

            }
            Console.Clear();




            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + "   ");

                }
                Console.WriteLine();
            }


            Console.Write("Digite um number  0 a 30 para idendificar os vizinhos deles: ");
            int pesq = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == pesq)                       
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (j > 0)
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        if (j < n - 1)
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i > 0)
                            Console.WriteLine("Up: "+mat[i-1,j]);
                        if (i < m-1)
                            Console.WriteLine("Dow: "+ mat[i+1,j]);
                    }


                }

            }
        }
    }
}
