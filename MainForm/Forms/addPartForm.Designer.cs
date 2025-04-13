namespace MainForm
{
    partial class addPartsForm
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
            this.InHouseBtn1 = new System.Windows.Forms.RadioButton();
            this.SaveBtn1 = new System.Windows.Forms.Button();
            this.IdTextBox1 = new System.Windows.Forms.TextBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OutsourcedBtn1 = new System.Windows.Forms.RadioButton();
            this.CancelBtn1 = new System.Windows.Forms.Button();
            this.MaxLabel1 = new System.Windows.Forms.Label();
            this.MinLabel1 = new System.Windows.Forms.Label();
            this.InventoryLabel1 = new System.Windows.Forms.Label();
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.PriceLabel1 = new System.Windows.Forms.Label();
            this.CompanyOrMachineLabel = new System.Windows.Forms.Label();
            this.MachineIdTextBox1 = new System.Windows.Forms.TextBox();
            this.MinTextBox1 = new System.Windows.Forms.TextBox();
            this.MaxTextBox1 = new System.Windows.Forms.TextBox();
            this.PriceTextBox1 = new System.Windows.Forms.TextBox();
            this.InventoryTextBox1 = new System.Windows.Forms.TextBox();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.AddPartTitle1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InHouseBtn1
            // 
            this.InHouseBtn1.AutoSize = true;
            this.InHouseBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouseBtn1.Location = new System.Drawing.Point(198, 82);
            this.InHouseBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InHouseBtn1.Name = "InHouseBtn1";
            this.InHouseBtn1.Size = new System.Drawing.Size(79, 20);
            this.InHouseBtn1.TabIndex = 0;
            this.InHouseBtn1.Text = "In-House";
            this.InHouseBtn1.UseVisualStyleBackColor = true;
            this.InHouseBtn1.CheckedChanged += new System.EventHandler(this.inHouseBtn1_CheckedChanged);
            // 
            // SaveBtn1
            // 
            this.SaveBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn1.Location = new System.Drawing.Point(327, 405);
            this.SaveBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBtn1.Name = "SaveBtn1";
            this.SaveBtn1.Size = new System.Drawing.Size(75, 22);
            this.SaveBtn1.TabIndex = 1;
            this.SaveBtn1.Text = "Save";
            this.SaveBtn1.UseVisualStyleBackColor = true;
            this.SaveBtn1.Click += new System.EventHandler(this.SaveBtn1_Click);
            // 
            // IdTextBox1
            // 
            this.IdTextBox1.Enabled = false;
            this.IdTextBox1.Location = new System.Drawing.Point(207, 137);
            this.IdTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdTextBox1.Name = "IdTextBox1";
            this.IdTextBox1.ReadOnly = true;
            this.IdTextBox1.Size = new System.Drawing.Size(140, 20);
            this.IdTextBox1.TabIndex = 2;
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel1.Location = new System.Drawing.Point(157, 137);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(22, 16);
            this.IdLabel1.TabIndex = 3;
            this.IdLabel1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(473, 398);
            this.dataGridView1.TabIndex = 4;
            // 
            // OutsourcedBtn1
            // 
            this.OutsourcedBtn1.AutoSize = true;
            this.OutsourcedBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutsourcedBtn1.Location = new System.Drawing.Point(327, 81);
            this.OutsourcedBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutsourcedBtn1.Name = "OutsourcedBtn1";
            this.OutsourcedBtn1.Size = new System.Drawing.Size(87, 20);
            this.OutsourcedBtn1.TabIndex = 8;
            this.OutsourcedBtn1.Text = "Outsorced";
            this.OutsourcedBtn1.UseVisualStyleBackColor = true;
            this.OutsourcedBtn1.CheckedChanged += new System.EventHandler(this.OutsourcedBtn1_CheckedChanged);
            // 
            // CancelBtn1
            // 
            this.CancelBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn1.Location = new System.Drawing.Point(416, 405);
            this.CancelBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelBtn1.Name = "CancelBtn1";
            this.CancelBtn1.Size = new System.Drawing.Size(75, 22);
            this.CancelBtn1.TabIndex = 11;
            this.CancelBtn1.Text = "Cancel";
            this.CancelBtn1.UseVisualStyleBackColor = true;
            this.CancelBtn1.Click += new System.EventHandler(this.CancelBtn1_Click);
            // 
            // MaxLabel1
            // 
            this.MaxLabel1.AutoSize = true;
            this.MaxLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel1.Location = new System.Drawing.Point(144, 320);
            this.MaxLabel1.Name = "MaxLabel1";
            this.MaxLabel1.Size = new System.Drawing.Size(35, 16);
            this.MaxLabel1.TabIndex = 14;
            this.MaxLabel1.Text = "Max";
            // 
            // MinLabel1
            // 
            this.MinLabel1.AutoSize = true;
            this.MinLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel1.Location = new System.Drawing.Point(354, 324);
            this.MinLabel1.Name = "MinLabel1";
            this.MinLabel1.Size = new System.Drawing.Size(31, 16);
            this.MinLabel1.TabIndex = 18;
            this.MinLabel1.Text = "Min";
            // 
            // InventoryLabel1
            // 
            this.InventoryLabel1.AutoSize = true;
            this.InventoryLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabel1.Location = new System.Drawing.Point(109, 226);
            this.InventoryLabel1.Name = "InventoryLabel1";
            this.InventoryLabel1.Size = new System.Drawing.Size(70, 16);
            this.InventoryLabel1.TabIndex = 20;
            this.InventoryLabel1.Text = "Inventory";
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel1.Location = new System.Drawing.Point(131, 182);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(48, 16);
            this.NameLabel1.TabIndex = 21;
            this.NameLabel1.Text = "Name";
            // 
            // PriceLabel1
            // 
            this.PriceLabel1.AutoSize = true;
            this.PriceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel1.Location = new System.Drawing.Point(92, 275);
            this.PriceLabel1.Name = "PriceLabel1";
            this.PriceLabel1.Size = new System.Drawing.Size(87, 16);
            this.PriceLabel1.TabIndex = 22;
            this.PriceLabel1.Text = "Price / Cost";
            // 
            // CompanyOrMachineLabel
            // 
            this.CompanyOrMachineLabel.AutoSize = true;
            this.CompanyOrMachineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyOrMachineLabel.Location = new System.Drawing.Point(95, 372);
            this.CompanyOrMachineLabel.Name = "CompanyOrMachineLabel";
            this.CompanyOrMachineLabel.Size = new System.Drawing.Size(84, 16);
            this.CompanyOrMachineLabel.TabIndex = 23;
            this.CompanyOrMachineLabel.Text = "Machine ID";
            // 
            // MachineIdTextBox1
            // 
            this.MachineIdTextBox1.Location = new System.Drawing.Point(207, 367);
            this.MachineIdTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MachineIdTextBox1.Name = "MachineIdTextBox1";
            this.MachineIdTextBox1.Size = new System.Drawing.Size(140, 20);
            this.MachineIdTextBox1.TabIndex = 31;
            // 
            // MinTextBox1
            // 
            this.MinTextBox1.Location = new System.Drawing.Point(391, 323);
            this.MinTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinTextBox1.Name = "MinTextBox1";
            this.MinTextBox1.Size = new System.Drawing.Size(100, 20);
            this.MinTextBox1.TabIndex = 32;
            // 
            // MaxTextBox1
            // 
            this.MaxTextBox1.Location = new System.Drawing.Point(207, 323);
            this.MaxTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxTextBox1.Name = "MaxTextBox1";
            this.MaxTextBox1.Size = new System.Drawing.Size(120, 20);
            this.MaxTextBox1.TabIndex = 33;
            // 
            // PriceTextBox1
            // 
            this.PriceTextBox1.Location = new System.Drawing.Point(207, 275);
            this.PriceTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceTextBox1.Name = "PriceTextBox1";
            this.PriceTextBox1.Size = new System.Drawing.Size(140, 20);
            this.PriceTextBox1.TabIndex = 34;
            // 
            // InventoryTextBox1
            // 
            this.InventoryTextBox1.Location = new System.Drawing.Point(207, 226);
            this.InventoryTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InventoryTextBox1.Name = "InventoryTextBox1";
            this.InventoryTextBox1.Size = new System.Drawing.Size(140, 20);
            this.InventoryTextBox1.TabIndex = 35;
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(207, 182);
            this.NameTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(140, 20);
            this.NameTextBox1.TabIndex = 36;
            // 
            // AddPartTitle1
            // 
            this.AddPartTitle1.AutoSize = true;
            this.AddPartTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartTitle1.Location = new System.Drawing.Point(50, 81);
            this.AddPartTitle1.Name = "AddPartTitle1";
            this.AddPartTitle1.Size = new System.Drawing.Size(79, 20);
            this.AddPartTitle1.TabIndex = 39;
            this.AddPartTitle1.Text = "Add Part";
            // 
            // addPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 538);
            this.Controls.Add(this.AddPartTitle1);
            this.Controls.Add(this.NameTextBox1);
            this.Controls.Add(this.InventoryTextBox1);
            this.Controls.Add(this.PriceTextBox1);
            this.Controls.Add(this.MaxTextBox1);
            this.Controls.Add(this.MinTextBox1);
            this.Controls.Add(this.MachineIdTextBox1);
            this.Controls.Add(this.CompanyOrMachineLabel);
            this.Controls.Add(this.PriceLabel1);
            this.Controls.Add(this.NameLabel1);
            this.Controls.Add(this.InventoryLabel1);
            this.Controls.Add(this.MinLabel1);
            this.Controls.Add(this.MaxLabel1);
            this.Controls.Add(this.CancelBtn1);
            this.Controls.Add(this.OutsourcedBtn1);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.IdTextBox1);
            this.Controls.Add(this.SaveBtn1);
            this.Controls.Add(this.InHouseBtn1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addPartsForm";
            this.Text = "Part";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton InHouseBtn1;
        private System.Windows.Forms.Button SaveBtn1;
        private System.Windows.Forms.TextBox IdTextBox1;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton OutsourcedBtn1;
        private System.Windows.Forms.Button CancelBtn1;
        private System.Windows.Forms.Label MaxLabel1;
        private System.Windows.Forms.Label MinLabel1;
        private System.Windows.Forms.Label InventoryLabel1;
        private System.Windows.Forms.Label NameLabel1;
        private System.Windows.Forms.Label PriceLabel1;
        private System.Windows.Forms.Label CompanyOrMachineLabel;
        private System.Windows.Forms.TextBox MachineIdTextBox1;
        private System.Windows.Forms.TextBox MinTextBox1;
        private System.Windows.Forms.TextBox MaxTextBox1;
        private System.Windows.Forms.TextBox PriceTextBox1;
        private System.Windows.Forms.TextBox InventoryTextBox1;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.Label AddPartTitle1;
    }
}

