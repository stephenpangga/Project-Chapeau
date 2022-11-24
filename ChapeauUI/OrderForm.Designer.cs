namespace ChapeauUI
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.flpnl_MainCatagories = new System.Windows.Forms.FlowLayoutPanel();
            this.flpnl_SubCatagories = new System.Windows.Forms.FlowLayoutPanel();
            this.flpnl_SubCatagoryItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lst_NewOrderItems = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_NewOrderClearItems = new System.Windows.Forms.Button();
            this.btn_NewOrderItemDelete = new System.Windows.Forms.Button();
            this.btn_NewOrderBack = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_ConfirmOrder = new System.Windows.Forms.Button();
            this.btn_CommentOrder = new ChapeauUI.BaseButton();
            this.lbl_Comment = new System.Windows.Forms.Label();
            this.rtxt_CommentOrder = new System.Windows.Forms.RichTextBox();
            this.btn_ConfirmComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.8F);
            this.label1.Location = new System.Drawing.Point(349, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "ORDER VIEW";
            // 
            // flpnl_MainCatagories
            // 
            this.flpnl_MainCatagories.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpnl_MainCatagories.Location = new System.Drawing.Point(445, 116);
            this.flpnl_MainCatagories.Name = "flpnl_MainCatagories";
            this.flpnl_MainCatagories.Size = new System.Drawing.Size(141, 283);
            this.flpnl_MainCatagories.TabIndex = 9;
            this.flpnl_MainCatagories.Paint += new System.Windows.Forms.PaintEventHandler(this.flpnl_MainCatagories_Paint);
            // 
            // flpnl_SubCatagories
            // 
            this.flpnl_SubCatagories.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpnl_SubCatagories.Location = new System.Drawing.Point(585, 116);
            this.flpnl_SubCatagories.Name = "flpnl_SubCatagories";
            this.flpnl_SubCatagories.Size = new System.Drawing.Size(133, 283);
            this.flpnl_SubCatagories.TabIndex = 10;
            this.flpnl_SubCatagories.Paint += new System.Windows.Forms.PaintEventHandler(this.flpnl_SubCatagories_Paint);
            // 
            // flpnl_SubCatagoryItems
            // 
            this.flpnl_SubCatagoryItems.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpnl_SubCatagoryItems.Location = new System.Drawing.Point(735, 116);
            this.flpnl_SubCatagoryItems.Name = "flpnl_SubCatagoryItems";
            this.flpnl_SubCatagoryItems.Size = new System.Drawing.Size(278, 438);
            this.flpnl_SubCatagoryItems.TabIndex = 11;
            // 
            // lst_NewOrderItems
            // 
            this.lst_NewOrderItems.Font = new System.Drawing.Font("Arial", 12F);
            this.lst_NewOrderItems.Location = new System.Drawing.Point(33, 117);
            this.lst_NewOrderItems.Name = "lst_NewOrderItems";
            this.lst_NewOrderItems.Size = new System.Drawing.Size(389, 483);
            this.lst_NewOrderItems.TabIndex = 12;
            this.lst_NewOrderItems.UseCompatibleStateImageBehavior = false;
            this.lst_NewOrderItems.SelectedIndexChanged += new System.EventHandler(this.lst_NewOrderItems_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selected items";
            // 
            // btn_NewOrderClearItems
            // 
            this.btn_NewOrderClearItems.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewOrderClearItems.Location = new System.Drawing.Point(240, 621);
            this.btn_NewOrderClearItems.Name = "btn_NewOrderClearItems";
            this.btn_NewOrderClearItems.Size = new System.Drawing.Size(81, 60);
            this.btn_NewOrderClearItems.TabIndex = 14;
            this.btn_NewOrderClearItems.Text = "Clear";
            this.btn_NewOrderClearItems.UseVisualStyleBackColor = true;
            this.btn_NewOrderClearItems.Click += new System.EventHandler(this.btn_NewOrderClearItems_Click);
            // 
            // btn_NewOrderItemDelete
            // 
            this.btn_NewOrderItemDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewOrderItemDelete.Location = new System.Drawing.Point(143, 622);
            this.btn_NewOrderItemDelete.Name = "btn_NewOrderItemDelete";
            this.btn_NewOrderItemDelete.Size = new System.Drawing.Size(78, 59);
            this.btn_NewOrderItemDelete.TabIndex = 15;
            this.btn_NewOrderItemDelete.Text = "Delete";
            this.btn_NewOrderItemDelete.UseVisualStyleBackColor = true;
            this.btn_NewOrderItemDelete.Click += new System.EventHandler(this.btn_NewOrderItemDelete_Click);
            // 
            // btn_NewOrderBack
            // 
            this.btn_NewOrderBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewOrderBack.Location = new System.Drawing.Point(33, 622);
            this.btn_NewOrderBack.Name = "btn_NewOrderBack";
            this.btn_NewOrderBack.Size = new System.Drawing.Size(84, 59);
            this.btn_NewOrderBack.TabIndex = 16;
            this.btn_NewOrderBack.Text = "Back";
            this.btn_NewOrderBack.UseVisualStyleBackColor = true;
            this.btn_NewOrderBack.Click += new System.EventHandler(this.btn_NewOrderBack_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btn_ConfirmOrder
            // 
            this.btn_ConfirmOrder.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_ConfirmOrder.Location = new System.Drawing.Point(833, 622);
            this.btn_ConfirmOrder.Name = "btn_ConfirmOrder";
            this.btn_ConfirmOrder.Size = new System.Drawing.Size(157, 60);
            this.btn_ConfirmOrder.TabIndex = 17;
            this.btn_ConfirmOrder.Text = "Confirm order";
            this.btn_ConfirmOrder.UseVisualStyleBackColor = false;
            this.btn_ConfirmOrder.Click += new System.EventHandler(this.btn_ConfirmOrder_Click);
            // 
            // btn_CommentOrder
            // 
            this.btn_CommentOrder.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_CommentOrder.Location = new System.Drawing.Point(343, 621);
            this.btn_CommentOrder.Name = "btn_CommentOrder";
            this.btn_CommentOrder.Size = new System.Drawing.Size(87, 60);
            this.btn_CommentOrder.TabIndex = 19;
            this.btn_CommentOrder.Text = "Add Comment";
            this.btn_CommentOrder.UseVisualStyleBackColor = true;
            this.btn_CommentOrder.Click += new System.EventHandler(this.btn_CommentOrder_Click);
            // 
            // lbl_Comment
            // 
            this.lbl_Comment.AutoSize = true;
            this.lbl_Comment.Location = new System.Drawing.Point(440, 457);
            this.lbl_Comment.Name = "lbl_Comment";
            this.lbl_Comment.Size = new System.Drawing.Size(139, 23);
            this.lbl_Comment.TabIndex = 20;
            this.lbl_Comment.Text = "Type comment";
            // 
            // rtxt_CommentOrder
            // 
            this.rtxt_CommentOrder.BackColor = System.Drawing.SystemColors.Info;
            this.rtxt_CommentOrder.Location = new System.Drawing.Point(445, 502);
            this.rtxt_CommentOrder.Name = "rtxt_CommentOrder";
            this.rtxt_CommentOrder.Size = new System.Drawing.Size(361, 98);
            this.rtxt_CommentOrder.TabIndex = 21;
            this.rtxt_CommentOrder.Text = "";
            this.rtxt_CommentOrder.TextChanged += new System.EventHandler(this.rtxt_CommentOrder_TextChanged);
            // 
            // btn_ConfirmComment
            // 
            this.btn_ConfirmComment.Location = new System.Drawing.Point(470, 622);
            this.btn_ConfirmComment.Name = "btn_ConfirmComment";
            this.btn_ConfirmComment.Size = new System.Drawing.Size(184, 59);
            this.btn_ConfirmComment.TabIndex = 22;
            this.btn_ConfirmComment.Text = "Confirm Comment";
            this.btn_ConfirmComment.UseVisualStyleBackColor = true;
            this.btn_ConfirmComment.Click += new System.EventHandler(this.btn_ConfirmComment_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.btn_ConfirmComment);
            this.Controls.Add(this.rtxt_CommentOrder);
            this.Controls.Add(this.lbl_Comment);
            this.Controls.Add(this.btn_CommentOrder);
            this.Controls.Add(this.flpnl_SubCatagories);
            this.Controls.Add(this.btn_ConfirmOrder);
            this.Controls.Add(this.btn_NewOrderBack);
            this.Controls.Add(this.btn_NewOrderItemDelete);
            this.Controls.Add(this.btn_NewOrderClearItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_NewOrderItems);
            this.Controls.Add(this.flpnl_SubCatagoryItems);
            this.Controls.Add(this.flpnl_MainCatagories);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.flpnl_MainCatagories, 0);
            this.Controls.SetChildIndex(this.flpnl_SubCatagoryItems, 0);
            this.Controls.SetChildIndex(this.lst_NewOrderItems, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_NewOrderClearItems, 0);
            this.Controls.SetChildIndex(this.btn_NewOrderItemDelete, 0);
            this.Controls.SetChildIndex(this.btn_NewOrderBack, 0);
            this.Controls.SetChildIndex(this.btn_ConfirmOrder, 0);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.flpnl_SubCatagories, 0);
            this.Controls.SetChildIndex(this.btn_CommentOrder, 0);
            this.Controls.SetChildIndex(this.lbl_Comment, 0);
            this.Controls.SetChildIndex(this.rtxt_CommentOrder, 0);
            this.Controls.SetChildIndex(this.btn_ConfirmComment, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpnl_MainCatagories;
        private System.Windows.Forms.FlowLayoutPanel flpnl_SubCatagories;
        private System.Windows.Forms.FlowLayoutPanel flpnl_SubCatagoryItems;
        private System.Windows.Forms.ListView lst_NewOrderItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_NewOrderClearItems;
        private System.Windows.Forms.Button btn_NewOrderItemDelete;
        private System.Windows.Forms.Button btn_NewOrderBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_ConfirmOrder;
        private BaseButton btn_CommentOrder;
        private System.Windows.Forms.Label lbl_Comment;
        private System.Windows.Forms.RichTextBox rtxt_CommentOrder;
        private System.Windows.Forms.Button btn_ConfirmComment;
    }
}