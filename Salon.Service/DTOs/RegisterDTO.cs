using Salon.Model;

namespace Salon.Service.DTOs
{
    public class RegisterDTO
    {
        public string NameUser { get; set; }
        public string LoginUser { get; set; }
        public string PasswordUser { get; set; }
        public EnumTypeUser Type { get; set; }
    }
}
