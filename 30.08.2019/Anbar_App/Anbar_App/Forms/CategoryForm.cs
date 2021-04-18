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
    public partial class CategoryForm : Form
    {
        ProductForm mainProduct = new ProductForm();
        List<Category> categories;
        int SelectIndex = -1;
        public CategoryForm(List<Category> cat)
        {
            InitializeComponent();
            categories = cat;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GenerateCategories();
        }

        private void BtnCatSave_Click(object sender, EventArgs e)
        {
            if (SelectIndex == -1)
            {
                string TxtCatName = txtCatName.Text.Trim();
                if (!string.IsNullOrEmpty(TxtCatName))
                {
                    Category cat = new Category();
                    cat.Name = mainProduct.FirstCharToUpper(TxtCatName);
                    categories.Add(cat);
                    GenerateCategories();
                }
                else { MessageBox.Show("Please, fill in all fields"); }
            }
            else
            {
                categories[SelectIndex].Name = txtCatName.Text;
                GenerateCategories();
            }
        }

        private void GenerateCategories()
        {
            ResetCatForm();
            listCategory.Items.Clear();
            for (var i = 0; i < categories.Count; i++)
            {
                listCategory.Items.Add(i + 1 + ". " + categories[i].Name);
            }
        }


        private void ResetCatForm()
        {
            btnCatDelete.Enabled = false;
            SelectIndex = -1;
            btnCatSave.Text = "Save";
            txtCatName.Text = "";
        }

        private void ListCategory_DoubleClick(object sender, EventArgs e)
        {
            if (categories.Count <= 0)
            {
                MessageBox.Show("Category List is Empty");
                return;
            }
            SelectIndex = listCategory.SelectedIndex;

            if (SelectIndex >= 0)
            {
                btnCatDelete.Enabled = true;
                btnCatSave.Text = "Edit";
                txtCatName.Text = categories[SelectIndex].Name;
            }
        }

        private void BtnCatDelete_Click(object sender, EventArgs e)
        {
            categories.RemoveAt(SelectIndex);
            GenerateCategories();
        }
    }
}
