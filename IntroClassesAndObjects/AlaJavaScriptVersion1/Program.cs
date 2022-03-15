namespace IntroClassesAndObjects.AlaJavaScriptVersion1
{
    internal class Program
    {
        static void Mainx(string[] args)
        {
            /*
             * Pause til 10:40
             *
             * - Klasser som en måte å utnytte
             *   sterk typing enda mer
             * - Constructor
             * - Innkapsling
             * - Properties
             */

            // demo 1
            var person = new Person
            {
                Name = "Terje",
                BirthYear = 1975
            };

            /*
             demo 2
            var person = new Person();
            person.Name = "Terje";
            person.BirthYear = 1975;
            */

            // demo 3
            var people = new Person[]
            {
                new Person {Name = "Terje", BirthYear = 1975},
                new Person {Name = "Per", BirthYear = 1980},
                new Person {Name = "Pål", BirthYear = 1982},
            };

            // demo 4
            var model = new Model
            {
                People = new Person[]
                {
                    new Person {Name = "Terje", BirthYear = 1975},
                    new Person {Name = "Per", BirthYear = 1980},
                    new Person {Name = "Pål", BirthYear = 1982},
                }
            };

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
