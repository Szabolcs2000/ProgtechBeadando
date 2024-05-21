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
    public partial class UserLoginWindow : Form
    {        
        public UserLoginWindow()
        {            
            InitializeComponent();                       
        }

        private static UserLoginWindow instance;

        public static UserLoginWindow Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserLoginWindow();
                return instance;
            }

        }

        private void BTN_Reg_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Admin_Click(object sender, EventArgs e)
        {
            AdminLoginWindow adminLoginWindow = new AdminLoginWindow();
            adminLoginWindow.FormClosed += (s, args) => this.Show();
            adminLoginWindow.Show();
            this.Hide();
        }
    }
}
