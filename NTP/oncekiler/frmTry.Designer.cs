﻿namespace NTP
{
    partial class frmTry
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btTopla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "2. sayı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "1. sayı";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(194, 69);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 22);
            this.tb2.TabIndex = 7;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(63, 69);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 22);
            this.tb1.TabIndex = 6;
            // 
            // btTopla
            // 
            this.btTopla.Location = new System.Drawing.Point(124, 113);
            this.btTopla.Name = "btTopla";
            this.btTopla.Size = new System.Drawing.Size(101, 40);
            this.btTopla.TabIndex = 5;
            this.btTopla.Text = "Topla";
            this.btTopla.UseVisualStyleBackColor = true;
            this.btTopla.Click += new System.EventHandler(this.btTopla_Click);
            // 
            // frmTry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 208);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btTopla);
            this.Name = "frmTry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btTopla;
    }
}