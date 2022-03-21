using BilgeAdam.ADONET.LoginPage.Extensions;
using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Concretes;
using BilgeAdam.Data.Dtos;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmProductManagement : Form
    {
        private IProductService service;
        private int totalCount;
        private BindingList<ProductDto> products;
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

        public frmProductManagement()
        {
            InitializeComponent();
            service = new ProductService();
            products = new BindingList<ProductDto>();
            cmbPageCount.SelectedIndex = 0;
            dgvProducts.DataSource = products;
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            products.Clear();
            TotalCount = service.GetTotalCount();
            service.GetProductByOffSet(PageIndex, PageSize, MapperProduct);
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
            //TODO : will develop
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


        #endregion


    }
}
