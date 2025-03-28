using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Capa_Datos
{
    public class D_DetallesReparacion : Conexion
    {
        // Método para mostrar los detalles de la reparación
        public DataTable MostrarDetalles()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlDataAdapter da = new SqlDataAdapter("MostrarDetallesReparacion", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(tabla);
            }
            return tabla;
        }

        // Método para insertar un detalle de reparación
        public void InsertarDetalle(int detalleID, int reparacionID, string descripcion, string fechaInicio, string fechaFin)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlCommand cmd = new SqlCommand("InsertarDetalleReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DetalleID", detalleID);
                cmd.Parameters.AddWithValue("@ReparacionID", reparacionID);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para editar un detalle de reparación
        public void EditarDetalle(int detalleID, int reparacionID, string descripcion, string fechaInicio, string fechaFin)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlCommand cmd = new SqlCommand("EditarDetalleReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DetalleID", detalleID);
                cmd.Parameters.AddWithValue("@ReparacionID", reparacionID);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar un detalle de reparación
        public void EliminarDetalle(int detalleID)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos el método AbrirConexion de la clase base
            {
                SqlCommand cmd = new SqlCommand("EliminarDetalleReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DetalleID", detalleID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}