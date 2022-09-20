using Salon.Model;

namespace Salon.Service.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public EnumTypeUser Type { get; set; }
    }
}
