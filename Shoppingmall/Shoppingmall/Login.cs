using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace Shoppingmall
{
    public partial class Login : Form
    {
        Main main;
        string connstr = "Server = 127.0.0.1;Port=3306;Database=member;Uid=root;Pwd=root";

        public Login(Main M)
        {
            InitializeComponent();
            main = M;
        }

        public DataSet Search()
        {
            string sql = "select * from member_name where 아이디 = '" + ID.Text + "' and 비밀번호 = '" + PW.Text + "'";
            DataSet ds = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { }
            }

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {

                    {
                        conn.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                        da.Fill(ds);
                    }

                }
                catch (Exception ex)
                {

                }
            }
            return ds;
        }

        public DataSet Search_Not()
        {
            string sql = "select * from member_not where 이름 = '" + textBox6.Text + "' and 비밀번호 = '" + textBox5.Text + "'";
            DataSet ds = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { }
            }

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {

                    {
                        conn.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                        da.Fill(ds);
                    }

                }
                catch (Exception ex)
                {

                }
            }
            return ds;
        }

        private void Login_OK(string Id, string Pw)
        {
            DataSet ds;
            ds = Search();

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            if ((Id == row["아이디"].ToString()) && (Pw == row["비밀번호"].ToString()))
                            {
                                MessageBox.Show("로그인 되었습니다.", "알림");
                                main.Login_button.Text = ID.Text;
                                Close();
                            }
                        }
                    }
                    else
                    {
                        Login_Fail.Text = "아이디 또는 비밀번호를 확인해주세요.";
                    }
                }
                catch (Exception ex) { }
            }
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if(Login_tab.Visible == true)
            {
                Login_OK(ID.Text, PW.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e) //로그인
        {
            Login_tab.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e) //비회원
        {
            Login_tab.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Join_us _Form = new Join_us();
            _Form.Show();
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_OK(ID.Text, PW.Text);
            }
        }

        private void PW_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_OK(ID.Text, PW.Text);
            }
        }
    }
}
