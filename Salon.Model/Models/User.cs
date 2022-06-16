namespace Salon.Model
{
    public class User
    {    
        [key]
        public int IdUser { get; set; }
        public string NameUser { get; set; }
        public string LoginUser { get; set; }
        public string PasswordUser { get; set; }
        public int Type { get; set; }
    }
}
