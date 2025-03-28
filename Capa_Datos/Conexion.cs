using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
    public class Conexion : IDisposable
    {
        private readonly string connectionString = "Data Source=DESKTOP-8LG08BJ\\SQLEXPRESS;Initial Catalog=SistemaReparaciones;Integrated Security=True;TrustServerCertificate=True;";
        protected SqlConnection conexion;
        private bool disposed = false; // Para controlar si ya se ha liberado el objeto

        public Conexion()
        {
            // Inicializa la conexión con la cadena de conexión ya definida.
            conexion = new SqlConnection(connectionString);
        }

        // Método para abrir la conexión
        public SqlConnection AbrirConexion()
        {
            try
            {
                // Asegúrate de que la conexión se abre correctamente
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();  // Abre la conexión si está cerrada
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                // Si hay un error al abrir la conexión, muestra el mensaje
                Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                throw;  // Lanza la excepción para que se maneje fuera de este método
            }
            return conexion;  // Retorna la conexión ya abierta
        }

        // Método para obtener la conexión sin abrirla
        public SqlConnection ObtenerConexion()
        {
            return conexion;  // Solo retorna la conexión sin abrirla
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();  // Cierra la conexión
                Console.WriteLine("Conexión cerrada correctamente.");
            }
        }

        // Implementación de IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Suprime el finalizador para evitar que se llame a un segundo Dispose
        }

        // Método para liberar recursos
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Libera los recursos gestionados
                    if (conexion != null)
                    {
                        conexion.Dispose();  // Libera la conexión
                    }
                }

                disposed = true;
            }
        }

        // Destructor (finalizador)
        ~Conexion()
        {
            Dispose(false); // Llama a Dispose en el destructor
        }
    }
}










