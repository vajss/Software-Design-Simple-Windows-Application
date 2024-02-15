using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    partial class frmServer
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
            this.btnToggle = new ToggleButton();
            this.SuspendLayout();
            // 
            // btnToggle
            // 
            this.btnToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.White;
            this.btnToggle.Location = new System.Drawing.Point(350, 250);
            this.btnToggle.rdus = 40;
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(80, 40);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.Text = "O";
            this.btnToggle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToggle);
            this.Name = "frmServer";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

