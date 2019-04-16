using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MwalimuApplication
{
    
    public partial class EditStudentData : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public EditStudentData()
        {
            InitializeComponent();
            
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lynette\\source\\repos\\MwalimuApplication\\DataStudent.accdb; Persist Security Info=False";
        }
        private void EditStudentData_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from StudentDetails";
            command.CommandText = query;

            OleDbDataReader reader= command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["AdmissionNumber"].ToString());
            }
            bunifuCustomLabel1.Text = "Data edited successfully";
            connection.Close();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update StudentDetails set [AdmissionNumber]='" + materialSingleLineTextField1.Text + "', [StudentName]='" + materialSingleLineTextField4.Text + "',[Age]='" + materialSingleLineTextField3.Text + "',[Dorm]='" + materialSingleLineTextField2.Text + "' where [AdmissionNumber]='" + materialSingleLineTextField1.Text + "')";
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show(query);
                bunifuCustomLabel1.Text = "Data edited successfully";
                connection.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from StudentDetails where [AdmissionNumber]='"+comboBox1.Text+"'";
            command.CommandText = query;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                materialSingleLineTextField1.Text= reader["AdmissionNumber"].ToString();
                materialSingleLineTextField4.Text=reader["StudentName"].ToString();
                materialSingleLineTextField3.Text= reader["Age"].ToString();
                materialSingleLineTextField2.Text= reader["Dorm"].ToString();
            }
            bunifuCustomLabel1.Text = "Data edited successfully";
            connection.Close();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from StudentDetails where [AdmissionNumber]='" + materialSingleLineTextField1.Text + "'";
                command.CommandText = query;

                command.ExecuteNonQuery();
               
                bunifuCustomLabel1.Text = "Data deleted successfully";
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void BunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {

        }
    }
}
