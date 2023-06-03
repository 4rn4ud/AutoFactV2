using AutoFact2.Views;
using AutoFact2.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Repository
{
    public class InvoiceLineRepository
    {
        public InvoiceLineRepository()
        {

        }
        public List<Invoiceline> findAll(int id)
        {
            int idQuote;
            int idProduct;
            int quantity;
            int promotion;
            int prix;

            List<Invoiceline> lesLignesFactures = new List<Invoiceline>();
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT * FROM Invoiceline where idQuote = @idQuote";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idQuote = Convert.ToInt32(reader["idQuote"]);
                    idProduct = Convert.ToInt32(reader["idProduct"]);
                    quantity = Convert.ToInt32(reader["quantity"]);
                    promotion = Convert.ToInt32(reader["promotion"]);
                    prix = Convert.ToInt32(reader["prix"]);

                    lesLignesFactures.Add(new Invoiceline(idQuote, idProduct, quantity, promotion, prix));
                }
            }
            reader.Close();
            connection.Close();

            return lesLignesFactures;
        }



        public void create(int idCustomer, DateTime DateInvoice)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string insertSql = "";

            insertSql = "INSERT INTO Invoice (idCustomer, Date) " +
                        "VALUES (@idCustomer, @DateInvoice)";


            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
            {
                command.Parameters.AddWithValue("@idCustomer", idCustomer);
                command.Parameters.AddWithValue("@DateInvoice", DateInvoice);


                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        /* public void delete(int id)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string deleteSql = "";

                deleteSql = "DELETE FROM Invoice WHERE id = @id; " +
                            "VALUES (@id)";
            

            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(deleteSql, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
            connection.Close();


        } */

        public void update(int id, int idCustomer, DateTime DateInvoice)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string updateSql = "";


                updateSql = "UPDATE Invoice " +
                 "SET idCustomer = @idCustomer, Date = @DateInvoice" +
                 "WHERE id = @Id";



            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(updateSql, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@idCustomer", idCustomer);
                command.Parameters.AddWithValue("@DateInvoice", DateInvoice);


                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public DateTime GetDate(int id)
        {
            
  
            DateTime DateInvoice;
            DateInvoice = DateTime.Now;

            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT Date FROM Invoice WHERE id = @Id";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                DateInvoice = Convert.ToDateTime( reader["date"]);

            } 

            reader.Close();
            connection.Close();

            return DateInvoice;
        }

        public int GetIdCustomer(int id)
        {


            int IdCustomer;
            IdCustomer = 0;

            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT IdCustomer FROM Invoice WHERE id = @Id";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                IdCustomer = Convert.ToInt32(reader["IdCustomer"]);

            }

            reader.Close();
            connection.Close();

            return IdCustomer;
        }
    }
}
