﻿using System;
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
    public partial class AddStudent : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public AddStudent()
        {
            InitializeComponent();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lynette\\source\\repos\\MwalimuApplication\\DataStudent.accdb; Persist Security Info=False";
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into StudentDetails ([AdmissionNumber],[StudentName],[Age],[Dorm]) values('" + materialSingleLineTextField1.Text + "','" + materialSingleLineTextField2.Text + "','" + materialSingleLineTextField3.Text + "','" + materialSingleLineTextField4.Text + "')";

                command.ExecuteNonQuery();
                
                connection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
