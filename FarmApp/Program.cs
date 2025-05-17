using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть назву ферми: ");
            string name = Console.ReadLine();

            Console.Write("Введiть iм’я власника: ");
            string owner = Console.ReadLine();

            Console.Write("Введiть кiлькiсть працiвникiв: ");
            int workers = int.Parse(Console.ReadLine());

            Console.Write("Введiть площу (у гектарах): ");
            double area = double.Parse(Console.ReadLine());

            Console.Write("Введiть тип ферми: ");
            string type = Console.ReadLine();

            Console.Write("Чи є технiка? (y - так, n - нi): ");
            bool hasMachines = Console.ReadKey().Key == ConsoleKey.Y;
            Console.WriteLine();

            Console.Write("Введiть рiчний дохiд: ");
            double income = double.Parse(Console.ReadLine());

            Farm myFarm = new Farm
            {
                Name = name,
                Owner = owner,
                WorkersCount = workers,
                Area = area,
                Type = type,
                HasMachines = hasMachines,
                YearIncome = income
            };

            double incomePerWorker = myFarm.GetIncomePerWorker();

            Console.WriteLine("\n--- ІНФОРМАЦІЯ ПРО ФЕРМУ ---");
            Console.WriteLine("Назва: " + myFarm.Name);
            Console.WriteLine("Власник: " + myFarm.Owner);
            Console.WriteLine("Кiлькiсть працiвникiв: " + myFarm.WorkersCount);
            Console.WriteLine("Площа: " + myFarm.Area + " га");
            Console.WriteLine("Тип ферми: " + myFarm.Type);
            Console.WriteLine(myFarm.HasMachines ? "Ферма має техніку." : "Ферма не має техніки.");
            Console.WriteLine("Рiчний дохiд: " + myFarm.YearIncome.ToString("0.00"));
            Console.WriteLine("Дохiд на одного працiвника: " + incomePerWorker.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
