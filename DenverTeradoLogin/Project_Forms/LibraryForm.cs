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
    public partial class LibraryForm : Form
    {

        private static LibraryForm _instance;

        public static LibraryForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LibraryForm();
                return _instance;
            }
        }

        public LibraryForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {

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
