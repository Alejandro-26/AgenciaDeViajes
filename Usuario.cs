using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
    public class Usuario
    {
        private string idUsuario;
        private string nombreUsuario;
        private string contraseña;
        private string rolUsuario;

        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public string RolUsuario
        {
            get { return rolUsuario; }
            set { rolUsuario = value; }
        }

        public Usuario()
        {
            // Constructor predeterminado
            idUsuario = "";
            nombreUsuario = "";
            contraseña = "";
            rolUsuario = "";
        }

        public Usuario(string idUsuario, string nombreUsuario, string contraseña, string rolUsuario)
        {
            // Constructor con parámetros
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.rolUsuario = rolUsuario;
        }

        public void Registro(string idUsuario, string nombreUsuario, string contraseña, string rolUsuario)
        {
            
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.rolUsuario = rolUsuario;

            Console.WriteLine("Registro de usuario realizado.");
        }

        public void ActualizarContraseña(string nuevaContraseña)
        {
            this.contraseña = nuevaContraseña;

            Console.WriteLine("Contraseña actualizada correctamente.");
        }

        public bool Login(string nombreUsuario, string contraseña)
        {
          
            if (this.nombreUsuario == nombreUsuario && this.contraseña == contraseña)
            {
                Console.WriteLine("Inicio de sesión exitoso.");
                return true;
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido. Nombre de usuario o contraseña incorrectos.");
                return false;
            }
        }

      
    }

}
