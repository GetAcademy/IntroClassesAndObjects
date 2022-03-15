using System;

namespace IntroClassesAndObjects
{
    class Person
    {
        private string _name;
        private int _birthYear;

        public Person(
            string name, int birthYear)
        {
            _name  = name;
            _birthYear = birthYear;
        }

        public void Show()
        {
            Console.WriteLine($"Navn: {_name} Fødselsår: {_birthYear}");
        }
    }
}
