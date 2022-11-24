namespace ChapeauUI
{
    partial class TableViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableViewForm));
            this.flpnl_DiningTables = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_FreeColor = new System.Windows.Forms.Label();
            this.lbl_ReservedColor = new System.Windows.Forms.Label();
            this.lbl_OccupiedColor = new System.Windows.Forms.Label();
            this.tableViewRefresher = new System.Windows.Forms.Timer(this.components);
            this.btn_KitchenNotifications = new ChapeauUI.BaseButton();
            this.btn_BarNotifications = new ChapeauUI.BaseButton();
            this.pnl_NotificationButtons = new System.Windows.Forms.Panel();
            this.pic_NotificationKitchen = new System.Windows.Forms.PictureBox();
            this.pic_NotificationBar = new System.Windows.Forms.PictureBox();
            this.lbl_Notifications = new System.Windows.Forms.Label();
            this.pnl_Notifications = new System.Windows.Forms.Panel();
            this.btn_hidePanel = new System.Windows.Forms.Button();
            this.lbl_OrderContentWaiter = new System.Windows.Forms.Label();
            this.lst_OrderContentWaiter = new System.Windows.Forms.ListView();
            this.btn_Served = new ChapeauUI.BaseButton();
            this.lst_OrdersWaiter = new System.Windows.Forms.ListView();
            this.ordersWaiterRefresher = new System.Windows.Forms.Timer(this.components);
            this.pnl_NotificationButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NotificationKitchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NotificationBar)).BeginInit();
            this.pnl_Notifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnl_DiningTables
            // 
            this.flpnl_DiningTables.Location = new System.Drawing.Point(107, 166);
            this.flpnl_DiningTables.Name = "flpnl_DiningTables";
            this.flpnl_DiningTables.Size = new System.Drawing.Size(780, 359);
            this.flpnl_DiningTables.TabIndex = 8;
            this.flpnl_DiningTables.Paint += new System.Windows.Forms.PaintEventHandler(this.flpnl_DiningTables_Paint);
            // 
            // lbl_FreeColor
            // 
            this.lbl_FreeColor.AutoSize = true;
            this.lbl_FreeColor.Location = new System.Drawing.Point(102, 543);
            this.lbl_FreeColor.Name = "lbl_FreeColor";
            this.lbl_FreeColor.Size = new System.Drawing.Size(80, 36);
            this.lbl_FreeColor.TabIndex = 9;
            this.lbl_FreeColor.Text = "Free";
            // 
            // lbl_ReservedColor
            // 
            this.lbl_ReservedColor.AutoSize = true;
            this.lbl_ReservedColor.Location = new System.Drawing.Point(102, 620);
            this.lbl_ReservedColor.Name = "lbl_ReservedColor";
            this.lbl_ReservedColor.Size = new System.Drawing.Size(148, 36);
            this.lbl_ReservedColor.TabIndex = 10;
            this.lbl_ReservedColor.Text = "Reserved";
            // 
            // lbl_OccupiedColor
            // 
            this.lbl_OccupiedColor.AutoSize = true;
            this.lbl_OccupiedColor.Location = new System.Drawing.Point(102, 581);
            this.lbl_OccupiedColor.Name = "lbl_OccupiedColor";
            this.lbl_OccupiedColor.Size = new System.Drawing.Size(148, 36);
            this.lbl_OccupiedColor.TabIndex = 11;
            this.lbl_OccupiedColor.Text = "Occupied";
            // 
            // tableViewRefresher
            // 
            this.tableViewRefresher.Enabled = true;
            this.tableViewRefresher.Interval = 30000;
            this.tableViewRefresher.Tick += new System.EventHandler(this.tableViewRefresher_Tick);
            // 
            // btn_KitchenNotifications
            // 
            this.btn_KitchenNotifications.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btn_KitchenNotifications.Location = new System.Drawing.Point(317, 47);
            this.btn_KitchenNotifications.Name = "btn_KitchenNotifications";
            this.btn_KitchenNotifications.Size = new System.Drawing.Size(239, 62);
            this.btn_KitchenNotifications.TabIndex = 12;
            this.btn_KitchenNotifications.Text = "Kitchen";
            this.btn_KitchenNotifications.UseVisualStyleBackColor = true;
            this.btn_KitchenNotifications.Click += new System.EventHandler(this.btn_KitchenNotifications_Click);
            // 
            // btn_BarNotifications
            // 
            this.btn_BarNotifications.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btn_BarNotifications.Location = new System.Drawing.Point(31, 47);
            this.btn_BarNotifications.Name = "btn_BarNotifications";
            this.btn_BarNotifications.Size = new System.Drawing.Size(239, 63);
            this.btn_BarNotifications.TabIndex = 13;
            this.btn_BarNotifications.Text = "Bar";
            this.btn_BarNotifications.UseVisualStyleBackColor = true;
            this.btn_BarNotifications.Click += new System.EventHandler(this.btn_BarNotifications_Click);
            // 
            // pnl_NotificationButtons
            // 
            this.pnl_NotificationButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_NotificationButtons.Controls.Add(this.pic_NotificationKitchen);
            this.pnl_NotificationButtons.Controls.Add(this.pic_NotificationBar);
            this.pnl_NotificationButtons.Controls.Add(this.lbl_Notifications);
            this.pnl_NotificationButtons.Controls.Add(this.btn_KitchenNotifications);
            this.pnl_NotificationButtons.Controls.Add(this.btn_BarNotifications);
            this.pnl_NotificationButtons.Location = new System.Drawing.Point(107, 12);
            this.pnl_NotificationButtons.Name = "pnl_NotificationButtons";
            this.pnl_NotificationButtons.Size = new System.Drawing.Size(582, 141);
            this.pnl_NotificationButtons.TabIndex = 14;
            // 
            // pic_NotificationKitchen
            // 
            this.pic_NotificationKitchen.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_NotificationKitchen.Image = ((System.Drawing.Image)(resources.GetObject("pic_NotificationKitchen.Image")));
            this.pic_NotificationKitchen.Location = new System.Drawing.Point(492, 53);
            this.pic_NotificationKitchen.Name = "pic_NotificationKitchen";
            this.pic_NotificationKitchen.Size = new System.Drawing.Size(57, 50);
            this.pic_NotificationKitchen.TabIndex = 16;
            this.pic_NotificationKitchen.TabStop = false;
            // 
            // pic_NotificationBar
            // 
            this.pic_NotificationBar.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_NotificationBar.Image = ((System.Drawing.Image)(resources.GetObject("pic_NotificationBar.Image")));
            this.pic_NotificationBar.Location = new System.Drawing.Point(206, 54);
            this.pic_NotificationBar.Name = "pic_NotificationBar";
            this.pic_NotificationBar.Size = new System.Drawing.Size(57, 50);
            this.pic_NotificationBar.TabIndex = 15;
            this.pic_NotificationBar.TabStop = false;
            // 
            // lbl_Notifications
            // 
            this.lbl_Notifications.AutoSize = true;
            this.lbl_Notifications.Location = new System.Drawing.Point(31, 9);
            this.lbl_Notifications.Name = "lbl_Notifications";
            this.lbl_Notifications.Size = new System.Drawing.Size(188, 36);
            this.lbl_Notifications.TabIndex = 14;
            this.lbl_Notifications.Text = "Notifications";
            // 
            // pnl_Notifications
            // 
            this.pnl_Notifications.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnl_Notifications.Controls.Add(this.btn_hidePanel);
            this.pnl_Notifications.Controls.Add(this.lbl_OrderContentWaiter);
            this.pnl_Notifications.Controls.Add(this.lst_OrderContentWaiter);
            this.pnl_Notifications.Controls.Add(this.btn_Served);
            this.pnl_Notifications.Controls.Add(this.lst_OrdersWaiter);
            this.pnl_Notifications.Location = new System.Drawing.Point(21, 166);
            this.pnl_Notifications.Name = "pnl_Notifications";
            this.pnl_Notifications.Size = new System.Drawing.Size(964, 534);
            this.pnl_Notifications.TabIndex = 15;
            // 
            // btn_hidePanel
            // 
            this.btn_hidePanel.Font = new System.Drawing.Font("Arial", 18F);
            this.btn_hidePanel.Location = new System.Drawing.Point(867, 15);
            this.btn_hidePanel.Name = "btn_hidePanel";
            this.btn_hidePanel.Size = new System.Drawing.Size(75, 56);
            this.btn_hidePanel.TabIndex = 4;
            this.btn_hidePanel.Text = "X";
            this.btn_hidePanel.UseVisualStyleBackColor = true;
            this.btn_hidePanel.Click += new System.EventHandler(this.btn_hidePanel_Click);
            // 
            // lbl_OrderContentWaiter
            // 
            this.lbl_OrderContentWaiter.AutoSize = true;
            this.lbl_OrderContentWaiter.Location = new System.Drawing.Point(624, 72);
            this.lbl_OrderContentWaiter.Name = "lbl_OrderContentWaiter";
            this.lbl_OrderContentWaiter.Size = new System.Drawing.Size(216, 36);
            this.lbl_OrderContentWaiter.TabIndex = 3;
            this.lbl_OrderContentWaiter.Text = "Order Content";
            // 
            // lst_OrderContentWaiter
            // 
            this.lst_OrderContentWaiter.Location = new System.Drawing.Point(630, 111);
            this.lst_OrderContentWaiter.Name = "lst_OrderContentWaiter";
            this.lst_OrderContentWaiter.Size = new System.Drawing.Size(311, 291);
            this.lst_OrderContentWaiter.TabIndex = 2;
            this.lst_OrderContentWaiter.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Served
            // 
            this.btn_Served.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Served.Location = new System.Drawing.Point(673, 424);
            this.btn_Served.Name = "btn_Served";
            this.btn_Served.Size = new System.Drawing.Size(269, 78);
            this.btn_Served.TabIndex = 1;
            this.btn_Served.Text = "Served";
            this.btn_Served.UseVisualStyleBackColor = true;
            this.btn_Served.Click += new System.EventHandler(this.btn_Served_Click);
            // 
            // lst_OrdersWaiter
            // 
            this.lst_OrdersWaiter.Location = new System.Drawing.Point(26, 28);
            this.lst_OrdersWaiter.Name = "lst_OrdersWaiter";
            this.lst_OrdersWaiter.Size = new System.Drawing.Size(532, 474);
            this.lst_OrdersWaiter.TabIndex = 0;
            this.lst_OrdersWaiter.UseCompatibleStateImageBehavior = false;
            this.lst_OrdersWaiter.SelectedIndexChanged += new System.EventHandler(this.lst_OrdersWaiter_SelectedIndexChanged);
            // 
            // ordersWaiterRefresher
            // 
            this.ordersWaiterRefresher.Enabled = true;
            this.ordersWaiterRefresher.Interval = 30000;
            this.ordersWaiterRefresher.Tick += new System.EventHandler(this.ordersWaiterRefresher_Tick);
            // 
            // TableViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.pnl_Notifications);
            this.Controls.Add(this.pnl_NotificationButtons);
            this.Controls.Add(this.lbl_OccupiedColor);
            this.Controls.Add(this.lbl_ReservedColor);
            this.Controls.Add(this.lbl_FreeColor);
            this.Controls.Add(this.flpnl_DiningTables);
            this.Font = new System.Drawing.Font("Arial", 16F);
            this.Name = "TableViewForm";
            this.Text = "TableViewForm";
            this.Load += new System.EventHandler(this.TableViewForm_Load);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.flpnl_DiningTables, 0);
            this.Controls.SetChildIndex(this.lbl_FreeColor, 0);
            this.Controls.SetChildIndex(this.lbl_ReservedColor, 0);
            this.Controls.SetChildIndex(this.lbl_OccupiedColor, 0);
            this.Controls.SetChildIndex(this.pnl_NotificationButtons, 0);
            this.Controls.SetChildIndex(this.pnl_Notifications, 0);
            this.pnl_NotificationButtons.ResumeLayout(false);
            this.pnl_NotificationButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NotificationKitchen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NotificationBar)).EndInit();
            this.pnl_Notifications.ResumeLayout(false);
            this.pnl_Notifications.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnl_DiningTables;
        private System.Windows.Forms.Label lbl_FreeColor;
        private System.Windows.Forms.Label lbl_ReservedColor;
        private System.Windows.Forms.Label lbl_OccupiedColor;
        private System.Windows.Forms.Timer tableViewRefresher;
        private BaseButton btn_KitchenNotifications;
        private BaseButton btn_BarNotifications;
        private System.Windows.Forms.Panel pnl_NotificationButtons;
        private System.Windows.Forms.Label lbl_Notifications;
        private System.Windows.Forms.Panel pnl_Notifications;
        private System.Windows.Forms.Label lbl_OrderContentWaiter;
        private System.Windows.Forms.ListView lst_OrderContentWaiter;
        private BaseButton btn_Served;
        private System.Windows.Forms.ListView lst_OrdersWaiter;
        private System.Windows.Forms.Timer ordersWaiterRefresher;
        private System.Windows.Forms.Button btn_hidePanel;
        private System.Windows.Forms.PictureBox pic_NotificationKitchen;
        private System.Windows.Forms.PictureBox pic_NotificationBar;
    }
}