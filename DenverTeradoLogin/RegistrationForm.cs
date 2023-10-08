using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenverTeradoLogin
{
    public partial class RegistrationForm : Form
    {
        private static RegistrationForm _instance;

        public static RegistrationForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistrationForm();
                return _instance;
            }
        }

        private bool isShown = false;



        public RegistrationForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
            
        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {
            
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Match match = Regex.Match(email, pattern);
            return match.Success;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Txt_Password.Text = "";
            Txt_Password1.Text = "";
            Login.Instance.Show();
            this.Hide();
        }

        private void Cb_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (Cb_ShowPassword.Checked == true)
            {
                Txt_Password.UseSystemPasswordChar = false;
                Txt_Password1.UseSystemPasswordChar=false;
            }
            else
            {
                Txt_Password.UseSystemPasswordChar = true;
                Txt_Password1.UseSystemPasswordChar = true;
            }
        }

        private void appUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.denverDBDataSet);

        }

        private void appUsersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.appUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.denverDBDataSet);

        }

        private void appUsersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.appUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.denverDBDataSet);

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denverDBDataSet.appUsers' table. You can move, or remove it, as needed.
            this.appUsersTableAdapter.Fill(this.denverDBDataSet.appUsers);
            // TODO: This line of code loads data into the 'denverDBDataSet.appUsers' table. You can move, or remove it, as needed.
            this.appUsersTableAdapter.Fill(this.denverDBDataSet.appUsers);

        }

        private void appUsersBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.appUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.denverDBDataSet);

        }

        private void Txt_Password1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Lbl_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Instance.Show();
        }

        private void Txt_Password1_Validating(object sender, CancelEventArgs e)
        {
            if(Txt_Password.Text != Txt_Password1.Text)
            {
                Txt_Password1.BorderStyle = BorderStyle.None;
                panel1.BackColor = Color.Red;
            }
            else
            {
                panel1.BackColor = Color.Transparent;
            }
        }

        private void Txt_Username_Validating(object sender, CancelEventArgs e)
        {
            var username = string.Empty;
            if (appUsersTableAdapter.GetAllData().Count > 0)
            {
                var userData = appUsersTableAdapter.GetDataByUsername(Txt_Username.Text);
                if(userData.Count > 0)
                {
                    username = userData[0].username;
                }
            }


            if (username != string.Empty)
            {
                Lbl_User.Text = "User already exist";
                Lbl_User.ForeColor = Color.Red;
            }
            else
            {
                Lbl_User.Text = "Username: ";
                Lbl_User.ForeColor= Color.Black;
            }
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            var username = string.Empty;
            if (appUsersTableAdapter.GetAllData().Count > 0)
            {
                var userData = appUsersTableAdapter.GetDataByUsername(Txt_Username.Text);
                if (userData.Count > 0) { 
                    username = userData[0].username;
                };
            }
                if(username == string.Empty && Txt_Password.Text == Txt_Password1.Text && (Txt_Lastname.Text != string.Empty && Txt_First.Text != string.Empty))
                {
                    try
                    {
                        string fullname;
                        if (Txt_Middle.Text == null)
                        {
                            fullname = String.Format("{0} {1}", Txt_First.Text, Txt_Lastname.Text);
                        }
                        else 
                        { 
                            fullname = String.Format("{0} {1} {2}", Txt_First.Text, Txt_Middle.Text, Txt_Lastname.Text);
                        }
                        string salt = BCrypt.Net.BCrypt.GenerateSalt();
                        string hashPassword = BCrypt.Net.BCrypt.HashPassword(Txt_Password.Text, salt);
                        appUsersTableAdapter.Insert(fullname, Txt_Email.Text, Txt_Contact.Text, "User", Txt_Username.Text, hashPassword, salt);
                        DialogResult onOk = MessageBox.Show("Successful Registration", "You are now registered", MessageBoxButtons.OK);
                        
                        if(onOk == DialogResult.OK)
                        {
                            Txt_Contact.Text = "";
                            Txt_Email.Text = string.Empty;
                            Txt_First.Text = string.Empty;
                            Txt_Middle.Text = string.Empty;
                            Txt_Lastname.Text   = string.Empty;
                            Txt_Password.Text = string.Empty;
                            Txt_Password1.Text  = string.Empty;
                            Txt_Username.Text = string.Empty;
                            Login.Instance.Show();
                            this.Hide();
                            
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {

                }
            }

        private void Txt_Contact_Validating(object sender, CancelEventArgs e)
        {
            if(!Regex.IsMatch(Txt_Contact.Text, @"^09\d{9}$"))
            {
                Lbl_Contact.Text = "Is not a valid number";
                Lbl_Contact.ForeColor = Color.Red;
            }
            else
            {
                Lbl_Contact.Text = "Contact Number:";
                Lbl_Contact.ForeColor= Color.Black;
            }
        }

        private void Txt_Email_Validating(object sender, CancelEventArgs e)
        {
            if(!Regex.IsMatch(Txt_Email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")) 
            {
                Lbl_Email.Text = "Not a valid Email";
                Lbl_Email.ForeColor = Color.Red;
            }
            else
            {
                Lbl_Email.Text = "Email:";
                Lbl_Email.ForeColor = Color.Black;
            }
        }
    }
    
}


