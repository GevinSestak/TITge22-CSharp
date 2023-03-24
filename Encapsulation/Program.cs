using Encapsulation.Services;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Encapsulation";
            Console.WriteLine("Encapsulation");
            
            Student student = new Student();
            // Paneme väärtused muutujatele
            student.Id = "101";
            student.Name = "Pets";
            student.Email = "hallokosmos@mail.ru";

            Console.WriteLine("ID = " + student.Id);
            Console.WriteLine("NAME = " + student.Name);
            Console.WriteLine("EMAIL = " + student.Email);

            Console.WriteLine("-----------------------------------");

            ProtectedStudent protectedStudent = new ProtectedStudent();
            // Kui DoSomething on protected ja teises classis siis ei saa seda kasutada
            //protectedStudent.DoSomething();

            // Kui protected meetod on samas classis, siis saab seda kasutada
            Program p = new Program();
            p.DoSomethingInProgramClass();

            // Kui protected internal muutujale antakse väärtus siia määratud classi siis ei anna veateadet.
            // kui väärtust ei ole pandud, siis annab veateate
            var protectedInternalStudent = new ProtectedInternalStudent();
            protectedInternalStudent.ProtectedInternalStudent1 = "asd";

            // Ei saa kasutada kuna private protected tasemel
            var privateProtectedStudent = new PrivateProtectedStudent();
            // Alumine rida annab errorit kuna on private protected
            //privateProtectedStudent.ProtectedInternalStudent1 = "asdasd";
            
            // Private protected muutujat saab kasutada ainult samas classis
            // kindlasti peab sellele järgnema ka MINGISUGUNE VÄÄÄÄÄÄÄÄÄÄRTUS!!!!
            Program pp = new Program();
            Console.WriteLine(pp.PrivateProtectedInProgramClass = "asdasd123 Main Method");

            Console.WriteLine("-----------------------------------");

            var sc = new SealedStudent();
            sc.Id = 123;
            sc.Name = "Putin";
            sc.Email = "Putin@gay.ee";
            Console.WriteLine($"ID = {sc.Id}\nName = {sc.Name}\nEmail = {sc.Email}");

            Console.ReadKey();
        }
        protected void DoSomethingInProgramClass()
        {
            Console.WriteLine("asdasdasdasdasd");
        }
        private protected string PrivateProtectedInProgramClass = "PrivateProtectedInProgramClass";
    }
    class Student1
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}