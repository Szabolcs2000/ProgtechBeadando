using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufeBeadandoProject
{
    public partial class RegWindow : Form
    {
        public RegWindow()
        {
            InitializeComponent();
            TB_RegPW.UseSystemPasswordChar = true;
            TB_RegPW2.UseSystemPasswordChar = true;
        }

        private static RegWindow instance;

        public static RegWindow Instance
        {
            get
            {
                if (instance == null)
                    instance = new RegWindow();
                return instance;
            }

        }

        private void BTN_RegUser_Click(object sender, EventArgs e)
        {
            UserLoginWindow userLoginWindow = new UserLoginWindow();
            userLoginWindow.FormClosed += (s, args) => this.Show();
            userLoginWindow.Show();
            this.Hide();
        }

        private void BTN_RegExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
