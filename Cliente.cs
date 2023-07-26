using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
    public class Cliente
    {
        private string cedula;
        private string nombres;
        private string apellidos;
        private string telefono;
        private string direccion;
        private string email;
        private string ciudad;

        public Cliente()
        {
            cedula = "1023890910";
            nombres = "Yeison";
            apellidos = "Buitrago";
            telefono = "3142594875";
            direccion = "calle 73#12-10";
            email = "yed@gmail.com";
            ciudad = "Bogotá";
        }


        public Cliente(string cedula, string nombres, string apellidos, string telefono, string direccion, string email, string ciudad)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.ciudad = ciudad;
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public void Registro()
        {
            // Realizar el registro del cliente
            Console.WriteLine("Cliente registrado exitosamente.");
        }

        public void Actualizar(string cedula, string nombres, string apellidos, string telefono, string direccion, string email, string ciudad)
        {
            // Actualizar los datos del cliente
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.ciudad = ciudad;

            Console.WriteLine("Datos del cliente actualizados exitosamente.");
        }


     

        public void Consultar()
        {
            // Realizar la consulta y visualización de los datos del cliente
            Console.WriteLine("Datos del cliente:");
            Console.WriteLine("Cédula: " + cedula);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Teléfono: " + telefono);
            Console.WriteLine("Dirección: " + direccion);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Ciudad: " + ciudad);
        }
    }
}


