namespace BT_20_11_NET
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnQuit = new Button();
            btnLogin = new Button();
            tbPassWord = new TextBox();
            tbUserName = new TextBox();
            lbPassWord = new Label();
            lbUserName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnQuit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(tbPassWord);
            panel1.Controls.Add(tbUserName);
            panel1.Controls.Add(lbPassWord);
            panel1.Controls.Add(lbUserName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 361);
            panel1.TabIndex = 0;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(356, 277);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(530, 277);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassWord
            // 
            tbPassWord.Location = new Point(329, 143);
            tbPassWord.Name = "tbPassWord";
            tbPassWord.Size = new Size(322, 27);
            tbPassWord.TabIndex = 3;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(329, 52);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(322, 27);
            tbUserName.TabIndex = 2;
            // 
            // lbPassWord
            // 
            lbPassWord.AutoSize = true;
            lbPassWord.Location = new Point(107, 146);
            lbPassWord.Name = "lbPassWord";
            lbPassWord.Size = new Size(76, 20);
            lbPassWord.TabIndex = 1;
            lbPassWord.Text = "Pass Word";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(107, 52);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(82, 20);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "User Name";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 387);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Form1";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnQuit;
        private Button btnLogin;
        private TextBox tbPassWord;
        private TextBox tbUserName;
        private Label lbPassWord;
        private Label lbUserName;
    }
}
