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
	
	public partial class Form9 : Form
	{
		string Conn = "Server=localhost;Database=youtube;Uid=root;Pwd=0330;";
		public Form9()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox1.Text == "" )
			{
				MessageBox.Show("입력되지 않았습니다.");
			}
			else
			{

				using (MySqlConnection conn = new MySqlConnection(Conn))
				{
					conn.Open();
					MySqlCommand msc = new MySqlCommand("insert into purchase(PNum, PName, PWriter, PSell) values('" + textBox12.Text + "', '" + textBox13.Text + "', '" + textBox14.Text + "', " + textBox1.Text + ")", conn);
					int result = msc.ExecuteNonQuery();

					if (result == 1)
					{
						MessageBox.Show("구매되었습니다!");
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "SELECT * FROM store";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "store");

				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["SNum"].ToString();

					//두번째부터는 이렇게 작성
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SName"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SWriter"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SGroup"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SGrade"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SPrice"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SSale"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SSell"].ToString());
				
					listView1.Items.Add(lvi);

				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "SELECT * FROM purchase";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "purchase");

				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["PName"].ToString();

					//두번째부터는 이렇게 작성
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PWriter"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PSell"].ToString());

					listView2.Items.Add(lvi);

				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
		}

		private void 검색하기_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "select * from store where SGrade >= " + textBox4.Text + ";";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "store");

				//받아온 결과를 리스트뷰2에 출력
				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["SNum"].ToString();
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SName"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SWriter"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SGroup"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SGrade"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SSale"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SSell"].ToString());
					listView1.Items.Add(lvi);
				}
			}
		}
	}
}
