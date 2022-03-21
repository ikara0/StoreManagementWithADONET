namespace BilgeAdam.ADONET.LoginPage
{
    partial class frmProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cmsProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTotalProductCount = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbPageCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.msProducts = new System.Windows.Forms.MenuStrip();
            this.msOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.msAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cmsProduct.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.msProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ContextMenuStrip = this.cmsProduct;
            this.dgvProducts.Location = new System.Drawing.Point(12, 97);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(725, 422);
            this.dgvProducts.TabIndex = 0;
            // 
            // cmsProduct
            // 
            this.cmsProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDelete,
            this.cmsEdit});
            this.cmsProduct.Name = "cmsProduct";
            this.cmsProduct.Size = new System.Drawing.Size(108, 48);
            this.cmsProduct.Text = "Delete";
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(180, 22);
            this.cmsDelete.Text = "Delete";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(180, 22);
            this.cmsEdit.Text = "Edit";
            this.cmsEdit.Click += new System.EventHandler(this.cmsEdit_Click);
            // 
            // txtTotalProductCount
            // 
            this.txtTotalProductCount.Location = new System.Drawing.Point(95, 536);
            this.txtTotalProductCount.Name = "txtTotalProductCount";
            this.txtTotalProductCount.Size = new System.Drawing.Size(71, 23);
            this.txtTotalProductCount.TabIndex = 1;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(583, 532);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(63, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(661, 532);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cmbPageCount
            // 
            this.cmbPageCount.FormattingEnabled = true;
            this.cmbPageCount.Items.AddRange(new object[] {
            "15",
            "20",
            "25"});
            this.cmbPageCount.Location = new System.Drawing.Point(513, 532);
            this.cmbPageCount.Name = "cmbPageCount";
            this.cmbPageCount.Size = new System.Drawing.Size(53, 23);
            this.cmbPageCount.TabIndex = 3;
            this.cmbPageCount.SelectedIndexChanged += new System.EventHandler(this.cmbPageCount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Count";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Controls.Add(this.cmbSuppliers);
            this.grpFilter.Controls.Add(this.cmbCategories);
            this.grpFilter.Location = new System.Drawing.Point(12, 46);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(725, 42);
            this.grpFilter.TabIndex = 5;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filtre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Suppliers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categories";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(450, 11);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(216, 23);
            this.cmbSuppliers.TabIndex = 3;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(83, 13);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(216, 23);
            this.cmbCategories.TabIndex = 3;
            // 
            // msProducts
            // 
            this.msProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msOptions});
            this.msProducts.Location = new System.Drawing.Point(0, 0);
            this.msProducts.Name = "msProducts";
            this.msProducts.Size = new System.Drawing.Size(751, 24);
            this.msProducts.TabIndex = 6;
            this.msProducts.Text = "menuStrip1";
            // 
            // msOptions
            // 
            this.msOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAddProduct});
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(61, 20);
            this.msOptions.Text = "Options";
            // 
            // msAddProduct
            // 
            this.msAddProduct.Name = "msAddProduct";
            this.msAddProduct.Size = new System.Drawing.Size(180, 22);
            this.msAddProduct.Text = "Add Product";
            this.msAddProduct.Click += new System.EventHandler(this.msAddProduct_Click);
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 577);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPageCount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtTotalProductCount);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.msProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msProducts;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cmsProduct.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.msProducts.ResumeLayout(false);
            this.msProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProducts;
        private TextBox txtTotalProductCount;
        private Button btnPrevious;
        private Button btnNext;
        private ComboBox cmbPageCount;
        private Label label1;
        private Label label2;
        private GroupBox grpFilter;
        private Label label4;
        private Label label3;
        private ComboBox cmbSuppliers;
        private ComboBox cmbCategories;
        private MenuStrip msProducts;
        private ToolStripMenuItem msOptions;
        private ToolStripMenuItem msAddProduct;
        private ContextMenuStrip cmsProduct;
        private ToolStripMenuItem cmsDelete;
        private ToolStripMenuItem cmsEdit;
    }
}