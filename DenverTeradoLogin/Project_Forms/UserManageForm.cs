using DenverTeradoLogin.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenverTeradoLogin.Project_Forms
{
    public partial class UserManageForm : Form
    {
        private static UserManageForm _instance;

        public static UserManageForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserManageForm();
                return _instance;
            }
        }

        public UserManageForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denverDBDataSet.appUsers1' table. You can move, or remove it, as needed.
            this.appUsers1TableAdapter.Fill(this.denverDBDataSet.appUsers1);
            // TODO: This line of code loads data into the 'denverDBDataSet.appUsers1' table. You can move, or remove it, as needed.
            this.appUsers1TableAdapter.Fill(this.denverDBDataSet.appUsers1);
            // TODO: This line of code loads data into the 'denverDBDataSet.appUsers' table. You can move, or remove it, as needed.
         

        }

   

        private void Btn_Mainform_Click(object sender, EventArgs e)
        {
            if (MainForm.Instance == null)
            {
                MainForm instance = new MainForm(AuthSession.Instance.Username, AuthSession.Instance.Role);
                instance.Show();
            }
            else
            {
                MainForm.Instance.Show();
            }
            this.Hide();
        }

        private void appUsers1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appUsers1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.denverDBDataSet);

        }

        private void appUsers1DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int rowIndex = appUsers1DataGridView.SelectedCells[0].RowIndex;
                string message = string.Format("index at:{0} \ndata id:{1}", rowIndex.ToString(), appUsers1DataGridView[0, rowIndex].Value.ToString());
                EditUsers edit = new EditUsers(appUsers1DataGridView[0, rowIndex].Value.ToString());
                edit.Show();
                this.Hide();
            }
        }
    }
}
