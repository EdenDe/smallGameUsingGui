using System;
using System.Windows.Forms;
using System.Drawing;


namespace Game
{
    public partial class Play : Form
    {
        Menu parent;
        string name;
        
        public Play(Menu p,string name)
        {
            parent = p;
            this.name = name;
            InitializeComponent();            
        }

        private void ckAnswer1_Click(object sender, EventArgs e)
        {
            {
                if (rbO1.Checked && answer1.Visible || answerQ2.Checked && answer2.Visible || answerQ3.Checked && answer3.Visible)
                {
                    MessageBox.Show("Correct answer!", "Correct!");
                    lblCounter.Text = (int.Parse(lblCounter.Text) + 1).ToString();
                }
                else
                {
                    MessageBox.Show("Wrong answer!", "Wrong");
                }

                timer1.Stop();
                NextQ();
            }
        }

        private void NextQ()
        {
            if (answer1.Visible)
            {
                answer1.Visible = false;
                gbQ1.Visible = false;

                answer2.Visible = true;
                gbQ2.Visible = true;
                lbltimer.Text = "7";
            }
            else if (answer2.Visible)
            {
                answer2.Visible = false;
                gbQ2.Visible = false;

                answer3.Visible = true;
                gbQ3.Visible = true;
                lbltimer.Text = "7";

            }
            else
            {
                answer3.Visible = false;
                gbQ3.Visible = false;

                FinishGame();
            }
        }


        private void FinishGame()
        {
            lblFillIn.Visible = false;
                        
            switch (lblCounter.Text)
            {
                case "0":
                    pcIF0.Visible = true;
                    lblEnd.Text += "GIVE IT ANOTHER TRY!";
                    break;

                case "1":
                    pcIF1.Visible = true;
                    lblEnd.Text += "YOU CAN DO BETTER NEXT TIME";
                    break;

                case "2":
                    pcIF2.Visible = true;
                    lblEnd.Text += "YOU ALMOST GOT IT ALL";
                    break;

                case "3":
                    pcIF3.Visible = true;
                    lblEnd.Text += "GOOD JOB!";
                    break;
            }

            lblEnd.Visible = true;
            btnTryAgain.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = (int.Parse(lbltimer.Text) - 1).ToString();
            if (lbltimer.Text == "0")
            {
                timer1.Stop();
                MessageBox.Show("Time's out, next question", "Time's out");
                NextQ();
            }
        }


        private void btnGiveUP_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbltimer_TextChanged(object sender, EventArgs e)
        {
            if (lbltimer.Text == "7")
            {
                timer1.Start();
            }
        }

        private void Play_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Have fun, " + name, "Enjoy");
            lbltimer.Text = "7";
            lblCounter.Text = "0";

            lblEnd.Text = name + ", ";
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            Close();
            parent.PlayGame(parent.FindID(name));
        }
    }
}