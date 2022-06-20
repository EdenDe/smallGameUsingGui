
namespace Game
{
    partial class SignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnterId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.LinkLabel();
            this.btmlogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 32F);
            this.label1.Location = new System.Drawing.Point(275, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.label2.Location = new System.Drawing.Point(246, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "please enter your id to log in (9 digits)";
            // 
            // txtEnterId
            // 
            this.txtEnterId.Location = new System.Drawing.Point(250, 238);
            this.txtEnterId.Name = "txtEnterId";
            this.txtEnterId.Size = new System.Drawing.Size(200, 20);
            this.txtEnterId.TabIndex = 2;
            this.txtEnterId.MaxLength = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 8.25F);
            this.label3.Location = new System.Drawing.Point(282, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "dont have an account?";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Kristen ITC", 8.25F);
            this.lblSignUp.Location = new System.Drawing.Point(417, 302);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(51, 16);
            this.lblSignUp.TabIndex = 4;
            this.lblSignUp.TabStop = true;
            this.lblSignUp.Text = "Sign up!";
            this.lblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSignUp_LinkClicked);
            // 
            // btmlogIn
            // 
            this.btmlogIn.BackColor = System.Drawing.Color.White;
            this.btmlogIn.Font = new System.Drawing.Font("Kristen ITC", 8.25F);
            this.btmlogIn.Location = new System.Drawing.Point(456, 234);
            this.btmlogIn.Name = "btmlogIn";
            this.btmlogIn.Size = new System.Drawing.Size(67, 29);
            this.btmlogIn.TabIndex = 6;
            this.btmlogIn.Text = "Start!";
            this.btmlogIn.UseVisualStyleBackColor = false;
            this.btmlogIn.Click += new System.EventHandler(this.btmlogIn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(791, 447);
            this.ControlBox = false;
            this.Controls.Add(this.btmlogIn);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnterId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignIn";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnterId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblSignUp;
        private System.Windows.Forms.Button btmlogIn;
    }
}

