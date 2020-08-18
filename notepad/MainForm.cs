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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 登录界面
            LoginForm login_form = new LoginForm();
            login_form.MdiParent = this;

            int x = this.Width - login_form.Width / 2;
            int y = this.Height - login_form.Height / 2;
            Point login_point = new Point(x, y);
            login_form.Location = login_point;

            login_form.Show();
        }
    }
}
