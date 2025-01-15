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
namespace Library_management_project
{
    public partial class CreateAccountPage : Form
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source=DESKTOP-U9T38U9\SQLEXPRESS;Initial Catalog=Library_Management_system;Integrated Security=True");

        private void CreateNewAccBtn_Click(object sender, EventArgs e)
        {
           
            string insert_qurey = "insert into LOG_IN values('" + GiveUserName.Text + "','"+GivePassword.Text+"','"+GiveRole.Text +"', '0' )";
            
            if(GiveUserName.Text == "" || GivePassword.Text == "" || GiveRole.Text == "")
            {
                MessageBox.Show("Please Fill All Fields", "Failed", MessageBoxButtons.OK);
                return;

            }
            if(GiveUserName.Text==GiveUserName.Text)
            {

                MessageBox.Show("User Name Already Taken","Failed", MessageBoxButtons.OK);
               
            }

             SqlCommand CNA=new SqlCommand(insert_qurey, con);

            
           
            if(con.State == ConnectionState.Closed)
            { 
                con.Open();

            }
           
            if(con.State == ConnectionState.Open)
            { 
                int result=CNA.ExecuteNonQuery();
                 if (result > 0)
                 {
                MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK);
                 }
                 else
                 {
                MessageBox.Show("Account Creation Failed", "Failed", MessageBoxButtons.OK);
                 }
            }
            else
            {
                MessageBox.Show("Connection Failed", "Failed", MessageBoxButtons.OK);
            }

        }
    }
}
