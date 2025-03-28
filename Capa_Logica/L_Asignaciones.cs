using System;
using System.Data;
using Capa_Datos;

namespace Capa_Logica
{
    public class L_Asignaciones
    {
        private D_Asignaciones datos = new D_Asignaciones();

        // Método para obtener todas las asignaciones
        public DataTable MostrarAsignaciones()
        {
            return datos.MostrarAsignaciones();
        }

        // Método para insertar una nueva asignación
        public void InsertarAsignacion(int ReparacionID, int TecnicoID, DateTime FechaAsignacion)
        {
            datos.InsertarAsignacion(ReparacionID, TecnicoID, FechaAsignacion);
        }

        // Método para editar una asignación existente
        public void EditarAsignacion(int AsignacionID, int ReparacionID, int TecnicoID, DateTime FechaAsignacion)
        {
            datos.EditarAsignacion(AsignacionID, ReparacionID, TecnicoID, FechaAsignacion);
        }

        // Método para eliminar una asignación
        public void EliminarAsignacion(int AsignacionID)
        {
            datos.EliminarAsignacion(AsignacionID);
        }
    }
}



