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
                    id = reader.GetInt32(0);
                    raisonSocial = reader.GetString(1);
                    siren = reader.GetInt32(2);
                    adresse = reader.GetString(3);
                    cp = reader.GetInt32(4);
                    ville = reader.GetString(5);
                    tel = reader.GetString(6);
                    mail = reader.GetString(7);

                    lesProfils.Add(new Profil(id, raisonSocial, siren, adresse, cp, ville, tel, mail));
                }

            }
            reader.Close();
            connection.Close();

            return lesProfils;

        }
    }
}
