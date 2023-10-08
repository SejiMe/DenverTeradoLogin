namespace DenverTeradoLogin
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_First = new System.Windows.Forms.TextBox();
            this.Txt_Lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Middle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Password1 = new System.Windows.Forms.TextBox();
            this.Cb_ShowPassword = new System.Windows.Forms.CheckBox();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.denverDBDataSet = new DenverTeradoLogin.DenverDBDataSet();
            this.appUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appUsersTableAdapter = new DenverTeradoLogin.DenverDBDataSetTableAdapters.appUsersTableAdapter();
            this.tableAdapterManager = new DenverTeradoLogin.DenverDBDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Contact = new System.Windows.Forms.TextBox();
            this.Lbl_Contact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.denverDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUsersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // Txt_First
            // 
            this.Txt_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_First.Location = new System.Drawing.Point(69, 111);
            this.Txt_First.MinimumSize = new System.Drawing.Size(4, 35);
            this.Txt_First.Name = "Txt_First";
            this.Txt_First.Size = new System.Drawing.Size(180, 29);
            this.Txt_First.TabIndex = 0;
            // 
            // Txt_Lastname
            // 
            this.Txt_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Lastname.Location = new System.Drawing.Point(69, 241);
            this.Txt_Lastname.MinimumSize = new System.Drawing.Size(4, 35);
            this.Txt_Lastname.Name = "Txt_Lastname";
            this.Txt_Lastname.Size = new System.Drawing.Size(180, 29);
            this.Txt_Lastname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.Location = new System.Drawing.Point(478, 111);
            this.Txt_Email.MinimumSize = new System.Drawing.Size(4, 35);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(180, 29);
            this.Txt_Email.TabIndex = 5;
            this.Txt_Email.TextChanged += new System.EventHandler(this.Txt_Email_TextChanged);
            this.Txt_Email.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Email_Validating);
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.Location = new System.Drawing.Point(474, 84);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(62, 24);
            this.Lbl_Email.TabIndex = 4;
            this.Lbl_Email.Text = "Email:";
            // 
            // Txt_Middle
            // 
            this.Txt_Middle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Middle.Location = new System.Drawing.Point(69, 176);
            this.Txt_Middle.MinimumSize = new System.Drawing.Size(4, 35);
            this.Txt_Middle.Name = "Txt_Middle";
            this.Txt_Middle.Size = new System.Drawing.Size(180, 29);
            this.Txt_Middle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Middle Name:";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(279, 176);
            this.Txt_Password.MinimumSize = new System.Drawing.Size(4, 35);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(180, 29);
            this.Txt_Password.TabIndex = 8;
            this.Txt_Password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Confirm Password:";
            // 
            // Txt_Password1
            // 
            this.Txt_Password1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password1.Location = new System.Drawing.Point(1, 1);
            this.Txt_Password1.MinimumSize = new System.Drawing.Size(4, 35);
            this.Txt_Password1.Name = "Txt_Password1";
            this.Txt_Password1.Size = new System.Drawing.Size(178, 29);
            this.Txt_Password1.TabIndex = 10;
            this.Txt_Password1.UseSystemPasswordChar = true;
            this.Txt_Password1.TextChanged += new System.EventHandler(this.Txt_Password1_TextChanged);
            this.Txt_Password1.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Password1_Validating);
            // 
            // Cb_ShowPassword
            // 
            this.Cb_ShowPassword.AutoSize = true;
            this.Cb_ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cb_ShowPassword.Location = new System.Drawing.Point(478, 253);
            this.Cb_ShowPassword.Name = "Cb_ShowPassword";
            this.Cb_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.Cb_ShowPassword.TabIndex = 12;
            this.Cb_ShowPassword.Text = "Show Password";
            this.Cb_ShowPassword.UseVisualStyleBackColor = true;
            this.Cb_ShowPassword.CheckedChanged += new System.EventHandler(this.Cb_ShowPassword_CheckedChanged);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register.Location = new System.Drawing.Point(536, 283);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(122, 35);
            this.Btn_Register.TabIndex = 13;
            this.Btn_Register.Text = "Submit";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Txt_Username
            // 
            this.Txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Username.Location = new System.Drawing.Point(279, 111);
            this.Txt_Username.MinimumSize = new System.Drawing.Size(4, 35);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(180, 29);
            this.Txt_Username.TabIndex = 15;
            this.Txt_Username.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Username_Validating);
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_User.Location = new System.Drawing.Point(275, 84);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(102, 24);
            this.Lbl_User.TabIndex = 14;
            this.Lbl_User.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Denver Taredos\' Registration";
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Login.ForeColor = System.Drawing.Color.MediumBlue;
            this.Lbl_Login.Location = new System.Drawing.Point(215, 288);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(315, 24);
            this.Lbl_Login.TabIndex = 18;
            this.Lbl_Login.Text = "Already Have Account? Sign in here";
            this.Lbl_Login.Click += new System.EventHandler(this.Lbl_Login_Click);
            // 
            // denverDBDataSet
            // 
            this.denverDBDataSet.DataSetName = "DenverDBDataSet";
            this.denverDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appUsersBindingSource
            // 
            this.appUsersBindingSource.DataMember = "appUsers";
            this.appUsersBindingSource.DataSource = this.denverDBDataSet;
            // 
            // appUsersTableAdapter
            // 
            this.appUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.appUsersTableAdapter = this.appUsersTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DenverTeradoLogin.DenverDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txt_Password1);
            this.panel1.Location = new System.Drawing.Point(279, 240);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(180, 30);
            this.panel1.TabIndex = 19;
            // 
            // Txt_Contact
            // 
            this.Txt_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contact.Location = new System.Drawing.Point(478, 176);
            this.Txt_Contact.MinimumSize = new System.Drawing.Size(4, 35);
            this.Txt_Contact.Name = "Txt_Contact";
            this.Txt_Contact.Size = new System.Drawing.Size(180, 29);
            this.Txt_Contact.TabIndex = 21;
            this.Txt_Contact.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Contact_Validating);
            // 
            // Lbl_Contact
            // 
            this.Lbl_Contact.AutoSize = true;
            this.Lbl_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contact.Location = new System.Drawing.Point(474, 149);
            this.Lbl_Contact.Name = "Lbl_Contact";
            this.Lbl_Contact.Size = new System.Drawing.Size(152, 24);
            this.Lbl_Contact.TabIndex = 20;
            this.Lbl_Contact.Text = "Contact Number:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 340);
            this.Controls.Add(this.Txt_Contact);
            this.Controls.Add(this.Lbl_Contact);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_Login);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.Lbl_User);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Cb_ShowPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Middle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Txt_Lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_First);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.denverDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUsersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_First;
        private System.Windows.Forms.TextBox Txt_Lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txt_Middle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Password1;
        private System.Windows.Forms.CheckBox Cb_ShowPassword;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_Login;
        private DenverDBDataSet denverDBDataSet;
        private System.Windows.Forms.BindingSource appUsersBindingSource;
        private DenverDBDataSetTableAdapters.appUsersTableAdapter appUsersTableAdapter;
        private DenverDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Contact;
        private System.Windows.Forms.Label Lbl_Contact;
    }
}