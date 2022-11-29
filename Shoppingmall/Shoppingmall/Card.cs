using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace Shoppingmall
{
    public partial class Card : Form
    {
        Pay pay;
        string connstr = "Server = 127.0.0.1;Port=3306;Database=member;Uid=root;Pwd=root";

        public Card(Pay P)
        {
            InitializeComponent();
            pay = P;
        }

        public void Card_infor()
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    if(radioButton1.Checked == true)
                    {
                        string sql = "update member_not set 은행 = '" + radioButton1.Text + "', 카드번호1 = '" + textBox1.Text + "', 카드번호2 = '" + textBox2.Text + "', 카드번호3 = '" + textBox3.Text + "', 카드번호4 = '" + textBox4.Text + "' where 받는_사람 = '" + pay.textBox1.Text + "' and 주소 = '" + pay.textBox2.Text + "' and 전화번호 = '" + pay.textBox3.Text + "' and 비밀번호 = '" + pay.textBox4.Text +"' and 결제방식 = '" + pay.Pay_Card.Text + "'";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                    else if(radioButton2.Checked == true)
                    {
                        string sql = "update member_not set 은행 = '" + radioButton2.Text + "', 카드번호1 = '" + textBox1.Text + "', 카드번호2 = '" + textBox2.Text + "', 카드번호3 = '" + textBox3.Text + "', 카드번호4 = '" + textBox4.Text + "' where 받는_사람 = '" + pay.textBox1.Text + "' and 주소 = '" + pay.textBox2.Text + "' and 전화번호 = '" + pay.textBox3.Text + "' and 비밀번호 = '" + pay.textBox4.Text + "' and 결제방식 = '" + pay.Pay_Card.Text + "'";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                    else if (radioButton3.Checked == true)
                    {
                        string sql = "update member_not set 은행 = '" + radioButton3.Text + "', 카드번호1 = '" + textBox1.Text + "', 카드번호2 = '" + textBox2.Text + "', 카드번호3 = '" + textBox3.Text + "', 카드번호4 = '" + textBox4.Text + "' where 받는_사람 = '" + pay.textBox1.Text + "' and 주소 = '" + pay.textBox2.Text + "' and 전화번호 = '" + pay.textBox3.Text + "' and 비밀번호 = '" + pay.textBox4.Text + "' and 결제방식 = '" + pay.Pay_Card.Text + "'";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                    else if (radioButton4.Checked == true)
                    {
                        string sql = "update member_not set 은행 = '" + radioButton4.Text + "', 카드번호1 = '" + textBox1.Text + "', 카드번호2 = '" + textBox2.Text + "', 카드번호3 = '" + textBox3.Text + "', 카드번호4 = '" + textBox4.Text + "' where 받는_사람 = '" + pay.textBox1.Text + "' and 주소 = '" + pay.textBox2.Text + "' and 전화번호 = '" + pay.textBox3.Text + "' and 비밀번호 = '" + pay.textBox4.Text + "' and 결제방식 = '" + pay.Pay_Card.Text + "'";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                    else if (radioButton5.Checked == true)
                    {
                        string sql = "update member_not set 은행 = '" + radioButton5.Text + "', 카드번호1 = '" + textBox1.Text + "', 카드번호2 = '" + textBox2.Text + "', 카드번호3 = '" + textBox3.Text + "', 카드번호4 = '" + textBox4.Text + "' where 받는_사람 = '" + pay.textBox1.Text + "' and 주소 = '" + pay.textBox2.Text + "' and 전화번호 = '" + pay.textBox3.Text + "' and 비밀번호 = '" + pay.textBox4.Text + "' and 결제방식 = '" + pay.Pay_Card.Text + "'";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                    else if (radioButton6.Checked == true)
                    {
                        string sql = "update member_not set 은행 = '" + radioButton6.Text + "', 카드번호1 = '" + textBox1.Text + "', 카드번호2 = '" + textBox2.Text + "', 카드번호3 = '" + textBox3.Text + "', 카드번호4 = '" + textBox4.Text + "' where 받는_사람 = '" + pay.textBox1.Text + "' and 주소 = '" + pay.textBox2.Text + "' and 전화번호 = '" + pay.textBox3.Text + "' and 비밀번호 = '" + pay.textBox4.Text + "' and 결제방식 = '" + pay.Pay_Card.Text + "'";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                    else if (radioButton7.Checked == true)
                    {
                        string sql = "update member_not set 은행 = '" + radioButton7.Text + "', 카드번호1 = '" + textBox1.Text + "', 카드번호2 = '" + textBox2.Text + "', 카드번호3 = '" + textBox3.Text + "', 카드번호4 = '" + textBox4.Text + "' where 받는_사람 = '" + pay.textBox1.Text + "' and 주소 = '" + pay.textBox2.Text + "' and 전화번호 = '" + pay.textBox3.Text + "' and 비밀번호 = '" + pay.textBox4.Text + "' and 결제방식 = '" + pay.Pay_Card.Text + "'";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                    else if (radioButton8.Checked == true)
                    {
                        string sql = "update member_not set 은행 = '" + radioButton8.Text + "', 카드번호1 = '" + textBox1.Text + "', 카드번호2 = '" + textBox2.Text + "', 카드번호3 = '" + textBox3.Text + "', 카드번호4 = '" + textBox4.Text + "' where 받는_사람 = '" + pay.textBox1.Text + "' and 주소 = '" + pay.textBox2.Text + "' and 전화번호 = '" + pay.textBox3.Text + "' and 비밀번호 = '" + pay.textBox4.Text + "' and 결제방식 = '" + pay.Pay_Card.Text + "'";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                    else if (radioButton9.Checked == true)
                    {
                        string sql = "update member_not set 은행 = '" + radioButton9.Text + "', 카드번호1 = '" + textBox1.Text + "', 카드번호2 = '" + textBox2.Text + "', 카드번호3 = '" + textBox3.Text + "', 카드번호4 = '" + textBox4.Text + "' where 받는_사람 = '" + pay.textBox1.Text + "' and 주소 = '" + pay.textBox2.Text + "' and 전화번호 = '" + pay.textBox3.Text + "' and 비밀번호 = '" + pay.textBox4.Text + "' and 결제방식 = '" + pay.Pay_Card.Text + "'";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Card_infor();
            Close();
            MessageBox.Show("결제가 완료되었습니다!");
            pay.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
