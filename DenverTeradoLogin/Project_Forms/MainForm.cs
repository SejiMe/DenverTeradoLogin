using DenverTeradoLogin.Controller;
using DenverTeradoLogin.Project_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenverTeradoLogin
{
    public partial class MainForm : Form
    {


        // Admin open 5 forms
        // User open 1 form
        // Manager 4 forms
        // Supervisor 3 forms
        enum UsersGroup
        {
            Admin,
            User,
            Manager,
            Supervisor,
        }
        AuthSession session;
        private static MainForm _instance;

        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainForm(string.Empty, string.Empty);
                return _instance;
            }
        }


        public MainForm(string username, string role)
        {

            InitializeComponent();
            session = new AuthSession(username, role);
            Lbl_fullname.Text = AuthSession.Instance.FullName;
            Lbl_user.Text = AuthSession.Instance.Username;
            this.ControlBox = false;

           
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (AuthSession.Instance.Role == UsersGroup.Admin.ToString())
            {
                MakeOrderForm.Instance.Show();
                UserManageForm.Instance.Show();
                DashboardForm.Instance.Show();
                LibraryForm.Instance.Show();
            }

            if (AuthSession.Instance.Role == UsersGroup.Manager.ToString())
            {
                DashboardForm.Instance.Show();
                MakeOrderForm.Instance.Show();
                LibraryForm.Instance.Show();
                Btn_UM.Hide();
            }

            if (AuthSession.Instance.Role == UsersGroup.Supervisor.ToString())
            {
                MakeOrderForm.Instance.Show();
                LibraryForm.Instance.Show();
                Btn_UM.Hide();
                Btn_DBoard.Hide();
            }

            if (AuthSession.Instance.Role == UsersGroup.User.ToString())
            {
                Btn_DBoard.Hide();
                Btn_Library.Hide();
                Btn_UM.Hide();
                Btn_MO.Hide();
                Lbl_Canview.Text = "This is the only form you can view";
            }
        }

        private void Btn_signout_Click(object sender, EventArgs e)
        {
            LibraryForm.Instance.Dispose();
            MakeOrderForm.Instance.Dispose();
            DashboardForm.Instance.Dispose();
            UserManageForm.Instance.Dispose();
            AuthSession.Instance.UpdateSession(string.Empty, false, string.Empty, string.Empty);
            this.Dispose();
            this.Close();
        }

        private void Btn_UM_Click(object sender, EventArgs e)
        {
            UserManageForm.Instance.Show();
            this.Hide();
        }

        private void Btn_DBoard_Click(object sender, EventArgs e)
        {
            DashboardForm.Instance.Show();
            this.Hide();
        }

        private void Btn_Library_Click(object sender, EventArgs e)
        {
            LibraryForm.Instance.Show();
            this.Hide();
        }

        private void Btn_MO_Click(object sender, EventArgs e)
        {
            MakeOrderForm.Instance.Show();
            this.Hide();
        }
    }
}
