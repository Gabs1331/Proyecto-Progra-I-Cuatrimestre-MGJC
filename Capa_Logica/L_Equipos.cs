using System.Data;
using Capa_Datos;

namespace Capa_Logica
{
    public class L_Equipos
    {
        D_Equipos datos = new D_Equipos();

        public DataTable MostrarEquipos()
        {
            return datos.MostrarEquipos();
        }

        public void InsertarEquipo(int equipoID, string tipoEquipo, string modelo, int usuarioID)
        {
            datos.InsertarEquipo(equipoID, tipoEquipo, modelo, usuarioID);
        }

        public void EditarEquipo(int equipoID, string tipoEquipo, string modelo, int usuarioID)
        {
            datos.EditarEquipo(equipoID, tipoEquipo, modelo, usuarioID);
        }

        public void EliminarEquipo(int equipoID)
        {
            datos.EliminarEquipo(equipoID);
        }
    }
}

