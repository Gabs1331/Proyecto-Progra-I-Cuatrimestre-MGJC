using Capa_Datos;
using System;

namespace Capa_Logica
{
    public class L_Login
    {
        private D_Login datos = new D_Login();

        public bool ValidarUsuario(string usuarioID, string contrasena)
        {
            return datos.ValidarUsuario(usuarioID, contrasena);  // Validación de usuario usando D_Login
        }

        // Método LoginCorrecto que usa el método ValidarUsuario
        public bool LoginCorrecto(string usuarioID, string contrasena)
        {
            return ValidarUsuario(usuarioID, contrasena);  // Llama a ValidarUsuario
        }
    }
}







