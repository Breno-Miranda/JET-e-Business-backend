using Backend.Core.Requests;

namespace Backend.Core.Request
{
    public class RequestRegisterProduct : BaseRequest
    {
        public int Id { get; set; }
        public int Category_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
        public int Stock { get; set; }
        public string Url_image { get; set; }
        public bool Is_promotion { get; set; }
        public bool Is_activate { get; set; }
    }
}