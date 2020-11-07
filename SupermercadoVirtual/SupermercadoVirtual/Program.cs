using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SupermercadoVirtual
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region comentarios
            /*
            #region Cliente
            Cls_Cliente cliente = new Cls_Cliente();
            cliente.Crear();
            Console.WriteLine("Lista de clientes por defecto");
            cliente.Cedula = string.Empty;
            cliente.Consultar();

            Console.WriteLine("Consultar 1 Cliente");
            cliente.Cedula = "1AB23";
            cliente.Consultar();

            Console.WriteLine("Eliminar 1 Cliente");
            cliente.Cedula = "2AB45";
            cliente.Eliminar();
            cliente.Cedula = string.Empty;
            cliente.Consultar();

            Console.WriteLine("Modificar 1 Cliente");
            cliente.Cedula = "64516767";
            cliente.Direccion = string.Empty;
            cliente.Email = "mrod@test.net";
            cliente.Telefono = "+5068844";
            cliente.Modificar();
            cliente.Consultar();

            Console.WriteLine("Crear 1 Cliente");
            cliente.Cedula = "1254678";
            cliente.Nombre = "Rodolfo Gom";
            cliente.Telefono = "+5069878431336";
            cliente.Direccion = "Heredia .....lkl";
            cliente.Email = "rgom@test.co.cr";
            cliente.Crear();

            Console.WriteLine("Lista de Clientes");
            cliente.Cedula = string.Empty;
            cliente.Consultar();
            #endregion

            #region Productos
            Cls_Producto producto = new Cls_Producto();
            producto.Crear();
            Console.WriteLine("Lista de produtcos por defecto");
            producto.NombreProducto = string.Empty;
            producto.Consultar();

            Console.WriteLine("Consultar 1 producto");
            producto.NombreProducto = "Jabon";
            producto.Consultar();

            Console.WriteLine("Eliminar 1 producto");
            producto.NombreProducto = "Desodorante";
            producto.Eliminar();
            producto.NombreProducto = string.Empty;
            producto.Consultar();

            Console.WriteLine("Modificar 1 producto");
            producto.NombreProducto = "Leche";
            producto.Costo = 1550;
            producto.Cantidad = 200;
            producto.Modificar();
            producto.Consultar();

            Console.WriteLine("Crear 1 producto");
            producto.NombreProducto = "Cafe";
            producto.Costo = 740;
            producto.Cantidad = 250;
            producto.Crear();
            producto.Consultar();

            Console.WriteLine("Lista de productos");
            producto.NombreProducto = string.Empty;
            producto.Consultar();
            #endregion

            #region Item y actualizar Producto
            producto.NombreProducto = "Cafe";
            producto.Costo = 740;
            producto.Cantidad = 250;
            Cls_Item item = new Cls_Item(producto, 12);
            item.Consultar();

            producto.NombreProducto = "Cafe";
            producto.Cantidad = item.CantidadProducto();
            producto.Modificar();
            producto.Consultar();
            #endregion

            #region Carrito

            cliente.Cedula = "1254678";
            cliente.Nombre = "Rodolfo Gom";
            cliente.Telefono = "+5069878431336";
            cliente.Direccion = "Heredia .....lkl";
            cliente.Email = "rgom@test.co.cr";



            item.NombreProducto = "Leche";
            item.Costo = 1000m;
            item.Cantidad = 150;
            item.CantidadCompra = 12;
           
            Cls_Carrito carrito = new Cls_Carrito(0, cliente, item, item.CantidadCompra);
            carrito.AgregarItem(item, item.CantidadCompra);

            item.NombreProducto = "Cafe";
            item.Costo = 740;
            item.Cantidad = 250;
            item.CantidadCompra = 10;
            carrito.AgregarItem(item, item.CantidadCompra);
            carrito.Compra();
            carrito.Pago();
            carrito.Factura();

            #endregion
            */
            #endregion

            Cls_Menu Tienda = new Cls_Menu();
            Tienda.Menu();

        }

       
    }
}
