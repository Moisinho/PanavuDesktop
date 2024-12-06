using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Microsoft.Extensions.Configuration;

namespace PanavuAdmin.Database
{
    internal class AdminDB
    {
        private string connectionString;

        public AdminDB()
        {
            // Cargar la cadena de conexión desde el archivo de configuración
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public bool GetAdmin(String email, String password)
        {
            try
            {
                using(var  conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Conexión Establecida");
                    string query = "SELECT * FROM Admin WHERE admin_email = @email " +
                        "AND admin_password = @password";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        Console.WriteLine("Consulta preparada: " + query);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.Write("El Administrador " + reader["admin_name"].ToString() +
                                    " se ha autenticado correctamente");
                                return true;
                            }
                            return false;
                        }
                    }          
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la conexión o consulta: " + ex.Message); // Mensaje de error
                return false;
            }
        }
    }
}
