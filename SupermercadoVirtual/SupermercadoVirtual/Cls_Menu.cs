using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SupermercadoVirtual
{
    public class Cls_Menu
    {
        Cls_Cliente cliente = new Cls_Cliente();
        Cls_Producto producto = new Cls_Producto();
        Cls_Item item = new Cls_Item();

        public void Menu()
        {
            //Cargar valores por defecto
            cliente.Crear();
            producto.Crear();
            
            List<int> CodigoCarrito = new List<int>();
            bool estado = true;
            string sentenciaregex = @"^[1-3]+$";
            
            while (estado)
            {
                Console.WriteLine("Ingrese una de las siguientes opciones: \n 1. Administrar la tienda \n 2. Carrito \n 3. Salir");
                Regex numero = new Regex(sentenciaregex);
                string dato = Console.ReadLine();

                if (numero.IsMatch(dato))
                {
                    int accion = Convert.ToInt32(dato);

                    switch (accion)
                    {
                        case 1:
                            FuncionesMantenimiento(cliente, producto);
                            break;
                        case 2:
                            CarritoCompra(cliente, producto, item, CodigoCarrito);
                            break;
                        case 3:
                            estado = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una opcion valida...");
                }
            }

            Console.WriteLine("Se salio del sistema");
            Console.ReadLine();
        }

        private static void FuncionesMantenimiento(Cls_Cliente cliente, Cls_Producto producto)
        {
            bool estado = true;
            string sentenciaregex = @"^[1-9]+$";
            while (estado)
            {
                Console.WriteLine("Ingrese una de las siguientes opciones: \n " +
                    "1. Crear un cliente  \n " +
                    "2. Borrar un cliente \n " +
                    "3. Actualizar un cliente \n" +
                    "4. Buscar un cliente \n " +
                    "5. Crear un producto  \n " +
                    "6. Borrar un producto \n " +
                    "7. Actualizar un producto \n" +
                    "8. Buscar un producto \n" +
                    "9. Salir");
                Regex numero = new Regex(sentenciaregex);
                string dato = Console.ReadLine();

                if (numero.IsMatch(dato))
                {
                    int accion = Convert.ToInt32(dato);

                    switch (accion)
                    {
                        case 1:
                            Console.WriteLine("Opcion Para definir un nuevo cliente, por favor completar los siguientes valores");
                            NuevoUsuario(cliente);
                            break;
                        case 2:
                            Console.WriteLine("Opcion Para eliminar un cliente");
                            EliminarCliente(cliente);
                            break;
                        case 3:
                            Console.WriteLine("Opcion Para actualizar un cliente");
                            ActualizarCliente(cliente);
                            break;
                        case 4:
                            Console.WriteLine("Opcion Para buscar uno o mostrar todos los clientes");
                            BusquedaCliente(cliente);

                            break;
                        case 5:
                            Console.WriteLine("Opcion Para definir un nuevo producto, por favor completar los siguientes valores");
                            NuevoProducto(producto);
                            break;
                        case 6:
                            Console.WriteLine("Opcion Para eliminar un producto");
                            EliminarProducto(producto);
                            break;
                        case 7:
                            Console.WriteLine("Opcion Para actualizar un producto");
                            ActualizarProducto(producto);
                            break;
                        case 8:
                            Console.WriteLine("Opcion Para buscar uno o mostrar todos los productos");
                            BusquedaProducto(producto);
                            break;
                        case 9:
                            estado = false;
                            break;

                    }
                }
            }
        }

        private static void BusquedaProducto(Cls_Producto producto)
        {
            Console.WriteLine("Ingrese \n 1.Busqueda de un producto \n 2.Mostrar todos los productos \n Presione cualquier numero para salir");
            Regex numero = new Regex(@"^[1-2]+$");
            string dato = Console.ReadLine();
            if (numero.IsMatch(dato))
            {
                int accion = Convert.ToInt32(dato);
                switch (accion)
                {
                    case 1:
                        Console.WriteLine("Indicar nombre de producto:");
                        producto.NombreProducto = Console.ReadLine();
                        Console.WriteLine("Producto en el sistema");
                        producto.Consultar();
                        break;
                    case 2:
                        producto.NombreProducto = string.Empty;
                        Console.WriteLine("Productos en el sistema");
                        producto.Consultar();
                        break;
                }
            }
        }

        private static void ActualizarProducto(Cls_Producto producto)
        {
            Console.WriteLine("Indicar nombre del producto:");
            producto.NombreProducto = Console.ReadLine();
            int cantidad = -1;
            decimal costo = 0;

            Console.WriteLine("Desea actualizar la cantidad de producto, por favor indicar \n 1.Si \n 2.No");
            string decisioncantidad = Console.ReadLine();

            if (decisioncantidad.Contains("Si") || decisioncantidad.Contains("si"))
            {
                Console.WriteLine("Ingrese la cantidad total de producto");
                cantidad = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Desea actualizar el costo del producto, por favor indicar \n 1.Si \n 2.No");
            string decisioncosto = Console.ReadLine();
            if (decisioncosto.Contains("Si") || decisioncosto.Contains("si"))
            {
                Console.WriteLine("Ingrese el nuevo costo del producto");
                costo = Convert.ToDecimal(Console.ReadLine());
            }

            producto.Cantidad = cantidad;
            producto.Costo = costo;
            producto.Modificar();
        }

        private static void EliminarProducto(Cls_Producto producto)
        {
            Console.WriteLine("Indicar nombre de producto:");
            producto.NombreProducto = Console.ReadLine();
            producto.Eliminar();
        }

        private static void NuevoProducto(Cls_Producto producto)
        {
            Console.WriteLine("Indicar nombre de producto:");
            producto.NombreProducto = Console.ReadLine();
            Console.WriteLine("Indicar cantidad de producto:");
            producto.Cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indicar costo unitario del producto:");
            producto.Costo = Convert.ToDecimal(Console.ReadLine());
            producto.Crear();
        }

        private static void BusquedaCliente(Cls_Cliente cliente)
        {
            Console.WriteLine("Ingrese \n 1.Busqueda de un cliente \n 2.Mostrar todos los clientes \n Presione cualquier numero para salir");
            Regex numero = new Regex(@"^[1-2]+$");
            string dato = Console.ReadLine();
            if (numero.IsMatch(dato))
            {
                int accion = Convert.ToInt32(dato);
                switch (accion)
                {
                    case 1:
                        Console.WriteLine("Indicar la cedula:");
                        cliente.Cedula = Console.ReadLine();
                        Console.WriteLine("Cliente en el sistema");
                        cliente.Consultar();
                        break;
                    case 2:
                        cliente.Cedula = string.Empty;
                        Console.WriteLine("Clientes en el sistema");
                        cliente.Consultar();
                        break;
                }
            }
        }

        private static void ActualizarCliente(Cls_Cliente cliente)
        {
            Console.WriteLine("Indicar la cedula:");
            cliente.Cedula = Console.ReadLine();
            string telefono = string.Empty;
            string direccion = string.Empty;
            string email = string.Empty;

            Console.WriteLine("Desea actualizar el telefono, por favor indicar \n 1.Si \n 2.No");
            string decisiontelefono = Console.ReadLine();

            if (decisiontelefono.Contains("Si") || decisiontelefono.Contains("si"))
            {
                Console.WriteLine("Ingrese el nuevo numero de telefono con el codigo pais");
                telefono = Console.ReadLine();
            }

            Console.WriteLine("Desea actualizar la direccion, por favor indicar \n 1.Si \n 2.No");
            string decisiondireccion = Console.ReadLine();
            if (decisiondireccion.Contains("Si") || decisiondireccion.Contains("si"))
            {
                Console.WriteLine("Ingrese la nueva direccion");
                direccion = Console.ReadLine();
            }

            Console.WriteLine("Desea actualizar el email,  por favor indicar \n 1.Si \n 2.No");
            string decisionemail = Console.ReadLine();
            if (decisionemail.Contains("Si") || decisionemail.Contains("si"))
            {
                Console.WriteLine("Ingrese el nuevo correo");
                email = Console.ReadLine();
            }

            cliente.Telefono = telefono;
            cliente.Direccion = direccion;
            cliente.Email = email;
            cliente.Modificar();
        }

        private static void EliminarCliente(Cls_Cliente cliente)
        {
            Console.WriteLine("Indicar la cedula:");
            cliente.Cedula = Console.ReadLine();
            cliente.Eliminar();
        }

        private static void NuevoUsuario(Cls_Cliente cliente)
        {
            Console.WriteLine("Indicar la cedula:");
            cliente.Cedula = Console.ReadLine();
            Console.WriteLine("Indicar nombre completo:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Indicar la direccion:");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Indicar Telefono con el codigo país:");
            cliente.Telefono = Console.ReadLine();
            Console.WriteLine("Indicar Email:");
            cliente.Email = Console.ReadLine();
            cliente.Crear();
        }

        private static void CarritoCompra(Cls_Cliente cliente, Cls_Producto producto, Cls_Item item, List<int> codigoCarrito)
        {
            Console.WriteLine("Bienvenido al carrito de comprar");
            bool client = ObtenerCliente(cliente);
           

            if (client)
            {
                Console.WriteLine("Debe agregar al menos un producto al carrito");
                bool estadoItems = true;


                while (estadoItems)
                {
                    bool primeritem = IndicarItems(producto, item);

                    while (primeritem)
                    {
                        Random rnd = new Random();

                        int number = 0;
                        bool estadonumero = false;
                        while (!estadonumero)
                        {
                            number = rnd.Next(1, 1000000);
                            if (!codigoCarrito.Contains(number))
                            {
                                codigoCarrito.Add(number);
                                estadonumero = true;
                            }
                        }


                        Cls_Carrito carrito = new Cls_Carrito(number, cliente, item, item.CantidadCompra);
                        carrito.AgregarItem(item, item.CantidadCompra);


                        bool estadoproducto = true;
                        Console.WriteLine("Desea agregar otro producto, indicar Si o No");
                        string decision = Console.ReadLine();
                        if (decision.Contains("No") || decision.Contains("No"))
                        {
                            estadoproducto = false;
                        }

                        while (estadoproducto)
                        {
                            bool otroitem = IndicarItems(producto, item);
                            while (otroitem)
                            {
                                otroitem = false;
                                carrito.AgregarItem(item, item.CantidadCompra);
                                Console.WriteLine("Desea agregar otro producto, indicar Si o No");
                                decision = Console.ReadLine();
                                if (decision.Contains("No") || decision.Contains("No"))
                                {
                                    estadoproducto = false;
                                }
                            }
                        }
                        estadoItems = false;
                        primeritem = false;
                        carrito.Compra();
                        carrito.Pago();
                        carrito.Factura();
                    }
                }

            }
            else
            {
                Console.WriteLine("El usuario no existe");
            }
        }

        private static bool ObtenerCliente(Cls_Cliente cliente)
        {
            Console.WriteLine("Por favor indicar su identificacion:");
            string cedula = Console.ReadLine();
            foreach (Cls_Cliente cliente1 in cliente.cls_Clientes.Where(x => x.Cedula == cedula))
            {
                cliente.Cedula = cliente1.Cedula;
                cliente.Nombre = cliente1.Nombre;
                cliente.Direccion = cliente1.Direccion;
                cliente.Email = cliente1.Email;
                cliente.Telefono = cliente1.Telefono;
                return true;
            }

            return false;
        }

        private static bool IndicarItems(Cls_Producto producto, Cls_Item item)
        {
            Console.WriteLine("Lista de productos: ");
            producto.NombreProducto = string.Empty;
            producto.Consultar();

            Console.WriteLine("Indicar el nombre del producto para el carrito");
            string productoseleccionado = Console.ReadLine();

            foreach (Cls_Producto producto1 in producto.cls_Productos.Where(x => x.NombreProducto == productoseleccionado))
            {
                Console.WriteLine("Ingresar la cantidad de producto a comprar: ");
                int cantidadcompra = Convert.ToInt32(Console.ReadLine());
                item.NombreProducto = producto1.NombreProducto;
                item.Costo = producto1.Costo;
                item.Cantidad = producto1.Cantidad;
                item.CantidadCompra = cantidadcompra;
                if (item.Cantidad >= cantidadcompra)
                {
                    item.Consultar();
                    producto.NombreProducto = item.NombreProducto;
                    producto.Cantidad = item.CantidadProducto();
                    producto.Modificar();
                    return true;
                }
                return false;
            }
            return false;
        }


    }
}
