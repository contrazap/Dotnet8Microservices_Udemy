using Mango.Services.AuthAPI.Models.Dto;

namespace Mango.Services.AuthAPI.Models
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
