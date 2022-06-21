namespace UNOESC.BL
{
    public class ProductRepository
    {

        public Product Retrieve( int productId )
        { 
            // Implementa a lógica de acesso a dados
            Product product = new Product(productId);

            if (productId == 1)
            {
                product.ProductName = "Book";
                product.CurrentPrice = 75;
                product.ProductDescription = "Book of Souls";                
            }

            return product;
        }

        public bool Save( Product p )
        {
            // Lógica para salvar o produto no repositório de dados
            return true;
        }

    }
}
