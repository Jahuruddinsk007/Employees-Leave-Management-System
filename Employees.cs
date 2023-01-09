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
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmployees();
        }

        private void ShowEmployees()
        {
            string Query = "select * from EmployeeRecord";
            EmployeesList.DataSource = Con.GetData(Query);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(EmpFName.Text == "" || EmpLName.Text == "" || EmpEmail.Text == "" || EmpPhone.Text == "" || EmpDept.Text == "" || EmpRManager.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter Requred Details!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string FName = EmpFName.Text;
                    string LName = EmpLName.Text;
                    string Email = EmpEmail.Text;
                    string Phone = EmpPhone.Text;
                    string Dept = EmpDept.Text;
                    string RManager = EmpRManager.SelectedItem.ToString();
                    

                    string Query = "insert into EmployeeRecord values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, FName,LName,Email,Phone,Dept,RManager);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Inserted Successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmpFName.Text = "";
                    EmpLName.Text = "";
                    EmpEmail.Text = "";
                    EmpPhone.Text = "";
                    EmpDept.Text = "";
                    EmpRManager.Text = "";


                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int key = 0;
        private void EmployeesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EmpFName.Text = EmployeesList.SelectedRows[0].Cells[1].Value.ToString();
                EmpLName.Text = EmployeesList.SelectedRows[0].Cells[2].Value.ToString();
                EmpEmail.Text = EmployeesList.SelectedRows[0].Cells[3].Value.ToString();
                EmpPhone.Text = EmployeesList.SelectedRows[0].Cells[4].Value.ToString();
                EmpDept.Text = EmployeesList.SelectedRows[0].Cells[5].Value.ToString();
                EmpRManager.Text = EmployeesList.SelectedRows[0].Cells[6].Value.ToString();
                if (EmpFName.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(EmployeesList.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpFName.Text == "" || EmpLName.Text == "" || EmpEmail.Text == "" || EmpPhone.Text == "" || EmpDept.Text == "" || EmpRManager.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter Requred Details!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string FName = EmpFName.Text;
                    string LName = EmpLName.Text;
                    string Email = EmpEmail.Text;
                    string Phone = EmpPhone.Text;
                    string Dept = EmpDept.Text;
                    string RManager = EmpRManager.SelectedItem.ToString();


                    string Query = "update EmployeeRecord set EmpFName = '{0}', EmpLName = '{1}', EmpEmail = '{2}', EmpPhone = '{3}', EmpDept = '{4}', EmpRManager = '{5}' where EmpId = {6}";
                    Query = string.Format(Query, FName, LName, Email, Phone, Dept, RManager, key);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Updated Successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmpFName.Text = "";
                    EmpLName.Text = "";
                    EmpEmail.Text = "";
                    EmpPhone.Text = "";
                    EmpDept.Text = "";
                    EmpRManager.Text = "";

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
                if (EmpFName.Text == "" || EmpLName.Text == "" || EmpEmail.Text == "" || EmpPhone.Text == "" || EmpDept.Text == "" || EmpRManager.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter Requred Details!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    


                    string Query = "delete from EmployeeRecord where EmpId = {0}";
                    Query = string.Format(Query,key);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Deleted Successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmpFName.Text = "";
                    EmpLName.Text = "";
                    EmpEmail.Text = "";
                    EmpPhone.Text = "";
                    EmpDept.Text = "";
                    EmpRManager.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void CategoryLb_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void LeaveLb_Click(object sender, EventArgs e)
        {
            Leaves Obj = new Leaves();
            Obj.Show();
            this.Hide();
        }
    }
}
