
namespace UNOESC.BL
{
    public class Product
    {
        //-------------
        public Product() { }

        public Product(int productId)
        {
            ProductId = productId;
        }
        //--------------

        //--------------
        // ? = Nullable Type que possibilita que este atributo seja nulo
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        //--------------

        //--------------
        public bool Validate()
        {
            var isValid = true;

            if( string.IsNullOrWhiteSpace(ProductName) )
                isValid = false;

            if (CurrentPrice == null)
                isValid = false;

            return isValid;                
        }
        //--------------
    }
}
