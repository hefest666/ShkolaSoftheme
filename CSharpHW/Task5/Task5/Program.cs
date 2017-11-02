using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            char qws =' ';
            int size;

            do
            {
                try
                {
                    Console.Clear();
                    Console.Write("Введите фигуру(T, S, D): ");
                    qws = char.Parse(Console.ReadLine());
                    Console.Write("Введите размер фигуры(от 1 до 10): ");
                    size = int.Parse(Console.ReadLine());

                    if (size < 1 || size > 10 )
                    {
                        Console.WriteLine("Неправильный диапазон значений!!");
                        Console.ReadKey();
                        continue;
                    }

                    switch (qws)
                    {
                        case 'T':
                            BuildTriangle(size);
                            break;
                        case 'S':
                            BuildSquare(size);
                            break;
                        case 'D':
                            BuildDiamond(size);
                            break;

                        default: break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неправильный формат строки!");
                    Console.ReadKey();
                }
            
            } while (qws != 'q' && qws != 'Q');                        
        }

        public static void BuildTriangle(int s)
        {
            Console.WriteLine();
            string triangle = "";
            for(int i = 0; i < s; i++)
            {
                Console.WriteLine(triangle += "*" + " ");
            }
            Console.ReadKey();
        }

        public static void BuildSquare(int s)
        {
            Console.WriteLine();
            string square = "*";
            for(int i = 0; i < s; i++)
            {
                for(int j = 0; j < s; j++)
                {
                    Console.Write(square + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void BuildDiamond(int s)
        {
            Console.WriteLine();
            string diamond = "*";
            int i, j, N = s;

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (i <= N/2)
                    {
                        // Верхняя половина ромба
                        if (j >= N/2 - i && j <= N/2 + i)
                        {
                            Console.Write(diamond + " ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }                            
                    }
                    else
                    {
                        // Нижняя половина ромба
                        if (j >= N/2 + i - N + 1 && j <= N / 2 - i + N - 1)
                        {
                            Console.Write(diamond + " ");
                        }                            
                        else
                        { 
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
