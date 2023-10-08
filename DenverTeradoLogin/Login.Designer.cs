namespace DenverTeradoLogin
{
    partial class Login
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
            this.Cb_Show = new System.Windows.Forms.CheckBox();
            this.Btn_Signin = new System.Windows.Forms.Button();
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.denverDBDataSet = new DenverTeradoLogin.DenverDBDataSet();
            this.appUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appUsersTableAdapter = new DenverTeradoLogin.DenverDBDataSetTableAdapters.appUsersTableAdapter();
            this.tableAdapterManager = new DenverTeradoLogin.DenverDBDataSetTableAdapters.TableAdapterManager();
            this.findSingleEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findSingleEntityTableAdapter = new DenverTeradoLogin.DenverDBDataSetTableAdapters.FindSingleEntityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.denverDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findSingleEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cb_Show
            // 
            this.Cb_Show.AutoSize = true;
            this.Cb_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cb_Show.Location = new System.Drawing.Point(303, 142);
            this.Cb_Show.Name = "Cb_Show";
            this.Cb_Show.Size = new System.Drawing.Size(102, 17);
            this.Cb_Show.TabIndex = 0;
            this.Cb_Show.Text = "Show Password";
            this.Cb_Show.UseVisualStyleBackColor = true;
            this.Cb_Show.CheckedChanged += new System.EventHandler(this.Cb_Show_CheckedChanged);
            // 
            // Btn_Signin
            // 
            this.Btn_Signin.Location = new System.Drawing.Point(129, 170);
            this.Btn_Signin.Name = "Btn_Signin";
            this.Btn_Signin.Size = new System.Drawing.Size(150, 40);
            this.Btn_Signin.TabIndex = 1;
            this.Btn_Signin.Text = "Login";
            this.Btn_Signin.UseVisualStyleBackColor = true;
            this.Btn_Signin.Click += new System.EventHandler(this.Btn_Signin_Click);
            // 
            // Txt_User
            // 
            this.Txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_User.Location = new System.Drawing.Point(97, 93);
            this.Txt_User.MinimumSize = new System.Drawing.Size(4, 30);
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(200, 29);
            this.Txt_User.TabIndex = 3;
            this.Txt_User.Text = "Username";
            this.Txt_User.Leave += new System.EventHandler(this.Txt_User_Leave);
            this.Txt_User.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_User_MouseDown);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(97, 129);
            this.Txt_Password.MinimumSize = new System.Drawing.Size(4, 30);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(200, 29);
            this.Txt_Password.TabIndex = 4;
            this.Txt_Password.Text = "Password";
            this.Txt_Password.TextChanged += new System.EventHandler(this.Txt_Password_TextChanged);
            this.Txt_Password.Enter += new System.EventHandler(this.Txt_Password_Enter);
            this.Txt_Password.Leave += new System.EventHandler(this.Txt_Password_Leave);
            this.Txt_Password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_Password_MouseDown);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(129, 216);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(150, 40);
            this.Btn_Register.TabIndex = 5;
            this.Btn_Register.Text = "Sign Up";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Terado\'s Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableAdapterManager.appUsers1TableAdapter = null;
            this.tableAdapterManager.appUsersTableAdapter = this.appUsersTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FindSingleEntityTableAdapter = null;
            this.tableAdapterManager.SingleEntityWholeEditTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DenverTeradoLogin.DenverDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // findSingleEntityBindingSource
            // 
            this.findSingleEntityBindingSource.DataMember = "FindSingleEntity";
            this.findSingleEntityBindingSource.DataSource = this.denverDBDataSet;
            // 
            // findSingleEntityTableAdapter
            // 
            this.findSingleEntityTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_User);
            this.Controls.Add(this.Btn_Signin);
            this.Controls.Add(this.Cb_Show);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.denverDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findSingleEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Cb_Show;
        private System.Windows.Forms.Button Btn_Signin;
        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Label label1;
        private DenverDBDataSet denverDBDataSet;
        private System.Windows.Forms.BindingSource appUsersBindingSource;
        private DenverDBDataSetTableAdapters.appUsersTableAdapter appUsersTableAdapter;
        private DenverDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource findSingleEntityBindingSource;
        private DenverDBDataSetTableAdapters.FindSingleEntityTableAdapter findSingleEntityTableAdapter;
    }
}

