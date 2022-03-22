using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Concretes;
using BilgeAdam.Data.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmAddProduct : Form
    {
        private IProductService service;
        public frmAddProduct(IProductService service)
        {
            InitializeComponent();
            
            this.service = service;

        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            var categories = service.GetCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = nameof(ComboBoxItemDto.Name);
            var suppliers = service.GetSuppliers();
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = nameof(ComboBoxItemDto.Name);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            eerPr1.Clear();
            if (txtProductName.Text== String.Empty)
            {
                eerPr1.SetError(txtProductName, "Untitled product cannot be created!");
                return;
            }

            var selectedCategory = cmbCategory.SelectedItem as ComboBoxItemDto;
            var selectedSupplier = cmbSupplier.SelectedItem as ComboBoxItemDto;

            var productDto = new NewProductDto
            {
                Name = txtProductName.Text,
                UnitPrice = nudPrice.Value,
                UnitsInStock  = (int)nudUnitsInStock.Value,
                CategoryID = selectedCategory.ID,
                SupplierID = selectedSupplier.ID
            };

            var createProduct = service.CreateProduct(productDto);
            if (createProduct)
            {
                MessageBox.Show("Product Added :)", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Product could not be Added :)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        
    }
}
