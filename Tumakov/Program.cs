using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Collections.Generic;


namespace Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            ex11();
                   //homework//ex1//ex2//ex3
        }

        static void ex1()
        {
            Console.WriteLine("Написать программу, которая вычисляет число гласных и согласных букв в файле." +
                "Имя файла передавать как аргумент в функцию Main.Содержимое текстового файла заносится в массив символов." +
                "Количество гласных и согласных букв определяется проходом по массиву." +
                "Предусмотреть метод, входным параметром которого является массив символов." +
                "Метод вычисляет количество гласных и согласных букв.");
            string text = File.ReadAllText(@"C:\Users\Allli\Desktop\homework 5 ex 1.txt");
            string vowel = "уеыаоэяиёюУЕЫАОЭЯИЁЮ";
            string consonant = "цкнгшщзхфвпрлджчсмтбЦКНГШЩЗХФВПРЛДЖЧМТ";
            int i, j, k, n; i = j = k = n = 0;
            text.ToCharArray().All(z => {
                if (vowel.ToCharArray().Contains(z))
                {
                    i++;
                }
                else if (consonant.ToCharArray().Contains(z))
                    j++;
                    return true; 
            });
            k = text.ToCharArray().Intersect(vowel.ToCharArray()).Count();
            n = text.ToCharArray().Except(consonant.ToCharArray()).Count();
            Console.WriteLine(k);
            Console.WriteLine(n);
        }

        static void Print(int[,] mas)
        {
            for (int row = 0; row < mas.GetLength(0); row++)
            {
                for (int column = 0; column < mas.GetLength(1); column++)
                    Console.Write(mas[row, column] + "  ");
                Console.WriteLine();
            }
        }

        static int[,] Multiplication(int[,] a, int[,] b)
        {
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
        static void ex2()
        {
            try
            {
                Console.WriteLine("Написать программу, реализующую умножению двух матриц, заданных в виде двумерного массива." +
                    "В программе предусмотреть два метода: метод печати матрицы, метод умножения матриц" +
                    "(на вход две матрицы,возвращаемое значение – матрица).");
                Console.WriteLine("Enter a number of lines");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number of columns");
                int c = Convert.ToInt32(Console.ReadLine());
                int[,] mas = new int[l, c];
                Console.WriteLine("Enter number through enter");
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write("mas [{0},{1}] = ", i, j);
                        mas[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Enter type of operation" + "\n1 - print" + "\n2 - multiplication");
                int tp = int.Parse(Console.ReadLine());
                switch (tp)
                {
                    case 1:
                        Print(mas);
                        return;

                    case 2:
                        int[,] mas2 = new int[l, c];
                        Console.WriteLine("Enter number through enter");
                        for (int i = 0; i < l; i++)
                        {
                            for (int j = 0; j < c; j++)
                            {
                                Console.Write("mas2 [{0},{1}] = ", i, j);
                                mas2[i, j] = int.Parse(Console.ReadLine());
                            }
                        }
                        int[,] mul = Multiplication(mas, mas2);
                        Print(mul);
                        return;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static int[] BubbleSort(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int a = mas[i];
                        mas[i] = mas[j];
                        mas[j] = a;

                    }
                }
            }
            return mas;
        }
            
    static void ex3()
        {
            Console.WriteLine("Написать программу, вычисляющую среднюю температуру за год." +
            "Создать двумерный рандомный массив temperature[12, 30], в котором будет храниться температура " +
            "для каждого дня месяца(предполагается,что в каждом месяце 30 дней)." +
            "Сгенерировать значения температур случайным образом.Для каждого месяца распечатать среднюю температуру." +
            "Для этого написать метод, который по массиву temperature[12, 30] " +
            "для каждого месяца вычисляет среднюю температуру в нем, и в качестве результата возвращает массив " +
            "средних температур.Полученный массив средних температур отсортировать по возрастанию.");
            int[,] temperature = new int[12, 30];
            Random rand = new Random();
            int[] newmas = new int[12];
            for (int b = 0; b < temperature.GetLength(0); b++)
            {
                int sum = 0;
                for (int c = 0; c < temperature.GetLength(1); c++)
                {
                    temperature[b, c] = rand.Next(-10, 30);
                    sum += temperature[b, c];
                }
                newmas[b] = sum / 30;
            }
            BubbleSort(newmas);
            Console.WriteLine("Average temperatures: ");
            foreach (int i in newmas)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadLine();

        }

        static void ex11()
        {
            Console.WriteLine("Упражнение 6.1 выполнить с помощью коллекции List<T>.");
            string text = File.ReadAllText(@"C:\Users\Allli\Desktop\homework 5 ex 1.txt");
            List<char> chars = new List<char>();
            chars.AddRange(text);
            //string vowel = "уеыаоэяиёюУЕЫАОЭЯИЁЮ";
            //string consonant = "цкнгшщзхфвпрлджчсмтбЦКНГШЩЗХФВПРЛДЖЧМТ";
        }

        static void ex12()
        {
            Console.WriteLine("Упражнение 6.2 выполнить с помощью коллекций LinkedList<LinkedList<T>>.");
        }

        static void ex13()
        {
            Console.WriteLine("Написать программу для упражнения 6.3, использовав класс Dictionary<TKey, TValue>." +
                "В качестве ключей выбрать строки – названия месяцев, а в качестве значений – массив значений температур по дням.");

        }

    }
    }


