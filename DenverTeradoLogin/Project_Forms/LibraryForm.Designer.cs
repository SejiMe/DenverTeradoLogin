﻿namespace DenverTeradoLogin.Project_Forms
{
    partial class LibraryForm
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
            this.Btn_Mainform = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.Lbl_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Mainform
            // 
            this.Btn_Mainform.Location = new System.Drawing.Point(713, 29);
            this.Btn_Mainform.Name = "Btn_Mainform";
            this.Btn_Mainform.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mainform.TabIndex = 0;
            this.Btn_Mainform.Text = "Go Back";
            this.Btn_Mainform.UseVisualStyleBackColor = true;
            this.Btn_Mainform.Click += new System.EventHandler(this.Btn_Mainform_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(40, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 24);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Hello";
            // 
            // Lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_username.Location = new System.Drawing.Point(100, 29);
            this.Lbl_username.Name = "Lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(65, 24);
            this.Lbl_username.TabIndex = 2;
            this.Lbl_username.Text = "Hello!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Library Form";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_username);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Btn_Mainform);
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Mainform;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label Lbl_username;
        private System.Windows.Forms.Label label1;
    }
}