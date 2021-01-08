namespace Backend.Core.Responses
{
    public class ResponseLogin : BaseResponse
    {
        public string Token { get; set; }
        public int ExpireDate { get; set; }
    }
}