using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Capa_Datos
{
    public class D_Reparaciones : Conexion
    {
        // Método para mostrar las reparaciones
        public DataTable MostrarReparaciones()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlDataAdapter da = new SqlDataAdapter("MostrarReparaciones", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(tabla);
            }
            return tabla;
        }

        // Método para insertar una reparación
        public void InsertarReparacion(int reparacionID, int equipoID, string fechaSolicitud, string estado)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlCommand cmd = new SqlCommand("InsertarReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReparacionID", reparacionID);
                cmd.Parameters.AddWithValue("@EquipoID", equipoID);
                cmd.Parameters.AddWithValue("@FechaSolicitud", fechaSolicitud);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para editar una reparación
        public void EditarReparacion(int reparacionID, int equipoID, string fechaSolicitud, string estado)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlCommand cmd = new SqlCommand("EditarReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReparacionID", reparacionID);
                cmd.Parameters.AddWithValue("@EquipoID", equipoID);
                cmd.Parameters.AddWithValue("@FechaSolicitud", fechaSolicitud);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar una reparación
        public void EliminarReparacion(int reparacionID)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlCommand cmd = new SqlCommand("EliminarReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReparacionID", reparacionID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
