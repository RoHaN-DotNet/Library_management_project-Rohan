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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
     
        private void CreateNewAccBtn_Click(object sender, EventArgs e)
        {
            CreateAccountPage cap= new CreateAccountPage();
            cap.Show();

           
        } 
        
private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass();
            cp.Show();

        }
    }
}
