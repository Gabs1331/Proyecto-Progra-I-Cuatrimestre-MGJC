using Capa_Datos;
using System.Data;


namespace Capa_Logica
{
    public class L_Tecnicos
    {
        D_Tecnicos datos = new D_Tecnicos();

        public DataTable MostrarTecnicos()
        {
            return datos.MostrarTecnicos();
        }

        public void InsertarTecnico(int tecnicoID, string nombre, string especialidad)
        {
            datos.InsertarTecnico(tecnicoID, nombre, especialidad);
        }

        public void EditarTecnico(int tecnicoID, string nombre, string especialidad)
        {
            datos.EditarTecnico(tecnicoID, nombre, especialidad);
        }

        public void EliminarTecnico(int tecnicoID)
        {
            datos.EliminarTecnico(tecnicoID);
        }
    }
}

