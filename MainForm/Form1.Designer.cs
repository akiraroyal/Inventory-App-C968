namespace MainForm
{
    partial class MainForm
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
            this.dvgParts = new System.Windows.Forms.DataGridView();
            this.dvgProducts = new System.Windows.Forms.DataGridView();
            this.MainAddBtn1 = new System.Windows.Forms.Button();
            this.MainModifyBtn1 = new System.Windows.Forms.Button();
            this.MainDeleteBtn1 = new System.Windows.Forms.Button();
            this.MainAddProductbtn = new System.Windows.Forms.Button();
            this.MainModifyBtn2 = new System.Windows.Forms.Button();
            this.MainDeleteBtn2 = new System.Windows.Forms.Button();
            this.searchProductsBtn = new System.Windows.Forms.Button();
            this.serachPartsBtn1 = new System.Windows.Forms.Button();
            this.txtPartSearch = new System.Windows.Forms.TextBox();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.MainPartsLabel = new System.Windows.Forms.Label();
            this.MainProductLabel = new System.Windows.Forms.Label();
            this.InventoryMangementSystemLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.dvgParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgParts
            // 
            this.dvgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgParts.Location = new System.Drawing.Point(-43, 181);
            this.dvgParts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgParts.MultiSelect = false;
            this.dvgParts.Name = "dvgParts";
            this.dvgParts.ReadOnly = true;
            this.dvgParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgParts.Size = new System.Drawing.Size(642, 331);
            this.dvgParts.TabIndex = 0;
            // 
            // dvgProducts
            // 
            this.dvgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProducts.Location = new System.Drawing.Point(605, 181);
            this.dvgProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgProducts.MultiSelect = false;
            this.dvgProducts.Name = "dvgProducts";
            this.dvgProducts.ReadOnly = true;
            this.dvgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProducts.Size = new System.Drawing.Size(612, 331);
            this.dvgProducts.TabIndex = 1;
            // 
            // MainAddBtn1
            // 
            this.MainAddBtn1.Location = new System.Drawing.Point(234, 552);
            this.MainAddBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainAddBtn1.Name = "MainAddBtn1";
            this.MainAddBtn1.Size = new System.Drawing.Size(75, 34);
            this.MainAddBtn1.TabIndex = 2;
            this.MainAddBtn1.Text = "Add";
            this.MainAddBtn1.UseVisualStyleBackColor = true;
            this.MainAddBtn1.Click += new System.EventHandler(this.MainAddBtn1_Click);
            // 
            // MainModifyBtn1
            // 
            this.MainModifyBtn1.Location = new System.Drawing.Point(315, 552);
            this.MainModifyBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainModifyBtn1.Name = "MainModifyBtn1";
            this.MainModifyBtn1.Size = new System.Drawing.Size(75, 34);
            this.MainModifyBtn1.TabIndex = 3;
            this.MainModifyBtn1.Text = "Modify";
            this.MainModifyBtn1.UseVisualStyleBackColor = true;
            this.MainModifyBtn1.Click += new System.EventHandler(this.MainModifyBtn1_Click);
            // 
            // MainDeleteBtn1
            // 
            this.MainDeleteBtn1.Location = new System.Drawing.Point(396, 552);
            this.MainDeleteBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainDeleteBtn1.Name = "MainDeleteBtn1";
            this.MainDeleteBtn1.Size = new System.Drawing.Size(75, 34);
            this.MainDeleteBtn1.TabIndex = 4;
            this.MainDeleteBtn1.Text = "Delete";
            this.MainDeleteBtn1.UseVisualStyleBackColor = true;
            this.MainDeleteBtn1.Click += new System.EventHandler(this.MainDeleteBtn1_Click);
            // 
            // MainAddProductbtn
            // 
            this.MainAddProductbtn.Location = new System.Drawing.Point(846, 552);
            this.MainAddProductbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainAddProductbtn.Name = "MainAddProductbtn";
            this.MainAddProductbtn.Size = new System.Drawing.Size(75, 34);
            this.MainAddProductbtn.TabIndex = 5;
            this.MainAddProductbtn.Text = "Add";
            this.MainAddProductbtn.UseVisualStyleBackColor = true;
            this.MainAddProductbtn.Click += new System.EventHandler(this.MainAddProductbtn_Click);
            // 
            // MainModifyBtn2
            // 
            this.MainModifyBtn2.Location = new System.Drawing.Point(940, 552);
            this.MainModifyBtn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainModifyBtn2.Name = "MainModifyBtn2";
            this.MainModifyBtn2.Size = new System.Drawing.Size(75, 34);
            this.MainModifyBtn2.TabIndex = 6;
            this.MainModifyBtn2.Text = "Modify";
            this.MainModifyBtn2.UseVisualStyleBackColor = true;
            this.MainModifyBtn2.Click += new System.EventHandler(this.MainModifyBtn2_Click);
            // 
            // MainDeleteBtn2
            // 
            this.MainDeleteBtn2.Location = new System.Drawing.Point(1037, 552);
            this.MainDeleteBtn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainDeleteBtn2.Name = "MainDeleteBtn2";
            this.MainDeleteBtn2.Size = new System.Drawing.Size(75, 34);
            this.MainDeleteBtn2.TabIndex = 7;
            this.MainDeleteBtn2.Text = "Delete";
            this.MainDeleteBtn2.UseVisualStyleBackColor = true;
            this.MainDeleteBtn2.Click += new System.EventHandler(this.MainDeleteBtn2_Click);
            // 
            // searchProductsBtn
            // 
            this.searchProductsBtn.Location = new System.Drawing.Point(709, 97);
            this.searchProductsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchProductsBtn.Name = "searchProductsBtn";
            this.searchProductsBtn.Size = new System.Drawing.Size(75, 34);
            this.searchProductsBtn.TabIndex = 9;
            this.searchProductsBtn.Text = "Search";
            this.searchProductsBtn.UseVisualStyleBackColor = true;
            this.searchProductsBtn.Click += new System.EventHandler(this.searchProductsBtn_Click);
            // 
            // serachPartsBtn1
            // 
            this.serachPartsBtn1.Location = new System.Drawing.Point(162, 94);
            this.serachPartsBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serachPartsBtn1.Name = "serachPartsBtn1";
            this.serachPartsBtn1.Size = new System.Drawing.Size(75, 34);
            this.serachPartsBtn1.TabIndex = 10;
            this.serachPartsBtn1.Text = "Search";
            this.serachPartsBtn1.UseVisualStyleBackColor = true;
            this.serachPartsBtn1.Click += new System.EventHandler(this.serachPartsBtn1_Click);
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.AcceptsReturn = true;
            this.txtPartSearch.AcceptsTab = true;
            this.txtPartSearch.Location = new System.Drawing.Point(243, 99);
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(228, 26);
            this.txtPartSearch.TabIndex = 13;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.AcceptsReturn = true;
            this.txtProductSearch.AcceptsTab = true;
            this.txtProductSearch.Location = new System.Drawing.Point(790, 102);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(212, 26);
            this.txtProductSearch.TabIndex = 14;
            // 
            // MainPartsLabel
            // 
            this.MainPartsLabel.AutoSize = true;
            this.MainPartsLabel.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPartsLabel.Location = new System.Drawing.Point(23, 132);
            this.MainPartsLabel.Name = "MainPartsLabel";
            this.MainPartsLabel.Size = new System.Drawing.Size(52, 28);
            this.MainPartsLabel.TabIndex = 15;
            this.MainPartsLabel.Text = "Parts";
            // 
            // MainProductLabel
            // 
            this.MainProductLabel.AutoSize = true;
            this.MainProductLabel.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainProductLabel.Location = new System.Drawing.Point(679, 135);
            this.MainProductLabel.Name = "MainProductLabel";
            this.MainProductLabel.Size = new System.Drawing.Size(82, 28);
            this.MainProductLabel.TabIndex = 16;
            this.MainProductLabel.Text = "Products";
            // 
            // InventoryMangementSystemLabel
            // 
            this.InventoryMangementSystemLabel.AutoSize = true;
            this.InventoryMangementSystemLabel.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryMangementSystemLabel.Location = new System.Drawing.Point(23, 21);
            this.InventoryMangementSystemLabel.Name = "InventoryMangementSystemLabel";
            this.InventoryMangementSystemLabel.Size = new System.Drawing.Size(256, 28);
            this.InventoryMangementSystemLabel.TabIndex = 17;
            this.InventoryMangementSystemLabel.Text = "Inventory Management System";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(1037, 605);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 18;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.InventoryMangementSystemLabel);
            this.Controls.Add(this.MainProductLabel);
            this.Controls.Add(this.MainPartsLabel);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.txtPartSearch);
            this.Controls.Add(this.serachPartsBtn1);
            this.Controls.Add(this.searchProductsBtn);
            this.Controls.Add(this.MainDeleteBtn2);
            this.Controls.Add(this.MainModifyBtn2);
            this.Controls.Add(this.MainAddProductbtn);
            this.Controls.Add(this.MainDeleteBtn1);
            this.Controls.Add(this.MainModifyBtn1);
            this.Controls.Add(this.MainAddBtn1);
            this.Controls.Add(this.dvgProducts);
            this.Controls.Add(this.dvgParts);
            this.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dvgParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgParts;
        private System.Windows.Forms.DataGridView dvgProducts;
        private System.Windows.Forms.Button MainAddBtn1;
        private System.Windows.Forms.Button MainModifyBtn1;
        private System.Windows.Forms.Button MainDeleteBtn1;
        private System.Windows.Forms.Button MainAddProductbtn;
        private System.Windows.Forms.Button MainModifyBtn2;
        private System.Windows.Forms.Button MainDeleteBtn2;
        private System.Windows.Forms.Button searchProductsBtn;
        private System.Windows.Forms.Button serachPartsBtn1;
        private System.Windows.Forms.TextBox txtPartSearch;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Label MainPartsLabel;
        private System.Windows.Forms.Label MainProductLabel;
        private System.Windows.Forms.Label InventoryMangementSystemLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

