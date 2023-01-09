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
    public partial class ViewLeaves : Form
    {
        Functions Con;
        public ViewLeaves()
        {
            InitializeComponent();
            Con  = new Functions();
            EmpIdLb.Text = Login.EmpId + "";
            EmpNameLb.Text = Login.EmpFName;
            ShowLeaves();
        }

        private void ShowLeaves()
        {
            string Query = "select * from LeaveDetails where Employee = {0}";
            Query = string.Format(Query, Login.EmpId);
            LeavesList.DataSource = Con.GetData(Query);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
