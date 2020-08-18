using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            string user_name = username.Text;
            string pass_word = password.Text;
            if(user_name == "1" && pass_word == "1")
            {
                IndexForm index_form = new IndexForm();
                index_form.ShowDialog();
            }
            else
            {
                username.Clear();
                password.Clear();
                MessageBox.Show("用户名或密码错误！");
                username.Focus();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            username.Clear();
            password.Clear();
            username.Focus();

        }
    }
}
