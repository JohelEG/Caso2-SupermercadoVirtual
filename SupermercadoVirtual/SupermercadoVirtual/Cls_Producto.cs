using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoVirtual
{
    public class Cls_Producto : Cls_Abstract
    {
        #region variables
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        #endregion

        public List<Cls_Producto> cls_Productos { get; set; }

        #region Constructor
        public Cls_Producto(string nombreProducto, int cantidad, decimal costo)
        {
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            Costo = costo;
        }

        public Cls_Producto()
        {

        }

        public override void Crear()
        {
            if (cls_Productos is null)
            {
                cls_Productos = new List<Cls_Producto>();
                cls_Productos.Add(new Cls_Producto("Jabon", 15, 350.58m));
                cls_Productos.Add(new Cls_Producto("Arroz", 60, 900m));
                cls_Productos.Add(new Cls_Producto("Atun",  30, 950m));
                cls_Productos.Add(new Cls_Producto("Jugo", 80, 350.58m));
                cls_Productos.Add(new Cls_Producto("Cereal", 94, 350.58m));
                cls_Productos.Add(new Cls_Producto("Desodorante", 64, 2000.61m));
                cls_Productos.Add(new Cls_Producto("Galletas", 120, 750m));
                cls_Productos.Add(new Cls_Producto("Leche", 150, 1000m));
                cls_Productos.Add(new Cls_Producto("Alcohol en gel", 160, 500m));
                cls_Productos.Add(new Cls_Producto("Cerveza", 200, 1000m));
            }
            else
            {
                cls_Productos.Add(new Cls_Producto(NombreProducto, Cantidad, Costo));
                Console.WriteLine("Se creo un nuevo producto");
            }
        }

        public override void Consultar()
        {
            if (NombreProducto != null && NombreProducto != string.Empty)
            {
                foreach (Cls_Producto producto in cls_Productos.Where(x=> x.NombreProducto == NombreProducto))
                {
                    Console.WriteLine($"Producto {producto.NombreProducto} con una cantidad disponible {producto.Cantidad} con un precio unitario de {producto.Costo}");
                }
            }
            else
            {
                foreach (Cls_Producto producto in cls_Productos)
                {
                    Console.WriteLine($"Producto {producto.NombreProducto} con una cantidad disponible {producto.Cantidad} con un precio unitario de {producto.Costo}");
                }
            }
        }

        public override void Eliminar()
        {
            if (NombreProducto != null && NombreProducto != string.Empty)
            {
                for (int posicion = 0; posicion < cls_Productos.Count; posicion++)
                {
                    if (NombreProducto == cls_Productos[posicion].NombreProducto)
                    {
                        cls_Productos.Remove(cls_Productos[posicion]);
                        Console.WriteLine($"Se elimino el producto: {NombreProducto}");
                    }
                }
            }
        }

        public override void Modificar()
        {
            if (NombreProducto != "" && NombreProducto != string.Empty)
            {
                foreach (Cls_Producto producto in cls_Productos.Where(x => x.NombreProducto == NombreProducto))
                {
                    if (Cantidad > -1)
                    {
                        producto.Cantidad = Cantidad;
                    }
                    if (Costo > 0)
                    {
                        producto.Costo = Costo;
                    }

                    Console.WriteLine($"Se actualizo la informacion del producto: {NombreProducto}");
                }
            }
        }

        #endregion

    }
}
