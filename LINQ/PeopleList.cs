namespace LINQ
{
    public class PeopleList
    {
        public static readonly List<People> people = new List<People>()
        {
            new People() {
                Id = 1, 
                Name = "Jaak", 
                Age = 13, 
                GenderId = Guid.Parse("a7949a1c-16a3-4e0b-b31f-5322eed32c55") 
            },
            new People() { 
                Id = 2, 
                Name = "Jüri", 
                Age = 23, 
                GenderId = Guid.Parse("a7949a1c-16a3-4e0b-b31f-5322eed32c55") 
            },
            new People() { 
                Id = 3, 
                Name = "Mati", 
                Age = 18, 
                GenderId = Guid.Parse("a7949a1c-16a3-4e0b-b31f-5322eed32c55") 
            },
            new People() { 
                Id = 4, 
                Name = "Tom", 
                Age = 45, 
                GenderId = Guid.Parse("a7949a1c-16a3-4e0b-b31f-5322eed32c55")
            },
            new People() { 
                Id = 5, 
                Name = "Joonas", 
                Age = 85, 
                GenderId = Guid.Parse("a7949a1c-16a3-4e0b-b31f-5322eed32c55") 
            },
            new People() { 
                Id = 6, 
                Name = "Mari", 
                Age = 99, 
                GenderId = Guid.Parse("f5956c17-2a59-496e-9663-1072e132d1e2") 
            },
            new People() { 
                Id = 7, 
                Name = "Anna", 
                Age = 23, 
                GenderId = Guid.Parse("f5956c17-2a59-496e-9663-1072e132d1e2")
            },
        };
    }
}
