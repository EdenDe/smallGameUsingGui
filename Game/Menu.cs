using System;
using System.Windows.Forms;

namespace Game
{
    public partial class Menu : Form
    {
        int[] accounts = new int[2];
        string[] userNames = new string[2];
        int signedCounter = 0;
        

        public Menu()
        {
            InitializeComponent();
            IsMdiContainer = true;
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void PlayGame(int id)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.GetType().Name != "Play")
                {
                    ActiveMdiChild.Close();
                }
                else
                {
                    return;
                }

            }

            Play playGame = new Play(this, FindUserName(id));
            playGame.MdiParent = this;
            playGame.Show();
        }


        public string FindUserName(int id)
        {
            int count = 0;

            foreach (var item in accounts)
            {
                if (item == id)
                {
                    break;
                }
                count++;
            }

            return userNames[count];
        }

        public int FindID(string name)
        {
            int count = 0;

            foreach (var item in userNames)
            {
                if (item == name)
                {
                    break;
                }
                count++;
            }

            return accounts[count];
        }


        public void SignUpp()
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.GetType().Name != "SignUp")
                {
                    ActiveMdiChild.Close();
                }
                else
                {
                    return;
                }

            }
            SignUp SignMeUp = new SignUp(this);
            SignMeUp.MdiParent = this;
            SignMeUp.Show();
        }

        public void SignInn()
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.GetType().Name != "SignIn")
                {
                    ActiveMdiChild.Close();
                }
                else
                {
                    return;
                }
            }

            SignIn signMeIn = new SignIn(this);
            signMeIn.MdiParent = this;
            signMeIn.Show();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInn();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
            {

                if (ActiveMdiChild.GetType().Name != "About")
                {
                    ActiveMdiChild.Close();

                }
                else
                {
                    return;
                }

            }
            About aboutGame = new About(this);
            aboutGame.MdiParent = this;
            aboutGame.Show();
        }


        public bool Signed(int idNum)
        {
            foreach (var item in accounts)
            {
                if (item == idNum)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckUserName(string userName)
        {

            foreach (var item in userNames)
            {
                if (item == userName)
                {
                    return true;
                }
            }
            return false;
        }


        public bool CheckID(int idInt)
        {

            if (idInt.ToString().Length == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Add(int newID, string username)
        {
            if (username == "")
            {
                username = "no name";
            }

            if (signedCounter + 1 == accounts.Length)
            {
                EnlargeArray();
            }
            accounts[signedCounter] = newID;
            userNames[signedCounter++] = username;
        }

        private void EnlargeArray()
        {
            int[] newArray = new int[accounts.Length * 2];

            Array.Copy(accounts, newArray, accounts.Length);

            accounts = newArray;

            string[] newArray1 = new string[userNames.Length * 2];

            Array.Copy(userNames, newArray1, userNames.Length);

            userNames = newArray1;
        }



    }
}
