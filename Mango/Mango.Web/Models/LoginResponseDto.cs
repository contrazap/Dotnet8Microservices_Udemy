using Mango.Web.Models;

namespace Mango.Web
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
