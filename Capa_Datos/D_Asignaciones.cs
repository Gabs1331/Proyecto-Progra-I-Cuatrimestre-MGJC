using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
    public class D_Asignaciones : Conexion
    {
        // Método para mostrar todas las asignaciones
        public DataTable MostrarAsignaciones()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = AbrirConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("ConsultarAsignaciones", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(tabla);
            }
            return tabla;
        }

        // Método para insertar una nueva asignación (Sin AsignacionID)
        public void InsertarAsignacion(int ReparacionID, int TecnicoID, DateTime FechaAsignacion)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                SqlCommand cmd = new SqlCommand("InsertarAsignacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReparacionID", ReparacionID);
                cmd.Parameters.AddWithValue("@TecnicoID", TecnicoID);
                cmd.Parameters.AddWithValue("@FechaAsignacion", FechaAsignacion);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para editar una asignación existente (Se obtiene AsignacionID desde el DataGridView)
        public void EditarAsignacion(int AsignacionID, int ReparacionID, int TecnicoID, DateTime FechaAsignacion)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                SqlCommand cmd = new SqlCommand("EditarAsignacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AsignacionID", AsignacionID);
                cmd.Parameters.AddWithValue("@ReparacionID", ReparacionID);
                cmd.Parameters.AddWithValue("@TecnicoID", TecnicoID);
                cmd.Parameters.AddWithValue("@FechaAsignacion", FechaAsignacion);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar una asignación (Se obtiene AsignacionID desde el DataGridView)
        public void EliminarAsignacion(int AsignacionID)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                SqlCommand cmd = new SqlCommand("EliminarAsignacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AsignacionID", AsignacionID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

