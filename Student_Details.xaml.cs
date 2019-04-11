using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace MwalimuApp
{
    /// <summary>
    /// Interaction logic for Student_Details.xaml
    /// </summary>
    public partial class Student_Details : Page
    {
        public Student_Details()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

             
            
            SqlConnection conDatabase = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lynette\\Documents\\StudentData.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*)from StudentData.StudentDetails where AdmissionNumber='" + this.txtbox1.TextProp + "', StudentName='" + this.txtbox2.TextProp + "', Age='" + this.txtbox3.TextProp + "' and Dorm='" + this.txtbox4.TextProp + "'", conDatabase);

            
            
            
           

        }
    }
}
