using System;
using AutoPoco.DataSources;
using AutoPoco.Engine;

namespace ContractManager.Infrastructure.Data.Sources
{
    public class PersonSource : DatasourceBase<string>
    {
        private static readonly Random _random = new Random();
        private static readonly FirstNameSource _firstNameSource = new FirstNameSource();
        private static readonly LastNameSource _lastNameSource = new LastNameSource();

        public override string Next(IGenerationSession session)
        {
            var firstName = _firstNameSource.Next(session);
            var lastName = _lastNameSource.Next(session);
            return string.Format("{0} {1}", firstName, lastName);
        }

        //public override string Next(IGenerationSession session)
        //{
        //    return Names[_random.Next(0, Names.Length)];
        //}

        //private static readonly string[] Names =
        //{
        //    "Castor", "Mckinney",
        //    "Jarrod Burris",
        //    "Florence Robles",
        //    "Zoe Schwartz",
        //    "Alea Dyer",
        //    "Harrison Rice",
        //    "Katell Nguyen",
        //    "Peter Shelton",
        //    "Emi Holt",
        //    "Fitzgerald Mckinney",
        //    "Ciaran Kim",
        //    "Rosalyn Gibbs",
        //    "Gretchen Good",
        //    "Tanner Green",
        //    "Lillian Head",
        //    "Josiah Byrd",
        //    "Quemby Villarreal",
        //    "Malcolm Rojas",
        //    "David Carlson",
        //    "Calvin Pitts",
        //    "Tana Reyes",
        //    "Portia Copeland",
        //    "Mariam Buck",
        //    "Camden Frost",
        //    "Maris Guzman",
        //    "Joan Osborn",
        //    "Kelsey Blackwell",
        //    "Kevyn Meyers",
        //    "Gary Riddle",
        //    "Arthur Rice",
        //    "Cassandra Franklin",
        //    "Summer Holmes",
        //    "Fitzgerald Sharpe",
        //    "Gage Donaldson",
        //    "Herrod Buckley",
        //    "Arthur Velez",
        //    "Nicole Parsons",
        //    "Darryl Bird",
        //    "Carson Morrow",
        //    "Maryam Hill",
        //    "Ivy James",
        //    "Prescott Blevins",
        //    "Samson Walters",
        //    "Iona Weiss",
        //    "Alexa Frost",
        //    "Dai Dixon",
        //    "Venus Shelton",
        //    "Demetrius Osborn",
        //    "Vanna Hogan",
        //    "Velma Wise",
        //    "Gretchen Lynn",
        //    "Sean Robinson",
        //    "Yoshi Brock",
        //    "Beatrice Wilder",
        //    "Noelani Hester",
        //    "Jennifer Franco",
        //    "Calista Burton",
        //    "Kimberly Hester",
        //    "Dale Hampton",
        //    "Vincent Oneil",
        //    "Casey Best",
        //    "Randall Gonzalez",
        //    "Thaddeus Waller",
        //    "Jerome Hester",
        //    "Trevor Vargas",
        //    "Kirby Craft",
        //    "Libby Graves",
        //    "Tamara Benjamin",
        //    "Darryl Randolph",
        //    "Uta Burke",
        //    "Allistair Walter",
        //    "Paloma Rosa",
        //    "Mechelle Haynes",
        //    "Galvin Mercado",
        //    "Lacey Summers",
        //    "Nasim Kramer",
        //    "Dominique Turner",
        //    "Walter Cross",
        //    "Derek Nolan",
        //    "Hermione Bowen",
        //    "Aubrey Goodman",
        //    "Fulton Castaneda",
        //    "Dana Lancaster",
        //    "Britanni Stevens",
        //    "Molly Moody",
        //    "Cleo Luna",
        //    "Dieter Sweet",
        //    "Gil Roberts",
        //    "Deborah Cross",
        //    "Leilani Pugh",
        //    "Riley Jordan",
        //    "Declan Baird",
        //    "Porter Medina",
        //    "Graiden Armstrong",
        //    "Tanner Reynolds",
        //    "Jessica Taylor",
        //    "Jerry Summers",
        //    "Kirestin Mccray",
        //    "Kadeem Banks",
        //    "Desirae Bernard",
        //    "Penny Mordaunt",
        //    "Sandra Osborne",
        //    "Bob Russell",
        //};

    }
}