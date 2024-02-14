namespace Base_form.UserControls
{
    partial class UCInvoice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInvalidNumber = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.lblInvalidItem = new System.Windows.Forms.Label();
            this.lblGeneralError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(62, 13);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(114, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(62, 46);
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(114, 20);
            this.tbUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User:";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(62, 78);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(114, 20);
            this.tbDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(62, 113);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(114, 20);
            this.tbTotal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.tbDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbUser);
            this.panel1.Location = new System.Drawing.Point(48, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 150);
            this.panel1.TabIndex = 8;
            this.panel1.Tag = "Stahp";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.lblInvalidNumber);
            this.panel2.Controls.Add(this.cbProduct);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbQuantity);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbAmount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(275, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 150);
            this.panel2.TabIndex = 9;
            // 
            // lblInvalidNumber
            // 
            this.lblInvalidNumber.AutoSize = true;
            this.lblInvalidNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInvalidNumber.ForeColor = System.Drawing.Color.Coral;
            this.lblInvalidNumber.Location = new System.Drawing.Point(192, 47);
            this.lblInvalidNumber.Name = "lblInvalidNumber";
            this.lblInvalidNumber.Size = new System.Drawing.Size(76, 13);
            this.lblInvalidNumber.TabIndex = 15;
            this.lblInvalidNumber.Text = "Invalid number";
            this.lblInvalidNumber.Visible = false;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(68, 9);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(121, 21);
            this.cbProduct.TabIndex = 14;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(68, 43);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(121, 20);
            this.tbQuantity.TabIndex = 11;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(68, 75);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.ReadOnly = true;
            this.tbAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAmount.Size = new System.Drawing.Size(121, 20);
            this.tbAmount.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity:";
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(48, 237);
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.Size = new System.Drawing.Size(561, 172);
            this.dgvInvoiceItems.TabIndex = 10;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddItem.Location = new System.Drawing.Point(275, 184);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(84, 33);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveInvoice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveInvoice.Location = new System.Drawing.Point(48, 421);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(84, 33);
            this.btnSaveInvoice.TabIndex = 12;
            this.btnSaveInvoice.Text = "Save all";
            this.btnSaveInvoice.UseVisualStyleBackColor = false;
            this.btnSaveInvoice.Click += new System.EventHandler(this.BtnSaveInvoice_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteItem.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteItem.Location = new System.Drawing.Point(367, 184);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(84, 33);
            this.btnDeleteItem.TabIndex = 13;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // lblInvalidItem
            // 
            this.lblInvalidItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvalidItem.AutoSize = true;
            this.lblInvalidItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInvalidItem.ForeColor = System.Drawing.Color.Coral;
            this.lblInvalidItem.Location = new System.Drawing.Point(272, 220);
            this.lblInvalidItem.Name = "lblInvalidItem";
            this.lblInvalidItem.Size = new System.Drawing.Size(60, 13);
            this.lblInvalidItem.TabIndex = 16;
            this.lblInvalidItem.Text = "Invalid item";
            this.lblInvalidItem.Visible = false;
            // 
            // lblGeneralError
            // 
            this.lblGeneralError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGeneralError.AutoSize = true;
            this.lblGeneralError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGeneralError.ForeColor = System.Drawing.Color.Coral;
            this.lblGeneralError.Location = new System.Drawing.Point(138, 431);
            this.lblGeneralError.Name = "lblGeneralError";
            this.lblGeneralError.Size = new System.Drawing.Size(75, 13);
            this.lblGeneralError.TabIndex = 17;
            this.lblGeneralError.Text = "Invalid invoice";
            this.lblGeneralError.Visible = false;
            // 
            // UCInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGeneralError);
            this.Controls.Add(this.lblInvalidItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dgvInvoiceItems);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCInvoice";
            this.Size = new System.Drawing.Size(650, 467);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label lblInvalidNumber;
        private System.Windows.Forms.Label lblInvalidItem;
        private System.Windows.Forms.Label lblGeneralError;
    }
}
