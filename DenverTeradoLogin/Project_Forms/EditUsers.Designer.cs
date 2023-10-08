namespace DenverTeradoLogin.Project_Forms
{
    partial class EditUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Txt_user = new System.Windows.Forms.TextBox();
            this.findSingleEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denverDBDataSet = new DenverTeradoLogin.DenverDBDataSet();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_fullname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CB_passwordEdit = new System.Windows.Forms.CheckBox();
            this.Txt_CnfirmPass = new System.Windows.Forms.TextBox();
            this.Lbl_ConfirmPass = new System.Windows.Forms.Label();
            this.Txt_Contact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cb_role = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Pass = new System.Windows.Forms.Label();
            this.findSingleEntityTableAdapter = new DenverTeradoLogin.DenverDBDataSetTableAdapters.FindSingleEntityTableAdapter();
            this.tableAdapterManager = new DenverTeradoLogin.DenverDBDataSetTableAdapters.TableAdapterManager();
            this.singleEntityWholeEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleEntityWholeEditTableAdapter = new DenverTeradoLogin.DenverDBDataSetTableAdapters.SingleEntityWholeEditTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findSingleEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denverDBDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleEntityWholeEditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 57);
            this.panel1.TabIndex = 1;
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID.Location = new System.Drawing.Point(402, 14);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(50, 24);
            this.Lbl_ID.TabIndex = 4;
            this.Lbl_ID.Text = "1001";
            // 
            // Txt_user
            // 
            this.Txt_user.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.findSingleEntityBindingSource, "username", true));
            this.Txt_user.Location = new System.Drawing.Point(118, 20);
            this.Txt_user.MinimumSize = new System.Drawing.Size(4, 30);
            this.Txt_user.Name = "Txt_user";
            this.Txt_user.ReadOnly = true;
            this.Txt_user.Size = new System.Drawing.Size(180, 20);
            this.Txt_user.TabIndex = 3;
            // 
            // findSingleEntityBindingSource
            // 
            this.findSingleEntityBindingSource.DataMember = "FindSingleEntity";
            this.findSingleEntityBindingSource.DataSource = this.denverDBDataSet;
            // 
            // denverDBDataSet
            // 
            this.denverDBDataSet.DataSetName = "DenverDBDataSet";
            this.denverDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Submit.Location = new System.Drawing.Point(378, 8);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(100, 30);
            this.Btn_Submit.TabIndex = 2;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(272, 8);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(100, 30);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_Back);
            this.panel3.Controls.Add(this.Btn_Submit);
            this.panel3.Controls.Add(this.Btn_Delete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 65);
            this.panel3.TabIndex = 5;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(21, 8);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(100, 30);
            this.Btn_Back.TabIndex = 4;
            this.Btn_Back.Text = "Go Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name";
            // 
            // Txt_fullname
            // 
            this.Txt_fullname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.findSingleEntityBindingSource, "Fullname", true));
            this.Txt_fullname.Location = new System.Drawing.Point(33, 66);
            this.Txt_fullname.MinimumSize = new System.Drawing.Size(4, 30);
            this.Txt_fullname.Name = "Txt_fullname";
            this.Txt_fullname.Size = new System.Drawing.Size(180, 20);
            this.Txt_fullname.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CB_passwordEdit);
            this.panel2.Controls.Add(this.Txt_CnfirmPass);
            this.panel2.Controls.Add(this.Lbl_ConfirmPass);
            this.panel2.Controls.Add(this.Txt_Contact);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Cb_role);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Txt_email);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Txt_Password);
            this.panel2.Controls.Add(this.Lbl_Pass);
            this.panel2.Controls.Add(this.Txt_fullname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 255);
            this.panel2.TabIndex = 4;
            // 
            // CB_passwordEdit
            // 
            this.CB_passwordEdit.AutoSize = true;
            this.CB_passwordEdit.Location = new System.Drawing.Point(378, 24);
            this.CB_passwordEdit.Name = "CB_passwordEdit";
            this.CB_passwordEdit.Size = new System.Drawing.Size(91, 17);
            this.CB_passwordEdit.TabIndex = 14;
            this.CB_passwordEdit.Text = "edit password";
            this.CB_passwordEdit.UseVisualStyleBackColor = true;
            this.CB_passwordEdit.CheckedChanged += new System.EventHandler(this.CB_passwordEdit_CheckedChanged);
            // 
            // Txt_CnfirmPass
            // 
            this.Txt_CnfirmPass.Enabled = false;
            this.Txt_CnfirmPass.Location = new System.Drawing.Point(272, 139);
            this.Txt_CnfirmPass.MinimumSize = new System.Drawing.Size(4, 30);
            this.Txt_CnfirmPass.Name = "Txt_CnfirmPass";
            this.Txt_CnfirmPass.Size = new System.Drawing.Size(180, 20);
            this.Txt_CnfirmPass.TabIndex = 13;
            // 
            // Lbl_ConfirmPass
            // 
            this.Lbl_ConfirmPass.AutoSize = true;
            this.Lbl_ConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConfirmPass.Location = new System.Drawing.Point(268, 116);
            this.Lbl_ConfirmPass.Name = "Lbl_ConfirmPass";
            this.Lbl_ConfirmPass.Size = new System.Drawing.Size(137, 20);
            this.Lbl_ConfirmPass.TabIndex = 12;
            this.Lbl_ConfirmPass.Text = "Confirm Password";
            // 
            // Txt_Contact
            // 
            this.Txt_Contact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.findSingleEntityBindingSource, "contact_number", true));
            this.Txt_Contact.Location = new System.Drawing.Point(35, 211);
            this.Txt_Contact.MinimumSize = new System.Drawing.Size(4, 30);
            this.Txt_Contact.Name = "Txt_Contact";
            this.Txt_Contact.Size = new System.Drawing.Size(180, 20);
            this.Txt_Contact.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contact Number";
            // 
            // Cb_role
            // 
            this.Cb_role.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.findSingleEntityBindingSource, "role", true));
            this.Cb_role.DisplayMember = "role";
            this.Cb_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_role.FormattingEnabled = true;
            this.Cb_role.Items.AddRange(new object[] {
            "User",
            "Supervisor",
            "Manager",
            "Admin"});
            this.Cb_role.Location = new System.Drawing.Point(272, 213);
            this.Cb_role.Name = "Cb_role";
            this.Cb_role.Size = new System.Drawing.Size(180, 28);
            this.Cb_role.TabIndex = 9;
            this.Cb_role.ValueMember = "role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Role";
            // 
            // Txt_email
            // 
            this.Txt_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.findSingleEntityBindingSource, "email_address", true));
            this.Txt_email.Location = new System.Drawing.Point(35, 139);
            this.Txt_email.MinimumSize = new System.Drawing.Size(4, 30);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(180, 20);
            this.Txt_email.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Enabled = false;
            this.Txt_Password.Location = new System.Drawing.Point(272, 66);
            this.Txt_Password.MinimumSize = new System.Drawing.Size(4, 30);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(180, 20);
            this.Txt_Password.TabIndex = 5;
            // 
            // Lbl_Pass
            // 
            this.Lbl_Pass.AutoSize = true;
            this.Lbl_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pass.Location = new System.Drawing.Point(268, 43);
            this.Lbl_Pass.Name = "Lbl_Pass";
            this.Lbl_Pass.Size = new System.Drawing.Size(78, 20);
            this.Lbl_Pass.TabIndex = 4;
            this.Lbl_Pass.Text = "Password";
            // 
            // findSingleEntityTableAdapter
            // 
            this.findSingleEntityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.appUsers1TableAdapter = null;
            this.tableAdapterManager.appUsersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FindSingleEntityTableAdapter = this.findSingleEntityTableAdapter;
            this.tableAdapterManager.SingleEntityWholeEditTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DenverTeradoLogin.DenverDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // singleEntityWholeEditBindingSource
            // 
            this.singleEntityWholeEditBindingSource.DataMember = "SingleEntityWholeEdit";
            this.singleEntityWholeEditBindingSource.DataSource = this.denverDBDataSet;
            // 
            // singleEntityWholeEditTableAdapter
            // 
            this.singleEntityWholeEditTableAdapter.ClearBeforeFill = true;
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 377);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "EditUsers";
            this.Text = "EditUsers";
            this.Load += new System.EventHandler(this.EditUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findSingleEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denverDBDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleEntityWholeEditBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_fullname;
        private System.Windows.Forms.TextBox Txt_user;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label Lbl_Pass;
        private System.Windows.Forms.ComboBox Cb_role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Contact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.TextBox Txt_CnfirmPass;
        private System.Windows.Forms.Label Lbl_ConfirmPass;
        private DenverDBDataSet denverDBDataSet;
        private System.Windows.Forms.BindingSource findSingleEntityBindingSource;
        private DenverDBDataSetTableAdapters.FindSingleEntityTableAdapter findSingleEntityTableAdapter;
        private DenverDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource singleEntityWholeEditBindingSource;
        private DenverDBDataSetTableAdapters.SingleEntityWholeEditTableAdapter singleEntityWholeEditTableAdapter;
        private System.Windows.Forms.CheckBox CB_passwordEdit;
        private System.Windows.Forms.Button Btn_Back;
    }
}