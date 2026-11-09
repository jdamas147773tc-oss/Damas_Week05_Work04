using System.Xml.Linq;

namespace Damas_Week05_Work04
{
    partial class ProductForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBarcode = new Label();
            lblName = new Label();
            txtBarcode = new TextBox();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblCategory = new Label();
            lblOrigin = new Label();
            gbManufactured = new GroupBox();
            rbAbroad = new RadioButton();
            rbLocal = new RadioButton();
            cmbCategory = new ComboBox();
            lblCost = new Label();
            txtCost = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            txtMarkup = new TextBox();
            lblMarkup = new Label();
            btnCancel = new Button();
            btnClear = new Button();
            btnSave = new Button();
            lblStatus = new Label();
            cbStatus = new CheckBox();
            gbManufactured.SuspendLayout();
            SuspendLayout();
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(88, 44);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(64, 20);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "Barcode";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(88, 112);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(185, 44);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(277, 27);
            txtBarcode.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(277, 27);
            txtName.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(88, 157);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(185, 154);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(277, 79);
            txtDescription.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(88, 254);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // lblOrigin
            // 
            lblOrigin.AutoSize = true;
            lblOrigin.Location = new Point(88, 306);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(50, 20);
            lblOrigin.TabIndex = 8;
            lblOrigin.Text = "Origin";
            // 
            // gbManufactured
            // 
            gbManufactured.Controls.Add(rbAbroad);
            gbManufactured.Controls.Add(rbLocal);
            gbManufactured.Location = new Point(185, 304);
            gbManufactured.Name = "gbManufactured";
            gbManufactured.Size = new Size(250, 96);
            gbManufactured.TabIndex = 9;
            gbManufactured.TabStop = false;
            gbManufactured.Text = "Manufactured";
            // 
            // rbAbroad
            // 
            rbAbroad.AutoSize = true;
            rbAbroad.Location = new Point(148, 44);
            rbAbroad.Name = "rbAbroad";
            rbAbroad.Size = new Size(80, 24);
            rbAbroad.TabIndex = 1;
            rbAbroad.TabStop = true;
            rbAbroad.Text = "Abroad";
            rbAbroad.UseVisualStyleBackColor = true;
            // 
            // rbLocal
            // 
            rbLocal.AutoSize = true;
            rbLocal.Location = new Point(26, 44);
            rbLocal.Name = "rbLocal";
            rbLocal.Size = new Size(65, 24);
            rbLocal.TabIndex = 0;
            rbLocal.TabStop = true;
            rbLocal.Text = "Local";
            rbLocal.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(185, 251);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(277, 28);
            cmbCategory.TabIndex = 10;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(104, 479);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(38, 20);
            lblCost.TabIndex = 11;
            lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(104, 515);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(106, 27);
            txtCost.TabIndex = 12;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(254, 479);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 20);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "Cost";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(254, 515);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(106, 27);
            txtPrice.TabIndex = 14;
            // 
            // txtMarkup
            // 
            txtMarkup.Location = new Point(411, 515);
            txtMarkup.Name = "txtMarkup";
            txtMarkup.Size = new Size(106, 27);
            txtMarkup.TabIndex = 15;
            // 
            // lblMarkup
            // 
            lblMarkup.AutoSize = true;
            lblMarkup.Location = new Point(413, 479);
            lblMarkup.Name = "lblMarkup";
            lblMarkup.Size = new Size(81, 20);
            lblMarkup.TabIndex = 16;
            lblMarkup.Text = "Markup(%)";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(104, 561);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 44);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(230, 561);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 44);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(411, 561);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 44);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(102, 429);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(193, 431);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(72, 24);
            cbStatus.TabIndex = 21;
            cbStatus.Text = "Active";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 641);
            Controls.Add(cbStatus);
            Controls.Add(lblStatus);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(lblMarkup);
            Controls.Add(txtMarkup);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtCost);
            Controls.Add(lblCost);
            Controls.Add(cmbCategory);
            Controls.Add(gbManufactured);
            Controls.Add(lblOrigin);
            Controls.Add(lblCategory);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(txtBarcode);
            Controls.Add(lblName);
            Controls.Add(lblBarcode);
            Name = "ProductForm";
            Text = "ProductForm";
            gbManufactured.ResumeLayout(false);
            gbManufactured.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBarcode;
        private Label lblName;
        private TextBox txtBarcode;
        private TextBox txtName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblCategory;
        private Label lblOrigin;
        private GroupBox gbManufactured;
        private RadioButton rbLocal;
        private RadioButton rbAbroad;
        private ComboBox cmbCategory;
        private Label lblCost;
        private TextBox txtCost;
        private Label lblPrice;
        private TextBox txtPrice;
        private TextBox txtMarkup;
        private Label lblMarkup;
        private Button btnCancel;
        private Button btnClear;
        private Button btnSave;
        private Label lblStatus;
        private CheckBox cbStatus;
    }
}
