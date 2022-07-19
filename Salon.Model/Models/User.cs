using System.ComponentModel.DataAnnotations;

namespace Salon.Model.Models
{
    public class User
    {    
        [Key]
        public int IdUser { get; set; }
        public string NameUser { get; set; }
        public string LoginUser { get; set; }
        public string PasswordUser { get; set; }
        public EnumTypeUser Type { get; set; }

        public User(string name, string login, string password)
        {
            NameUser = name;
            LoginUser = login;
            PasswordUser = password;
        }

    }
}
