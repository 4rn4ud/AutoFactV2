using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Repository
{
    public class ProfilRepository
    {
        public ProfilRepository() 
        {
            
        }   
        public List<Profil> findAll()
        {
            int id;
            string raisonSocial;
            int siren;
            string adresse;
            int cp;
            string ville;
            string tel;
            string mail;
            List<Profil> lesProfils = new List<Profil>();
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT * FROM Profil";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if(reader.HasRows) 
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    raisonSocial = reader.GetString(1);
                    siren = Convert.ToInt32(reader["siren"]);
                    adresse = reader.GetString(3);
                    cp = Convert.ToInt32(reader["postalCode"]);
                    ville = Convert.ToString(reader["city"]);
                    tel = Convert.ToString(reader["tel"]);
                    mail = Convert.ToString(reader["mail"]);

                    lesProfils.Add(new Profil(id, raisonSocial, siren, adresse, cp, ville, tel, mail));
                }

            }
            reader.Close();
            connection.Close();

            return lesProfils;

        }
    }
}
