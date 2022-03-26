using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Dtos;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmEditProduct : Form
    {
        private ProductDto product;
        private IProductService service;

        private List<ComboBoxItemDto> categories;
        private List<ComboBoxItemDto> suppliers;
        public frmEditProduct(ProductDto product, IProductService service)
        {
            InitializeComponent();
            this.product = product;

            categories = new List<ComboBoxItemDto>();
            suppliers = new List<ComboBoxItemDto>();
            this.service = service;
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            LoadComboBoxItem();
            txtProductName.Text = product.Name;
            nudPrice.Value = Convert.ToDecimal(product.Price);
            nudStock.Value = Convert.ToInt32(product.Stock);
            cmbCategory.SelectedItem = product.Category;
            cmbSupplier.SelectedItem = product.Company;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedCategory = cmbCategory.SelectedItem as ComboBoxItemDto;
            var selectedSupplier = cmbSupplier.SelectedValue as ComboBoxItemDto; 
            var product = new ProductDto
            {
                Name = txtProductName.Text,
                Stock = Convert.ToInt32(nudStock.Value),
                Price = nudPrice.Value,
                Company = selectedSupplier.Name,
                Category = selectedCategory.Name
            };


            var result = service.UpdateProduct(product,selectedCategory,selectedSupplier);
            if (result)
            {
                MessageBox.Show("Product has been Updated.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The product could not be Updated.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               
        }
        private void LoadComboBoxItem()
        {
            suppliers.Clear();
            categories.Clear();

            suppliers = service.GetSuppliers();
            categories = service.GetCategories();
            foreach (var item in suppliers)
            {
                cmbSupplier.Items.Add(item.Name);
            }
            foreach (var item in categories)
            {
                cmbCategory.Items.Add(item.Name);
            }
        }
    }
}
