using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuizTimDersch
{
    internal class User : Database
    {
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string User_Password { get; set; }

        

        public User(string User_Name, string User_Password)
        {
            this.User_Name = User_Name;
            this.User_Password = User_Password;
            
        }

        public User(int User_Id, string User_Name, string User_Password)
        {
            this.User_Id = User_Id;
            this.User_Name = User_Name;
            this.User_Password = User_Password;
        }

        public User()
        {

        }

        public int registerUser()
        {
            MySqlConnection connection = GetConnection();
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO user (user_name) Values (@User_Name)";
            command.Parameters.AddWithValue("user_name", User_Name);
            command.ExecuteNonQuery();

            command.CommandText = "SELECT LAST_INSERT_ID()"; //Retrieve the last inserted Id from the database check if it´s not null
            object result = command.ExecuteScalar();
            int User_Id = result != null ? Convert.ToInt32(result) : 0;  //check if the return value of ExecuteScalar is 0 or !null
            string User_Password = BCrypt.Net.BCrypt.HashPassword(this.User_Password); // Hash the user password

            command.CommandText = "INSERT INTO password (user_id, password) VALUES (@User_Id, @User_Password)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@User_Id", User_Id);
            command.Parameters.AddWithValue("@User_Password", User_Password);
            command.ExecuteNonQuery();

            connection.Close();
            return User_Id;
        }

        public int loadUser()
        {
            MySqlConnection connection = GetConnection();
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT user_id FROM user WHERE user_name = @User_Name";
            command.Parameters.AddWithValue("@User_Name", User_Name);
            object result = command.ExecuteScalar();

            if (result != null) // check if the result doesnt return an empty object
            {
                int User_Id = Convert.ToInt32(result);

                command.CommandText = "SELECT password FROM password WHERE user_id = @User_Id";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@User_Id", User_Id);               
                string storedPassword = command.ExecuteScalar().ToString();
                

                bool arePasswordsEqual = BCrypt.Net.BCrypt.Verify(User_Password, storedPassword); // compare the input password to the hashed pw in the database

                if (arePasswordsEqual)
                {
                    connection.Close();
                    return User_Id;                  
                }
            }

            connection.Close();

            return 0;
        }

        public void saveHighscore(int highscore, int userId)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO highscore (user_id, points) VALUES (@userId, @highscore)";
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@highscore", highscore);
            command.ExecuteNonQuery();
        }

        public DataTable loadHighscore(int userId, int PersOver)
        {
           
                MySqlConnection connection = GetConnection();
                connection.Open();
                
                MySqlCommand command = connection.CreateCommand();
                if(PersOver == 0)
                {
                command.CommandText = "SELECT points AS Points, date AS Date FROM highscore WHERE user_id = @userId";
                command.Parameters.AddWithValue("@userId", userId);

                }
                else if(PersOver == 1)
                {
                command.CommandText = "SELECT user.user_name AS User, SUM(highscore.points) AS TotalPoints FROM user INNER JOIN highscore ON user.user_id = highscore.user_id GROUP BY user.user_id";
            }
        
                

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                connection.Close();

                return dt;


        }

    }
}
