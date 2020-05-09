using Mobile_Phone_Pay.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Phone_Pay.Repositories
{
    class ClientRepository
    {
        public static long saveClient(string nume, string prenume, string dataNasterii, long idAbonament, long idExtraOptiune, long idFactura)
        {
            string query = "INSERT INTO Clienti(Nume, Prenume, DataNasterii, Id_TipAbonament, Id_ExtraOptiune, Id_Plata)" +
             "VALUES (@nume, @prenume, @dataNasterii, @idAbonament, @idExtraOptiune, @idFactura); " +
             " SELECT last_insert_rowid()";
            long idClient = 0;

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@nume", nume);
                command.Parameters.AddWithValue("@prenume", prenume);
                command.Parameters.AddWithValue("@dataNasterii", dataNasterii);
                command.Parameters.AddWithValue("@idAbonament", idAbonament);
                command.Parameters.AddWithValue("@idExtraOptiune", idExtraOptiune);
                command.Parameters.AddWithValue("@idFactura", idFactura);

                connection.Open();

                idClient = (long)command.ExecuteScalar();
            }

            return idClient;
        }

        public static List<Client> findAllClienti()
        {
            string query = "SELECT * FROM Clienti";
            List<Client> clienti = new List<Client>();

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["Id"];
                        string nume = (string)sqlReader["Nume"];
                        string prenume = (string)sqlReader["Prenume"];
                        DateTime dataNasterii = DateTime.Parse((string)sqlReader["DataNasterii"]);
                        long idAbonament = (long)sqlReader["Id_TipAbonament"];
                        long idExtraOptiune = (long)sqlReader["Id_ExtraOptiune"];
                        long idFactura = (long)sqlReader["Id_Plata"];

                        Client client = new Client(id, nume, prenume, dataNasterii, idAbonament, idExtraOptiune, idFactura);
                        clienti.Add(client);
                    }
                }

                return clienti;
            }
        }

        public static Client findClientById(long idClient)
        {
            string query = "SELECT * FROM Clienti where Id=@id";
            Client client = null;

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", idClient);

                using (SQLiteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["Id"];
                        string nume = (string)sqlReader["Nume"];
                        string prenume = (string)sqlReader["Prenume"];
                        DateTime dataNasterii = DateTime.Parse((string)sqlReader["DataNasterii"]);
                        long idAbonament = (long)sqlReader["Id_TipAbonament"];
                        long idExtraOptiune = (long)sqlReader["Id_ExtraOptiune"];
                        long idFactura = (long)sqlReader["Id_Plata"];

                        client = new Client(id, nume, prenume, dataNasterii, idAbonament, idExtraOptiune, idFactura);
                    }
                }

                return client;
            }
        }

        public static void deleteClient(long idClient)
        {
            var query = "DELETE FROM Clienti WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", idClient);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public static void updateClient(Client client)
        {
            var query = "UPDATE Clienti " +
                "SET Nume = @nume, Prenume = @prenume, DataNasterii = @dataNasterii, Id_TipAbonament = @idTipAbonament, Id_ExtraOptiune = @idExtraOptiune, Id_Plata = @idPlata " +
                "WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(Connection.ConnectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@nume", client.Nume);
                command.Parameters.AddWithValue("@prenume", client.Prenume);
                command.Parameters.AddWithValue("@dataNasterii", client.DataNasterii);
                command.Parameters.AddWithValue("@idTipAbonament", client.IdAbonament);
                command.Parameters.AddWithValue("@idExtraOptiune", client.IdExtraOptiune);
                command.Parameters.AddWithValue("@idPlata", client.IdFactura);
                command.Parameters.AddWithValue("@id", client.Id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
