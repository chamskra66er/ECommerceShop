
namespace ECommerce.Data
{
    public class Favorite
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public string ProductName { get; set; }
        public string ImgUrl { get; set; }
    }
}
