using System;
using Npgsql;
namespace _14.BasesDeDatos
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Coneccion a Postgresql en C# */
            var connString = "Host=localhost;Username=postgres;Password=1234;Database=testdb";

            NpgsqlConnection conn = new NpgsqlConnection(connString);

            conn.Open();

            /* Consultar a la base de datos */
            var sql = "SELECT * FROM persona";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("Nombre: "+ rdr.GetString(1));
                Console.WriteLine("Edad: "+ rdr.GetInt32(2));
                Console.WriteLine("Email: "+ rdr.GetString(3));
                Console.WriteLine("DNI: "+ rdr.GetString(4));
                Console.WriteLine("Fecha de Nacimeinto: "+ rdr.GetDate(5));
            }

            conn.Close();

            /* insertar registro */
            /* conn.Open();

            var sqlInsert = "INSERT INTO persona (nombre, edad, email, dni, fecha_nacimiento) VALUES ('Juan', 35, 'juan@example.com',23876624, '1996-07-20')";
            NpgsqlCommand cmdInsert = new NpgsqlCommand(sqlInsert, conn);
            cmdInsert.ExecuteNonQuery();

            conn.Close(); */

            /* Actualizar registro */

            conn.Open();

            var sqlUpdate = "UPDATE persona SET nombre = 'Juan Carlos' WHERE id = 4";
            NpgsqlCommand cmdUpdate = new NpgsqlCommand(sqlUpdate, conn);
            cmdUpdate.ExecuteNonQuery();

            conn.Close();

            /* Eliminar registro */

            conn.Open();

            var sqlDelete = "DELETE FROM persona WHERE id = 3";
            NpgsqlCommand cmdDelete = new NpgsqlCommand(sqlDelete, conn);
            cmdDelete.ExecuteNonQuery();

            conn.Close();

        }
    }
}
