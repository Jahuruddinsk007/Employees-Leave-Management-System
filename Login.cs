using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class Login : Form
    {
        Functions Con;
        public Login()
        {
            InitializeComponent();
            Con = new Functions();
        }
        public static int EmpId;
        public static string EmpFName;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Please Enter Requred Details!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UNameTb.Text == "Admin" && PasswordTb.Text == "password")
                {
                    Employees Obj = new Employees();    
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    try
                    {
                        string Query = "select * from EmployeeRecord where EmpFName = '{0}' and EmpLName = '{1}'";
                        Query = string.Format(Query, UNameTb.Text, PasswordTb.Text);
                        DataTable dt = Con.GetData(Query);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Incorrect Password!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            UNameTb.Text = "";
                            PasswordTb.Text = "";
                        }
                        else
                        {
                            EmpId = Convert.ToInt32(dt.Rows[0][0].ToString());
                            EmpFName = dt.Rows[0][1].ToString();
                            ViewLeaves VObj = new ViewLeaves();
                            VObj.Show();
                            this.Hide();
                        }
                    }
                    catch(Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }


                }
            }
        }

        private void ClosedLb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
