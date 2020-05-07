using Mobile_Phone_Pay.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Phone_Pay.Repositories
{
    class ExtraOptiuneRepository
    {
        public static long saveExtraOptiune(string denumire, int minute, int mesaje, int net_mb, double pret)
        {
            string query = "INSERT INTO ExtraOptiuni(Denumire, Minute, Mesaje, Net_MB, Pret)" +
             "VALUES (@denumire, @minute, @mesaje, @net_MB, @pret); " +
             " SELECT last_insert_rowid()";
            long idExtraOptiune = 0;

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@denumire", denumire);
                command.Parameters.AddWithValue("@minute", minute);
                command.Parameters.AddWithValue("@mesaje", mesaje);
                command.Parameters.AddWithValue("@net_MB", net_mb);
                command.Parameters.AddWithValue("@pret", pret);

                connection.Open();

                idExtraOptiune = (long)command.ExecuteScalar();
            }

            return idExtraOptiune;
        }

        public static List<ExtraOptiune> findAllExtraOptiune()
        {
            string query = "SELECT * FROM ExtraOptiuni";
            List<ExtraOptiune> abonamente = new List<ExtraOptiune>();

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

                        ExtraOptiune extraOptiune = new ExtraOptiune(id, denumire, minute, mesaje, net_MB, pret);
                        abonamente.Add(extraOptiune);
                    }
                }

                return abonamente;
            }
        }

        public static void deleteExtraOptiune(ExtraOptiune extraOptiune)
        {
            var query = "DELETE FROM ExtraOptiuni WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", extraOptiune.Id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public static void updateExtraOptiune(ExtraOptiune extraOptiune)
        {
            var query = "UPDATE ExtraOptiuni " +
                "SET Denumire = @denumire, Minute = @minute, Mesaje = @mesaje, Net_MB = @net_MB, Pret = @pret " +
                "WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@denumire", extraOptiune.Name);
                command.Parameters.AddWithValue("@minute", extraOptiune.NoMinutes);
                command.Parameters.AddWithValue("@mesaje", extraOptiune.NoMessages);
                command.Parameters.AddWithValue("@net_MB", extraOptiune.NoNetMb);
                command.Parameters.AddWithValue("@pret", extraOptiune.Price);
                command.Parameters.AddWithValue("@id", extraOptiune.Id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
