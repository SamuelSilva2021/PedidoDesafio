
namespace PedidoDesafio.Entitites
{
    class Product
    {
        public string Name { get; set; }
        public double Prince { get; set; }

        public Product()
        {

        }

        public Product(string name, double prince)
        {
            Name = name;
            Prince = prince;
        }
    }
}
