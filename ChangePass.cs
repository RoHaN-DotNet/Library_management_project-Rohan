using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management_project
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U9T38U9\SQLEXPRESS;Initial Catalog=Library_Management_system;Integrated Security=True");

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string update_query = "update LOG_IN set U_Password='" + NewPassTB.Text + "' where U_Name='" + UserNameTB.Text + "' and U_Password='" + CurrentPassTB.Text + "'";
        SqlCommand CP=new SqlCommand(update_query, con);
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                int result = CP.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Password Changed Successfully", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Password Change Failed", "Failed", MessageBoxButtons.OK);
                }
            }



        }
    }
}
