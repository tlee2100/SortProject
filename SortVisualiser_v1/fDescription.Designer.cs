﻿namespace SortVisualiser_v1
{
    partial class fDescription
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDescription = new System.Windows.Forms.TabPage();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tpAlgorithm = new System.Windows.Forms.TabPage();
            this.rtbAlgorithm = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tpDescription.SuspendLayout();
            this.tpAlgorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDescription);
            this.tabControl1.Controls.Add(this.tpAlgorithm);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tpDescription
            // 
            this.tpDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tpDescription.Controls.Add(this.tbDescription);
            this.tpDescription.Location = new System.Drawing.Point(4, 28);
            this.tpDescription.Name = "tpDescription";
            this.tpDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tpDescription.Size = new System.Drawing.Size(573, 299);
            this.tpDescription.TabIndex = 0;
            this.tpDescription.Text = "Mô tả";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.tbDescription.Location = new System.Drawing.Point(0, 0);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(576, 303);
            this.tbDescription.TabIndex = 0;
            // 
            // tpAlgorithm
            // 
            this.tpAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.tpAlgorithm.Controls.Add(this.rtbAlgorithm);
            this.tpAlgorithm.Location = new System.Drawing.Point(4, 28);
            this.tpAlgorithm.Name = "tpAlgorithm";
            this.tpAlgorithm.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlgorithm.Size = new System.Drawing.Size(573, 299);
            this.tpAlgorithm.TabIndex = 1;
            this.tpAlgorithm.Text = "Giải thuật";
            // 
            // rtbAlgorithm
            // 
            this.rtbAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.rtbAlgorithm.Location = new System.Drawing.Point(0, 0);
            this.rtbAlgorithm.Name = "rtbAlgorithm";
            this.rtbAlgorithm.ReadOnly = true;
            this.rtbAlgorithm.Size = new System.Drawing.Size(573, 296);
            this.rtbAlgorithm.TabIndex = 0;
            this.rtbAlgorithm.Text = "";
            // 
            // fDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(582, 331);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDescription";
            this.Text = "fDescription";
            this.tabControl1.ResumeLayout(false);
            this.tpDescription.ResumeLayout(false);
            this.tpDescription.PerformLayout();
            this.tpAlgorithm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDescription;
        private System.Windows.Forms.TabPage tpAlgorithm;
        private System.Windows.Forms.TextBox tbDescription;
        public System.Windows.Forms.RichTextBox rtbAlgorithm;
    }
}