namespace Visual_Project
{
    partial class FORM_LoignRegester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_LoignRegester));
            this.BTN_LoginView = new System.Windows.Forms.Button();
            this.BTN_Signup = new System.Windows.Forms.Button();
            this.PNL_LoginRegester = new System.Windows.Forms.Panel();
            this.PNL_Regester = new System.Windows.Forms.Panel();
            this.LBL_Hint = new System.Windows.Forms.Label();
            this.LBL_PasswordConfirm = new System.Windows.Forms.Label();
            this.TxtBox_PasswordConfirm = new System.Windows.Forms.TextBox();
            this.LBL_Regester_Password = new System.Windows.Forms.Label();
            this.TxtBox_Signup_Password = new System.Windows.Forms.TextBox();
            this.LBL_Regester_NatNum = new System.Windows.Forms.Label();
            this.TxtBox_Signup_NatNum = new System.Windows.Forms.TextBox();
            this.LBL_Verification_Code = new System.Windows.Forms.Label();
            this.BTN_RegesterAndLogin = new System.Windows.Forms.Button();
            this.Verification_Code = new System.Windows.Forms.TextBox();
            this.PNL_Login = new System.Windows.Forms.Panel();
            this.LBL_Login_NatNum = new System.Windows.Forms.Label();
            this.TxtBox_Login_NatNum = new System.Windows.Forms.TextBox();
            this.LBl_Login_Password = new System.Windows.Forms.Label();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.TxtBox_Login_Password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNL_LoginRegester.SuspendLayout();
            this.PNL_Regester.SuspendLayout();
            this.PNL_Login.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_LoginView
            // 
            this.BTN_LoginView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_LoginView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_LoginView.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BTN_LoginView.FlatAppearance.BorderSize = 3;
            this.BTN_LoginView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_LoginView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LoginView.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.BTN_LoginView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_LoginView.Location = new System.Drawing.Point(22, 20);
            this.BTN_LoginView.Name = "BTN_LoginView";
            this.BTN_LoginView.Size = new System.Drawing.Size(200, 70);
            this.BTN_LoginView.TabIndex = 7;
            this.BTN_LoginView.Text = "Login";
            this.BTN_LoginView.UseVisualStyleBackColor = false;
            this.BTN_LoginView.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_Signup
            // 
            this.BTN_Signup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Signup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Signup.FlatAppearance.BorderSize = 3;
            this.BTN_Signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Signup.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.BTN_Signup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Signup.Location = new System.Drawing.Point(237, 20);
            this.BTN_Signup.Name = "BTN_Signup";
            this.BTN_Signup.Size = new System.Drawing.Size(200, 70);
            this.BTN_Signup.TabIndex = 6;
            this.BTN_Signup.Text = "Register";
            this.BTN_Signup.UseVisualStyleBackColor = false;
            this.BTN_Signup.Click += new System.EventHandler(this.button3_Click);
            // 
            // PNL_LoginRegester
            // 
            this.PNL_LoginRegester.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PNL_LoginRegester.Controls.Add(this.PNL_Regester);
            this.PNL_LoginRegester.Controls.Add(this.BTN_Signup);
            this.PNL_LoginRegester.Controls.Add(this.BTN_LoginView);
            this.PNL_LoginRegester.Controls.Add(this.PNL_Login);
            this.PNL_LoginRegester.Location = new System.Drawing.Point(12, 126);
            this.PNL_LoginRegester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PNL_LoginRegester.Name = "PNL_LoginRegester";
            this.PNL_LoginRegester.Size = new System.Drawing.Size(456, 407);
            this.PNL_LoginRegester.TabIndex = 9;
            // 
            // PNL_Regester
            // 
            this.PNL_Regester.Controls.Add(this.LBL_Hint);
            this.PNL_Regester.Controls.Add(this.LBL_PasswordConfirm);
            this.PNL_Regester.Controls.Add(this.TxtBox_PasswordConfirm);
            this.PNL_Regester.Controls.Add(this.LBL_Regester_Password);
            this.PNL_Regester.Controls.Add(this.TxtBox_Signup_Password);
            this.PNL_Regester.Controls.Add(this.LBL_Regester_NatNum);
            this.PNL_Regester.Controls.Add(this.TxtBox_Signup_NatNum);
            this.PNL_Regester.Controls.Add(this.LBL_Verification_Code);
            this.PNL_Regester.Controls.Add(this.BTN_RegesterAndLogin);
            this.PNL_Regester.Controls.Add(this.Verification_Code);
            this.PNL_Regester.Location = new System.Drawing.Point(11, 96);
            this.PNL_Regester.Name = "PNL_Regester";
            this.PNL_Regester.Size = new System.Drawing.Size(397, 278);
            this.PNL_Regester.TabIndex = 12;
            this.PNL_Regester.Visible = false;
            this.PNL_Regester.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_Regester_Paint);
            // 
            // LBL_Hint
            // 
            this.LBL_Hint.AutoSize = true;
            this.LBL_Hint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_Hint.Location = new System.Drawing.Point(160, 198);
            this.LBL_Hint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Hint.Name = "LBL_Hint";
            this.LBL_Hint.Size = new System.Drawing.Size(82, 20);
            this.LBL_Hint.TabIndex = 10;
            this.LBL_Hint.Text = "Hint:(1234)";
            // 
            // LBL_PasswordConfirm
            // 
            this.LBL_PasswordConfirm.AutoSize = true;
            this.LBL_PasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBL_PasswordConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_PasswordConfirm.Location = new System.Drawing.Point(31, 128);
            this.LBL_PasswordConfirm.Name = "LBL_PasswordConfirm";
            this.LBL_PasswordConfirm.Size = new System.Drawing.Size(130, 20);
            this.LBL_PasswordConfirm.TabIndex = 8;
            this.LBL_PasswordConfirm.Text = "Confirm Password:";
            // 
            // TxtBox_PasswordConfirm
            // 
            this.TxtBox_PasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBox_PasswordConfirm.Location = new System.Drawing.Point(164, 125);
            this.TxtBox_PasswordConfirm.Name = "TxtBox_PasswordConfirm";
            this.TxtBox_PasswordConfirm.PasswordChar = '*';
            this.TxtBox_PasswordConfirm.Size = new System.Drawing.Size(219, 27);
            this.TxtBox_PasswordConfirm.TabIndex = 9;
            // 
            // LBL_Regester_Password
            // 
            this.LBL_Regester_Password.AutoSize = true;
            this.LBL_Regester_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBL_Regester_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_Regester_Password.Location = new System.Drawing.Point(31, 85);
            this.LBL_Regester_Password.Name = "LBL_Regester_Password";
            this.LBL_Regester_Password.Size = new System.Drawing.Size(73, 20);
            this.LBL_Regester_Password.TabIndex = 5;
            this.LBL_Regester_Password.Text = "Password:";
            // 
            // TxtBox_Signup_Password
            // 
            this.TxtBox_Signup_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBox_Signup_Password.Location = new System.Drawing.Point(164, 82);
            this.TxtBox_Signup_Password.Name = "TxtBox_Signup_Password";
            this.TxtBox_Signup_Password.PasswordChar = '*';
            this.TxtBox_Signup_Password.Size = new System.Drawing.Size(219, 27);
            this.TxtBox_Signup_Password.TabIndex = 6;
            // 
            // LBL_Regester_NatNum
            // 
            this.LBL_Regester_NatNum.AutoSize = true;
            this.LBL_Regester_NatNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBL_Regester_NatNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_Regester_NatNum.Location = new System.Drawing.Point(31, 42);
            this.LBL_Regester_NatNum.Name = "LBL_Regester_NatNum";
            this.LBL_Regester_NatNum.Size = new System.Drawing.Size(127, 20);
            this.LBL_Regester_NatNum.TabIndex = 1;
            this.LBL_Regester_NatNum.Text = "National Number:";
            // 
            // TxtBox_Signup_NatNum
            // 
            this.TxtBox_Signup_NatNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBox_Signup_NatNum.Location = new System.Drawing.Point(164, 39);
            this.TxtBox_Signup_NatNum.Name = "TxtBox_Signup_NatNum";
            this.TxtBox_Signup_NatNum.Size = new System.Drawing.Size(219, 27);
            this.TxtBox_Signup_NatNum.TabIndex = 0;
            this.TxtBox_Signup_NatNum.TextChanged += new System.EventHandler(this.TxtBox_Signup_NatNum_TextChanged);
            // 
            // LBL_Verification_Code
            // 
            this.LBL_Verification_Code.AutoSize = true;
            this.LBL_Verification_Code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBL_Verification_Code.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_Verification_Code.Location = new System.Drawing.Point(31, 171);
            this.LBL_Verification_Code.Name = "LBL_Verification_Code";
            this.LBL_Verification_Code.Size = new System.Drawing.Size(126, 20);
            this.LBL_Verification_Code.TabIndex = 2;
            this.LBL_Verification_Code.Text = "Verification Code:";
            // 
            // BTN_RegesterAndLogin
            // 
            this.BTN_RegesterAndLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_RegesterAndLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_RegesterAndLogin.FlatAppearance.BorderSize = 0;
            this.BTN_RegesterAndLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RegesterAndLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RegesterAndLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_RegesterAndLogin.Location = new System.Drawing.Point(31, 222);
            this.BTN_RegesterAndLogin.Name = "BTN_RegesterAndLogin";
            this.BTN_RegesterAndLogin.Size = new System.Drawing.Size(352, 39);
            this.BTN_RegesterAndLogin.TabIndex = 4;
            this.BTN_RegesterAndLogin.Text = "Register And Login";
            this.BTN_RegesterAndLogin.UseVisualStyleBackColor = false;
            this.BTN_RegesterAndLogin.Click += new System.EventHandler(this.BTN_RegesterAndLogin_Click);
            // 
            // Verification_Code
            // 
            this.Verification_Code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Verification_Code.Location = new System.Drawing.Point(164, 168);
            this.Verification_Code.Name = "Verification_Code";
            this.Verification_Code.PasswordChar = '*';
            this.Verification_Code.Size = new System.Drawing.Size(219, 27);
            this.Verification_Code.TabIndex = 3;
            // 
            // PNL_Login
            // 
            this.PNL_Login.Controls.Add(this.LBL_Login_NatNum);
            this.PNL_Login.Controls.Add(this.TxtBox_Login_NatNum);
            this.PNL_Login.Controls.Add(this.LBl_Login_Password);
            this.PNL_Login.Controls.Add(this.BTN_Login);
            this.PNL_Login.Controls.Add(this.TxtBox_Login_Password);
            this.PNL_Login.Location = new System.Drawing.Point(11, 96);
            this.PNL_Login.Name = "PNL_Login";
            this.PNL_Login.Size = new System.Drawing.Size(426, 299);
            this.PNL_Login.TabIndex = 7;
            // 
            // LBL_Login_NatNum
            // 
            this.LBL_Login_NatNum.AutoSize = true;
            this.LBL_Login_NatNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBL_Login_NatNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_Login_NatNum.Location = new System.Drawing.Point(31, 42);
            this.LBL_Login_NatNum.Name = "LBL_Login_NatNum";
            this.LBL_Login_NatNum.Size = new System.Drawing.Size(127, 20);
            this.LBL_Login_NatNum.TabIndex = 1;
            this.LBL_Login_NatNum.Text = "National Number:";
            // 
            // TxtBox_Login_NatNum
            // 
            this.TxtBox_Login_NatNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBox_Login_NatNum.Location = new System.Drawing.Point(164, 39);
            this.TxtBox_Login_NatNum.Name = "TxtBox_Login_NatNum";
            this.TxtBox_Login_NatNum.Size = new System.Drawing.Size(219, 27);
            this.TxtBox_Login_NatNum.TabIndex = 0;
            // 
            // LBl_Login_Password
            // 
            this.LBl_Login_Password.AutoSize = true;
            this.LBl_Login_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBl_Login_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBl_Login_Password.Location = new System.Drawing.Point(31, 85);
            this.LBl_Login_Password.Name = "LBl_Login_Password";
            this.LBl_Login_Password.Size = new System.Drawing.Size(73, 20);
            this.LBl_Login_Password.TabIndex = 2;
            this.LBl_Login_Password.Text = "Password:";
            // 
            // BTN_Login
            // 
            this.BTN_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Login.FlatAppearance.BorderSize = 0;
            this.BTN_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Login.Location = new System.Drawing.Point(31, 136);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(352, 39);
            this.BTN_Login.TabIndex = 4;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = false;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // TxtBox_Login_Password
            // 
            this.TxtBox_Login_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBox_Login_Password.Location = new System.Drawing.Point(164, 82);
            this.TxtBox_Login_Password.Name = "TxtBox_Login_Password";
            this.TxtBox_Login_Password.PasswordChar = '*';
            this.TxtBox_Login_Password.Size = new System.Drawing.Size(219, 27);
            this.TxtBox_Login_Password.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 128);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Visual_Project.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(183, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FORM_LoignRegester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(480, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PNL_LoginRegester);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_LoignRegester";
            this.Text = "Login & Register Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FORM_LoignRegester_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PNL_LoginRegester.ResumeLayout(false);
            this.PNL_Regester.ResumeLayout(false);
            this.PNL_Regester.PerformLayout();
            this.PNL_Login.ResumeLayout(false);
            this.PNL_Login.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_LoginView;
        private System.Windows.Forms.Button BTN_Signup;
        private System.Windows.Forms.Panel PNL_LoginRegester;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PNL_Login;
        private System.Windows.Forms.Label LBL_Login_NatNum;
        private System.Windows.Forms.TextBox TxtBox_Login_NatNum;
        private System.Windows.Forms.Label LBl_Login_Password;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.TextBox TxtBox_Login_Password;
        private System.Windows.Forms.Panel PNL_Regester;
        private System.Windows.Forms.Label LBL_Hint;
        private System.Windows.Forms.Label LBL_PasswordConfirm;
        private System.Windows.Forms.TextBox TxtBox_PasswordConfirm;
        private System.Windows.Forms.Label LBL_Regester_Password;
        private System.Windows.Forms.TextBox TxtBox_Signup_Password;
        private System.Windows.Forms.Label LBL_Regester_NatNum;
        private System.Windows.Forms.TextBox TxtBox_Signup_NatNum;
        private System.Windows.Forms.Label LBL_Verification_Code;
        private System.Windows.Forms.Button BTN_RegesterAndLogin;
        private System.Windows.Forms.TextBox Verification_Code;
    }
}

