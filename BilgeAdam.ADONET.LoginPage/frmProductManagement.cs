using BilgeAdam.ADONET.LoginPage.Extensions;
using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Concretes;
using BilgeAdam.Data.Dtos;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmProductManagement : Form
    {
        private IProductService service;
        private int totalCount;
        private BindingList<ProductDto> products;
        private List<ComboBoxItemDto> categories;
        private List<ComboBoxItemDto> suppliers;
        public int TotalCount
        {
            get { return totalCount; }
            set
            {
                totalCount = value;
                txtTotalProductCount.Text = totalCount.ToString();

            }
        }

        private int pageIndex;
        public int PageIndex
        {
            get { return pageIndex; }
            set { pageIndex = value > 0 ? value : 0; }
        }

        public int PageSize
        {
            get
            {
                var selectedNumber = cmbPageCount.SelectedItem;
                if (selectedNumber == null)
                {
                    return Convert.ToInt32(cmbPageCount.Items[0]);
                }
                return Convert.ToInt32(selectedNumber);
            }

        }

        private int supplierID;
        private int categoryID;

        public frmProductManagement()
        {
            InitializeComponent();
            service = new ProductService();
            products = new BindingList<ProductDto>();
            cmbPageCount.SelectedIndex = 0;
            dgvProducts.DataSource = products;

            categories = new List<ComboBoxItemDto>();
            suppliers = new List<ComboBoxItemDto>();

        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadComboBoxItem();
            cmbSuppliers.SelectedIndex = 0;
            cmbCategories.SelectedIndex= 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PageIndex--;
            LoadProducts();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            PageIndex++;
            LoadProducts();
        }
        private void cmbPageCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }


        private void cmsDelete_Click(object sender, EventArgs e)
        {
            var product = (int)dgvProducts.CurrentRow.Cells[0].Value;

            var result = service.DeleteProduct(product);

            if (result)
            {
                MessageBox.Show("Product Deleted", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Product could not be Deleted", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            this.Switch(new frmEditProduct());
            this.Show();
        }

        private void msAddProduct_Click(object sender, EventArgs e)
        {
            this.Switch(new frmAddProduct(service));
            this.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCategories.SelectedIndex = 0;
            cmbSuppliers.SelectedIndex = 0;
            supplierID = 0;
            categoryID = 0; 
            LoadProducts();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex == 0)
            {
                return;
            }

            categoryID = GetCategoryID();
            var query = FilterQuery();
            products.Clear();
            service.GetFilterData(query, MapperProduct);

        }

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedIndex == 0)
            {
                return;
            }
            supplierID = GetSupplierID();
            var query = FilterQuery();
            products.Clear();
            service.GetFilterData(query, MapperProduct);
        }

        #region HelperMethods
        private void MapperProduct(SqlDataReader reader)
        {
            products.Add(new ProductDto
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Category = reader.GetString(4),
                Company = reader.GetString(5),

                Price = reader["Price"] != null ? Convert.ToDecimal(reader["Price"]) : null,
                Stock = reader["Stock"] != null ? Convert.ToInt32(reader["Stock"]) : null

            });
        }
        private void LoadProducts()
        {
            products.Clear();
            TotalCount = service.GetTotalCount();
            service.GetProductByOffSet(PageIndex, PageSize, MapperProduct);
        }
        private void LoadComboBoxItem()
        {
            suppliers.Clear();  
            categories.Clear();


            suppliers = service.GetSuppliers();
            categories = service.GetCategories();
            cmbSuppliers.Items.Insert(0, "Please select any value");
            cmbCategories.Items.Insert(0, "Please select any value");

            foreach (var item in suppliers)
            {
                cmbSuppliers.Items.Add(item.Name);
            }
            foreach (var item in categories)
            {
                cmbCategories.Items.Add(item.Name);
            }
        }

        private int GetCategoryID()
        {

            var flag = true;
            while (flag)
            {
                foreach (var item in categories)
                {
                    if (item.Name == cmbCategories.Text)
                    {
                        return item.ID;
                    }
                }
            }
            return 0;
        }
        private int GetSupplierID()
        {
            var flag = true;
            while (flag)
            {
                foreach (var item in suppliers)
                {
                    if (item.Name == cmbSuppliers.Text)
                    {
                        return item.ID;
                    }
                } 
            }
            return 0;
        }
        private string FilterQuery()
        {
            if(categoryID <= 0 && supplierID <= 0)
            {
                return string.Empty;
            }
            PageIndex = 0;

            var filterQuery = new StringBuilder();
            var filter = new List<string>();

            if (categoryID > 0)
            {
                filter.Add($"c.CategoryID = {categoryID}");
            }
            if(supplierID > 0)
            {
                filter.Add($"s.SupplierID = {supplierID}");
            }
            filterQuery.Append(" WHERE ");
            filterQuery.Append(string.Join(" AND ", filter));
            return filterQuery.ToString();
        }
        #endregion




        
    }
}
