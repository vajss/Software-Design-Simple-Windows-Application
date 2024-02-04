namespace Base_form
{
    partial class FrmAddProduct
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
            this.lblMeasurementUnit = new System.Windows.Forms.Label();
            this.cbMeasurementUnit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMeasurementUnit
            // 
            this.lblMeasurementUnit.AutoSize = true;
            this.lblMeasurementUnit.Location = new System.Drawing.Point(58, 47);
            this.lblMeasurementUnit.Name = "lblMeasurementUnit";
            this.lblMeasurementUnit.Size = new System.Drawing.Size(94, 13);
            this.lblMeasurementUnit.TabIndex = 0;
            this.lblMeasurementUnit.Text = "Measurement unit:";
            // 
            // cbMeasurementUnit
            // 
            this.cbMeasurementUnit.FormattingEnabled = true;
            this.cbMeasurementUnit.Location = new System.Drawing.Point(158, 43);
            this.cbMeasurementUnit.Name = "cbMeasurementUnit";
            this.cbMeasurementUnit.Size = new System.Drawing.Size(121, 21);
            this.cbMeasurementUnit.TabIndex = 1;
            this.cbMeasurementUnit.SelectedIndexChanged += new System.EventHandler(this.cbMeasurementUnit_SelectedIndexChanged);
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMeasurementUnit);
            this.Controls.Add(this.lblMeasurementUnit);
            this.Name = "FrmAddProduct";
            this.Text = "Add product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeasurementUnit;
        private System.Windows.Forms.ComboBox cbMeasurementUnit;
    }
}