namespace IntroClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pause 11:05
             *
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
            

            /*
             demo 2
            var person = new Person();
            person.Name = "Terje";
            person.BirthYear = 1975;
            */

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

            // demo 5
            /*
            var model2 = new Model2
            {
                Inputs = new Inputs
                {
                    PageA = new PageA
                    {
                        Number = 5,
                        Text = "Hei"
                    }

                },
                Places= new Place []{
                    new Place() { Name= "Stavern", Country= "Norway"},
                    new Place() { Name= "Stockholm", Country= "Sweden"},
                }
            };
            */
        }
    }
}
