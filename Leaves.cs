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
    public partial class Leaves : Form
    {
        Functions Con;
        public Leaves()
        {
            InitializeComponent();
            Con = new Functions();
            ShowLeaves();
            GetEmployees();
            GetCategories();
        }
        private void ShowLeaves()
        {
            string Query = "select * from LeaveDetails";
            LeavesList.DataSource = Con.GetData(Query);
        }
        private void FilterLeaves()
        {
            string Query = "select * from LeaveDetails where Status = '{0}'";
            Query = string.Format(Query,SearchCb.SelectedItem.ToString());
            LeavesList.DataSource = Con.GetData(Query);
        }
        public void GetEmployees()
        {
            string Query = "select * from EmployeeRecord";
            EmpCb.DisplayMember = Con.GetData(Query).Columns["EmpFName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = Con.GetData(Query);
        }
        public void GetCategories()
        {
            string Query = "select * from CategoryDetails";
            CatCb.DisplayMember = Con.GetData(Query).Columns["CatName"].ToString();
            CatCb.ValueMember = Con.GetData(Query).Columns["CatId"].ToString();
            CatCb.DataSource = Con.GetData(Query);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(EmpCb.SelectedIndex == -1 || CatCb.SelectedIndex == -1 || StatusTb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter Requred Details!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int Emp = Convert.ToInt32(EmpCb.SelectedValue.ToString());
                    int Category = Convert.ToInt32(CatCb.SelectedValue.ToString());
                    string DateStart = StartDateTp.Value.Date.ToString("yyyy-MM-dd");
                    string DateEnd = EndDateTp.Value.Date.ToString("yyyy-MM-dd");
                    string DateApplied = DateTime.Today.ToString("yyyy-MM-dd");
                    //string Status = StatusTb.SelectedItem.ToString(); 
                    String Status = "Pending";

                    

                    string Query = "insert into LeaveDetails values({0},{1},'{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query,Emp,Category,DateStart,DateEnd,DateApplied,Status);
                    Con.SetData(Query);
                    ShowLeaves();
                    MessageBox.Show("Leave Applied Successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void LeavesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpCb.Text = LeavesList.SelectedRows[0].Cells[1].Value.ToString();
            CatCb.Text = LeavesList.SelectedRows[0].Cells[2].Value.ToString();
            StartDateTp.Text = LeavesList.SelectedRows[0].Cells[3].Value.ToString();
            EndDateTp.Text = LeavesList.SelectedRows[0].Cells[4].Value.ToString();
            StatusTb.Text = LeavesList.SelectedRows[0].Cells[6].Value.ToString();
            

            if (EmpCb.SelectedIndex == -1)
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(LeavesList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || CatCb.SelectedIndex == -1 || StatusTb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter Requred Details!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int Emp = Convert.ToInt32(EmpCb.SelectedValue.ToString());
                    int Category = Convert.ToInt32(CatCb.SelectedValue.ToString());
                    string DateStart = StartDateTp.Value.Date.ToString("yyyy-MM-dd");
                    string DateEnd = EndDateTp.Value.Date.ToString("yyyy-MM-dd");
                    string DateApplied = DateTime.Today.ToString("yyyy-MM-dd");
                    string Status = StatusTb.SelectedItem.ToString(); 
                    //String Status = "Pending";

                    string Query = "update LeaveDetails set Employee = {0}, Category = {1}, DateStart = '{2}', DateEnd = '{3}', Status = '{4}' where LId = {5}";
                    Query = string.Format(Query, Emp, Category, DateStart, DateEnd, Status,key);
                    Con.SetData(Query);
                    ShowLeaves();
                    MessageBox.Show("Leave Updated Successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || CatCb.SelectedIndex == -1 || StatusTb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter Requred Details!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string Query = "delete from LeaveDetails where LId = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowLeaves();
                    MessageBox.Show("Leave deleted Successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ShowLeaves();
        }

        private void SearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterLeaves();
        }

        private void EmployeesLb_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void CategoryLb_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void LogoutLb_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
