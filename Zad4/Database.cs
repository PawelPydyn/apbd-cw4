using Zad4.Models;

namespace Zad4
{
    public class Database
    {
        public static List<Animal> Animals = new List<Animal>()
        {
            new Animal() { Id = 1, Name = "Reksio" , Category = "pies", Weight = 25, HairColor = "czarny" },
            new Animal() { Id = 2, Name = "Reksio" , Category = "pies", Weight = 25, HairColor = "czarny" },
            new Animal() { Id = 3, Name = "Reksio" , Category = "pies", Weight = 25, HairColor = "czarny" },

        };

        public static List<Visit> Visits = new List<Visit>()
        {
            new Visit() { AnimalId = 1, VisitDate = "15.05.2025", VisitDescrpition = "Cos tam1", VisitPrice = 5000},
            new Visit() { AnimalId = 2, VisitDate = "1.01.2025", VisitDescrpition = "Cos tam2", VisitPrice = 1000},
            new Visit() { AnimalId = 3, VisitDate = "20.10.2025", VisitDescrpition = "Cos tam3", VisitPrice = 2000}

        };

        
    }
}
