using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace Shoppingmall
{
    public partial class Main : Form
    {
        string connstr = "Server = 127.0.0.1;Port=3306;Database=member;Uid=root;Pwd=root";

        public Main()
        {
            InitializeComponent();
        }

        public void Connection()
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex) {  }
            }
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (Login_button.Text == "Login")
            {
                Login login = new Login(this);
                login.Show();
            }
            else {  }
        }

        private void 내정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_Infor _Form = new My_Infor();
            _Form.Show();
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("로그아웃 하시겠습니까?", "알림", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                 MessageBox.Show("로그아웃되었습니다.");
                 Login_button.Text = "Login";
            }
        }

        #region
        private void label2_Click(object sender, EventArgs e)  //옷 가격
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label2.Text;
                    _Infor.label7.Text = "65";
                    _Infor.label8.Text = "68";
                    _Infor.pictureBox1.Image = pictureBox2.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label2.Text;
                _Infor.label7.Text = "65";
                _Infor.label8.Text = "68";
                _Infor.pictureBox1.Image = pictureBox2.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void pictureBox2_Click(object sender, EventArgs e)  //옷 사진
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label2.Text;
                    _Infor.label7.Text = "65";
                    _Infor.label8.Text = "68";
                    _Infor.pictureBox1.Image = pictureBox2.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label2.Text;
                _Infor.label7.Text = "65";
                _Infor.label8.Text = "68";
                _Infor.pictureBox1.Image = pictureBox2.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label3.Text;
                    _Infor.label7.Text = "53";
                    _Infor.label8.Text = "72";
                    _Infor.pictureBox1.Image = pictureBox13.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label3.Text;
                _Infor.label7.Text = "53";
                _Infor.label8.Text = "72";
                _Infor.pictureBox1.Image = pictureBox13.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void label3_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label3.Text;
                    _Infor.label7.Text = "53";
                    _Infor.label8.Text = "72";
                    _Infor.pictureBox1.Image = pictureBox13.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label3.Text;
                _Infor.label7.Text = "53";
                _Infor.label8.Text = "72";
                _Infor.pictureBox1.Image = pictureBox13.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label4.Text;
                    _Infor.label7.Text = "48";
                    _Infor.label8.Text = "70";
                    _Infor.pictureBox1.Image = pictureBox7.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label4.Text;
                _Infor.label7.Text = "48";
                _Infor.label8.Text = "70";
                _Infor.pictureBox1.Image = pictureBox7.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void label4_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label4.Text;
                    _Infor.label7.Text = "48";
                    _Infor.label8.Text = "70";
                    _Infor.pictureBox1.Image = pictureBox7.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label4.Text;
                _Infor.label7.Text = "48";
                _Infor.label8.Text = "70";
                _Infor.pictureBox1.Image = pictureBox7.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label5.Text;
                    _Infor.label6.Text = "M";
                    _Infor.label7.Text = "28";
                    _Infor.label8.Text = "80";
                    _Infor.pictureBox1.Image = pictureBox5.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label5.Text;
                _Infor.label6.Text = "M";
                _Infor.label7.Text = "28";
                _Infor.label8.Text = "80";
                _Infor.pictureBox1.Image = pictureBox5.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void label5_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label5.Text;
                    _Infor.label6.Text = "M";
                    _Infor.label7.Text = "28";
                    _Infor.label8.Text = "80";
                    _Infor.pictureBox1.Image = pictureBox5.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label5.Text;
                _Infor.label6.Text = "M";
                _Infor.label7.Text = "28";
                _Infor.label8.Text = "80";
                _Infor.pictureBox1.Image = pictureBox5.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label6.Text;
                    _Infor.label7.Text = "40";
                    _Infor.label8.Text = "68";
                    _Infor.pictureBox1.Image = pictureBox12.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label6.Text;
                _Infor.label7.Text = "40";
                _Infor.label8.Text = "68";
                _Infor.pictureBox1.Image = pictureBox12.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void label6_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label6.Text;
                    _Infor.label7.Text = "40";
                    _Infor.label8.Text = "68";
                    _Infor.pictureBox1.Image = pictureBox12.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label6.Text;
                _Infor.label7.Text = "40";
                _Infor.label8.Text = "68";
                _Infor.pictureBox1.Image = pictureBox12.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label7.Text;
                    _Infor.label7.Text = "53";
                    _Infor.label8.Text = "74";
                    _Infor.pictureBox1.Image = pictureBox8.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label7.Text;
                _Infor.label7.Text = "53";
                _Infor.label8.Text = "74";
                _Infor.pictureBox1.Image = pictureBox8.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void label7_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label7.Text;
                    _Infor.label7.Text = "53";
                    _Infor.label8.Text = "74";
                    _Infor.pictureBox1.Image = pictureBox8.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label7.Text;
                _Infor.label7.Text = "53";
                _Infor.label8.Text = "74";
                _Infor.pictureBox1.Image = pictureBox8.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label8.Text;
                    _Infor.label6.Text = "S";
                    _Infor.label7.Text = "28";
                    _Infor.label8.Text = "45";
                    _Infor.pictureBox1.Image = pictureBox6.Image;
                    _Infor.Show();
                }
            }
            else
            {
                Product_infor _Infor = new Product_infor(this);
                _Infor.label1.Text = label8.Text;
                _Infor.label6.Text = "S";
                _Infor.label7.Text = "28";
                _Infor.label8.Text = "45";
                _Infor.pictureBox1.Image = pictureBox6.Image;
                _Infor.Show();
            }
            #endregion
        }

        private void label8_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label8.Text;
                    _Infor.label6.Text = "S";
                    _Infor.label7.Text = "28";
                    _Infor.label8.Text = "45";
                    _Infor.pictureBox1.Image = pictureBox6.Image;
                    _Infor.Show();
                }
            }
            else
            {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label8.Text;
                    _Infor.label6.Text = "S";
                    _Infor.label7.Text = "28";
                    _Infor.label8.Text = "45";
                    _Infor.pictureBox1.Image = pictureBox6.Image;
                    _Infor.Show();
            }
            #endregion
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label9.Text;
                    _Infor.label7.Text = "56";
                    _Infor.label8.Text = "68";
                    _Infor.pictureBox1.Image = pictureBox9.Image;
                    _Infor.Show();
                }
            }
            else
            {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label9.Text;
                    _Infor.label7.Text = "56";
                    _Infor.label8.Text = "68";
                    _Infor.pictureBox1.Image = pictureBox9.Image;
                    _Infor.Show();
            }
            #endregion
        }

        private void label9_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label9.Text;
                    _Infor.label7.Text = "56";
                    _Infor.label8.Text = "68";
                    _Infor.pictureBox1.Image = pictureBox9.Image;
                    _Infor.Show();
                }
            }
            else
            {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label9.Text;
                    _Infor.label7.Text = "56";
                    _Infor.label8.Text = "68";
                    _Infor.pictureBox1.Image = pictureBox9.Image;
                    _Infor.Show();
            }
            #endregion
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label10.Text;
                    _Infor.label7.Text = "52";
                    _Infor.label8.Text = "74";
                    _Infor.pictureBox1.Image = pictureBox10.Image;
                    _Infor.Show();
                }
            }
            else
            {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label10.Text;
                    _Infor.label7.Text = "52";
                    _Infor.label8.Text = "74";
                    _Infor.pictureBox1.Image = pictureBox10.Image;
                    _Infor.Show();
            }
            #endregion
        }

        private void label10_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label10.Text;
                    _Infor.label7.Text = "52";
                    _Infor.label8.Text = "74";
                    _Infor.pictureBox1.Image = pictureBox10.Image;
                    _Infor.Show();
                }
            }
            else
            {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label10.Text;
                    _Infor.label7.Text = "52";
                    _Infor.label8.Text = "74";
                    _Infor.pictureBox1.Image = pictureBox10.Image;
                    _Infor.Show();
            }
            #endregion
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label11.Text;
                    _Infor.label7.Text = "56";
                    _Infor.label8.Text = "70";
                    _Infor.pictureBox1.Image = pictureBox3.Image;
                    _Infor.Show();
                }
            }
            else
            {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label11.Text;
                    _Infor.label7.Text = "56";
                    _Infor.label8.Text = "70";
                    _Infor.pictureBox1.Image = pictureBox3.Image;
                    _Infor.Show();
            }
            #endregion
        }

        private void label11_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label11.Text;
                    _Infor.label7.Text = "56";
                    _Infor.label8.Text = "70";
                    _Infor.pictureBox1.Image = pictureBox3.Image;
                    _Infor.Show();
                }
            }
            else
            {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label11.Text;
                    _Infor.label7.Text = "56";
                    _Infor.label8.Text = "70";
                    _Infor.pictureBox1.Image = pictureBox3.Image;
                    _Infor.Show();
            }
            #endregion
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label12.Text;
                    _Infor.label7.Text = "52";
                    _Infor.label8.Text = "71";
                    _Infor.pictureBox1.Image = pictureBox4.Image;
                    _Infor.Show();
                }
            }
            else
            {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label12.Text;
                    _Infor.label7.Text = "52";
                    _Infor.label8.Text = "71";
                    _Infor.pictureBox1.Image = pictureBox4.Image;
                    _Infor.Show();
            }
            #endregion
        }

        private void label12_Click(object sender, EventArgs e) //옷 사진과 가격 끝
        {
            #region 
            Pay pay = new Pay();

            if (Login_button.Text == "Login")
            {
                DialogResult result = MessageBox.Show("현재 비회원 상태입니다.\n비회원으로 주문하시겠습니까?", "알림", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label12.Text;
                    _Infor.label7.Text = "52";
                    _Infor.label8.Text = "71";
                    _Infor.pictureBox1.Image = pictureBox4.Image;
                    _Infor.Show();
                }
            }
            else
            {
                    Product_infor _Infor = new Product_infor(this);
                    _Infor.label1.Text = label12.Text;
                    _Infor.label7.Text = "52";
                    _Infor.label8.Text = "71";
                    _Infor.pictureBox1.Image = pictureBox4.Image;
                    _Infor.Show();
            }
            #endregion
        }
        #endregion // 옷 사진 가격 클릭 결제 창

        private void Main_Load(object sender, EventArgs e)
        {
            Connection();
        }
    }
}
