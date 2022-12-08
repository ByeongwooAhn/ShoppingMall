using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string connstr = "Server = 127.0.0.1;Port=3306;Database=member;Uid=root;Pwd=root";
        int change1 = 0, change2 = 0, change3 = 0;

        public My_Infor()
        {
            InitializeComponent();

        }

        public Main main;

        public void Member_Load()
        {
                string sql = "select 아이디, 비밀번호, 주소, 핸드폰 from member_name where 아이디 = '" + main.Login_button.Text + "'";
                using (MySqlConnection conn = new MySqlConnection(connstr))
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

        public DataSet Order_Search()
        {
            string sql = "select 상품명 from member_pay where 아이디 = '" + main.Login_button.Text + "'";
            DataSet ds = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                    MessageBox.Show(ex.Message);
                }
            }
            return ds;
        }

        public void Order_Load()
        {
            DataSet ds;
            ds = Order_Search();

            int number = 0;

            using(MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach(DataRow row in ds.Tables[0].Rows)
                        {
                            number++;

                            Label labels = (Controls.Find("List" + number.ToString(), true)[0] as Label);
                            labels.Text = row["상품명"].ToString();

                            /*if(number == 1)
                            {
                                List1.Text = row["상품명"].ToString();
                            }
                            else if (number == 2)
                            {
                                List2.Text = row["상품명"].ToString();
                            }
                            else if (number == 3)
                            {
                                List3.Text = row["상품명"].ToString();
                            }
                            else if (number == 4)
                            {
                                List4.Text = row["상품명"].ToString();
                            }
                            else if (number == 5)
                            {
                                List5.Text = row["상품명"].ToString();
                            }
                            else if (number == 6)
                            {
                                List6.Text = row["상품명"].ToString();
                            }*/
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        public void Order1()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_pay where 아이디 = '" + main.Login_button.Text + "' and 상품명 = '" + List1.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label15.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label15.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order2()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_pay where 아이디 = '" + main.Login_button.Text + "' and 상품명 = '" + List2.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label15.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label15.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order3()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_pay where 아이디 = '" + main.Login_button.Text + "' and 상품명 = '" + List3.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label15.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label15.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order4()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_pay where 아이디 = '" + main.Login_button.Text + "' and 상품명 = '" + List4.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label15.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label15.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order5()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_pay where 아이디 = '" + main.Login_button.Text + "' and 상품명 = '" + List5.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label15.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label15.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order6()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_pay where 아이디 = '" + main.Login_button.Text + "' and 상품명 = '" + List6.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
 
                    label5.Text = reader["가격"].ToString();
                    label15.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label15.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Member_Pw_Update()
        {
            string sql = "update member_name set 비밀번호 = '" + textBox2.Text + "' where 아이디 = '" + main.Login_button.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Member_Address_Update()
        {
            string sql = "update member_name set 주소 = '" + textBox3.Text + "' where 아이디 = '" + main.Login_button.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Member_Phone_Update()
        {
            string sql = "update member_name set 핸드폰 = '" + textBox4.Text + "' where 아이디 = '" + main.Login_button.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Member_Update()
        {
            if (change1 == 1)
            {
                Member_Pw_Update();
                change1 = 0;
            }
            if (change2 == 1)
            {
                Member_Address_Update();
                change2 = 0;
            }
            if (change3 == 1)
            {
                Member_Phone_Update();
                change3 = 0;
            }
            MessageBox.Show("회원정보가 변경되었습니다.", "알림");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            change1 = 1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            change2 = 1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            change3 = 1;
        }

        private void My_Infor_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Member_Load();
            Order_Load();

            change1 = 0;
            change2 = 0;
            change3 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("회원정보를 변경 하시겠습니까?", "알림", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (change1 == 0 && change2 == 0 && change3 == 0)
                {
                    MessageBox.Show("변경할 회원정보가 없습니다.", "알림");
                }
                if (change1 == 1 || change2 == 1 || change3 == 1)
                {
                    Member_Update();
                }
            }
        }


        private void List1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Order1();
        }

        private void List2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Order2();
        }

        private void List3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Order3();
        }

        private void List4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Order4();
        }

        private void List5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Order5();
        }

        private void List6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Order6();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
