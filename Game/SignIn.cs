using System;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public partial class SignIn : Form
    {

        Menu parent;   

        public SignIn(Menu f)
        {
            parent = f;
            InitializeComponent();      
        }

        private void btmlogIn_Click(object sender, EventArgs e)
        {          
            try
            {                
                int idNum = int.Parse(txtEnterId.Text);

                if (parent.Signed(idNum))
                {                   
                    Close();
                    parent.PlayGame(idNum);
                }
                else if (!parent.CheckID(idNum))
                {
                    MessageBox.Show("id should be 9 digits", "Length Error");
                }
                else
                {
                    MessageBox.Show("you dont have an account, please try another id or sign up!");
                }
            }
        
            catch (FormatException)
            {
                MessageBox.Show("id contains only digits", "Format Error");
            }
            catch (Exception)
            {
                MessageBox.Show("error!", "Sorry!");
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            parent.lblGameName.Visible = false;
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            parent.SignUpp();
        }
    }
}
