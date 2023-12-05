using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentadora_equipo.Clases
{
    class CConexion
    {
        SqlConnection conex = new SqlConnection();

        static String servidor = "localhost";
        static String bd = "Rentadora3";
        static String usuario = "root2";
        static String contrasenia = "denilson18";
        static String puerto = "1433";

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
        {
            DataSource = $"{servidor},{puerto}",
            InitialCatalog = bd,
            UserID = usuario,
            Password = contrasenia,
            PersistSecurityInfo = true
        };

        public SqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = builder.ConnectionString;
                conex.Open();
                return conex;
            }
            catch (Exception ex)
            {
                // Manejar la excepción según sea necesario.
                return null;
            }
        }

        public void cerrarConexion()
        {
            conex.Close();
        }


        //conexion del login
        public bool VerificarCredenciales(string Correo, string Clave)
        {
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Verificar las credenciales en tu tabla de clientes
                    string query = "SELECT * FROM Clientes WHERE Correo = @Correo AND Clave = @Clave";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Correo", Correo);
                        command.Parameters.AddWithValue("@Clave", Clave);

                        int count = (int)command.ExecuteScalar();

                        return count > 0; // Devuelve true si las credenciales son válidas
                    }
                }
                catch (Exception ex)
                {
                    // Imprimir información detallada sobre la excepción
                    Console.WriteLine($"Error al verificar credenciales: {ex.Message}");
                    Console.WriteLine($"StackTrace: {ex.StackTrace}");
                    return false;
                }
            }
        }

    }



    }




