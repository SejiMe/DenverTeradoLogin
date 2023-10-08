namespace DenverTeradoLogin
{
    partial class MainForm
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
            this.Lbl_fullname = new System.Windows.Forms.Label();
            this.Lbl_user = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_signout = new System.Windows.Forms.Button();
            this.Btn_UM = new System.Windows.Forms.Button();
            this.Btn_DBoard = new System.Windows.Forms.Button();
            this.Btn_Library = new System.Windows.Forms.Button();
            this.Btn_MO = new System.Windows.Forms.Button();
            this.Lbl_Canview = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_fullname
            // 
            this.Lbl_fullname.AutoSize = true;
            this.Lbl_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fullname.Location = new System.Drawing.Point(24, 55);
            this.Lbl_fullname.Name = "Lbl_fullname";
            this.Lbl_fullname.Size = new System.Drawing.Size(234, 20);
            this.Lbl_fullname.TabIndex = 0;
            this.Lbl_fullname.Text = "firstname middlename lastname";
            // 
            // Lbl_user
            // 
            this.Lbl_user.AutoSize = true;
            this.Lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_user.Location = new System.Drawing.Point(23, 19);
            this.Lbl_user.Name = "Lbl_user";
            this.Lbl_user.Size = new System.Drawing.Size(178, 25);
            this.Lbl_user.TabIndex = 1;
            this.Lbl_user.Text = "Welcome: User!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_user);
            this.panel1.Controls.Add(this.Lbl_fullname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_signout);
            this.panel2.Controls.Add(this.Btn_UM);
            this.panel2.Controls.Add(this.Btn_DBoard);
            this.panel2.Controls.Add(this.Btn_Library);
            this.panel2.Controls.Add(this.Btn_MO);
            this.panel2.Controls.Add(this.Lbl_Canview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 376);
            this.panel2.TabIndex = 3;
            // 
            // Btn_signout
            // 
            this.Btn_signout.Location = new System.Drawing.Point(747, 338);
            this.Btn_signout.Name = "Btn_signout";
            this.Btn_signout.Size = new System.Drawing.Size(75, 23);
            this.Btn_signout.TabIndex = 5;
            this.Btn_signout.Text = "Sign Out";
            this.Btn_signout.UseVisualStyleBackColor = true;
            this.Btn_signout.Click += new System.EventHandler(this.Btn_signout_Click);
            // 
            // Btn_UM
            // 
            this.Btn_UM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UM.Location = new System.Drawing.Point(324, 261);
            this.Btn_UM.Name = "Btn_UM";
            this.Btn_UM.Size = new System.Drawing.Size(179, 47);
            this.Btn_UM.TabIndex = 4;
            this.Btn_UM.Text = "User Management";
            this.Btn_UM.UseVisualStyleBackColor = true;
            this.Btn_UM.Click += new System.EventHandler(this.Btn_UM_Click);
            // 
            // Btn_DBoard
            // 
            this.Btn_DBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DBoard.Location = new System.Drawing.Point(362, 197);
            this.Btn_DBoard.Name = "Btn_DBoard";
            this.Btn_DBoard.Size = new System.Drawing.Size(109, 47);
            this.Btn_DBoard.TabIndex = 3;
            this.Btn_DBoard.Text = "Dashboard";
            this.Btn_DBoard.UseVisualStyleBackColor = true;
            this.Btn_DBoard.Click += new System.EventHandler(this.Btn_DBoard_Click);
            // 
            // Btn_Library
            // 
            this.Btn_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Library.Location = new System.Drawing.Point(363, 130);
            this.Btn_Library.Name = "Btn_Library";
            this.Btn_Library.Size = new System.Drawing.Size(103, 47);
            this.Btn_Library.TabIndex = 2;
            this.Btn_Library.Text = "Library";
            this.Btn_Library.UseVisualStyleBackColor = true;
            this.Btn_Library.Click += new System.EventHandler(this.Btn_Library_Click);
            // 
            // Btn_MO
            // 
            this.Btn_MO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MO.Location = new System.Drawing.Point(349, 68);
            this.Btn_MO.Name = "Btn_MO";
            this.Btn_MO.Size = new System.Drawing.Size(138, 47);
            this.Btn_MO.TabIndex = 1;
            this.Btn_MO.Text = "Make Order";
            this.Btn_MO.UseVisualStyleBackColor = true;
            this.Btn_MO.Click += new System.EventHandler(this.Btn_MO_Click);
            // 
            // Lbl_Canview
            // 
            this.Lbl_Canview.AutoSize = true;
            this.Lbl_Canview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Canview.Location = new System.Drawing.Point(345, 32);
            this.Lbl_Canview.Name = "Lbl_Canview";
            this.Lbl_Canview.Size = new System.Drawing.Size(147, 20);
            this.Lbl_Canview.TabIndex = 0;
            this.Lbl_Canview.Text = "Forms you can view";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_fullname;
        private System.Windows.Forms.Label Lbl_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_Canview;
        private System.Windows.Forms.Button Btn_Library;
        private System.Windows.Forms.Button Btn_MO;
        private System.Windows.Forms.Button Btn_UM;
        private System.Windows.Forms.Button Btn_DBoard;
        private System.Windows.Forms.Button Btn_signout;
    }
}