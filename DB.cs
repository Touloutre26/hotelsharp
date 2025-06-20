using MySql.Data.MySqlClient;
using System;

namespace hotelcsharpL3;
public class DatabaseConnection
{
    private string connectionString;

    // Constructeur pour initialiser la chaîne de connexion
    public DatabaseConnection()
    {
        connectionString = "Server=localhost;Database=nom_de_votre_base;User ID=utilisateur;Password=mot_de_passe;";
    }

    // Méthode pour obtenir une connexion MySQL
    public MySqlConnection GetConnection()
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        return connection;
    }

    // Méthode pour exécuter une requête de lecture
    public void ExecuteQuery(string query, Action<MySqlDataReader> handleData)
    {
        using (var connection = GetConnection())
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    // Utilise une action déléguée pour traiter les données du reader
                    handleData(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
