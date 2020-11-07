using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoVirtual
{
    public class Cls_Carrito : Cls_Item
    {

        public int Identificador { get; set; }

        public Cls_Cliente Cls_Cliente { get; set; }

        public List<Cls_Item> items { get; set; }

        public Cls_Carrito(int identificador, Cls_Cliente cliente, Cls_Item item, int cantidad) : base(item, cantidad)
        {
            Identificador = identificador;
            Cls_Cliente = cliente;
        }

        public Cls_Carrito()
        {

        }


        #region Metodos

        public void AgregarItem(Cls_Item item, int cantidad)
        {
            if (items is null )
            {
                items = new List<Cls_Item>();

                items.Add(new Cls_Item(item, cantidad));
            }
            else
            {
                items.Add(new Cls_Item(item, cantidad));
            }

        }


        public void Compra()
        {
            if(items != null)
            {
                Cls_Cliente.Consultar();
                Console.WriteLine("Posee los siguientes articulos:");
                foreach(Cls_Item items in items)
                {
                    items.Consultar();
                    Console.WriteLine($"Numero de orden {Identificador}");
                }
            }
            else
            {
                Console.WriteLine("Debe agregar al menos un item");
            }
        }

        public void Factura()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("----------Factura--------------");
            Console.WriteLine($"Fecha de emision {string.Format("{0:dd/MM/yyyy}",dt)}");
            Console.WriteLine($"Emitida para {Cls_Cliente.Nombre}, cedula: {Cls_Cliente.Cedula}");
            Console.WriteLine($"Correo {Cls_Cliente.Email}");
            Console.WriteLine($"Direccion {Cls_Cliente.Direccion}");
            Console.WriteLine($"Telefono {Cls_Cliente.Telefono}");
            Console.WriteLine($"Numero de orden {Identificador}");
            Console.WriteLine("----------Lista de productos--------------");
            foreach(Cls_Item items in items)
            {
                Console.WriteLine($"Producto: {items.NombreProducto} --- Cantidad: {items.CantidadCompra} --- Precio unitario:{items.Costo} --- Precio Total: {items.CantidadCompra * items.Costo}");
            }
            Pago();
        }

        public void Pago()
        {
            decimal pago = 0.0m;   
            foreach (Cls_Item items in items)
            {
                pago += (items.CantidadCompra * items.Costo);
            }

            Console.WriteLine($"Su pago total es: {pago}");
            
        }

        #endregion

    }
}
