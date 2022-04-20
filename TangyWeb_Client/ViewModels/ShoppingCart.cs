using Tangy_Models;

namespace TangyWeb_Client.ViewModels
{
    public class ShoppingCart
    {
        public int ProductId { get; set; }
        public ProductDTO ProductDTO { get; set; }
        public int ProductPriceId { get; set; }
        public ProductPriceDTO ProductPriceDTO { get; set; }
        public int Count { get; set; }
    }
}
