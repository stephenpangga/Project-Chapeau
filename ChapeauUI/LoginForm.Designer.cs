namespace ChapeauUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_LoginUsername = new System.Windows.Forms.TextBox();
            this.txt_LoginPassword = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_LoginUsername = new System.Windows.Forms.Label();
            this.lbl_LoginPassword = new System.Windows.Forms.Label();
            this.img_ChapeauLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_ChapeauLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_LoginUsername
            // 
            this.txt_LoginUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginUsername.Location = new System.Drawing.Point(486, 357);
            this.txt_LoginUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_LoginUsername.Name = "txt_LoginUsername";
            this.txt_LoginUsername.Size = new System.Drawing.Size(242, 26);
            this.txt_LoginUsername.TabIndex = 0;
            // 
            // txt_LoginPassword
            // 
            this.txt_LoginPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginPassword.Location = new System.Drawing.Point(486, 412);
            this.txt_LoginPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_LoginPassword.Name = "txt_LoginPassword";
            this.txt_LoginPassword.PasswordChar = '*';
            this.txt_LoginPassword.Size = new System.Drawing.Size(242, 26);
            this.txt_LoginPassword.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(311, 506);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(417, 65);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_LoginUsername
            // 
            this.lbl_LoginUsername.AutoSize = true;
            this.lbl_LoginUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginUsername.Location = new System.Drawing.Point(323, 365);
            this.lbl_LoginUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoginUsername.Name = "lbl_LoginUsername";
            this.lbl_LoginUsername.Size = new System.Drawing.Size(97, 18);
            this.lbl_LoginUsername.TabIndex = 3;
            this.lbl_LoginUsername.Text = "Employee ID";
            // 
            // lbl_LoginPassword
            // 
            this.lbl_LoginPassword.AutoSize = true;
            this.lbl_LoginPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginPassword.Location = new System.Drawing.Point(323, 415);
            this.lbl_LoginPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoginPassword.Name = "lbl_LoginPassword";
            this.lbl_LoginPassword.Size = new System.Drawing.Size(78, 18);
            this.lbl_LoginPassword.TabIndex = 4;
            this.lbl_LoginPassword.Text = "Password";
            // 
            // img_ChapeauLogo
            // 
            this.img_ChapeauLogo.Image = ((System.Drawing.Image)(resources.GetObject("img_ChapeauLogo.Image")));
            this.img_ChapeauLogo.Location = new System.Drawing.Point(311, 66);
            this.img_ChapeauLogo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.img_ChapeauLogo.Name = "img_ChapeauLogo";
            this.img_ChapeauLogo.Size = new System.Drawing.Size(417, 240);
            this.img_ChapeauLogo.TabIndex = 8;
            this.img_ChapeauLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.img_ChapeauLogo);
            this.Controls.Add(this.lbl_LoginPassword);
            this.Controls.Add(this.lbl_LoginUsername);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_LoginPassword);
            this.Controls.Add(this.txt_LoginUsername);
            this.Name = "LoginForm";
            this.Text = "6350";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.txt_LoginUsername, 0);
            this.Controls.SetChildIndex(this.txt_LoginPassword, 0);
            this.Controls.SetChildIndex(this.btn_Login, 0);
            this.Controls.SetChildIndex(this.lbl_LoginUsername, 0);
            this.Controls.SetChildIndex(this.lbl_LoginPassword, 0);
            this.Controls.SetChildIndex(this.img_ChapeauLogo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.img_ChapeauLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_LoginUsername;
        private System.Windows.Forms.TextBox txt_LoginPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_LoginUsername;
        private System.Windows.Forms.Label lbl_LoginPassword;
        public System.Windows.Forms.PictureBox img_ChapeauLogo;
    }
}

