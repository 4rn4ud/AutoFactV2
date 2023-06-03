﻿using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Repository
{
    public class CategoryRepository
    {

    }

    public List<Category> findAll()
    {
        int id;
        string label;
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
                label = Convert.ToString(reader["libel"]);
                unitPrice = Convert.ToSingle(reader["unitPrice"]);
                idCategory = Convert.ToInt32(reader["idCategory"]);

                lesProducts.Add(new Product(id, label, unitPrice, idCategory));
            }
        }
        reader.Close();
        connection.Close();

        return lesProducts;
    }
}