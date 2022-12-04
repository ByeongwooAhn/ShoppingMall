using MySql.Data.MySqlClient;
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
    public partial class My_Infor : Form
    {
        int change = 0;
        Main main;
        string connstr = "Server = 127.0.0.1;Port=3306;Database=member;Uid=root;Pwd=root";

        public My_Infor(Main M)
        {
            InitializeComponent();
            main = M;
        }

        public void Member_Load()
        {
            string sql = "select 아이디, 비밀번호, 주소, 핸드폰 from member_name where 아이디 = '" + main.Login_button.Text + "'";
            using(MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    textBox1.Text = reader["아이디"].ToString();
                    textBox2.Text = reader["비밀번호"].ToString();
                    textBox3.Text = reader["주소"].ToString();
                    textBox4.Text = reader["핸드폰"].ToString();
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void My_Infor_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Member_Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            change = 1;
        }
    }
}
