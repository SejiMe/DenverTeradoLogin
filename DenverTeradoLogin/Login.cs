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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DenverTeradoLogin
{
    public partial class Login : Form
    {

        private static Login _instance;

        public static Login Instance
        {
            get {
                if(_instance == null)
                    _instance = new Login();
                return _instance; 
            }
        }

        RegistrationForm _registrationForm;


        public Login()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
 
            
        }

        private bool ValidatePassword(string password)
        {
            if (password.ToUpper() == "PASSWORD")
                return true;

            else
                return false;
        }

        private bool ValidateUsername(string username)
        {
            if(username.ToUpper() == "USERNAME")
                return true;

            else
                return false;
        }

        private void Txt_Password_MouseDown(object sender, MouseEventArgs e)
        {
            if(ValidatePassword(Txt_Password.Text))
            {
                Txt_Password.Text = "";
                Txt_Password.UseSystemPasswordChar = true;
                Txt_Password.ForeColor = Color.Black;
            }
            
        }

        private void Txt_Password_Leave(object sender, EventArgs e)
        {
            if (Txt_Password.Text == string.Empty)
            {
                Txt_Password.Text = "Password";
                Txt_Password.UseSystemPasswordChar = false;
                Txt_User.ForeColor = Color.SlateGray;
            }
                
        }

        private void Txt_User_MouseDown(object sender, MouseEventArgs e)
        {
            if(ValidateUsername(Txt_User.Text))
            {
                Txt_User.Text = "";
                Txt_User.ForeColor = Color.Black;
            }
        }

        private void Txt_User_Leave(object sender, EventArgs e)
        {
            if(Txt_User.Text == string.Empty)
            {
                Txt_User.Text = "Username";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denverDBDataSet.appUsers' table. You can move, or remove it, as needed.
            this.appUsersTableAdapter.Fill(this.denverDBDataSet.appUsers);
            Txt_User.ForeColor = Color.SlateGray;
            Txt_Password.ForeColor = Color.SlateGray;
        }

        private void Btn_Signin_Click(object sender, EventArgs e)
        {
            string password = string.Empty;
            string salt = string.Empty;
            if(appUsersTableAdapter.GetAllData().Count > 0)
            {
                if(Txt_User.Text.Length > 0 && Txt_Password.Text.Length > 0 && appUsersTableAdapter.GetDataByUsername(Txt_User.Text).Count > 0)
                {
                    var userData = appUsersTableAdapter.GetDataByUsername(Txt_User.Text);
                    password = userData[0].password;
                    salt = userData[0].salt;
                
                    if(BCrypt.Net.BCrypt.Verify(Txt_Password.Text, password))
                    {
                        var data = this.appUsersTableAdapter.GetDataByUsername(Txt_User.Text);
                        
                        DialogResult onok = MessageBox.Show("Successful Signing in", "Welcome to my App");
                        if(onok == DialogResult.OK)
                        {
                            AuthSession.Instance.UpdateSession(data.ToList()[0].username, true, data.ToList()[0].Fullname, data.ToList()[0].role);
                            MainForm form = new MainForm(data.ToList()[0].username,data.ToList()[0].role);
                            form.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username Input or Password", "", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                MessageBox.Show("There is no data!", "No data in the system", MessageBoxButtons.OK);
            }
            
           
        }

        private void Cb_Show_CheckedChanged(object sender, EventArgs e)
        {
            if(Cb_Show.Checked == true)
            {
                Txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_Password.UseSystemPasswordChar = true;

            }
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {

            RegistrationForm.Instance.Show();
            this.Hide();
            
        }

        private void appUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.denverDBDataSet);

        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            if (ValidatePassword(Txt_Password.Text))
            {
                Txt_Password.Text = "";
                Txt_Password.UseSystemPasswordChar = true;
                Txt_Password.ForeColor = Color.Black;
            }
        }

        
    }
}
