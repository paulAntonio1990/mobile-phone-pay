using Mobile_Phone_Pay.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Phone_Pay.Repositories
{
    class PlataRepository
    {
        public static long savePlata(double valoare, string scadenta)
        {
            string query = "INSERT INTO Plati(Valoare, Scadenta)" +
                "VALUES (@valoare, @scadenta); " +
                " SELECT last_insert_rowid()";
            long id = 0;

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@valoare", valoare) ;
                    command.Parameters.AddWithValue("@scadenta", scadenta);

                    id = (long)command.ExecuteScalar();
                }
            }

            return id;
        }

        public static List<Plata> findAllPlata()
        {
            string query = "SELECT * FROM Plati";
            List<Plata> plati = new List<Plata>();

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader sqlReader = command.ExecuteReader())
                    {
                        while (sqlReader.Read())
                        {
                            long id = (long)sqlReader["Id"];
                            double valoare = Convert.ToDouble((long)sqlReader["Valoare"]);
                            DateTime scadenta = DateTime.Parse((string)sqlReader["Scadenta"]);

                            Plata plata = new Plata(id, valoare, scadenta);
                            plati.Add(plata);
                        }
                    }
                }

                return plati;
            }
        }

        public static Plata findPlataById(long idPlata)
        {
            string query = "SELECT * FROM Plati where Id = @id";
            Plata plata = null;

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idPlata);
                    using (SQLiteDataReader sqlReader = command.ExecuteReader())
                    {
                        while (sqlReader.Read())
                        {
                            long id = (long)sqlReader["Id"];
                            double valoare = (double)sqlReader["Valoare"];
                            DateTime scadenta = DateTime.Parse((string)sqlReader["Scadenta"]);

                            plata = new Plata(id, valoare, scadenta);
                        }
                    }
                }

                return plata;
            }
        }

        public static void deletePlata(long idPlata)
        {
            var query = "DELETE FROM Plati WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idPlata);

                    command.ExecuteNonQuery();
                }

            }
        }

        public static void updatePlata(Plata plata)
        {
            var query = "UPDATE Plati " +
                "SET Valoare = @valoare, Scadenta = @scadenta " +
                "WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@valoare", plata.Value);
                command.Parameters.AddWithValue("@scadenta", plata.DueDate.ToShortDateString());
                command.Parameters.AddWithValue("@id", plata.Id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
