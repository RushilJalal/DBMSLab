using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace databaseconnection
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ConnectDB()
        {
            conn = new OracleConnection("Data Source=localhost:1521;Persist Security Info=True;User ID=system;Password=1234");
            conn.Open();
            MessageBox.Show("Connected");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB();
                OracleCommand command2 = conn.CreateCommand();
                command2.CommandText = "INSERT INTO std (regno, name, depname, address) VALUES (:regno, :name, :depname, :address)";
                command2.Parameters.Add("regno", OracleDbType.Varchar2).Value = textBox1.Text;
                command2.Parameters.Add("name", OracleDbType.Varchar2).Value = textBox2.Text;
                command2.Parameters.Add("depname", OracleDbType.Varchar2).Value = textBox3.Text;
                command2.Parameters.Add("address", OracleDbType.Varchar2).Value = textBox4.Text;

                int rowsAffected = command2.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully!");
                }
                else
                {
                    MessageBox.Show("Error inserting data.");
                }

                command2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB();
                OracleCommand command2 = conn.CreateCommand();
                command2.CommandText = "update std set name=(:name), depname=(:depname), address=(:address) where regno=(:regno)";
                command2.Parameters.Add("regno", OracleDbType.Varchar2).Value = textBox1.Text;
                command2.Parameters.Add("name", OracleDbType.Varchar2).Value = textBox2.Text;
                command2.Parameters.Add("depname", OracleDbType.Varchar2).Value = textBox3.Text;
                command2.Parameters.Add("address", OracleDbType.Varchar2).Value = textBox4.Text;
                int rowsAffected = command2.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data updated successfully!");
                }
                else
                {
                    MessageBox.Show("Error updating data.");
                }

                command2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB();
                OracleCommand command2 = conn.CreateCommand();
                command2.CommandText = "delete from std where regno=(:regno)";
                command2.Parameters.Add("regno", OracleDbType.Varchar2).Value = textBox1.Text;

                int rowsAffected = command2.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Error deleted data.");
                }

                command2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConnectDB();
            using (OracleCommand cmd = new OracleCommand("Select * from std", conn))
            {
                using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
