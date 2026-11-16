        using System;
        using System.Collections.Generic;
        using System.Text;

        namespace Martinez_clases_objetos
        {
            internal class Producto
            {
                private string _nombre = "";

                public string Nombre

                 {
                   get
                    {
                        return _nombre;
                    }

                    set
                    {
                       if (String.IsNullOrWhiteSpace(value))
                            {
                            Console.WriteLine("No se puede poner nombres vacios");
                        }

                        else
                        {
                            _nombre = value;
                        }

                    }
                }

                    private double _precio = 0;

                    public double Precio
                    {
                        get
                        {
                            return _precio;
                        }

                        set
                        {
                            if (value <= 0)
                            {
                                Console.WriteLine("El precio debe de ser mayor que 0");
                            }

                            else
                            {
                                _precio = value;
                            }
                        }
                    }

                private int _cantidad = 0;



                public int Cantidad
                {
                    get
                    {
                        return _cantidad;
                    }

                    set
                    {
                        if (value < 0)
                        {
                            Console.WriteLine("La cantidad del producto no puede ser negativa");
                        }

                        else
                        {
                            _cantidad = value;
                        }
                    }
                }

    
                public double ValorTotal
                {
                    get {
                        return _precio * _cantidad; 
                    } 
                }

                private int _codigo = 0;

                public int Codigo
                {
                    get
                    {
                        return _codigo;
                    }

                    set
                    {
                        _codigo = value;
                    }
                }

                public Producto (int codigo, string nombre, double precio, int cantidad)
                {
                    Nombre = nombre;
                    Precio = precio;
                    Cantidad = cantidad;
                    Codigo = codigo;
                }

            public void MostrarInfo()
            {
                    Console.WriteLine("Nombre: " + Nombre);
                    Console.WriteLine("Precio: " + Precio);
                    Console.WriteLine("Cantidad: " + Cantidad);
                    Console.WriteLine("codigo: " + Codigo);
                    Console.WriteLine("Valor total: " + ValorTotal);
                }

                }
            }
