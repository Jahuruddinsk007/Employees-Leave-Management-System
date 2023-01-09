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
    public partial class Categories : Form
    {
        Functions Con;
        public Categories()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCategories();
            
        }

        private void ShowCategories()
        {
            string Query = "select * from CategoryDetails";
            CategoriesList.DataSource = Con.GetData(Query);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatNameTb.Text == "")
                {
                    MessageBox.Show("Please Enter Requred Details!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string Category = CatNameTb.Text;
                    string Query = "insert into CategoryDetails values('{0}')";
                    Query = string.Format(Query, Category);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Inserted Successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CatNameTb.Text = "";

                }
            }
            catch(Exception Ex) 
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int key;
        private void CategoriesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CatNameTb.Text = CategoriesList.SelectedRows[0].Cells[1].Value.ToString();
                if (CatNameTb.Text == " ")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(CategoriesList.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Text == "")
                {
                    MessageBox.Show("Please Enter Requred Details!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string Category = CatNameTb.Text;
                    string Query = "update CategoryDetails set CatName = '{0}' where CatId = {1}";
                    Query = string.Format(Query, Category, key);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Updated Successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CatNameTb.Text = "";

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
                if (key == 0)
                {
                    MessageBox.Show("Please Enter Requred Details!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string Category = CatNameTb.Text;
                    string Query = "delete from CategoryDetails where CatId = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Deleted Successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CatNameTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmployeesLb_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void LeavesLb_Click(object sender, EventArgs e)
        {
            Leaves Obj = new Leaves();
            Obj.Show();
            this.Hide();
        }
    }
}
