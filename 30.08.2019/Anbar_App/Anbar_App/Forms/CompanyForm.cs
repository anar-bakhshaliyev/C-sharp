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
    public partial class CompanyForm : Form
    {
        ProductForm mainProduct = new ProductForm();
        List<Company> companies;
        int selectIndex = -1;
        public CompanyForm(List<Company> comp)
        {
            InitializeComponent();
            companies = comp;
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            GenerateCompanies();
        }

        private void BtnComSave_Click(object sender, EventArgs e)
        {
            if (selectIndex == -1)
            {
                string TxtComName = txtComName.Text.Trim();
                string TxtComPhone = txtComPhone.Text.Trim();
                string TxtComAdress = txtComAdress.Text.Trim();
                if (!string.IsNullOrEmpty(TxtComName) && !string.IsNullOrEmpty(TxtComPhone) && !string.IsNullOrEmpty(TxtComAdress))
                {
                    Company comp = new Company();
                    comp.Name = mainProduct.FirstCharToUpper(TxtComName);
                    comp.Phone = mainProduct.FirstCharToUpper(TxtComPhone);
                    comp.Adress = mainProduct.FirstCharToUpper(TxtComAdress);
                    companies.Add(comp);
                    GenerateCompanies();
                }
                else { MessageBox.Show("Please, fill in all fields"); }
            }
            else
            {
                companies[selectIndex].Name = txtComName.Text;
                companies[selectIndex].Phone = txtComPhone.Text;
                companies[selectIndex].Adress = txtComAdress.Text;
                GenerateCompanies();
            }
        }

        private void GenerateCompanies()
        {
            ResetCompForm();
            dgvCompany.Rows.Clear();
            for (int i = 0; i < companies.Count; i++)
            {
                dgvCompany.Rows.Add(companies[i].Name, companies[i].Phone, companies[i].Adress);
            }
        }

        private void ResetCompForm()
        {
            btnComDelete.Enabled = false;
            selectIndex = -1;
            btnComSave.Text = "Save";
            txtComName.Text = "";
            txtComPhone.Text = "";
            txtComAdress.Text = "";
        }

        private void DgvCompany_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (companies.Count <= 0)
            {
                MessageBox.Show("Company List is Empty");
                return;
            }
            selectIndex = dgvCompany.SelectedRows[0].Index;
            if (selectIndex >= 0)
            {
                btnComDelete.Enabled = true;
                btnComSave.Text = "Edit";
                txtComName.Text = companies[selectIndex].Name;
                txtComPhone.Text = companies[selectIndex].Phone;
                txtComAdress.Text = companies[selectIndex].Adress;
            }
        }

        private void BtnComDelete_Click(object sender, EventArgs e)
        {
            companies.RemoveAt(selectIndex);
            GenerateCompanies();
        }
    }
}
