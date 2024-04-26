using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuizTimDersch
{
    internal class Database
    {
        private readonly string connectionString;

        public Database()
        {
            connectionString =  "Server=localhost; Database=db_quiz; User=root; password=";
        }

        protected MySqlConnection GetConnection() 
        { 
            return new MySqlConnection(connectionString);
        }


    }
}
