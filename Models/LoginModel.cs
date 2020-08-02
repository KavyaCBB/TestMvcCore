using System;
namespace TestMvcCore.Models
{
    public class LoginModel
    {
        public int Loginid { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public string SocialLoginType { get; set; }
        public string Token { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
