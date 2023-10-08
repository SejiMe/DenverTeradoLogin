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
    public partial class MakeOrderForm : Form
    {

        private static MakeOrderForm _instance;

        public static MakeOrderForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MakeOrderForm();
                return _instance;
            }
        }

        public MakeOrderForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Btn_Mainform_Click(object sender, EventArgs e)
        {
           
            if(MainForm.Instance == null)
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
