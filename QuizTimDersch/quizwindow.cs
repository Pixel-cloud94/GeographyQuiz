using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace QuizTimDersch
{
    public partial class QuizWindow : Form
    {
        private int counter = 0;
        private int highscore = 0;
        private int topic;
        private int conID;
        private int userID;
        
        public QuizWindow(int userId)
        {
            InitializeComponent();
            panelChooseContinent.Hide();
            panelGameFlagBy.Hide();
            panelfinishrestart.Hide();
            userID = userId;
            loadDataTb(0);

        }

        public void loadDataTb(int persover)
        {
            User user = new User();
            DataTable dt = user.loadHighscore(userID, persover);
            dataGridViewHighscore.DataSource = dt;
        }
        public void startGame()
        {
            counter = 0;
            panelGameFlagBy.Show();
            panelChooseTopic.Hide();
            panelGameplay.Hide();
            panelChooseContinent.Hide();
            nextQuestion();

           
            if (topic == 1|| topic == 2)
            {
                labelQueryCapital.Show();
                labelQueryCountry.Hide();
            }


            if (topic == 3)
            {
                labelQueryCountry.Show();
                labelQueryCapital.Hide();
                btnAnswer1.Text = "";
                btnAnswer2.Text = "";
                btnAnswer3.Text = "";
                btnAnswer4.Text = "";

            }
            if(topic ==4)
            {
                labelQueryCapital.Show();
                labelQueryCountry.Hide();
                btnAnswer1.Text = "";
                btnAnswer2.Text = "";
                btnAnswer3.Text = "";
                btnAnswer4.Text = "";
            }

            if (topic == 5|| topic ==6)
            {
                labelQueryCountry.Show();
                labelQueryCapital.Hide();

            }
           
        }

        private void AssignValuesToButtons()
        {
            // Instantiate a list with 4 objects
            Questions questionsInstance = new Questions();
            List<Questions> questions = questionsInstance.MixCountries(conID);

            // Create list of buttons
            List<Button> buttons = new List<Button> { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };

            // Shuffle buttons
            Random rng = new Random();
            int n = buttons.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Button temp = buttons[k];
                buttons[k] = buttons[n];
                buttons[n] = temp;
            }

            // Assign  values based on the shuffled order
            for (int i = 0; i < buttons.Count; i++)
            {
                if (topic == 1 || topic== 2)
                {
                    buttons[i].Text = questions[i].country;
                    buttons[i].BackgroundImage = null;

                }
                
                else if (topic == 3 || topic == 4)
                {
                    buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                    buttons[i].BackgroundImage = questions[i].flag;


                }
                else if (topic == 5 || topic== 6)
                {
                    buttons[i].Text = questions[i].capital;
                    buttons[i].BackgroundImage = null;

                }
               
            }

            // Country or Capital Querylabel to assign
            labelQueryCountry.Text = questions[0].country;
            labelQueryCapital.Text = questions[0].capital;

            // Flag in Picturebox load
            pictureBoxFlag.Image = questions[0].flag;
        }



        private void panelChooseTopic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuizWindow_Load(object sender, EventArgs e)
        {
            panelChooseTopic.BackColor = Color.FromArgb(120, 158, 158, 158);
            panelGameplay.BackColor = Color.FromArgb(120, 158, 158, 158);
            panelGameFlagBy.BackColor = Color.FromArgb(100,0,0,0);
            panelChooseContinent.BackColor = Color.FromArgb(120, 158, 158, 158);
            panelfinishrestart.BackColor = Color.FromArgb(170, 158, 158, 158);
            panel3.BackColor = Color.FromArgb(120, 158, 158, 158);
            panel2.BackColor = Color.FromArgb(120, 158, 158, 158);


        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            highscore = 0;
            counter = 0;
            panelChooseTopic.Hide();
            panelGameplay.Hide();
            panelChooseContinent.Show();
            

            

        }

        private void nextQuestion()
        {
            if (counter < 10) //Wiederholung auf 10 Durchgänge beschränken
            {
                    AssignValuesToButtons();
                

                    counter++;
                    labelCounter.Text = (counter.ToString() + "/10");
            }
            else
            {
                User user = new User();
                user.saveHighscore(highscore, userID); 
                panelfinishrestart.Show();                
                labelfinish.Text = "You answered " + highscore.ToString() + "/10 Questions right";
            }
            
        }

        private void buttonCountryByFlag_Click(object sender, EventArgs e)
        {
            topic = 1;
            pictureBoxFlag.Show();
            labelQueryCountry.Hide();
            labelQuestion.Text = "Choose the Country \nmatching this Flag!";
        }

        private void buttonCountryByCapital_Click(object sender, EventArgs e)
        {
            topic = 2;
            pictureBoxFlag.Hide();
            labelQuestion.Text = "Choose the Country \nmatching this Capital!";

        }

        private void buttonFlagByCountry_Click(object sender, EventArgs e)
        {
            topic = 3;
            pictureBoxFlag.Hide();
            labelQueryCapital.Hide();
            labelQuestion.Text = "Choose the Flag \nmatching this Country!";
        }

        private void buttonFlagByCapital_Click(object sender, EventArgs e)
        {
            topic = 4;
            pictureBoxFlag.Hide();
            labelQueryCountry.Hide();
            labelQuestion.Text = "Choose the Flag \nmatching this Capital!";
        }

        private void buttonCapitalByCountry_Click(object sender, EventArgs e)
        {
            topic = 5;
            pictureBoxFlag.Hide();
            labelQuestion.Text = "Choose the Capital \nmatching this Country!";
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (btnAnswer1.Text == labelQueryCountry.Text ^ btnAnswer1.Text == labelQueryCapital.Text)
            {
                highscore++;
                labelCounter.Text = "Right!";
            }
            
            if (ReferenceEquals(btnAnswer1.BackgroundImage, pictureBoxFlag.Image))
            {

                highscore++;
                labelCounter.Text = "Right!";
            }
            else
            {
                labelCounter.Text = "Wrong!";
            }


            nextQuestion();
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            if (btnAnswer2.Text == labelQueryCountry.Text ^ btnAnswer2.Text == labelQueryCapital.Text)
            {
                highscore++;
                labelCounter.Text = "Right!";
            }
            
            else if (ReferenceEquals(btnAnswer2.BackgroundImage, pictureBoxFlag.Image))
            {

                highscore++;
                labelCounter.Text = "Right!";
            }
            else
            {
                labelCounter.Text = "Wrong!";
            }

            nextQuestion();
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            if (btnAnswer3.Text == labelQueryCountry.Text ^ btnAnswer3.Text == labelQueryCapital.Text)
            {
                highscore++;
                labelCounter.Text = "Right!";
            }
           
            if (ReferenceEquals(btnAnswer3.BackgroundImage, pictureBoxFlag.Image))
            {

                highscore++;
                labelCounter.Text = "Right!";
            }
            else
            {
                labelCounter.Text = "Wrong!";
            }

            nextQuestion();
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            if (btnAnswer4.Text == labelQueryCountry.Text ^ btnAnswer4.Text == labelQueryCapital.Text)
            {
                highscore++;
                labelCounter.Text = "Right!";
            }
            
            if (ReferenceEquals(btnAnswer4.BackgroundImage, pictureBoxFlag.Image))
            {
               
                highscore++;
                labelCounter.Text = "Right!";
            }
            else
            {
                labelCounter.Text = "Wrong!";
            }

            nextQuestion();
        }

        private void buttonCapitalByFlag_Click(object sender, EventArgs e)
        {
            topic = 6;
            pictureBoxFlag.Show();
            labelQueryCountry.Hide();
            labelQuestion.Text = "Choose the Capital \nmatching this Flag!";
        }

        private void panelGameFlagBy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            counter = 0;
            highscore = 0;
            panelfinishrestart.Hide();
            labelQueryCapital.Show();
            labelQueryCountry.Show();
            startGame();
            


        }

        private void pictureBoxFlag_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxWorldwide_Click(object sender, EventArgs e)
        {
            conID = 0;
            startGame();
            panelGameFlagBy.Show();
        }

        private void pictureBoxAfrica_Click(object sender, EventArgs e)
        {
            conID = 1;
            startGame();
            panelGameFlagBy.Show();
        }

        private void pictureBoxAntarctica_Click(object sender, EventArgs e)
        {
            conID = 2;
            startGame();
            panelGameFlagBy.Show();
        }

        private void pictureBoxAsia_Click(object sender, EventArgs e)
        {
            conID = 3;
            startGame();
            panelGameFlagBy.Show();
        }

        private void pictureBoxEurope_Click(object sender, EventArgs e)
        {
            conID = 4;
            startGame();
            panelGameFlagBy.Show();
        }

        private void pictureBoxNorthAmerica_Click(object sender, EventArgs e)
        {
            conID=5;
            startGame();
            panelGameFlagBy.Show();
        }

        private void pictureBoxAustralia_Click(object sender, EventArgs e)
        {
            conID=6;
            startGame();
            panelGameFlagBy.Show();
        }

        private void pictureBoxSouthAmerica_Click(object sender, EventArgs e)
        {
            conID = 7;
            startGame();
            panelGameFlagBy.Show();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelfinishrestart.Hide();
            panelGameFlagBy.Hide();
            panelGameplay.Show();
            panelChooseTopic.Show();
            loadDataTb(0);


        }

        private void dataGridViewHighscore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void buttonOverall_Click(object sender, EventArgs e)
        {
            loadDataTb(1);
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            loadDataTb(0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
