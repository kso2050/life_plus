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
	public partial class Form5 : Form
	{
		string Conn = "Server=localhost;Database=youtube;Uid=root;Pwd=0330;";

		public Form5()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
			{
				MessageBox.Show("내용이 입력되지 않았습니다.");
			}
			else
			{

				using (MySqlConnection conn = new MySqlConnection(Conn))
				{
					conn.Open();
					MySqlCommand msc = new MySqlCommand("insert into music(MNum, MName, MArtist, MAlbum, MDate, MGroup, MWrite, MCompose, MArrange, MGrade, MPrice) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" +textBox7.Text +"', '" +textBox8.Text +"', '" +textBox9.Text +"', " +textBox10.Text+ ", " +textBox11.Text+ ")", conn);
					int result = msc.ExecuteNonQuery();

					if (result == 1)
					{
						MessageBox.Show("추천되었습니다!");
					}
				}
			}
		}


		//BNum, BName, BGroup,BWriter, BPublish, BDate, BGrade,BPrice
		/*
		 *			lvi.SubItems.Add(ds.Tables[0].Rows[i]["BName"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BGroup"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BWriter"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BWriter"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BPublish"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BDate"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BGrade"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BPrice"].ToString());
		*/


		private void button2_Click(object sender, EventArgs e)
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

					listView1.Items.Add(lvi);

				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" )
			{
				MessageBox.Show("내용이 입력되지 않았습니다.");
			}
			else
			{

				using (MySqlConnection conn = new MySqlConnection(Conn))
				{
					conn.Open();
					MySqlCommand msc = new MySqlCommand("insert into book(BNum, BName, BGroup,BWriter, BPublish, BDate, BGrade,BPrice) values('" + textBox12.Text + "', '" + textBox13.Text + "', '" + textBox14.Text + "', '" + textBox15.Text + "', '" + textBox16.Text + "', '" + textBox17.Text + "', " + textBox18.Text + ", " + textBox19.Text + ")", conn);
					int result = msc.ExecuteNonQuery();

					if (result == 1)
					{
						MessageBox.Show("추천되었습니다!");
					}
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
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
					lvi.Text = ds.Tables[0].Rows[i]["BNum"].ToString();

					//두번째부터는 이렇게 작성
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BName"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BGroup"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BWriter"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BWriter"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BPublish"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BDate"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BGrade"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["BPrice"].ToString());

					listView2.Items.Add(lvi);

				}
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			listView2.Items.Clear();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			new Form10().ShowDialog();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			new Form11().ShowDialog();
		}
	}
}
