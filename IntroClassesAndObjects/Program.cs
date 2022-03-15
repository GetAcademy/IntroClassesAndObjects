using System;

namespace IntroClassesAndObjects
{
    internal class Program
    {
        private static void ClickerDemo()
        {
            var clickers = new Clicker[]
            {
                new Clicker('q'),
                new Clicker('p'),
                new Clicker('b'),
                new Clicker('d'),
                new Clicker('o'),
            };
            var totalClicks = 0;
            while (true)
            {
                var keyInfo = Console.ReadKey();
                Console.Clear();
                foreach (var clicker in clickers)
                {
                    clicker.Click(keyInfo.KeyChar);
                    clicker.Show();
                    totalClicks += clicker.Count;
                }
                Console.WriteLine($"Totalt antall klikk = {totalClicks}");
            }


            /*
            var count = 0;
            while (true)
            {
                var keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Q)
                {
                    count++;
                }

                Console.Clear();
                Console.WriteLine($"Clicker Q = {count}");
            }             
             */
        }

        static void Main(string[] args)
        {
            ClickerDemo();
            return;
            /*
             * - Klasser som en måte å utnytte
             *   sterk typing enda mer
             * - Constructor
             * - Innkapsling
             * - Klassevariable vs objektvariable
             * - Properties
             */

            // demo 1
            var person = new Person(
                "Terje", 1975);
            person.Show();


            // demo 3
            var people = new Person[]
            {
                new Person ("Terje", 1975),
                new Person ("Per", 1980),
                new Person ("Pål", 1982),
            };

            // demo 4
            var model = new Model(
                new Person[]
                {
                    new Person ("Terje", 1975),
                    new Person ("Per", 1980),
                    new Person ("Pål", 1982),
                });
        }
    }
}
