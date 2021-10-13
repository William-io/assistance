namespace Assistance.Domain.Models
{
    public class User : Entity
    {       
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Genre { get; set; }

        //Sintomas e protocolo
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
