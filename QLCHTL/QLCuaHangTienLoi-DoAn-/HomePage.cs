using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class HomePage : Form
    {

        public HomePage(string roleCurrent)
        {
            InitializeComponent();

            DisplayRoleCurrent(roleCurrent);
        }

        private void DisplayRoleCurrent(string roleCurrrent)
        {
            string text = "Bạn đang truy cập với quyền" + roleCurrrent;
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }
    }
}
