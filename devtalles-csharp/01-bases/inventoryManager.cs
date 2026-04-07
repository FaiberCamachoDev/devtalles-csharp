partial class Program
{
    static string[] _products = ["Monitor", "Teclado", "Mouse"];
    static int[] _stock = [10, 25, 30];
    static double[] _prices=[250.50, 25.50, 45.00];
    static bool _exit = false;
    static void InventoryManager()
    {
        
        do
        {
            Console.WriteLine(@"1. comprar productos
2. listar inventario
3. salir");
            int inputOption = int.Parse(Console.ReadLine()!);
            switch (inputOption)
            {
                case  1:
                    Console.Clear();
                    buyProduct();
                    break;
                case 2:
                    Console.Clear();
                    showListProducts();
                    break;
                case 3:
                    Console.Clear();
                    _exit = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("«elige una opcion correcta del menu»");
                    break;
            }
        } while (!_exit);

        static void showListProducts()
        {
            Console.WriteLine("Inventario de productos");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < _products.Length; i++)
            {
                Console.WriteLine($"Producto: {_products[i]}, Stock: {_stock[i]}, Prices: {_prices[i]:C}");
            }
        }

        static void buyProduct()
        {
            Console.WriteLine("\nIngrese el producto que desea comprar: ");
            string? searchedProduct = Console.ReadLine();
            Console.WriteLine("\nIngrese la cantidad que desee comprar: ");
            int quantity = int.Parse(Console.ReadLine()!); // ! es un nullishing operator para que permita hacer la conversion
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase)) // products representa cada producto recorrido, cambio cada que equals no coincide.
                {
                    if (quantity <= _stock[i])
                    {
                        double total = quantity * _prices[i];
                        _stock[i] -= quantity;
                        Console.WriteLine($"Compra exitosa, total a pagar: {total:C}"); //:C formato de moneda (currency)
                        Console.WriteLine($"Stock restante para el producto {searchedProduct} es: {_stock[i]}");
                    }
                    else
                    {
                        Console.WriteLine("Not in stock avaliable.");
                    }
                }
            }
        }
    }
}