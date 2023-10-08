namespace DenverTeradoLogin.Project_Forms
{
    partial class UserManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Mainform = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.denverDBDataSet = new DenverTeradoLogin.DenverDBDataSet();
            this.appUsers1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appUsers1TableAdapter = new DenverTeradoLogin.DenverDBDataSetTableAdapters.appUsers1TableAdapter();
            this.tableAdapterManager = new DenverTeradoLogin.DenverDBDataSetTableAdapters.TableAdapterManager();
            this.appUsers1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.appUsers1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.appUsers1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.denverDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUsers1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUsers1BindingNavigator)).BeginInit();
            this.appUsers1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appUsers1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Mainform);
            this.panel1.Controls.Add(this.Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 81);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Mainform
            // 
            this.Btn_Mainform.Location = new System.Drawing.Point(555, 29);
            this.Btn_Mainform.Name = "Btn_Mainform";
            this.Btn_Mainform.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mainform.TabIndex = 9;
            this.Btn_Mainform.Text = "Go Back";
            this.Btn_Mainform.UseVisualStyleBackColor = true;
            this.Btn_Mainform.Click += new System.EventHandler(this.Btn_Mainform_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(12, 32);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(146, 20);
            this.Label.TabIndex = 0;
            this.Label.Text = "Edit User Accounts";
            // 
            // denverDBDataSet
            // 
            this.denverDBDataSet.DataSetName = "DenverDBDataSet";
            this.denverDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appUsers1BindingSource
            // 
            this.appUsers1BindingSource.DataMember = "appUsers1";
            this.appUsers1BindingSource.DataSource = this.denverDBDataSet;
            // 
            // appUsers1TableAdapter
            // 
            this.appUsers1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.appUsers1TableAdapter = this.appUsers1TableAdapter;
            this.tableAdapterManager.appUsersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FindSingleEntityTableAdapter = null;
            this.tableAdapterManager.SingleEntityWholeEditTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DenverTeradoLogin.DenverDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // appUsers1BindingNavigator
            // 
            this.appUsers1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.appUsers1BindingNavigator.BindingSource = this.appUsers1BindingSource;
            this.appUsers1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.appUsers1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.appUsers1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.appUsers1BindingNavigatorSaveItem});
            this.appUsers1BindingNavigator.Location = new System.Drawing.Point(0, 81);
            this.appUsers1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.appUsers1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.appUsers1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.appUsers1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.appUsers1BindingNavigator.Name = "appUsers1BindingNavigator";
            this.appUsers1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.appUsers1BindingNavigator.Size = new System.Drawing.Size(642, 25);
            this.appUsers1BindingNavigator.TabIndex = 3;
            this.appUsers1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // appUsers1BindingNavigatorSaveItem
            // 
            this.appUsers1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.appUsers1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("appUsers1BindingNavigatorSaveItem.Image")));
            this.appUsers1BindingNavigatorSaveItem.Name = "appUsers1BindingNavigatorSaveItem";
            this.appUsers1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.appUsers1BindingNavigatorSaveItem.Text = "Save Data";
            this.appUsers1BindingNavigatorSaveItem.Click += new System.EventHandler(this.appUsers1BindingNavigatorSaveItem_Click);
            // 
            // appUsers1DataGridView
            // 
            this.appUsers1DataGridView.AllowUserToAddRows = false;
            this.appUsers1DataGridView.AllowUserToDeleteRows = false;
            this.appUsers1DataGridView.AllowUserToResizeColumns = false;
            this.appUsers1DataGridView.AllowUserToResizeRows = false;
            this.appUsers1DataGridView.AutoGenerateColumns = false;
            this.appUsers1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appUsers1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.appUsers1DataGridView.DataSource = this.appUsers1BindingSource;
            this.appUsers1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appUsers1DataGridView.Location = new System.Drawing.Point(0, 106);
            this.appUsers1DataGridView.Name = "appUsers1DataGridView";
            this.appUsers1DataGridView.ReadOnly = true;
            this.appUsers1DataGridView.Size = new System.Drawing.Size(642, 319);
            this.appUsers1DataGridView.TabIndex = 3;
            this.appUsers1DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appUsers1DataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_appUsers";
            this.dataGridViewTextBoxColumn1.HeaderText = "PK_appUsers";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fullname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fullname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email_address";
            this.dataGridViewTextBoxColumn3.HeaderText = "email_address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "contact_number";
            this.dataGridViewTextBoxColumn4.HeaderText = "contact_number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "role";
            this.dataGridViewTextBoxColumn5.HeaderText = "role";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn6.HeaderText = "username";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // UserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 425);
            this.Controls.Add(this.appUsers1DataGridView);
            this.Controls.Add(this.appUsers1BindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "UserManageForm";
            this.Text = "UserManageForm";
            this.Load += new System.EventHandler(this.UserManageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.denverDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUsers1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUsers1BindingNavigator)).EndInit();
            this.appUsers1BindingNavigator.ResumeLayout(false);
            this.appUsers1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appUsers1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Btn_Mainform;
        private DenverDBDataSet denverDBDataSet;
        private System.Windows.Forms.BindingSource appUsers1BindingSource;
        private DenverDBDataSetTableAdapters.appUsers1TableAdapter appUsers1TableAdapter;
        private DenverDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator appUsers1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton appUsers1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView appUsers1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}