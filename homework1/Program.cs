using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            ex3();
        }
        //djl

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
                        Console.WriteLine("Stop! Don't touch me there. This is my  no-no square");
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
                Console.WriteLine("Не знаю таких чисел для возраста!");
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
        struct Visitor
        {
            public string name;
            public int passport;
            public int number_of_Request;
            public string Problem;
            public int levelofStupidity;
            public int LevelOfScandalism;
            
            public Visitor(string Name,int pas, int num, string prob, int LvlStpd, int LvlScnd)
            {
                this.name = Name;
                this.passport = pas;
                this.number_of_Request = num;
                this.Problem = prob;
                this.levelofStupidity = LvlStpd;
                this.LevelOfScandalism = LvlScnd;
            }
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
            var levelOfStupidity = new List<string>() {"smart", "stupid"};
            var levelOfScandalism = new List<string>() { "Canadian", "Too_Calm", "Really_Calm", "Calm",
                "Quite", "Quite_enough", "Normal", "Not_Really_Scandalist", "Half_Scandalist", "Sacndalist", "Awfull_Scandalist" };
            string path = @"C:\Users\Allli\Desktop\ex3.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadLine();
                Console.WriteLine(text);
                string[] guest1 = text.Split(" ");
                string name = guest1[0];
                Console.WriteLine("Name: {0}", name);
                int pasport = Convert.ToInt32(guest1[1]);
                Console.WriteLine("Passport: {0}", pasport);
                byte num = Convert.ToByte(guest1[2]);
                Console.WriteLine("Number of the client: {0}", num);
                string problem = guest1[3].ToLower();
                string brain = guest1[4];
                int idbrain = levelOfStupidity.IndexOf(brain);
                Console.WriteLine("Index of Brain power: {0}", idbrain);
                string adequacy = guest1[5];
                int idadequacy = levelOfScandalism.IndexOf(adequacy);
                Console.WriteLine("Problematic level of client: {0}", idadequacy);
                Visitor visitor1 = new Visitor(name, pasport, num, problem, idbrain, idadequacy);

                Console.WriteLine("Let's go to Zina");
                if (problem.Contains("warm") || problem.Contains("conection"))
                {
                    Console.WriteLine("Zina Says: You nedd to go to the first window"); ;
                    switch (idbrain)
                    {
                        case 1:
                            Array values = Enum.GetValues(typeof(windows));
                            Random random = new Random();
                            windows randomBar = (windows)values.GetValue(random.Next(values.Length));
                            Console.WriteLine("You are at {0} window", randomBar);
                            if (idadequacy > 5)
                            {
                                Console.WriteLine("How many people will we leave behind?");
                                int num3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("You left behind {0} people", num3);
                            }
                            return;
                        case 0:
                            Console.WriteLine("You are at the first window");
                            if (idadequacy > 5)
                            {
                                Console.WriteLine("How many people will we leave behind?");
                                int num3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("You left behind {0} people", num3);
                            }
                            return;
                    }
                }
                else if (problem.Contains("payment") || problem.Contains("money") || problem.Contains("pay"))
                {
                    Console.WriteLine("Zina Says: You need to go to the second window");
                    switch (idbrain)
                    {
                        case 1:
                            Array values = Enum.GetValues(typeof(windows));
                            Random random = new Random();
                            windows randomBar = (windows)values.GetValue(random.Next(values.Length));
                            Console.WriteLine("You are at {0} window", randomBar);
                            if (idadequacy > 5)
                            {
                                Console.WriteLine("How many people will we leave behind?");
                                int num3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("You left behind {0} people", num3);
                            }
                            return;
                        case 0:
                            Console.WriteLine("You are at the first window");
                            if (idadequacy > 5)
                            {
                                Console.WriteLine("How many people will we leave behind?");
                                int num3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("You left behind {0} people", num3);
                            }
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Zina Says: You need to go to the third window");
                    switch (idbrain)
                    {
                        case 1:
                            Array values = Enum.GetValues(typeof(windows));
                            Random random = new Random();
                            windows randomBar = (windows)values.GetValue(random.Next(values.Length));
                            Console.WriteLine("You are at {0} window", randomBar);
                            if (idadequacy > 5)
                            {
                                Console.WriteLine("How many people will we leave behind?");
                                int num3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("You left behind {0} people", num3);
                            }
                            return;
                        case 0:
                            Console.WriteLine("You are at the first window");
                            if (idadequacy > 5)
                            {
                                Console.WriteLine("How many people will we leave behind?");
                                int num3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("You left behind {0} people", num3);
                            }
                            return;
                    }
                }

            }




        }
        }
}
