namespace Encapsulation.Services
{
    // Internal classis saab kutsuda esile projekti sees.
    // teisest projektis olevat internal classi ei saa välja kutsuda
    public class Student2
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}