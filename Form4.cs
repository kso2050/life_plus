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
	public partial class Form4 : Form
	{
		string Conn = "Server=localhost;Database=youtube;Uid=root;Pwd=0330;";
		public Form4()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "SELECT * FROM creator";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "creator");

				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["CName"].ToString();

					//두번째부터는 이렇게 작성
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["CId"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["CNum"].ToString());


					listView1.Items.Add(lvi);

				}
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "SELECT * FROM book";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "book");

				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["BName"].ToString();

					//두번째부터는 이렇게 작성
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BWriter"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BGroup"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BPublish"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BGrade"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BPrice"].ToString());

					listView4.Items.Add(lvi);

				}
			}
		}



		

		private void button5_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "SELECT * FROM music";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "music");

				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["MNum"].ToString();

					//두번째부터는 이렇게 작성
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["MName"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["MArtist"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["MAlbum"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["MDate"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["MGroup"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["MWrite"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["MCompose"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["MArrange"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["MGrade"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["MPrice"].ToString());

					listView3.Items.Add(lvi);
				}
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			new Form8().ShowDialog();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			new Form9().ShowDialog();
		}

		//private void button4_Click(object sender, EventArgs e)
		//{
		//	listView2.Items.Clear();
		//}

		private void button9_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
		}


		private void button10_Click(object sender, EventArgs e)
		{
			listView3.Items.Clear();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			listView4.Items.Clear();
		}

		private void button10_Click_1(object sender, EventArgs e)
		{
			new Form10().ShowDialog();
		}

		private void button11_Click_1(object sender, EventArgs e)
		{
			new Form11().ShowDialog();
		}

		private void 검색하기_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "select * from creator where CNum >= " + textBox4.Text + ";";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "creator");

				//받아온 결과를 리스트뷰2에 출력
				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["CName"].ToString();
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["CId"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["CNum"].ToString());
					


					listView1.Items.Add(lvi);
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "SELECT * FROM sub";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "sub");

				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["SName"].ToString();

					//두번째부터는 이렇게 작성
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SId"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["SNum"].ToString());
				
					listView2.Items.Add(lvi);

				}
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			listView2.Items.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
			{
				MessageBox.Show("입력되지 않았습니다.");
			}
			else
			{

				using (MySqlConnection conn = new MySqlConnection(Conn))
				{
					conn.Open();
					MySqlCommand msc = new MySqlCommand("insert into sub( SName, SId,SNum) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "'+1)", conn);
					int result = msc.ExecuteNonQuery();

					if (result == 1)
					{
						MessageBox.Show("구독되었습니다!");
					}
				}
			}
		}
	}
}
