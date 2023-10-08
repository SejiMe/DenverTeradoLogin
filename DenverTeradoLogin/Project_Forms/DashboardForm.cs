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
    public partial class DashboardForm : Form
    {

        private static DashboardForm _instance;

        public static DashboardForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DashboardForm();
                return _instance;
            }
        }

        public DashboardForm()
        {
            InitializeComponent();
            this.ControlBox = false;
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
    }
}
