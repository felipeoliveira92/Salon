using System.ComponentModel.DataAnnotations;

namespace Salon.Model.Models
{
    public class User
    {            
        public User(string name, string login, string password, EnumTypeUser type)
        {
            Name = name;
            Username = login;
            Password = password;
            Type = type;
        }

        public User()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public EnumTypeUser Type { get; set; }
    }
}
