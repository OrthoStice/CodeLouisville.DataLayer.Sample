using System;
using System.Linq;
using CodeLouisville.DL;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dl = new Data<Person>(@"/home/kevin/repos/Sample/data/db.json");

            var data = dl.Get();
            if (data?.Count == 0)
            {
                var dad = new Person() { FirstName = "Pa", LastName = "Bear", DOB = new DateTime(1969, 6, 6), Sex = "M" };
                var mom = new Person() { FirstName = "Ma", LastName = "Bear", DOB = new DateTime(1968, 4, 8), Sex = "F" };
                var girl = new Person() { FirstName = "Sister", LastName = "Bear", DOB = new DateTime(1992, 3, 29), Sex = "F" };
                girl.Parents.AddRange(new Person[] { dad, mom });
                var boy = new Person() { FirstName = "Brother", LastName = "Bear", DOB = new DateTime(2000, 3, 24), Sex = "M" };
                boy.Parents.AddRange(new Person[] { dad, mom });


                dl.Save(new Person[] { dad, mom, girl, boy });
                data = dl.Get();
            }

            var numberOfBears = data.Count;
            var oldestChild = dl.GetByQuery((rows) =>
            {
                return rows.Where(p => p.FirstName.ToUpper() == "SISTER").FirstOrDefault();
            });

            Console.WriteLine($"There are {numberOfBears} Bears");
            if (oldestChild != null)
                Console.WriteLine($"The first-born is {oldestChild.FirstName} and {(oldestChild.Sex.ToUpper() == "F" ? "She" : "He")} is {DateTime.Now.Year - oldestChild.DOB.Year} old.");

            oldestChild.LastName += " III";

            dl.SaveOne(oldestChild,(rows)=>{
                return rows.ToList().FindIndex(p=> p.FirstName.ToUpper()=="SISTER");
            });

            Console.WriteLine("enter to exit...");
            Console.ReadLine();

        }
    }
}
