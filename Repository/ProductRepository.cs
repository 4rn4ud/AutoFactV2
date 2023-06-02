using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Repository
{
    public class ProductRepository
    {
        public ProductRepository()
        {

        }
        public List<Product> findAll()
        {
            int id;
            string libel;
            float unitPrice;
            int idCategory;

            List<Product> lesProducts = new List<Product>();
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT * FROM Product";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    libel = Convert.ToString(reader["libel"]);
                    unitPrice = Convert.ToSingle(reader["unitPrice"]);
                    idCategory = Convert.ToInt32(reader["idCategory"]);

                    lesProducts.Add(new Product(id, libel, unitPrice, idCategory));
                }
            }
            reader.Close();
            connection.Close();

            return lesProducts;
        }
    }
}
