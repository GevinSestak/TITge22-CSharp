using AutoMapper;

namespace Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mapping";
            Console.WriteLine("Mapper");
            
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Pets";
            emp.Title = "President";
            emp.Description= "Lahe mees";
            
            // Mapping algab
            // Data transfer object
            EmployeeDTO dto = new EmployeeDTO();
            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title;
            dto.Description = emp.Description;

            Console.WriteLine(dto.Id + " " + dto.Name + " " + dto.Title + " " + dto.Description);
            Console.WriteLine("-------------------Automapper osa--------------------------");
            // Tegime ja täitsime andmetega Employee objekti
            Employee employee = new Employee
            {
                Id = 123,
                Name = "Name1233",
                Description = "Des123",
                Title = "Title123"
            };

            // On soovitav kasutada siis kui muutujaid on väga palju nagu ntx 100 tki.
            var mapper = Program.InitializeAutomapper();
            var empDto2 = mapper.Map<Employee, EmployeeDTO>(employee);
            Console.WriteLine(empDto2.Id + " " + empDto2.Name + " " + empDto2.Title + " " + empDto2.Description);
            Console.ReadKey();
        }
        // Mapper on AutoMapper nugetist saadud class
        public static Mapper InitializeAutomapper()
        {
            // Anna kõik mappimise seadistused
            var config = new MapperConfiguration(cfg =>
            {
                // Mappime Employee ja EmployeeDTO classid omavahel ära.
                cfg.CreateMap<Employee, EmployeeDTO>();
            });
            // Loob mappimise instantsi Mapperist ja returnib selle
            var mapper = new Mapper(config);
            return mapper;
        }
    }
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}