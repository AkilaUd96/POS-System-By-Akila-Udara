
namespace POS_System_By_Akila_Udara.ProductsF
{
    partial class DefineProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineProductScreen));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ProductName = new MetroFramework.Controls.MetroTextBox();
            this.productCategoryCombo = new MetroFramework.Controls.MetroComboBox();
            this.ProductSupplierCombo = new MetroFramework.Controls.MetroComboBox();
            this.SalesPriceText = new MetroFramework.Controls.MetroTextBox();
            this.PurchasePricetext = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DefineNewButton = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SelectAllSize = new System.Windows.Forms.Button();
            this.Deselect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(646, 131);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Product Name";
            // 
            // ProductName
            // 
            // 
            // 
            // 
            this.ProductName.CustomButton.Image = null;
            this.ProductName.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.ProductName.CustomButton.Name = "";
            this.ProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductName.CustomButton.TabIndex = 1;
            this.ProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductName.CustomButton.UseSelectable = true;
            this.ProductName.CustomButton.Visible = false;
            this.ProductName.Lines = new string[0];
            this.ProductName.Location = new System.Drawing.Point(405, 128);
            this.ProductName.MaxLength = 32767;
            this.ProductName.Name = "ProductName";
            this.ProductName.PasswordChar = '\0';
            this.ProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductName.SelectedText = "";
            this.ProductName.SelectionLength = 0;
            this.ProductName.SelectionStart = 0;
            this.ProductName.ShortcutsEnabled = true;
            this.ProductName.Size = new System.Drawing.Size(207, 23);
            this.ProductName.TabIndex = 0;
            this.ProductName.UseSelectable = true;
            this.ProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ProductName.Click += new System.EventHandler(this.ProductName_Click);
            // 
            // productCategoryCombo
            // 
            this.productCategoryCombo.FormattingEnabled = true;
            this.productCategoryCombo.ItemHeight = 23;
            this.productCategoryCombo.Location = new System.Drawing.Point(405, 157);
            this.productCategoryCombo.Name = "productCategoryCombo";
            this.productCategoryCombo.Size = new System.Drawing.Size(207, 29);
            this.productCategoryCombo.TabIndex = 1;
            this.productCategoryCombo.UseSelectable = true;
            // 
            // ProductSupplierCombo
            // 
            this.ProductSupplierCombo.FormattingEnabled = true;
            this.ProductSupplierCombo.ItemHeight = 23;
            this.ProductSupplierCombo.Location = new System.Drawing.Point(405, 192);
            this.ProductSupplierCombo.Name = "ProductSupplierCombo";
            this.ProductSupplierCombo.Size = new System.Drawing.Size(207, 29);
            this.ProductSupplierCombo.TabIndex = 2;
            this.ProductSupplierCombo.UseSelectable = true;
            this.ProductSupplierCombo.SelectedIndexChanged += new System.EventHandler(this.ProductSupplierCombo_SelectedIndexChanged);
            // 
            // SalesPriceText
            // 
            // 
            // 
            // 
            this.SalesPriceText.CustomButton.Image = null;
            this.SalesPriceText.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.SalesPriceText.CustomButton.Name = "";
            this.SalesPriceText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SalesPriceText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SalesPriceText.CustomButton.TabIndex = 1;
            this.SalesPriceText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SalesPriceText.CustomButton.UseSelectable = true;
            this.SalesPriceText.CustomButton.Visible = false;
            this.SalesPriceText.Lines = new string[0];
            this.SalesPriceText.Location = new System.Drawing.Point(405, 256);
            this.SalesPriceText.MaxLength = 32767;
            this.SalesPriceText.Name = "SalesPriceText";
            this.SalesPriceText.PasswordChar = '\0';
            this.SalesPriceText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SalesPriceText.SelectedText = "";
            this.SalesPriceText.SelectionLength = 0;
            this.SalesPriceText.SelectionStart = 0;
            this.SalesPriceText.ShortcutsEnabled = true;
            this.SalesPriceText.Size = new System.Drawing.Size(207, 23);
            this.SalesPriceText.TabIndex = 4;
            this.SalesPriceText.UseSelectable = true;
            this.SalesPriceText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SalesPriceText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PurchasePricetext
            // 
            // 
            // 
            // 
            this.PurchasePricetext.CustomButton.Image = null;
            this.PurchasePricetext.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.PurchasePricetext.CustomButton.Name = "";
            this.PurchasePricetext.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PurchasePricetext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PurchasePricetext.CustomButton.TabIndex = 1;
            this.PurchasePricetext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PurchasePricetext.CustomButton.UseSelectable = true;
            this.PurchasePricetext.CustomButton.Visible = false;
            this.PurchasePricetext.Lines = new string[0];
            this.PurchasePricetext.Location = new System.Drawing.Point(405, 227);
            this.PurchasePricetext.MaxLength = 32767;
            this.PurchasePricetext.Name = "PurchasePricetext";
            this.PurchasePricetext.PasswordChar = '\0';
            this.PurchasePricetext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PurchasePricetext.SelectedText = "";
            this.PurchasePricetext.SelectionLength = 0;
            this.PurchasePricetext.SelectionStart = 0;
            this.PurchasePricetext.ShortcutsEnabled = true;
            this.PurchasePricetext.Size = new System.Drawing.Size(207, 23);
            this.PurchasePricetext.TabIndex = 3;
            this.PurchasePricetext.UseSelectable = true;
            this.PurchasePricetext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PurchasePricetext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(671, 258);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Sales Price";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(646, 227);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Purchase price";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(633, 196);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Product Supplier";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(626, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(117, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Product Category";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Save.Location = new System.Drawing.Point(490, 316);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(195, 37);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseCustomBackColor = true;
            this.Save.UseSelectable = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Exit.Location = new System.Drawing.Point(490, 369);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(195, 37);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Close";
            this.Exit.UseCustomBackColor = true;
            this.Exit.UseSelectable = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // DefineNewButton
            // 
            this.DefineNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.DefineNewButton.Location = new System.Drawing.Point(107, 369);
            this.DefineNewButton.Name = "DefineNewButton";
            this.DefineNewButton.Size = new System.Drawing.Size(210, 37);
            this.DefineNewButton.TabIndex = 8;
            this.DefineNewButton.Text = "Define New";
            this.DefineNewButton.UseCustomBackColor = true;
            this.DefineNewButton.UseSelectable = true;
            this.DefineNewButton.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(210, 225);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(107, 94);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(137, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Select Product Size";
            // 
            // SelectAllSize
            // 
            this.SelectAllSize.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SelectAllSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAllSize.Location = new System.Drawing.Point(71, 128);
            this.SelectAllSize.Name = "SelectAllSize";
            this.SelectAllSize.Size = new System.Drawing.Size(30, 20);
            this.SelectAllSize.TabIndex = 12;
            this.SelectAllSize.Text = "S";
            this.SelectAllSize.UseVisualStyleBackColor = false;
            // 
            // Deselect
            // 
            this.Deselect.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Deselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deselect.Location = new System.Drawing.Point(71, 156);
            this.Deselect.Name = "Deselect";
            this.Deselect.Size = new System.Drawing.Size(30, 20);
            this.Deselect.TabIndex = 13;
            this.Deselect.Text = "D";
            this.Deselect.UseVisualStyleBackColor = false;
            // 
            // DefineProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 463);
            this.Controls.Add(this.Deselect);
            this.Controls.Add(this.SelectAllSize);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DefineNewButton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.PurchasePricetext);
            this.Controls.Add(this.SalesPriceText);
            this.Controls.Add(this.ProductSupplierCombo);
            this.Controls.Add(this.productCategoryCombo);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefineProductScreen";
            this.Text = "Product Definition";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DefineProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox ProductName;
        private MetroFramework.Controls.MetroComboBox productCategoryCombo;
        private MetroFramework.Controls.MetroComboBox ProductSupplierCombo;
        private MetroFramework.Controls.MetroTextBox SalesPriceText;
        private MetroFramework.Controls.MetroTextBox PurchasePricetext;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton Save;
        private MetroFramework.Controls.MetroButton Exit;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroButton DefineNewButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Button SelectAllSize;
        private System.Windows.Forms.Button Deselect;
    }
}