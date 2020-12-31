
namespace Backend.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public int Category_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public double discount { get; set; }
        public int stock { get; set; }
        public string url_image { get; set; }
        public bool is_promotion { get; set; }
        public bool is_activate { get; set; }
    }
}