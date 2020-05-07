using Mobile_Phone_Pay.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Phone_Pay.Repositories
{
    public class TipAbonamentRepository
    { 
        public static long saveTipAbonament(string denumire, int minute, int mesaje, int net_mb, double pret)
        {
                string query = "INSERT INTO Abonamente(Denumire, Minute, Mesaje, Net_MB, Pret)" +
                 "VALUES (@denumire, @minute, @mesaje, @net_MB, @pret); " +
                 " SELECT last_insert_rowid()";
            long idAbonament = 0;

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@denumire", denumire);
                command.Parameters.AddWithValue("@minute", minute);
                command.Parameters.AddWithValue("@mesaje", mesaje);
                command.Parameters.AddWithValue("@net_MB", net_mb);
                command.Parameters.AddWithValue("@pret", pret);

                connection.Open();

                idAbonament = (long)command.ExecuteScalar();
            }

            return idAbonament;
        }

        public static List<TipAbonament> findAllTipAbonament()
        {
            string query = "SELECT * FROM Abonamente";
            List<TipAbonament> abonamente = new List<TipAbonament>();

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["Id"];
                        string denumire = (string)sqlReader["Denumire"];
                        int minute = Convert.ToInt32((long)sqlReader["Minute"]);
                        int mesaje = Convert.ToInt32((long)sqlReader["Mesaje"]);
                        int net_MB = Convert.ToInt32((long)sqlReader["Net_MB"]);
                        double pret = (double)sqlReader["Pret"];

                        TipAbonament abonament = new TipAbonament(id, denumire, minute, mesaje, net_MB, pret);
                        abonamente.Add(abonament);
                    }
                }

                return abonamente; 
            }
        }

        public static void deleteAbonament(TipAbonament aboanment)
        {
            var query = "DELETE FROM Abonamente WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", aboanment.Id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public static void updateAbonament(TipAbonament abonament)
        {
            var query = "UPDATE Abonamente " +
                "SET Denumire = @denumire, Minute = @minute, Mesaje = @mesaje, Net_MB = @net_MB, Pret = @pret " +
                "WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@denumire", abonament.Name);
                command.Parameters.AddWithValue("@minute", abonament.NoMinutes);
                command.Parameters.AddWithValue("@mesaje", abonament.NoMessages);
                command.Parameters.AddWithValue("@net_MB", abonament.NoNetMb);
                command.Parameters.AddWithValue("@pret", abonament.Price);
                command.Parameters.AddWithValue("@id", abonament.Id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
