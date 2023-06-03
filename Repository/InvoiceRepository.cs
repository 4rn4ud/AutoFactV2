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
    public class InvoiceRepository
    {
        public InvoiceRepository()
        {

        }
        public List<Invoice> findAll()
        {
            int id;
            int idCustomer;
            DateTime DateInvoice;
            //List<Invoiceline> Invoicelines ;


            List<Invoice> lesFactures = new List<Invoice>();
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT * FROM Invoice";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    idCustomer = Convert.ToInt32(reader["IdCustomer"]);
                    DateInvoice = Convert.ToDateTime(reader["Date"]);
                    //Invoicelines = Convert.ToString(reader["companyName"]);
                    lesFactures.Add(new Invoice(id, idCustomer, DateInvoice));
                }
            }
            reader.Close();
            connection.Close();

            return lesFactures;
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
    }
}
