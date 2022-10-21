using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace totry1
{
    class Program
    {
        //struct Visitor
        //{
        //    public string name { get; set; }
        //    public int passport { get; set; }
        //    public int number_of_Request { get; set; }
        //    public string Problem { get; set; }
        //    public string levelofStupidity { get; set; }
        //    public string LevelOfScandalism { get; set; }

        //    //public Visitor(string Name, int pas, int num, string prob, int LvlStpd, int LvlScnd)
        //    //{
        //    //    this.name = Name;
        //    //    this.passport = pas;
        //    //    this.number_of_Request = num;
        //    //    this.Problem = prob;
        //    //    this.levelofStupidity = LvlStpd;
        //    //    this.LevelOfScandalism = LvlScnd;
        //    //}
        //}
        static void Main(string[] args)
        {
            //var levelOfStupidity = new List<string>() { "smart", "stupid" };
            //var levelOfScandalism = new List<string>() { "Canadian", "Too_Calm", "Really Calm", "Calm",
            //    "Quite", "Quite_enough", "Normal", "Not_Really_Scandalist", "Half_Scandalist", "Sacndalist", "Awfull_Scandalist" };
            //string path = @"C:\Users\Allli\Desktop\ex3.txt";
            //var file = File.ReadAllLines(path);
            //List<Visitor> list = file.Select(s => s.Split(','))
            //    .Select(Visitor => new Visitor
            //    {
            //        name = Visitor[0],
            //        passport = int.Parse(Visitor[1]),
            //        number_of_Request = int.Parse(Visitor[2]),
            //        Problem = Visitor[3],
            //        levelofStupidity = Visitor[4],
            //        LevelOfScandalism = Visitor[5],
            //    })
            //    .ToList();
            //foreach (var a in list)
            //{
            //    foreach (var item in list)
            //        Console.WriteLine(item);
            //}
            var file = File.ReadAllLines(@"C:\Users\Allli\Desktop\ex3.txt");
            List<Person> list = file.Select(s => s.Split(','))
                .Select(person => new Person
                {
                    Param1 = person[0],
                    Param2 = person[1],
                }).ToList();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(list[i].Param1);
                Console.WriteLine(list[i].Param2);
            }
        }
            public class Person
        {
            public string Param1 { get; set; }
            public string Param2 { get; set; }
            public string Param3 { get; set; }
            public string Param4 { get; set; }
            public string Param5 { get; set; }
            public string Param6 { get; set; }
        }

    }
    }

