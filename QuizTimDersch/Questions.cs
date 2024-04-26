using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTimDersch
{
    internal class Questions : Database
    {

        public string country;
        public string capital;
        public Bitmap flag;

        public Questions(string country, string capital, Bitmap flag)
        {
            this.country = country;
            this.capital = capital;
            this.flag = flag;
        }

        

        public Questions()
        {

        }

        private List<int> lastIds = new List<int>();


        public List<Questions> MixCountries(int conID)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            
                MySqlCommand command = connection.CreateCommand();
                if (conID == 0)
                {
                    command.CommandText = "SELECT * FROM country ORDER BY rand() LIMIT 4;"; //Wenn worldwide ausgewählt ist Table country mischen und die ersten 4 Datasets wählen
                }
                else 
                {
                command.CommandText = "SELECT * FROM country WHERE continent_id = @continentId ORDER BY rand() LIMIT 4;";//Datasets anhand der continent_id wählen randomizen und die ersten 4 Datasets wählen
                command.Parameters.AddWithValue("@continentId", conID);
                }
                MySqlDataReader reader = command.ExecuteReader();
            
            
                List<Questions> values = new List<Questions>(); // Liste instanzieren und die 4 Datasets hinzufügen

                while (reader.Read())
                {
                    string country = reader["country_name"].ToString();
                    string capital = reader["country_capital"].ToString();
                    Bitmap flag = new Bitmap(getFlag(country));

                    Questions question = new Questions(country, capital, flag);
                    values.Add(question);
                    

                }
                return values; //Liste zurückgeben, die 4 Datasets enthält
            }

           
           

           

            
        

        public Bitmap getFlag(string country)
        {
            string filePath = $"C:\\Users\\tn\\source\\repos\\QuizTimDersch\\QuizTimDersch\\Images\\Flags\\{country}.png";

            if (File.Exists(filePath))
            {
                Bitmap flag = new Bitmap(filePath);
                return flag;
            }
            else
            {
                filePath = $"C:\\Users\\tn\\source\\repos\\QuizTimDersch\\QuizTimDersch\\Images\\Flags\\lgbtq.jpeg"; //Da ich nicht alle 200 Flaggen durchgehen möchte wird diese Flagge angezeigt. Welches Land stellt sie wohl da ?
                Bitmap flag = new Bitmap(filePath);
                return flag;

            }
        }













    }




}

