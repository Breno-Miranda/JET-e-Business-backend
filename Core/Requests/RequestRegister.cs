using Backend.Core.Requests;

namespace Backend.Core.Request
{
    public class RequestRegister : BaseRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}