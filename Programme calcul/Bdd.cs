using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Programme_calcul
{
    public class Bdd
    {
        private MySqlConnection connection;

        public Bdd()
        {
            this.initConnexion();
        }

        private void initConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=basecalcul; UID=root; SslMode=none;PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }
        public void AddOperation(double gauche,double droite,char op)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO operations (operandeGauche, operandeDroite, operateur) VALUES (@operandeGauche, @operandeDroite, @operateur)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@operandeGauche", gauche);
                cmd.Parameters.AddWithValue("@operandeDroite", droite);
                cmd.Parameters.AddWithValue("@operateur", op);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("erreur");
                Console.WriteLine(ex.Message);
               
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }
    }

}

