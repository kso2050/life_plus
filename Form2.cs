using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace youtube_db
{
	public partial class Form2 : Form
	{
		string Conn = "Server=localhost;Database=youtube;Uid=root;Pwd=0330;";
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""|| textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
			{
				MessageBox.Show("내용을 입력해주세요.");
			}
			else
			{
				//DB에 데이터 삽입
				using (MySqlConnection conn = new MySqlConnection(Conn))
				{
					conn.Open();
					MySqlCommand msc = new MySqlCommand("insert into user(UId, UPw, UName, USex, UPhone, UAge, UBirth) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', " + textBox6.Text + ", '" + textBox7.Text + "')", conn);
					int result = msc.ExecuteNonQuery();

					if (result == 1)
					{
						MessageBox.Show("가입이 완료되었습니다!");
						this.Dispose();
						new Form4().ShowDialog();
					}
				}
			}
		}	
	}
}
