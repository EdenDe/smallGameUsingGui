using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class SignUp : Form
    {
        Menu parent;

        public SignUp(Menu p)
        {
            parent = p;          
            InitializeComponent();
        }
      
        private void btmSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                int idInt = int.Parse(txtSign.Text);
                string username = txtUsername.Text;


                if (parent.CheckUserName(username))
                {
                    MessageBox.Show("The name is already taken", "Already Taken Error");
                    return;
                }

                if (!parent.CheckID(idInt))
                {
                    MessageBox.Show("id needs to be 9 digits", "Length Error");
                }
                else if (parent.Signed(idInt))
                {
                    MessageBox.Show("This id is already taken", "Already Taken Error");
                }
                else
                {
                    parent.Add(idInt, username);
                    MessageBox.Show("OK! you can sign in now!" , "Succsus");
                    Close();
                    parent.SignInn();                    
                }

            }      
            catch (FormatException)
            {
                MessageBox.Show("id needs to be only digits", "Format Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Sorry!");
            }
        }

     
     
    }
}
