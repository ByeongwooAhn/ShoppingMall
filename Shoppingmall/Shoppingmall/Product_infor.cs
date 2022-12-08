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
        public Product_infor()
        {
            InitializeComponent();
        }

        public Main main;

        private void button1_Click(object sender, EventArgs e)
        {
            if (main.Login_button.Text == "Login")
            {
                Pay _Form = new Pay();
                _Form._Infor = this;
                _Form.Show();
            }
            else
            {
                Pay_m _m = new Pay_m();
                _m._Infor = this;
                _m.label5.Text = main.Login_button.Text;
                _m.Show();
            }
        }
    }
}
