using Anbar_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anbar_App.Forms
{
    public partial class EmployeeForm : Form
    {
        ProductForm mainProduct = new ProductForm();
        List<Employee> employees;
        int selecetIndex = -1;
        public EmployeeForm(List<Employee> empl)
        {
            InitializeComponent();
            employees = empl;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            GenerateEmployees();
        }

        private void BtnEmpSave_Click(object sender, EventArgs e)
        {
            if (selecetIndex == -1)
            {
                string TxtEmpFname = txtEmpFname.Text.Trim();
                string TxtEmpLname = txtEmpLname.Text.Trim();
                string TxtEmpPos = txtEmpPos.Text.Trim();
                if (!string.IsNullOrEmpty(TxtEmpFname) && !string.IsNullOrEmpty(TxtEmpLname) && !string.IsNullOrEmpty(TxtEmpPos))
                {
                    Employee employee = new Employee();
                    employee.Firstname = mainProduct.FirstCharToUpper(TxtEmpFname);
                    employee.Lastname = mainProduct.FirstCharToUpper(TxtEmpLname);
                    employee.Position = mainProduct.FirstCharToUpper(TxtEmpPos);
                    employees.Add(employee);
                    GenerateEmployees();
                }
                else { MessageBox.Show("Please, fill in all fields"); }
            }
            else
            {
                employees[selecetIndex].Firstname = txtEmpFname.Text;
                employees[selecetIndex].Lastname = txtEmpLname.Text;
                employees[selecetIndex].Position = txtEmpPos.Text;
                GenerateEmployees();
            }
        }
        private void GenerateEmployees()
        {
            ResetEmpForm();
            dgvEmployee.Rows.Clear();
            foreach (Employee emp in employees)
            {
                dgvEmployee.Rows.Add(emp.Firstname, emp.Lastname, emp.Position);
            }
        }

        private void ResetEmpForm()
        {
            btnEmpDelete.Enabled = false;
            selecetIndex = -1;
            btnEmpSave.Text = "Save";
            txtEmpFname.Text = "";
            txtEmpLname.Text = "";
            txtEmpPos.Text = "";
        }

        private void DgvEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (employees.Count <= 0)
            {
                MessageBox.Show("Employeer List is Empty");
                return;
            }
            selecetIndex = dgvEmployee.SelectedRows[0].Index;
            if (selecetIndex >= 0)
            {
                btnEmpDelete.Enabled = true;
                btnEmpSave.Text = "Edit";
                txtEmpFname.Text = employees[selecetIndex].Firstname;
                txtEmpLname.Text = employees[selecetIndex].Lastname;
                txtEmpPos.Text = employees[selecetIndex].Position;
            }
        }

        private void BtnEmpDelete_Click(object sender, EventArgs e)
        {
            employees.RemoveAt(selecetIndex);
            GenerateEmployees();
        }
    }
}
