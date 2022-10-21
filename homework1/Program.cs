using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_
{
    class Program
    {
        static void Main(string[] args)
        {
            ex1();
        }

        class Student
        {
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public string Subject1 { get; set; }
            public string Subject2 { get; set; }
            public string Subject3 { get; set; }
            public int Mark { get; set; }


            public Student(string n, string d, string e, string h, string k, int m = 0)
            {
                Name = n;
                DOB = DateTime.Parse(d);
                Subject1 = e;
                Subject2 = h;
                Subject3 = k;
                Mark = m;
            }
        }

        static void ex1()
        {
            Console.WriteLine("1. Создать студента из вашей группы (фамилия, имя, год рождения, с каким экзаменом поступил, баллы)." +
                "Создать словарь для студентов из вашей группы(10 человек). В консоли необходимо создать меню:" +
                "1.Eсли человек вводит слово: Новый студент, то необходимо ввести информацию о новом студенте и добавить его в лист" +
                "2.Если человек вводит слово: Удалить, то по фамилии и имени удаляется студент " +
                "3.Если человек вводит слово: Сортировать, то происходит сортировка по баллам(по возрастанию)");

            Dictionary<int, Student> students = new Dictionary<int, Student>();
            {

            };
        }

        static void ex2()
        {
            Console.WriteLine("Месяц - Октябрь. Климат благоприятный. Пиво свежее. И холодно. Два клана воюют. " +
                "Сидя по разные стороны длинного стола викингов, Bavarian Beer Bears и Scandinavian " +
                "Schöllers готовятся сразиться друг с другом в историческом испытании.Игра пятерок викингов! " +
                "Викинги дружелюбный народ, жадный до пива.Цель игры состоит в том, чтобы обе команды набрали " +
                "одинаковое количество пятерок, чтобы вся орда викингов получила бесплатную порцию пива от рефери Бьорга" +
                " Бьоргесона.Однако Бьорг пил весь день и поэтому потерял способность сравнивать количество пятерок," +
                " которое показывают викинги.Создайте функцию, которая принимает массивы двух команд, " +
                "сравнивает количество показанных пятерок и, если они совпадают, возвращает «Drinks All Round! " +
                "Free Beers on Bjorg!».Если они этого не сделают, ответьте: «Ой, Бьорг - пончик! Ни для кого пива!» ." +
                "Гарантируется, что оба массива будут содержать только целые числа от 0 до 9. ");

            Console.WriteLine("Enter number of vikings in every team");
            int num = int.Parse(Console.ReadLine());
            int[] team1 = new int[num];
            Console.WriteLine("Enter numbers of the first team through enter");
            for (int i = 0; i < num; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                team1[i] = c;
            }
            int[] team2 = new int[num];
            Console.WriteLine("Enter numbers of the second team through enter");
            for (int j = 0; j < num; j++)
            {
                int d = Convert.ToInt32(Console.ReadLine());
                team2[j] = d;
            }
            int a = 0;
            for (int n = 0; n < num; n++)
            {
                if (team1[n] == 5)
                {
                    a++;
                }
            }
            int u = 0;
            for (int m = 0; m < num; m++)
            {
                if (team2[m] == 5)
                {
                    u++;
                }
            }
            if (u == a)
            {
                Console.WriteLine("Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }




        }
    }
}
