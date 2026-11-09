using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Damas_Week05_Work04
{
    public partial class ProductListForm : Form
    {
        public ProductListForm(List<Product> products)
        {
            InitializeComponent();

            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.DataSource = new BindingList<Product>(products);

            dgvProducts.Columns["IsActive"].HeaderText = "Active";
            dgvProducts.Columns["MarkupPercent"].HeaderText = "Markup (%)";

            btnReturn.Click += btnReturn_Click;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}