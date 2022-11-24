namespace ChapeauUI
{
    partial class OrdersListForm
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
            this.btn_MarkFinished = new System.Windows.Forms.Button();
            this.btn_SortByFinished = new System.Windows.Forms.Button();
            this.btn_SortByRunning = new System.Windows.Forms.Button();
            this.lbl_SortBy = new System.Windows.Forms.Label();
            this.PicBox_TableNumber = new System.Windows.Forms.PictureBox();
            this.lst_Orders = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_OrderTime = new System.Windows.Forms.Label();
            this.lbl_OrderStatus = new System.Windows.Forms.Label();
            this.timer_OrderListView = new System.Windows.Forms.Timer(this.components);
            this.lbl_OrderHandledBy = new System.Windows.Forms.Label();
            this.btn_ViewServedList = new System.Windows.Forms.Button();
            this.btn_ViewDefaultOrders = new System.Windows.Forms.Button();
            this.flpnl_Orders = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_TableNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_MarkFinished
            // 
            this.btn_MarkFinished.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MarkFinished.Location = new System.Drawing.Point(767, 642);
            this.btn_MarkFinished.Name = "btn_MarkFinished";
            this.btn_MarkFinished.Size = new System.Drawing.Size(175, 50);
            this.btn_MarkFinished.TabIndex = 0;
            this.btn_MarkFinished.Text = "Mark as Ready";
            this.btn_MarkFinished.UseVisualStyleBackColor = true;
            this.btn_MarkFinished.Click += new System.EventHandler(this.Btn_MarkFinished_Click);
            // 
            // btn_SortByFinished
            // 
            this.btn_SortByFinished.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortByFinished.Location = new System.Drawing.Point(238, 645);
            this.btn_SortByFinished.Name = "btn_SortByFinished";
            this.btn_SortByFinished.Size = new System.Drawing.Size(100, 40);
            this.btn_SortByFinished.TabIndex = 9;
            this.btn_SortByFinished.Text = "Ready";
            this.btn_SortByFinished.UseVisualStyleBackColor = true;
            this.btn_SortByFinished.Click += new System.EventHandler(this.Btn_SortByFinished_Click);
            // 
            // btn_SortByRunning
            // 
            this.btn_SortByRunning.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortByRunning.Location = new System.Drawing.Point(132, 645);
            this.btn_SortByRunning.Name = "btn_SortByRunning";
            this.btn_SortByRunning.Size = new System.Drawing.Size(100, 40);
            this.btn_SortByRunning.TabIndex = 10;
            this.btn_SortByRunning.Text = "Running";
            this.btn_SortByRunning.UseVisualStyleBackColor = true;
            this.btn_SortByRunning.Click += new System.EventHandler(this.Btn_SortByRunning_Click);
            // 
            // lbl_SortBy
            // 
            this.lbl_SortBy.AutoSize = true;
            this.lbl_SortBy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SortBy.Location = new System.Drawing.Point(51, 656);
            this.lbl_SortBy.Name = "lbl_SortBy";
            this.lbl_SortBy.Size = new System.Drawing.Size(96, 27);
            this.lbl_SortBy.TabIndex = 11;
            this.lbl_SortBy.Text = "Sort by:";
            // 
            // PicBox_TableNumber
            // 
            this.PicBox_TableNumber.Location = new System.Drawing.Point(391, 10);
            this.PicBox_TableNumber.Name = "PicBox_TableNumber";
            this.PicBox_TableNumber.Size = new System.Drawing.Size(100, 90);
            this.PicBox_TableNumber.TabIndex = 12;
            this.PicBox_TableNumber.TabStop = false;
            // 
            // lst_Orders
            // 
            this.lst_Orders.Location = new System.Drawing.Point(0, 0);
            this.lst_Orders.Name = "lst_Orders";
            this.lst_Orders.Size = new System.Drawing.Size(561, 529);
            this.lst_Orders.TabIndex = 0;
            this.lst_Orders.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lst_Orders);
            this.panel1.Location = new System.Drawing.Point(391, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 529);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lbl_OrderTime
            // 
            this.lbl_OrderTime.AutoSize = true;
            this.lbl_OrderTime.Location = new System.Drawing.Point(526, 20);
            this.lbl_OrderTime.Name = "lbl_OrderTime";
            this.lbl_OrderTime.Size = new System.Drawing.Size(138, 23);
            this.lbl_OrderTime.TabIndex = 13;
            this.lbl_OrderTime.Text = "Time Ordered:";
            // 
            // lbl_OrderStatus
            // 
            this.lbl_OrderStatus.AutoSize = true;
            this.lbl_OrderStatus.Location = new System.Drawing.Point(526, 45);
            this.lbl_OrderStatus.Name = "lbl_OrderStatus";
            this.lbl_OrderStatus.Size = new System.Drawing.Size(72, 23);
            this.lbl_OrderStatus.TabIndex = 14;
            this.lbl_OrderStatus.Text = "Status:";
            // 
            // timer_OrderListView
            // 
            this.timer_OrderListView.Enabled = true;
            this.timer_OrderListView.Interval = 10000;
            this.timer_OrderListView.Tick += new System.EventHandler(this.Timer_OrderListView_Tick);
            // 
            // lbl_OrderHandledBy
            // 
            this.lbl_OrderHandledBy.AutoSize = true;
            this.lbl_OrderHandledBy.Location = new System.Drawing.Point(526, 70);
            this.lbl_OrderHandledBy.Name = "lbl_OrderHandledBy";
            this.lbl_OrderHandledBy.Size = new System.Drawing.Size(120, 23);
            this.lbl_OrderHandledBy.TabIndex = 16;
            this.lbl_OrderHandledBy.Text = "Handled by: ";
            // 
            // btn_ViewServedList
            // 
            this.btn_ViewServedList.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewServedList.Location = new System.Drawing.Point(132, 691);
            this.btn_ViewServedList.Name = "btn_ViewServedList";
            this.btn_ViewServedList.Size = new System.Drawing.Size(206, 30);
            this.btn_ViewServedList.TabIndex = 17;
            this.btn_ViewServedList.Text = "View Served Orders";
            this.btn_ViewServedList.UseVisualStyleBackColor = true;
            this.btn_ViewServedList.Click += new System.EventHandler(this.Btn_ViewServedList_Click);
            // 
            // btn_ViewDefaultOrders
            // 
            this.btn_ViewDefaultOrders.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewDefaultOrders.Location = new System.Drawing.Point(132, 662);
            this.btn_ViewDefaultOrders.Name = "btn_ViewDefaultOrders";
            this.btn_ViewDefaultOrders.Size = new System.Drawing.Size(206, 30);
            this.btn_ViewDefaultOrders.TabIndex = 18;
            this.btn_ViewDefaultOrders.Text = "View Default Orders";
            this.btn_ViewDefaultOrders.UseVisualStyleBackColor = true;
            this.btn_ViewDefaultOrders.Click += new System.EventHandler(this.Btn_ViewDefaultOrders_Click);
            // 
            // flpnl_Orders
            // 
            this.flpnl_Orders.AutoScroll = true;
            this.flpnl_Orders.Location = new System.Drawing.Point(54, 17);
            this.flpnl_Orders.Name = "flpnl_Orders";
            this.flpnl_Orders.Size = new System.Drawing.Size(290, 618);
            this.flpnl_Orders.TabIndex = 19;
            // 
            // OrdersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.flpnl_Orders);
            this.Controls.Add(this.btn_ViewDefaultOrders);
            this.Controls.Add(this.btn_ViewServedList);
            this.Controls.Add(this.lbl_OrderHandledBy);
            this.Controls.Add(this.lbl_OrderStatus);
            this.Controls.Add(this.lbl_OrderTime);
            this.Controls.Add(this.PicBox_TableNumber);
            this.Controls.Add(this.btn_MarkFinished);
            this.Controls.Add(this.lbl_SortBy);
            this.Controls.Add(this.btn_SortByRunning);
            this.Controls.Add(this.btn_SortByFinished);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdersListForm";
            this.Text = "[Occupation]Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersListForm_FormClosing);
            this.Load += new System.EventHandler(this.OrdersListForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btn_SortByFinished, 0);
            this.Controls.SetChildIndex(this.btn_SortByRunning, 0);
            this.Controls.SetChildIndex(this.lbl_SortBy, 0);
            this.Controls.SetChildIndex(this.btn_MarkFinished, 0);
            this.Controls.SetChildIndex(this.PicBox_TableNumber, 0);
            this.Controls.SetChildIndex(this.lbl_OrderTime, 0);
            this.Controls.SetChildIndex(this.lbl_OrderStatus, 0);
            this.Controls.SetChildIndex(this.lbl_OrderHandledBy, 0);
            this.Controls.SetChildIndex(this.btn_ViewServedList, 0);
            this.Controls.SetChildIndex(this.btn_ViewDefaultOrders, 0);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.flpnl_Orders, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_TableNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SortByFinished;
        private System.Windows.Forms.Button btn_SortByRunning;
        private System.Windows.Forms.Label lbl_SortBy;
        private System.Windows.Forms.Button btn_MarkFinished;
        private System.Windows.Forms.PictureBox PicBox_TableNumber;
        private System.Windows.Forms.ListView lst_Orders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_OrderTime;
        private System.Windows.Forms.Label lbl_OrderStatus;
        private System.Windows.Forms.Timer timer_OrderListView;
        private System.Windows.Forms.Label lbl_OrderHandledBy;
        private System.Windows.Forms.Button btn_ViewServedList;
        private System.Windows.Forms.Button btn_ViewDefaultOrders;
        private System.Windows.Forms.FlowLayoutPanel flpnl_Orders;
    }
}