using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTimDersch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            labelFillOutAllFields.Hide();
            labelPWnotMatch.Hide();
            labelUsernameExists.Hide();
            labelWrongPassword.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.FromArgb(120,158,158,158);
            panelRegister.BackColor = Color.FromArgb(120, 158, 158, 158);
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHide_Click(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
            panelLogin.Hide();
            panelRegister.Show();

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(textBoxUsernameRegister.Text) && !String.IsNullOrEmpty(textPasswordRegister.Text) && textPasswordRegister.Text.Equals(textBoxRepeatPassword.Text))
            {
                User user = new User(textBoxUsernameRegister.Text, textPasswordRegister.Text);
                int user_id = user.registerUser();
                QuizWindow quiz1 = new QuizWindow(user_id);
                this.Hide();
                quiz1.Show();
            }
            else if(String.IsNullOrEmpty(textBoxUsernameRegister.Text) || String.IsNullOrEmpty(textPasswordRegister.Text) || String.IsNullOrEmpty(textBoxRepeatPassword.Text))
            {
                labelFillOutAllFields.Show(); 
            }
            else
            {
                labelFillOutAllFields.Hide();
                labelPWnotMatch.Show();
            }

        }

        private void panelLogin_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user = new User(BoxUsername.Text, BoxPassword.Text);
            int user_id = user.loadUser();

            if (user_id != 0)
            {
                QuizWindow quiz1 = new QuizWindow(user_id);
                this.Hide();
                quiz1.Show();
            }
            else
            {
                labelWrongPassword.Show();
            }

        }
    }
}
