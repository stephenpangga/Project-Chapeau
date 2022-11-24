namespace ChapeauUI
{
    partial class BaseForm
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
            this.components = new System.ComponentModel.Container();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_LoggedUser = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Clock = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.CausesValidation = false;
            this.Btn_LogOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogOut.Location = new System.Drawing.Point(879, 17);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(106, 62);
            this.Btn_LogOut.TabIndex = 7;
            this.Btn_LogOut.Text = "LogOut";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // lbl_LoggedUser
            // 
            this.lbl_LoggedUser.AutoSize = true;
            this.lbl_LoggedUser.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_LoggedUser.Location = new System.Drawing.Point(783, 49);
            this.lbl_LoggedUser.Name = "lbl_LoggedUser";
            this.lbl_LoggedUser.Size = new System.Drawing.Size(42, 32);
            this.lbl_LoggedUser.TabIndex = 8;
            this.lbl_LoggedUser.Text = "---";
            this.lbl_LoggedUser.Click += new System.EventHandler(this.lbl_LoggedUser_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_User.Location = new System.Drawing.Point(783, 30);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(81, 32);
            this.lbl_User.TabIndex = 9;
            this.lbl_User.Text = "User:";
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.AutoSize = true;
            this.lbl_Clock.Location = new System.Drawing.Point(892, 82);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(74, 27);
            this.lbl_Clock.TabIndex = 10;
            this.lbl_Clock.Text = "--:--:--";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // BaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.lbl_Clock);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_LoggedUser);
            this.Controls.Add(this.Btn_LogOut);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseForm_FormClosed);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Label lbl_LoggedUser;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Clock;
        private System.Windows.Forms.Timer clock;
    }
}