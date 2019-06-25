namespace KK_DMS.Forms
{
    partial class GeneOfferForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VendorSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKUProduit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VendorSKU,
            this.VendorSize,
            this.Collection,
            this.Designation,
            this.BrandName,
            this.MaterialContent,
            this.Origin,
            this.Price,
            this.Long,
            this.Weight});
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 819);
            this.dataGridView1.TabIndex = 0;
            // 
            // VendorSKU
            // 
            this.VendorSKU.HeaderText = "Vendor SKU";
            this.VendorSKU.MinimumWidth = 6;
            this.VendorSKU.Name = "VendorSKU";
            this.VendorSKU.ReadOnly = true;
            this.VendorSKU.Width = 160;
            // 
            // VendorSize
            // 
            this.VendorSize.HeaderText = "Vendor Size";
            this.VendorSize.MinimumWidth = 6;
            this.VendorSize.Name = "VendorSize";
            this.VendorSize.ReadOnly = true;
            this.VendorSize.Width = 160;
            // 
            // Collection
            // 
            this.Collection.HeaderText = "Collection";
            this.Collection.MinimumWidth = 6;
            this.Collection.Name = "Collection";
            this.Collection.ReadOnly = true;
            this.Collection.Width = 80;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.MinimumWidth = 6;
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            this.Designation.Width = 80;
            // 
            // BrandName
            // 
            this.BrandName.HeaderText = "Brand Name";
            this.BrandName.MinimumWidth = 6;
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 95;
            // 
            // MaterialContent
            // 
            this.MaterialContent.HeaderText = "Material Content";
            this.MaterialContent.MinimumWidth = 6;
            this.MaterialContent.Name = "MaterialContent";
            this.MaterialContent.ReadOnly = true;
            this.MaterialContent.Width = 96;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin";
            this.Origin.MinimumWidth = 6;
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            this.Origin.Width = 66;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 66;
            // 
            // Long
            // 
            this.Long.HeaderText = "HPS Measurement (cm)";
            this.Long.MinimumWidth = 6;
            this.Long.Name = "Long";
            this.Long.ReadOnly = true;
            this.Long.Width = 80;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 66;
            // 
            // SKUProduit
            // 
            this.SKUProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SKUProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SKUProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SKUProduit.Location = new System.Drawing.Point(165, 12);
            this.SKUProduit.Name = "SKUProduit";
            this.SKUProduit.Size = new System.Drawing.Size(337, 34);
            this.SKUProduit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vendor SKU";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(517, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(734, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 54);
            this.button2.TabIndex = 75;
            this.button2.Text = "Générer offer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            // 
            // GeneOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 903);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SKUProduit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GeneOfferForm";
            this.Text = "GeneOfferForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneOfferForm_OnClosing);
            this.Load += new System.EventHandler(this.GeneOfferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SKUProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}