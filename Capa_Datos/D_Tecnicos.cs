using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;


namespace Capa_Datos
{
    public class D_Tecnicos : Conexion
    {
        // Método para mostrar los técnicos
        public DataTable MostrarTecnicos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlDataAdapter da = new SqlDataAdapter("ConsultarTecnicos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(tabla);
            }
            return tabla;
        }

        // Método para insertar un técnico
        public void InsertarTecnico(int tecnicoID, string nombre, string especialidad)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlCommand cmd = new SqlCommand("InsertarTecnico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TecnicoID", tecnicoID);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Especialidad", especialidad);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para editar un técnico
        public void EditarTecnico(int tecnicoID, string nombre, string especialidad)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlCommand cmd = new SqlCommand("ModificarTecnico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TecnicoID", tecnicoID);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Especialidad", especialidad);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar un técnico
        public void EliminarTecnico(int tecnicoID)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlCommand cmd = new SqlCommand("EliminarTecnico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TecnicoID", tecnicoID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}


