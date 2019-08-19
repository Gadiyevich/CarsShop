namespace CarsShop
{
    partial class CarsShop
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
            this.CarsShopLabel = new System.Windows.Forms.Label();
            this.CarsListLabel = new System.Windows.Forms.Label();
            this.carsListbox = new System.Windows.Forms.ListBox();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseItem = new System.Windows.Forms.Button();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorsListbox = new System.Windows.Forms.ListBox();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.storeProfitlabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.deleteFromShopCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarsShopLabel
            // 
            this.CarsShopLabel.AutoSize = true;
            this.CarsShopLabel.BackColor = System.Drawing.Color.Aqua;
            this.CarsShopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsShopLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CarsShopLabel.Location = new System.Drawing.Point(438, 22);
            this.CarsShopLabel.Name = "CarsShopLabel";
            this.CarsShopLabel.Size = new System.Drawing.Size(310, 67);
            this.CarsShopLabel.TabIndex = 0;
            this.CarsShopLabel.Text = "Cars Shop";
            // 
            // CarsListLabel
            // 
            this.CarsListLabel.AutoSize = true;
            this.CarsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsListLabel.Location = new System.Drawing.Point(41, 146);
            this.CarsListLabel.Name = "CarsListLabel";
            this.CarsListLabel.Size = new System.Drawing.Size(98, 25);
            this.CarsListLabel.TabIndex = 1;
            this.CarsListLabel.Text = "Cars List";
            // 
            // carsListbox
            // 
            this.carsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsListbox.FormattingEnabled = true;
            this.carsListbox.ItemHeight = 25;
            this.carsListbox.Location = new System.Drawing.Point(46, 186);
            this.carsListbox.Name = "carsListbox";
            this.carsListbox.Size = new System.Drawing.Size(396, 204);
            this.carsListbox.TabIndex = 2;
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 25;
            this.shoppingCartListbox.Location = new System.Drawing.Point(769, 186);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(415, 204);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(764, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shopping Cart";
            // 
            // purchaseItem
            // 
            this.purchaseItem.BackColor = System.Drawing.Color.OrangeRed;
            this.purchaseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseItem.Location = new System.Drawing.Point(495, 247);
            this.purchaseItem.Name = "purchaseItem";
            this.purchaseItem.Size = new System.Drawing.Size(222, 68);
            this.purchaseItem.TabIndex = 5;
            this.purchaseItem.Text = "Add To Card ->";
            this.purchaseItem.UseVisualStyleBackColor = false;
            this.purchaseItem.Click += new System.EventHandler(this.PurchaseItem_Click);
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxLabel.Location = new System.Drawing.Point(41, 446);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(93, 25);
            this.vendorListboxLabel.TabIndex = 10;
            this.vendorListboxLabel.Text = "Vendors";
            // 
            // vendorsListbox
            // 
            this.vendorsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorsListbox.FormattingEnabled = true;
            this.vendorsListbox.ItemHeight = 25;
            this.vendorsListbox.Location = new System.Drawing.Point(46, 483);
            this.vendorsListbox.Name = "vendorsListbox";
            this.vendorsListbox.Size = new System.Drawing.Size(351, 204);
            this.vendorsListbox.TabIndex = 9;
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(723, 483);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(66, 25);
            this.storeProfitValue.TabIndex = 12;
            this.storeProfitValue.Text = "$0.00";
            // 
            // storeProfitlabel
            // 
            this.storeProfitlabel.AutoSize = true;
            this.storeProfitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitlabel.Location = new System.Drawing.Point(569, 483);
            this.storeProfitlabel.Name = "storeProfitlabel";
            this.storeProfitlabel.Size = new System.Drawing.Size(127, 25);
            this.storeProfitlabel.TabIndex = 11;
            this.storeProfitlabel.Text = "Store Profit:";
            // 
            // makePurchase
            // 
            this.makePurchase.BackColor = System.Drawing.Color.DodgerBlue;
            this.makePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePurchase.ForeColor = System.Drawing.Color.Black;
            this.makePurchase.Location = new System.Drawing.Point(1019, 406);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(165, 54);
            this.makePurchase.TabIndex = 13;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = false;
            this.makePurchase.Click += new System.EventHandler(this.MakePurchase_Click);
            // 
            // deleteFromShopCart
            // 
            this.deleteFromShopCart.BackColor = System.Drawing.Color.DimGray;
            this.deleteFromShopCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFromShopCart.ForeColor = System.Drawing.Color.Black;
            this.deleteFromShopCart.Location = new System.Drawing.Point(838, 406);
            this.deleteFromShopCart.Name = "deleteFromShopCart";
            this.deleteFromShopCart.Size = new System.Drawing.Size(165, 54);
            this.deleteFromShopCart.TabIndex = 14;
            this.deleteFromShopCart.Text = "Delete";
            this.deleteFromShopCart.UseVisualStyleBackColor = false;
            this.deleteFromShopCart.Click += new System.EventHandler(this.DeleteFromShopCart_Click);
            // 
            // CarsShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1224, 713);
            this.Controls.Add(this.deleteFromShopCart);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitlabel);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.vendorsListbox);
            this.Controls.Add(this.purchaseItem);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carsListbox);
            this.Controls.Add(this.CarsListLabel);
            this.Controls.Add(this.CarsShopLabel);
            this.Name = "CarsShop";
            this.Text = "Cars Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarsShopLabel;
        private System.Windows.Forms.Label CarsListLabel;
        private System.Windows.Forms.ListBox carsListbox;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button purchaseItem;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorsListbox;
        private System.Windows.Forms.Label storeProfitValue;
        private System.Windows.Forms.Label storeProfitlabel;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Button deleteFromShopCart;
    }
}

