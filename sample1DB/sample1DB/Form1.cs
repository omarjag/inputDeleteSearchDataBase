using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace sample1DB
{
	public partial class Form1 : Form
	{
		//Makes connection to Local Database
		SqlConnection c = new SqlConnection(/*YOUR LOCALDB PATH */);
		public Form1()
		{
			InitializeComponent();
		}
		//Calls function displayData() upon first opening the program
		private void Form1_Load(object sender, EventArgs e)
		{
			displayData();
		}
		//Insert
		private void button1_Click(object sender, EventArgs e)
		{
			c.Open();
			SqlCommand cmd = c.CreateCommand();
			cmd.CommandType = CommandType.Text;

			if (fNametxtBox.Text == "")
			{
				MessageBox.Show("Please Enter First Name", "Error");
				fNametxtBox.Focus();
			}
			else if (lNametxtBox.Text == "")
			{
				MessageBox.Show("Please Enter Last Name", "Error");
				lNametxtBox.Focus();
			}
			else if (stateTxtBox.Text == "")
			{
				MessageBox.Show("Please Enter State", "Error");
				stateTxtBox.Focus();
			}
			else
			{
				cmd.CommandText = "insert into table1 values('" + fNametxtBox.Text + "','" + lNametxtBox.Text + "','" + stateTxtBox.Text + "')";
				cmd.ExecuteNonQuery();
				MessageBox.Show(fNametxtBox.Text + " " + lNametxtBox.Text + " Has been added");
				fNametxtBox.Clear();
				lNametxtBox.Clear();
				stateTxtBox.Clear();
				fNametxtBox.Focus();
			}
			
			c.Close();
			displayData();

		}
		// A function that will open the connection to the Local Database, Select all from our table, and Load it into a DataGridView
		public void displayData()
		{
			c.Open();
			SqlCommand cmd = c.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from table1";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			c.Close();

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		//Delete
		private void button2_Click(object sender, EventArgs e)
		{
			c.Open();
			SqlCommand cmd = c.CreateCommand();
			cmd.CommandType = CommandType.Text;
			if (fNametxtBox.Text == "")
			{
				MessageBox.Show("Please Enter First Name", "Error");
				fNametxtBox.Focus();
			}
			else if(lNametxtBox.Text == "")
			{
				MessageBox.Show("Please Enter Last Name", "Error");
				lNametxtBox.Focus();
			}
			else if(stateTxtBox.Text == "")
			{
				MessageBox.Show("Please Enter State", "Error");
				stateTxtBox.Focus();
			}
			else
			{
				cmd.CommandText = "delete from table1 where FirstName='" + fNametxtBox.Text + "'" + "AND LastName='" + lNametxtBox.Text + "'" + "AND State='" + stateTxtBox.Text + "'";

				cmd.ExecuteNonQuery();
				fNametxtBox.Clear();
				lNametxtBox.Clear();
				stateTxtBox.Clear();
			}
			c.Close();
			displayData();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		
		//Search
		private void button5_Click(object sender, EventArgs e)
		{
			c.Open();
			SqlCommand cmd = c.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from table1 where FirstName='"+fNametxtBox.Text+"'" + "OR LastName='" + lNametxtBox.Text + "'" + "OR State='" + stateTxtBox.Text + "'";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			c.Close();
			fNametxtBox.Clear();
			lNametxtBox.Clear();
			stateTxtBox.Clear();

		}

		//Display
		private void button4_Click(object sender, EventArgs e)
		{
			displayData();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
