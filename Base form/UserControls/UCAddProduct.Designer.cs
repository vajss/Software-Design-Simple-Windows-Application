﻿namespace Base_form.UserControls
{
    partial class UCAddProduct
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbManufacturer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMeasurementUnit = new System.Windows.Forms.ComboBox();
            this.lblMeasurementUnit = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(205, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrice.Location = new System.Drawing.Point(205, 169);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(121, 20);
            this.tbPrice.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Price:";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.Location = new System.Drawing.Point(205, 84);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Name:";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescription.Location = new System.Drawing.Point(205, 123);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(121, 20);
            this.tbDescription.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Description";
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.Location = new System.Drawing.Point(205, 263);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(121, 21);
            this.cbManufacturer.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Manufacturer:";
            // 
            // cbMeasurementUnit
            // 
            this.cbMeasurementUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMeasurementUnit.FormattingEnabled = true;
            this.cbMeasurementUnit.Location = new System.Drawing.Point(205, 212);
            this.cbMeasurementUnit.Name = "cbMeasurementUnit";
            this.cbMeasurementUnit.Size = new System.Drawing.Size(121, 21);
            this.cbMeasurementUnit.TabIndex = 27;
            // 
            // lblMeasurementUnit
            // 
            this.lblMeasurementUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMeasurementUnit.AutoSize = true;
            this.lblMeasurementUnit.Location = new System.Drawing.Point(105, 216);
            this.lblMeasurementUnit.Name = "lblMeasurementUnit";
            this.lblMeasurementUnit.Size = new System.Drawing.Size(94, 13);
            this.lblMeasurementUnit.TabIndex = 26;
            this.lblMeasurementUnit.Text = "Measurement unit:";
            // 
            // lblRequired
            // 
            this.lblRequired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRequired.AutoSize = true;
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblRequired.Location = new System.Drawing.Point(193, 301);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(104, 13);
            this.lblRequired.TabIndex = 39;
            this.lblRequired.Text = "All fields are required";
            this.lblRequired.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRequired.Visible = false;
            // 
            // UCAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbManufacturer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMeasurementUnit);
            this.Controls.Add(this.lblMeasurementUnit);
            this.Name = "UCAddProduct";
            this.Size = new System.Drawing.Size(457, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMeasurementUnit;
        private System.Windows.Forms.Label lblMeasurementUnit;
        private System.Windows.Forms.Label lblRequired;
    }
}
