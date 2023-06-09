using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AutoFact2.Views
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();

            // Obtenez une référence au contrôle Chart
            Chart chart = chart1;

            // Supprimez toutes les séries existantes (le cas échéant)
            chart1.Series.Clear();

            // Créez la troisième série pour le devis
            Series devis = new Series("Devis");
            devis.ChartType = SeriesChartType.Bar;
            // Créez la troisième série pour la facture
            Series facture = new Series("Facture");
            facture.ChartType = SeriesChartType.Bar;
            // Créez la troisième série pour l'acquittement
            Series acquittement = new Series("Acquittement");
            acquittement.ChartType = SeriesChartType.Bar;

            string annee;
            int stats;
            string label;

            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT strftime('%Y', S.date) AS annee, COUNT(*) AS stats, T.libel AS label FROM Quote Q INNER JOIN Status S ON S.idQuote=Q.id INNER JOIN Type T ON T.id=S.idType GROUP BY annee, T.libel ORDER BY annee";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    annee = Convert.ToString(reader["annee"]);
                    stats = Convert.ToInt32(reader["stats"]);
                    label = Convert.ToString(reader["label"]);

                    if (annee == "2023" && label == "Devis")
                    {
                        devis.Points.AddXY("2023", stats);
                    }
                    else if (annee == "2023" && label == "Facture")
                    {
                        facture.Points.AddXY("2023", stats);
                    }
                    else if (annee == "2023" && label == "Acquittement")
                    {
                        acquittement.Points.AddXY("2023", stats);
                    }
                }
            }
            reader.Close();
            connection.Close();

            chart1.Series.Add(devis);
            chart1.Series.Add(facture);
            chart1.Series.Add(acquittement);

            // Définissez le titre du graphique
            chart1.Titles.Add("Statistiques pour l'année en cours");

            // Affichez le graphique
            chart1.Update();










            // Obtenez une référence au contrôle Chart
            Chart Chart2 = chart2;

            // Supprimez toutes les séries existantes (le cas échéant)
            chart2.Series.Clear();

            // Récupérez l'année actuelle
            int currentYear = DateTime.Now.Year;

            // Créez une liste pour stocker les labels uniques
            List<string> labels = new List<string>();

            connection.Open();

            string selectSql2 = "SELECT DISTINCT T.libel AS label FROM Quote Q INNER JOIN Status S ON S.idQuote=Q.id INNER JOIN Type T ON T.id=S.idType";
            SQLiteCommand command2 = new SQLiteCommand(selectSql2, connection);
            SQLiteDataReader reader2 = command2.ExecuteReader();

            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    string label2 = Convert.ToString(reader2["label"]);
                    labels.Add(label2);
                }
            }

            reader2.Close();
            connection.Close();

            // Créez une série pour chaque label
            foreach (string label2 in labels)
            {
                Series series2 = new Series(label2);
                series2.ChartType = SeriesChartType.Bar;

                connection.Open();

                for (int i = currentYear - 2; i <= currentYear; i++)
                {
                    string year = i.ToString();

                    selectSql2 = "SELECT COUNT(*) AS stats FROM Quote Q INNER JOIN Status S ON S.idQuote=Q.id INNER JOIN Type T ON T.id=S.idType WHERE strftime('%Y', S.date) = @Year AND T.libel = @Label";
                    command2 = new SQLiteCommand(selectSql2, connection);
                    command2.Parameters.AddWithValue("@Year", year);
                    command2.Parameters.AddWithValue("@Label", label2);
                    reader2 = command2.ExecuteReader();

                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            int stats2 = Convert.ToInt32(reader2["stats"]);
                            series2.Points.AddXY(year, stats2);
                        }
                    }

                    reader2.Close();
                }

                connection.Close();

                // Ajoutez la série au graphique
                chart2.Series.Add(series2);
            }

            // Faites pivoter le graphique de 90 degrés
            chart2.ChartAreas[0].Area3DStyle.Inclination = 90;

            // Définissez le titre du graphique
            chart2.Titles.Add("Statistiques sur les 3 dernières années");

            // Affichez le graphique
            chart2.Update();
        }
    }
}