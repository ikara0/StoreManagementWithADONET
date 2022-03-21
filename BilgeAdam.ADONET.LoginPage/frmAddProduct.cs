using BilgeAdam.Data.Abstractions;
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
        private readonly IProductService service;
        public frmAddProduct(IProductService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            //TODO : will develop
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO : will develop
        }
    }
}
