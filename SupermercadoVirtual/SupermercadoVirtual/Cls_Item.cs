using System;

namespace SupermercadoVirtual
{
    public class Cls_Item : Cls_Producto
    {
        public int CantidadCompra { get; set; }

        public Cls_Item(Cls_Producto producto, int cantidad) 
        {
            NombreProducto = producto.NombreProducto;
            Cantidad = producto.Cantidad;
            Costo = producto.Costo;
            CantidadCompra = cantidad;
        }

        public Cls_Item()
        {

        }
  
        public override void Consultar()
        {
            if(CantidadCompra <= Cantidad)
            {
                Console.WriteLine($"Su item escogido fue {NombreProducto} con un costo por unidad de {Costo} con una cantidad de {CantidadCompra}");
            }
            else
            {
                Console.WriteLine($"El producto dispone de una cantidad de {Cantidad}");
            }
        }

        public int CantidadProducto()
        {
            if (CantidadCompra <= Cantidad)
            {
                return Cantidad - CantidadCompra;
            }
            else
            {
                return Cantidad;
            }
        }

    }
}