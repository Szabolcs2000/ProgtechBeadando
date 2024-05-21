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
    public partial class AdminLoginWindow : Form
    {
       
        public AdminLoginWindow()        {
          
            InitializeComponent();
        }

        private static AdminLoginWindow instance;

        public static AdminLoginWindow Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdminLoginWindow();
                return instance;
            }

        }

        private void BTN_User_Click(object sender, EventArgs e)
        {
            UserLoginWindow userLoginWindow = new UserLoginWindow();
            userLoginWindow.FormClosed += (s, args) => this.Show();
            userLoginWindow.Show();
            this.Hide();
        }
    }
}
