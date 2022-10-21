using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            ex4();
        }

        public struct Student
        {
            public string name;
            public int dateofBirth;
            public string exam;
            public int pointsOfExam;
            public Student(string Name, int Age, string Exam, int Points)
            {
                name = Name;
                dateofBirth = Age;
                exam = Exam;
                pointsOfExam = Points;
            }
        }
        static void Commands()
        {
            Console.WriteLine("You can:" + "\nAdd" + "\nDelete" + "\nSort" + "\nShow");
        }
        static public void Ex1()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student("Арайан ",10/10/2004, "Инфоматика",259) },
                {2, new Student("Алина",10/03/2004,"Английский",252) },
                {3, new Student("Диана",10/14/2005,"Информатика",235) },
                {4, new Student("Максим",13/12/2004,"Английский",246) },
                {5, new Student("Дания",12/12/2004,"Английский",267) },
                {6, new Student("Никита",25/04/2004,"Информатика",249) },
                {7, new Student("Радмир",18/03/2004,"Информатика",243) },
                {8, new Student("Аделина",15/06/2004,"Физика",248) },
                {9, new Student("Маргарита",13/04/2000,"Физика",242) },
                {10, new Student("Виталий",01/09/20038,"Информатика",205) }

            };
            bool flag = true;
            string input;
            while (flag)
            {
                Commands();
                input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "add":
                        AddStudent(students);
                        break;
                    case "delete":
                        Remove(students);
                        break;
                    case "sort":
                        students = SortStudents(students);
                        break;
                    case "пshow":
                        WriteAllStudents(students);
                        break;

                    default:
                        Console.WriteLine("----");
                        break;
                }
                Console.Clear();
            }

        }

        public static void Remove(Dictionary<int, Student> students)
        {
            Console.WriteLine("Eneter student's id");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                if (students.ContainsKey(id))
                {
                    Console.WriteLine("Student was deleted succesfully");
                    students.Remove(id);
                }
                else
                {
                    Console.WriteLine("StudentNotFound");
                }
            }
            else
            {
                Console.WriteLine("Wrong enter");
            }
            Console.ReadKey();
        }

        private static void AddStudent(Dictionary<int, Student> students)
        {
            Console.Clear();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Eneter his date of birth");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Wrong enter");
            }
            Console.WriteLine("Enter student's extra exam");
            string exam = Console.ReadLine();
            Console.WriteLine("Enter student's points");
            int points;
            while (!int.TryParse(Console.ReadLine(), out points) || points < 0)
            {
                Console.WriteLine("Wrong enter");
            }
            Random random = new Random();
            int valueId = random.Next(0, 100);
            while (students.ContainsKey(valueId))
            {
                valueId = random.Next();
            }
            students.Add(valueId, new Student(name, age, exam, points));
            Console.Clear();
            Console.WriteLine("Student was added");
            Console.ReadKey();
        }

        private static Dictionary<int, Student> SortStudents(Dictionary<int, Student> students)
        {

            var sort = students.OrderByDescending(x => x.Value.pointsOfExam).ToDictionary(x => x.Key, x => x.Value);
            return sort;
        }

        private static void WriteAllStudents(Dictionary<int, Student> students)
        {
            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} {student.Value.name} {student.Value.dateofBirth} " +
                    $"{student.Value.exam} {student.Value.pointsOfExam}");
            }
            Console.ReadKey();
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
        enum windows
        {
            first = 0,
            second = 1,
            third = 2
        }
        public class Visitor
        {
            public Visitor() { }
            public Visitor(int Id, string Name, int NumOfproblem, string Problem, int IQ, int Angr)
            {
                this.Id = Id;
                this.Name = Name;
                this.NumOfProblem = NumOfProblem;
                this.Problem = Problem;
                this.IQ = IQ;
                this.Angr = Angr;
            }
            public string Name { get; set; }
            public int Id { get; set; }
            public int NumOfProblem { get; set; }
            public string Problem { get; set; }
            public int IQ { get; set; }
            public int Angr { get; set; }
        }
        public static void ex3()
        {
            Console.WriteLine("История в жэке. Начался отопительный сезон, в городе начали " +
                "включать отопление и у жителей возникают проблемы.Для решения этих проблем они идут в жэк.В жэке есть 3 окна:" +
                "первое окно помогает людям решить проблемы с отоплением(подключение и тд)," +
                "второе окно решает проблемы с оплатой отопления, в третье окно идут все остальные." +
                "Необходимо создать структуру жителя.У жителя есть имя, номер паспорта(для однозначной идентификации), " +
                "проблема, темперамент.Проблема характеризуется номером и описанием." +
                "Темперамент характеризуется степенью скандальности от 0 до 10(10 - скандалист, 0 - паинька)," +
                " умом(1 - умный, 0 - тупой). В каждое окно жители встают по очереди." +
                "Перед входом в жэк стоит Зина, которая уточняет у жителей, какая у них проблема и по " +
                "ключевым словам определяет их в нужное окно. Если житель скандалист(от 5 и выше), " +
                "то он не будет обращать внимание на очередь и обгонит людей, которые впереди него" +
                "(на сколько человек обгонять житель спрашивает у пользователя)." +
                "Если человек тупой, то он встаёт не в то окно, даже несмотря на указание Зины(случайным образом)." +
                "К Зине все выстраиваются в стек.");
            string path = @"C:\Users\Allli\Desktop\ex3.txt";
            List<Visitor> listOfVisitors = new List<Visitor>();
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    Visitor person = new Visitor();
                    string text = reader.ReadLine().ToLower();
                    string[] guests = new string[6];
                    guests = text.Split(" ");
                    person.Name = guests[0];
                    person.Id = int.Parse(guests[1]);
                    person.NumOfProblem = int.Parse(guests[2]);
                    person.Problem = guests[3];
                    person.IQ = int.Parse(guests[4]);
                    person.Angr = int.Parse(guests[5]);

                    listOfVisitors.Add(person);
                }

                listOfVisitors.Reverse();
                for (int i = 0; i < listOfVisitors.Count(); i++)
                {

                    Visitor person = listOfVisitors[i];
                    Console.WriteLine("Name: " + person.Name + "\nPasport: " + person.Id + "\nNumber of application" + person.NumOfProblem +
                        "\nProblem: " + person.Problem);
                    Console.WriteLine("Let's go to Zina");
                    Console.WriteLine("Going...");
                    Thread.Sleep(5000);

                    if (person.Problem.Contains("warm") || person.Problem.Contains("conection"))
                    {
                        Console.WriteLine("Zina Says: You nedd to go to the first window"); ;
                        Console.WriteLine("Going...");
                        Thread.Sleep(5000);
                        switch (person.IQ)
                        {
                            case 1:
                                Array values = Enum.GetValues(typeof(windows));
                                Random random = new Random();
                                windows randomBar = (windows)values.GetValue(random.Next(values.Length));
                                Console.WriteLine("You are at {0} window", randomBar);
                                if (person.Angr > 5)
                                {
                                    Console.WriteLine("How many people will we leave behind?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("You left behind {0} people", num3);
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                continue;

                            case 0:
                                Console.WriteLine("You are at the first window");
                                if (person.Angr > 5)
                                {
                                    Console.WriteLine("How many people will we leave behind?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("You left behind {0} people", num3);
                                    string wait = Console.ReadLine();
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                continue;
                        }
                    }
                    else if (person.Problem.Contains("payment") || person.Problem.Contains("money") || person.Problem.Contains("pay"))
                    {
                        Console.WriteLine("Zina Says: You need to go to the second window");
                        Console.WriteLine("Going...");
                        Thread.Sleep(5000);
                        switch (person.IQ)
                        {
                            case 1:
                                Array values = Enum.GetValues(typeof(windows));
                                Random random = new Random();
                                windows randomBar = (windows)values.GetValue(random.Next(values.Length));
                                Console.WriteLine("You are at {0} window", randomBar);
                                if (person.Angr > 5)
                                {
                                    Console.WriteLine("How many people will we leave behind?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("You left behind {0} people", num3);
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                continue;
                            case 0:
                                Console.WriteLine("You are at the first window");
                                if (person.Angr > 5)
                                {
                                    Console.WriteLine("How many people will we leave behind?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("You left behind {0} people", num3);
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Zina Says: You need to go to the third window");
                        Console.WriteLine("Going...");
                        Thread.Sleep(5000);
                        switch (person.IQ)
                        {
                            case 1:
                                Array values = Enum.GetValues(typeof(windows));
                                Random random = new Random();
                                windows randomBar = (windows)values.GetValue(random.Next(values.Length));
                                Console.WriteLine("You are at {0} window", randomBar);
                                if (person.Angr > 5)
                                {
                                    Console.WriteLine("How many people will we leave behind?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("You left behind {0} people", num3);
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                continue;
                            case 0:
                                Console.WriteLine("You are at the first window");
                                if (person.Angr > 5)
                                {
                                    Console.WriteLine("How many people will we leave behind?");
                                    int num3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("You left behind {0} people", num3);
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Print enter to continue");
                                    Console.ReadLine();
                                }
                                continue;
                        }
                    }
                }

            }
        }
        public static void ex4()
        {
            Console.WriteLine("Написать метод для обхода графа в глубину или ширину - вывести на экран кратчайший путь.");
            Random rand = new Random();
            Queue<int> q = new Queue<int>();
            int u;
            u = rand.Next(3, 5);
            bool[] used = new bool[u + 1];
            int[][] g = new int[u + 1][];

            for (int i = 0; i < u + 1; i++)
            {
                g[i] = new int[u + 1];
                Console.Write("\n({0}) вершина -->[", i + 1);
                for (int j = 0; j < u + 1; j++)
                {
                    g[i][j] = rand.Next(0, 2);
                }
                g[i][i] = 0;
                foreach (var item in g[i])
                {
                    Console.Write(" {0}", item);
                }
                Console.Write("]\n");
            }
            used[u] = true;

            q.Enqueue(u);
            Console.WriteLine("Начинаем обход с {0} вершины", u + 1);
            while (q.Count != 0)
            {
                u = q.Peek();
                q.Dequeue();
                Console.WriteLine("Перешли к узлу {0}", u + 1);

                for (int i = 0; i < g.Length; i++)
                {
                    if (Convert.ToBoolean(g[u][i]))
                    {
                        if (!used[i])
                        {
                            used[i] = true;
                            q.Enqueue(i);
                            Console.WriteLine("Добавили в очередь узел {0}", i + 1);
                        }
                    }
                }
            }

        }

    }
}
