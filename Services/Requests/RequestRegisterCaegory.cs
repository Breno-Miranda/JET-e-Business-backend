using Backend.Core.Requests;

namespace Backend.Services.Request
{
    public class RequestRegisterCategory : BaseRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Discount { get; set; }
        public int Stock { get; set; }
        public string Url_image { get; set; }
        public bool Is_promotion { get; set; }
        public bool Is_activate { get; set; }
    }
}