using System.Data;
using Capa_Datos;
using Microsoft.Data.SqlClient;

namespace Capa_Logica
{
    public class L_Usuarios
    {
        D_Usuarios datos = new D_Usuarios();

        public DataTable MostrarUsuarios()
        {
            return datos.MostrarUsuarios();  // Llama a la capa de datos para mostrar los usuarios
        }

        public void InsertarUsuario(string nombre, string correo, string telefono)
        {
            datos.InsertarUsuario(nombre, correo, telefono); // Llama a la capa de datos para insertar el usuario
        }

        public void EditarUsuario(int usuarioID, string nombre, string correo, string telefono)
        {
            datos.EditarUsuario(usuarioID, nombre, correo, telefono); // Llama a la capa de datos para editar el usuario
        }

        public void EliminarUsuario(int usuarioID)
        {
            datos.EliminarUsuario(usuarioID); // Llama a la capa de datos para eliminar el usuario
        }
    }
}




