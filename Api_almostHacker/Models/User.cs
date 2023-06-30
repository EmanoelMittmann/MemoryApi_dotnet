using Api_almostHacker.Enuns;

namespace Api_almostHacker.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleEnum Role { get; set; }
        public string Cpf { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
