using BCrypt.Net;
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
    public partial class EditUsers : Form
    {
        private static EditUsers instance;
        public static EditUsers Instance
        {
            get
            {
                if(instance == null)
                    instance = new EditUsers("");
                return instance;
            }
        }
        public EditUsers(string id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
            Lbl_ID.Text = id;
            this.ControlBox = false;
        }

        private void appUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void EditUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denverDBDataSet.appUsers' table. You can move, or remove it, as needed.
            this.findSingleEntityTableAdapter.Fill(this.denverDBDataSet.FindSingleEntity, int.Parse(Lbl_ID.Text));
            this.singleEntityWholeEditTableAdapter.Fill(this.denverDBDataSet.SingleEntityWholeEdit, int.Parse(Lbl_ID.Text));
            var origData = this.singleEntityWholeEditTableAdapter.GetData(int.Parse(Lbl_ID.Text));
            MessageBox.Show(origData.ToList()[0].username);

        }

        private void findSingleEntityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.findSingleEntityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.denverDBDataSet);

        }

       
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            if(CB_passwordEdit.Checked == true && Txt_CnfirmPass.Text == Txt_Password.Text)
            {
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(Txt_Password.Text, salt);
                var origData = this.singleEntityWholeEditTableAdapter.GetData(int.Parse(Lbl_ID.Text));
                this.singleEntityWholeEditTableAdapter.Update(Txt_fullname.Text, Txt_email.Text, Txt_Contact.Text, Cb_role.Text, Txt_user.Text,passwordHash, salt, origData.ToList()[0].PK_appUsers,
                    origData.ToList()[0].Fullname, origData.ToList()[0].email_address, origData.ToList()[0].contact_number, origData.ToList()[0].role, origData.ToList()[0].username, origData.ToList()[0].password, origData.ToList()[0].salt);
                MessageBox.Show("Updated Successfully");
            }
            else if(CB_passwordEdit.Checked == true && Txt_Password.Text != Txt_CnfirmPass.Text)
            {
                MessageBox.Show("password not match", "Unmatched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var origData = this.findSingleEntityTableAdapter.GetData(int.Parse(Lbl_ID.Text));
                this.findSingleEntityTableAdapter.Update(Txt_fullname.Text, Txt_email.Text, Txt_Contact.Text, Cb_role.Text, Txt_user.Text, origData.ToList()[0].Fullname, origData.ToList()[0].email_address, origData.ToList()[0].contact_number, origData.ToList()[0].role, origData.ToList()[0].username, origData.ToList()[0].PK_appUsers);
                MessageBox.Show("Updated Successfully");
            }
        }

        

        private void CB_passwordEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_passwordEdit.Checked)
            {
                Txt_CnfirmPass.Enabled = true;
                Txt_Password.Enabled = true;
            }
            else
            {
                Txt_CnfirmPass.Enabled =false;
                Txt_Password.Enabled = false;
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            var origData = this.singleEntityWholeEditTableAdapter.GetData(int.Parse(Lbl_ID.Text));
            var origData1 = this.findSingleEntityTableAdapter.GetData(int.Parse(Lbl_ID.Text));
            singleEntityWholeEditTableAdapter.Delete(origData.ToList()[0].PK_appUsers, origData.ToList()[0].Fullname, origData.ToList()[0].email_address, origData.ToList()[0].contact_number, origData.ToList()[0].role, origData.ToList()[0].username, origData.ToList()[0].password, origData.ToList()[0].salt);
            
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            UserManageForm.Instance.Show();
            this.Hide();
        }
    }
}
