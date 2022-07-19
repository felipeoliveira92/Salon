using Salon.Model;

namespace Salon.Api.ViewModels
{
    public class RegisterViewModel
    {
        public string NameUser { get; set; }
        public string LoginUser { get; set; }
        public string PasswordUser { get; set; }
        public EnumTypeUser Type { get; set; }
    }
}
