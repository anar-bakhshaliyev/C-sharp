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
    public partial class ProductForm : Form
    {
        List<Category> categories;
        List<Company> companies;
        List<Employee> employees;
        List<Product> products;
        int selectIndex = -1;
        public ProductForm()
        {
            InitializeComponent();
            categories = new List<Category>();
            companies = new List<Company>();
            employees = new List<Employee>();
            products = new List<Product>();
        }

        // Using All Forms 
        public string FirstCharToUpper(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        

        // Product Form
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation in Form
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please, fill Name");
                return;
            }
            double textPrice;
            bool TextPrice = double.TryParse(txtPrice.Text.Trim(), out textPrice);
            if (TextPrice == false)
            {
                MessageBox.Show("Please, fill Price");
                return;
            }
            DateTime textProDate;
            bool TextProDate = DateTime.TryParse(txtproDate.Text.Trim(), out textProDate);
            if (TextProDate == false)
            {
                MessageBox.Show("Please, fill Production Date");
                return;
            }
            DateTime textExpDate;
            bool TextExpDate = DateTime.TryParse(txtexpDate.Text.Trim(), out textExpDate);
            if (TextExpDate == false)
            {
                MessageBox.Show("Please, fill Expiration Date");
                return;
            }

            int textQuantity;
            bool TextQuantity = int.TryParse(txtQuantity.Text.Trim(), out textQuantity);
            if (TextQuantity == false)
            {
                MessageBox.Show("Please, fill Quantity");
                return;
            }

            if (selectIndex == -1)
            {
                int sindexCat = cbxCategory.SelectedIndex;
                int sindexCom = cbxCompany.SelectedIndex;
                string TxtName = txtName.Text.Trim();
                double TxtPrice = textPrice;
                DateTime TxtproDate = textProDate;
                DateTime TxtexpDate = textExpDate;
                int TxtQuantity = textQuantity;
                if (!string.IsNullOrEmpty(TxtName) && !string.IsNullOrEmpty(TxtPrice.ToString()) && !string.IsNullOrEmpty(TxtproDate.ToString()) && !string.IsNullOrEmpty(TxtexpDate.ToString()) && !string.IsNullOrEmpty(TxtQuantity.ToString()) && !string.IsNullOrEmpty(cbxCategory.Text) && !string.IsNullOrEmpty(cbxCompany.Text))
                {
                    Product product = new Product();
                    product.Name = FirstCharToUpper(TxtName);
                    product.Price = TxtPrice;
                    product.ProductionDate = TxtproDate;
                    product.ExpirationDate = TxtexpDate;
                    product.Quantity = TxtQuantity;
                    product.Category = categories[sindexCat];
                    product.Company = companies[sindexCom];
                    products.Add(product);
                    GenerateProducts();
                }
                else { MessageBox.Show("Please, fill in all fields"); }
            }
            else
            {
                products[selectIndex].Name = txtName.Text;
                products[selectIndex].Price = double.Parse(txtPrice.Text.Trim());
                products[selectIndex].ProductionDate = DateTime.Parse(txtproDate.Text.Trim());
                products[selectIndex].ExpirationDate = DateTime.Parse(txtexpDate.Text.Trim());
                products[selectIndex].Quantity = int.Parse(txtQuantity.Text.Trim());
                products[selectIndex].Category = categories[cbxCategory.SelectedIndex];
                products[selectIndex].Company = companies[cbxCompany.SelectedIndex];
                GenerateProducts();
            }
        }

        // productions List added DateGrid
        private void GenerateProducts()
        {
            ResetProForm();
            dgvProduct.Rows.Clear();
            foreach (var prod in products)
            {
                dgvProduct.Rows.Add(prod.Name, prod.Price + " $", prod.ProductionDate.ToShortDateString(), prod.ExpirationDate.ToShortDateString(), prod.Quantity, prod.Category.Name, prod.Company.Name);
            }
        }

        private void ResetProForm()
        {
            btnDelete.Enabled = false;
            selectIndex = -1;
            btnSave.Text = "Save";
            txtName.Text = "";
            txtPrice.Text = "";
            txtproDate.Text = "";
            txtexpDate.Text = "";
            txtQuantity.Text = "";
            cbxCompany.Text = "";
            cbxCategory.Text = "";
        }

        // Edit information at lists
        private void DgvProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (products.Count <= 0)
            {
                MessageBox.Show("Product List is Empty");
                return;
            }
            selectIndex = dgvProduct.SelectedRows[0].Index;
            if (selectIndex >= 0)
            {
                btnDelete.Enabled = true;
                btnSave.Text = "Edit";
                txtName.Text = products[selectIndex].Name.ToString();
                txtPrice.Text = products[selectIndex].Price.ToString();
                txtproDate.Text = products[selectIndex].ProductionDate.ToString();
                txtexpDate.Text = products[selectIndex].ExpirationDate.ToString();
                txtQuantity.Text = products[selectIndex].Quantity.ToString();
                cbxCompany.Text = products[selectIndex].Company.Name;
                cbxCategory.Text = products[selectIndex].Category.Name;
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            products.RemoveAt(selectIndex);
            GenerateProducts();
        }

        // To Category Form
        private void categoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(categories);
            categoryForm.FormClosed += new FormClosedEventHandler(CmbxFillCategories);
            categoryForm.ShowDialog();
        }
        private void CmbxFillCategories(object sender, EventArgs e)
        {
            cbxCategory.Items.Clear();
            foreach (var item in categories)
            {
                cbxCategory.Items.Add(item.Name);
            }
        }

        // To Company Form
        private void companyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm(companies);
            companyForm.FormClosed += new FormClosedEventHandler(CmbxFillCompanies);
            companyForm.ShowDialog();
        }

        private void CmbxFillCompanies(object sender, EventArgs e)
        {
            cbxCompany.Items.Clear();
            foreach (Company item in companies)
            {
                cbxCompany.Items.Add(item.Name);
            }
        }


        // To Employee Form
        private void employeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(employees);
            employeeForm.ShowDialog();
        }

    }
}
