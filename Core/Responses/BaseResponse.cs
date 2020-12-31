using System.Collections.Generic;


namespace Backend.Core.Responses
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public List<string> MessageList { get; set; }
        public BaseResponse()
        {
            MessageList = new List<string>();
        }
    }
}