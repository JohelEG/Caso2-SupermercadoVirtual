using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoVirtual
{
    public class Cls_Cliente : Cls_Abstract
    {

        #region variables
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        #endregion
        public List<Cls_Cliente> cls_Clientes { get; set; }

        #region Metodos
        public override void Crear()
        {
           if(cls_Clientes is null)
            {
                cls_Clientes = new List<Cls_Cliente>();
                cls_Clientes.Add(new Cls_Cliente("1AB23", "Johel Eli", "San Jose ...", "+5067888","jeliz@test.com"));
                cls_Clientes.Add(new Cls_Cliente("2AB45", "Alfredo Mar", "Alajuela ...", "+50667854", "amar@test.com"));
                cls_Clientes.Add(new Cls_Cliente("64516767", "Maria Rod", "Guanacaste ...", "+5068845", "mrod@test.com"));
            }
            else
            {
                cls_Clientes.Add(new Cls_Cliente(Cedula, Nombre, Direccion, Telefono, Email));
                Console.WriteLine("Se creo un nuevo cliente");
            }
        }

        public override void Consultar()
        {
            if(Cedula != null && Cedula != string.Empty)
            {
                foreach(Cls_Cliente cliente in cls_Clientes.Where(x=>x.Cedula == Cedula))
                {
                    Console.WriteLine($"El cliente {cliente.Nombre} con cedula {cliente.Cedula}, con telefono {cliente.Telefono}, direccion {cliente.Direccion} y con el correo electronico {cliente.Email}");
                }
            }
            else
            {
                foreach (Cls_Cliente cliente in cls_Clientes)
                {
                    Console.WriteLine($"El cliente {cliente.Nombre} con cedula {cliente.Cedula}, con telefono {cliente.Telefono}, direccion {cliente.Direccion} y con el correo electronico {cliente.Email}");
                }
            }
        }

        public override void Eliminar()
        {
            if (Cedula != null && Cedula != string.Empty)
            {
                for(int posicion = 0; posicion < cls_Clientes.Count; posicion++)
                {
                    if(Cedula == cls_Clientes[posicion].Cedula)
                    {
                        cls_Clientes.Remove(cls_Clientes[posicion]);
                        Console.WriteLine($"Se elimino el cliente con la cedula {Cedula}");
                    }
                }
            }
        }

        public override void Modificar()
        {
            if (Cedula != null && Cedula != string.Empty)
            {
                foreach (Cls_Cliente cliente in cls_Clientes.Where(x => x.Cedula == Cedula))
                {
                    if(Telefono != string.Empty && Telefono != null)
                    {
                        cliente.Telefono = Telefono;
                    }
                    if (Direccion != string.Empty && Direccion != null)
                    {
                        cliente.Direccion = Direccion;
                    }
                    if(Email != string.Empty && Email != null)
                    {
                        cliente.Email = Email;
                    }

                    Console.WriteLine($"Se actualizo la informacion del cliente con la cedula {Cedula}");
                }
            }
        }

        #endregion

        #region Constructor
        public Cls_Cliente(string cedula, string nombre, string direccion, string telefono, string email)
        {
            Cedula = cedula;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }
        public Cls_Cliente()
        {

        }
        #endregion
    }
}
