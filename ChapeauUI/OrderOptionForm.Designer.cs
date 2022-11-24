namespace ChapeauUI
{
    partial class OrderOptionForm
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
            this.lst_CurrentOrder = new System.Windows.Forms.ListView();
            this.Btn_NewOrder = new System.Windows.Forms.Button();
            this.Btn_Payment = new System.Windows.Forms.Button();
            this.lbl_OrderView = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_CurrentPrice = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_TableNr = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_EditQuantity = new System.Windows.Forms.TextBox();
            this.lbl_menuSelected = new System.Windows.Forms.Label();
            this.txt_menuItemName = new System.Windows.Forms.TextBox();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_CurrentOrder
            // 
            this.lst_CurrentOrder.Location = new System.Drawing.Point(47, 76);
            this.lst_CurrentOrder.Name = "lst_CurrentOrder";
            this.lst_CurrentOrder.Size = new System.Drawing.Size(495, 482);
            this.lst_CurrentOrder.TabIndex = 10;
            this.lst_CurrentOrder.UseCompatibleStateImageBehavior = false;
            this.lst_CurrentOrder.SelectedIndexChanged += new System.EventHandler(this.lstview_CurrentOrder_SelectedIndexChanged);
            this.lst_CurrentOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lst_CurrentOrder_MouseClick);
            // 
            // Btn_NewOrder
            // 
            this.Btn_NewOrder.Location = new System.Drawing.Point(577, 115);
            this.Btn_NewOrder.Name = "Btn_NewOrder";
            this.Btn_NewOrder.Size = new System.Drawing.Size(174, 85);
            this.Btn_NewOrder.TabIndex = 11;
            this.Btn_NewOrder.Text = "New Order";
            this.Btn_NewOrder.UseVisualStyleBackColor = true;
            this.Btn_NewOrder.Click += new System.EventHandler(this.Btn_NewOrder_Click);
            // 
            // Btn_Payment
            // 
            this.Btn_Payment.Location = new System.Drawing.Point(788, 115);
            this.Btn_Payment.Name = "Btn_Payment";
            this.Btn_Payment.Size = new System.Drawing.Size(174, 85);
            this.Btn_Payment.TabIndex = 12;
            this.Btn_Payment.Text = "Payment";
            this.Btn_Payment.UseVisualStyleBackColor = true;
            this.Btn_Payment.Click += new System.EventHandler(this.Btn_Payment_Click);
            // 
            // lbl_OrderView
            // 
            this.lbl_OrderView.AutoSize = true;
            this.lbl_OrderView.Location = new System.Drawing.Point(43, 37);
            this.lbl_OrderView.Name = "lbl_OrderView";
            this.lbl_OrderView.Size = new System.Drawing.Size(254, 23);
            this.lbl_OrderView.TabIndex = 13;
            this.lbl_OrderView.Text = "The Current Order of Table:";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(577, 440);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(174, 85);
            this.btn_remove.TabIndex = 14;
            this.btn_remove.Text = "Change Quantity";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_CurrentPrice
            // 
            this.lbl_CurrentPrice.AutoSize = true;
            this.lbl_CurrentPrice.Location = new System.Drawing.Point(43, 594);
            this.lbl_CurrentPrice.Name = "lbl_CurrentPrice";
            this.lbl_CurrentPrice.Size = new System.Drawing.Size(180, 23);
            this.lbl_CurrentPrice.TabIndex = 15;
            this.lbl_CurrentPrice.Text = "Current Total Price:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(340, 594);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(28, 23);
            this.lbl_price.TabIndex = 16;
            this.lbl_price.Text = "...";
            // 
            // lbl_TableNr
            // 
            this.lbl_TableNr.AutoSize = true;
            this.lbl_TableNr.Location = new System.Drawing.Point(324, 37);
            this.lbl_TableNr.Name = "lbl_TableNr";
            this.lbl_TableNr.Size = new System.Drawing.Size(28, 23);
            this.lbl_TableNr.TabIndex = 17;
            this.lbl_TableNr.Text = "...";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(47, 648);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(127, 61);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(582, 393);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(83, 23);
            this.lbl_quantity.TabIndex = 19;
            this.lbl_quantity.Text = "Quantity";
            // 
            // txt_EditQuantity
            // 
            this.txt_EditQuantity.Location = new System.Drawing.Point(788, 393);
            this.txt_EditQuantity.Name = "txt_EditQuantity";
            this.txt_EditQuantity.Size = new System.Drawing.Size(174, 30);
            this.txt_EditQuantity.TabIndex = 20;
            // 
            // lbl_menuSelected
            // 
            this.lbl_menuSelected.AutoSize = true;
            this.lbl_menuSelected.Location = new System.Drawing.Point(582, 325);
            this.lbl_menuSelected.Name = "lbl_menuSelected";
            this.lbl_menuSelected.Size = new System.Drawing.Size(180, 23);
            this.lbl_menuSelected.TabIndex = 21;
            this.lbl_menuSelected.Text = "MenuItem Selected";
            // 
            // txt_menuItemName
            // 
            this.txt_menuItemName.Location = new System.Drawing.Point(788, 318);
            this.txt_menuItemName.Name = "txt_menuItemName";
            this.txt_menuItemName.Size = new System.Drawing.Size(174, 30);
            this.txt_menuItemName.TabIndex = 22;
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Location = new System.Drawing.Point(261, 594);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(21, 23);
            this.lbl_euro.TabIndex = 23;
            this.lbl_euro.Text = "€";
            // 
            // OrderOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.lbl_euro);
            this.Controls.Add(this.txt_menuItemName);
            this.Controls.Add(this.lbl_menuSelected);
            this.Controls.Add(this.txt_EditQuantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_TableNr);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_CurrentPrice);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_OrderView);
            this.Controls.Add(this.Btn_Payment);
            this.Controls.Add(this.Btn_NewOrder);
            this.Controls.Add(this.lst_CurrentOrder);
            this.Name = "OrderOptionForm";
            this.Text = "OrderOptionForm";
            this.Load += new System.EventHandler(this.OrderOptionForm_Load);
            this.Controls.SetChildIndex(this.lst_CurrentOrder, 0);
            this.Controls.SetChildIndex(this.Btn_NewOrder, 0);
            this.Controls.SetChildIndex(this.Btn_Payment, 0);
            this.Controls.SetChildIndex(this.lbl_OrderView, 0);
            this.Controls.SetChildIndex(this.btn_remove, 0);
            this.Controls.SetChildIndex(this.lbl_CurrentPrice, 0);
            this.Controls.SetChildIndex(this.lbl_price, 0);
            this.Controls.SetChildIndex(this.lbl_TableNr, 0);
            this.Controls.SetChildIndex(this.Btn_LogOut, 0);
            this.Controls.SetChildIndex(this.btn_back, 0);
            this.Controls.SetChildIndex(this.lbl_quantity, 0);
            this.Controls.SetChildIndex(this.txt_EditQuantity, 0);
            this.Controls.SetChildIndex(this.lbl_menuSelected, 0);
            this.Controls.SetChildIndex(this.txt_menuItemName, 0);
            this.Controls.SetChildIndex(this.lbl_euro, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_CurrentOrder;
        private System.Windows.Forms.Button Btn_NewOrder;
        private System.Windows.Forms.Button Btn_Payment;
        private System.Windows.Forms.Label lbl_OrderView;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_CurrentPrice;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_TableNr;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_EditQuantity;
        private System.Windows.Forms.Label lbl_menuSelected;
        private System.Windows.Forms.TextBox txt_menuItemName;
        private System.Windows.Forms.Label lbl_euro;
    }
}