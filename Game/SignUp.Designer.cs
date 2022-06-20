
namespace Game
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltlenterid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.btmSignUp = new System.Windows.Forms.Button();
            this.lbluserName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ltlenterid
            // 
            this.ltlenterid.AutoSize = true;
            this.ltlenterid.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.ltlenterid.Location = new System.Drawing.Point(199, 182);
            this.ltlenterid.Name = "ltlenterid";
            this.ltlenterid.Size = new System.Drawing.Size(165, 23);
            this.ltlenterid.TabIndex = 0;
            this.ltlenterid.Text = "Please enter your id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 26.25F);
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "One step before you can start playing!";
            // 
            // txtSign
            // 
            this.txtSign.Location = new System.Drawing.Point(203, 208);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(161, 20);
            this.txtSign.TabIndex = 2;
            this.txtSign.MaxLength = 9;
            // 
            // btmSignUp
            // 
            this.btmSignUp.BackColor = System.Drawing.Color.White;
            this.btmSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btmSignUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmSignUp.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.btmSignUp.Location = new System.Drawing.Point(203, 312);
            this.btmSignUp.Name = "btmSignUp";
            this.btmSignUp.Size = new System.Drawing.Size(144, 40);
            this.btmSignUp.TabIndex = 3;
            this.btmSignUp.Text = "Sign Up!";
            this.btmSignUp.UseVisualStyleBackColor = false;
            this.btmSignUp.Click += new System.EventHandler(this.btmSignUp_Click);
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.lbluserName.Location = new System.Drawing.Point(199, 248);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(230, 23);
            this.lbluserName.TabIndex = 5;
            this.lbluserName.Text = "Please enter your username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(203, 271);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(226, 20);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.MaxLength = 15;
            // 
            // SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(781, 400);
            this.ControlBox = false;
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbluserName);
            this.Controls.Add(this.btmSignUp);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltlenterid);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltlenterid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Button btmSignUp;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.TextBox txtUsername;
    }
}