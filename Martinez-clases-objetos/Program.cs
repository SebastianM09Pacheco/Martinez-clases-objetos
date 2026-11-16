using System;
namespace Martinez_clases_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Producto Numero" + i);
                Console.WriteLine("Escribe el nombre del producto: ");
                string nombre = Console.ReadLine() ?? "";
                
                while (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine("No se puede poner nombres vacios");
                    Console.WriteLine("Escribe el nombre del producto: ");
                    nombre = Console.ReadLine() ?? "";
                }

                Console.WriteLine("Escribe el precio del producto: ");
                double precio = 0;

                while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0)
                {
                    Console.WriteLine("Introduce un precio válido mayor que 0:");
                }

                Console.WriteLine("Escribe la cantidad del producto: ");
                int cantidad = 0;

                while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
                {
                    Console.WriteLine("Introduce una cantidad válida que 0 o mayor:");
                }

                Console.WriteLine("Escribe el Codigo del producto: ");
                int codigo = 0;
                while (!int.TryParse(Console.ReadLine(), out codigo))
                {
                    Console.WriteLine("Debes introducir un código numérico válido.");
                }

                Producto producto = new Producto(codigo, nombre, precio, cantidad);
                producto.MostrarInfo();

            }

        }


    }
}