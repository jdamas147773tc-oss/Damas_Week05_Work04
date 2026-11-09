using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Damas_Week05_Work04
{
    public partial class ProductForm : Form
    {
        private readonly List<Product> products = new List<Product>();
        private readonly List<string> usedBarcodes = new List<string>();

        private ErrorProvider errorProvider = new ErrorProvider();
        private Label lblBarcodeStatus = new Label();

        public ProductForm()
        {
            InitializeComponent();
            SetupExtras();
        }

        private void SetupExtras()
        {
            errorProvider.ContainerControl = this;

            lblBarcodeStatus.AutoSize = true;
            lblBarcodeStatus.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblBarcodeStatus.Text = "";
            lblBarcodeStatus.Location = new Point(txtBarcode.Left, txtBarcode.Bottom + 2);
            Controls.Add(lblBarcodeStatus);

            lblCost.Text = "Cost";
            lblPrice.Text = "Price (auto)";
            lblMarkup.Text = "Markup (%)";

            txtBarcode.MaxLength = 13;
            txtName.MaxLength = 50;
            txtDescription.Multiline = true;
            txtPrice.ReadOnly = true;
            txtPrice.TabStop = false;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbCategory.Items.AddRange(new object[]
            {
                "Beverages", "Snacks", "Bakery", "Canned Goods", "Household", "Others"
            });

            txtBarcode.TextChanged += txtBarcode_TextChanged;
            txtBarcode.KeyPress += DigitsOnly_KeyPress;
            txtCost.KeyPress += DecimalOnly_KeyPress;
            txtMarkup.KeyPress += DecimalOnly_KeyPress;
            txtCost.TextChanged += PriceInputs_TextChanged;
            txtMarkup.TextChanged += PriceInputs_TextChanged;
            btnSave.Click += btnSave_Click;
            btnClear.Click += btnClear_Click;
            btnCancel.Click += btnCancel_Click;

            AcceptButton = btnSave;

            ClearForm();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            string code = txtBarcode.Text.Trim();

            if (code.Length == 0)
            {
                lblBarcodeStatus.Text = "";
            }
            else if (code.Length < 8)
            {
                lblBarcodeStatus.ForeColor = Color.DimGray;
                lblBarcodeStatus.Text = "Barcode must be 8 to 13 digits.";
            }
            else if (usedBarcodes.Contains(code))
            {
                lblBarcodeStatus.ForeColor = Color.Firebrick;
                lblBarcodeStatus.Text = "Barcode is already in use.";
            }
            else
            {
                lblBarcodeStatus.ForeColor = Color.SeaGreen;
                lblBarcodeStatus.Text = "Barcode is available.";
            }
        }

        private void DigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DecimalOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.' && !box.Text.Contains("."))
            {
                return;
            }
            e.Handled = true;
        }

        private void PriceInputs_TextChanged(object sender, EventArgs e)
        {
            decimal cost, markup;

            bool costOk = decimal.TryParse(txtCost.Text, NumberStyles.Number,
                                           CultureInfo.InvariantCulture, out cost);
            bool markupOk = decimal.TryParse(txtMarkup.Text, NumberStyles.Number,
                                             CultureInfo.InvariantCulture, out markup);

            if (costOk && markupOk)
            {
                decimal price = cost + (cost * markup / 100m);
                txtPrice.Text = price.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                txtPrice.Text = "";
            }
        }

        private bool ValidateForm()
        {
            errorProvider.Clear();
            bool isValid = true;
            Control firstBad = null;

            string code = txtBarcode.Text.Trim();
            if (code.Length < 8 || code.Length > 13)
            {
                MarkError(txtBarcode, "Barcode must be 8 to 13 digits.", ref isValid, ref firstBad);
            }
            else if (usedBarcodes.Contains(code))
            {
                MarkError(txtBarcode, "This barcode is already in use.", ref isValid, ref firstBad);
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MarkError(txtName, "Name is required.", ref isValid, ref firstBad);
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MarkError(cmbCategory, "Please choose a category.", ref isValid, ref firstBad);
            }

            if (!rbLocal.Checked && !rbAbroad.Checked)
            {
                MarkError(gbManufactured, "Please choose Local or Abroad.", ref isValid, ref firstBad);
            }

            decimal cost;
            if (!decimal.TryParse(txtCost.Text, NumberStyles.Number,
                                  CultureInfo.InvariantCulture, out cost) || cost <= 0)
            {
                MarkError(txtCost, "Enter a cost greater than 0.", ref isValid, ref firstBad);
            }

            decimal markup;
            if (!decimal.TryParse(txtMarkup.Text, NumberStyles.Number,
                                  CultureInfo.InvariantCulture, out markup) || markup < 0 || markup > 1000)
            {
                MarkError(txtMarkup, "Enter a markup from 0 to 1000.", ref isValid, ref firstBad);
            }

            if (firstBad != null)
            {
                firstBad.Focus();
            }
            return isValid;
        }

        private void MarkError(Control box, string message, ref bool isValid, ref Control firstBad)
        {
            errorProvider.SetError(box, message);
            isValid = false;
            if (firstBad == null)
            {
                firstBad = box;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            Product p = new Product
            {
                Barcode = txtBarcode.Text.Trim(),
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Origin = rbLocal.Checked ? "Local" : "Abroad",
                IsActive = cbStatus.Checked,
                Cost = decimal.Parse(txtCost.Text, CultureInfo.InvariantCulture),
                MarkupPercent = decimal.Parse(txtMarkup.Text, CultureInfo.InvariantCulture),
                Price = decimal.Parse(txtPrice.Text, CultureInfo.InvariantCulture)
            };

            products.Add(p);
            usedBarcodes.Add(p.Barcode);

            ClearForm();

            Hide();

            ProductListForm list = new ProductListForm(products);
            list.ShowDialog();

            Show();
            txtBarcode.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (HasData())
            {
                DialogResult answer = MessageBox.Show(
                    "Discard this product and close the form?", "Cancel",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }
            }
            Close();
        }

        private bool HasData()
        {
            return txtBarcode.Text.Length > 0 || txtName.Text.Length > 0 ||
                   txtDescription.Text.Length > 0 || txtCost.Text.Length > 0 ||
                   txtMarkup.Text.Length > 0 || cmbCategory.SelectedIndex != -1;
        }

        private void ClearForm()
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtCost.Clear();
            txtMarkup.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1;
            rbLocal.Checked = true;
            cbStatus.Checked = true;
            lblBarcodeStatus.Text = "";
            errorProvider.Clear();
            txtBarcode.Focus();
        }
    }
}