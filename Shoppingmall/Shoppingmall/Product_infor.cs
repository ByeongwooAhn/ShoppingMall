using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppingmall
{
    public partial class Product_infor : Form
    {
        Main main;

        public Product_infor(Main M)
        {
            InitializeComponent();
            main = M;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (main.Login_button.Text == "Login")
            {
                Pay _Form = new Pay();
                _Form.Show();
            }
            else
            {
                Pay_m _m = new Pay_m();
                _m.Show();
            }
        }
    }
}
