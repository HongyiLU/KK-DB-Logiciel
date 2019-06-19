namespace KK数据库管理软件.Forms
{
    partial class ADUQFacForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADUQFacForm));
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.dESIGNATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kEEPKOOLDataSet = new KK数据库管理软件.KEEPKOOLDataSet();
            this.Label8 = new System.Windows.Forms.Label();
            this.DateFac = new System.Windows.Forms.DateTimePicker();
            this.DeleteFac = new System.Windows.Forms.Button();
            this.UpdateFac = new System.Windows.Forms.Button();
            this.WriteNewFac = new System.Windows.Forms.Button();
            this.NOM_FOURNISSEUR = new System.Windows.Forms.TextBox();
            this.REF_FACTURE = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DETAILFAC = new System.Windows.Forms.DataGridView();
            this.QteFacProd = new System.Windows.Forms.TextBox();
            this.PrixFacProd = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dESIGNATIONTableAdapter = new KK数据库管理软件.KEEPKOOLDataSetTableAdapters.DESIGNATIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dESIGNATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kEEPKOOLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DETAILFAC)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.DataSource = this.dESIGNATIONBindingSource;
            this.ComboBox1.DisplayMember = "DESIGNATION";
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox1.Location = new System.Drawing.Point(59, 159);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(321, 33);
            this.ComboBox1.TabIndex = 46;
            this.ComboBox1.ValueMember = "DESIGNATION";
            // 
            // dESIGNATIONBindingSource
            // 
            this.dESIGNATIONBindingSource.DataMember = "DESIGNATION";
            this.dESIGNATIONBindingSource.DataSource = this.kEEPKOOLDataSet;
            // 
            // kEEPKOOLDataSet
            // 
            this.kEEPKOOLDataSet.DataSetName = "KEEPKOOLDataSet";
            this.kEEPKOOLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(729, 41);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(69, 29);
            this.Label8.TabIndex = 45;
            this.Label8.Text = "Date:";
            // 
            // DateFac
            // 
            this.DateFac.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFac.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFac.Location = new System.Drawing.Point(804, 39);
            this.DateFac.Name = "DateFac";
            this.DateFac.Size = new System.Drawing.Size(241, 34);
            this.DateFac.TabIndex = 44;
            // 
            // DeleteFac
            // 
            this.DeleteFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFac.Location = new System.Drawing.Point(778, 794);
            this.DeleteFac.Name = "DeleteFac";
            this.DeleteFac.Size = new System.Drawing.Size(157, 40);
            this.DeleteFac.TabIndex = 43;
            this.DeleteFac.Text = "Delete";
            this.DeleteFac.UseVisualStyleBackColor = true;
            this.DeleteFac.Click += new System.EventHandler(this.DeleteFac_Click);
            // 
            // UpdateFac
            // 
            this.UpdateFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFac.Location = new System.Drawing.Point(502, 794);
            this.UpdateFac.Name = "UpdateFac";
            this.UpdateFac.Size = new System.Drawing.Size(157, 40);
            this.UpdateFac.TabIndex = 42;
            this.UpdateFac.Text = "Update";
            this.UpdateFac.UseVisualStyleBackColor = true;
            this.UpdateFac.Click += new System.EventHandler(this.UpdateFac_Click);
            // 
            // WriteNewFac
            // 
            this.WriteNewFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteNewFac.Location = new System.Drawing.Point(226, 794);
            this.WriteNewFac.Name = "WriteNewFac";
            this.WriteNewFac.Size = new System.Drawing.Size(157, 40);
            this.WriteNewFac.TabIndex = 41;
            this.WriteNewFac.Text = "Add";
            this.WriteNewFac.UseVisualStyleBackColor = true;
            this.WriteNewFac.Click += new System.EventHandler(this.WriteNewFac_Click);
            // 
            // NOM_FOURNISSEUR
            // 
            this.NOM_FOURNISSEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_FOURNISSEUR.Location = new System.Drawing.Point(278, 77);
            this.NOM_FOURNISSEUR.Name = "NOM_FOURNISSEUR";
            this.NOM_FOURNISSEUR.Size = new System.Drawing.Size(276, 34);
            this.NOM_FOURNISSEUR.TabIndex = 40;
            // 
            // REF_FACTURE
            // 
            this.REF_FACTURE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.REF_FACTURE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.REF_FACTURE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REF_FACTURE.Location = new System.Drawing.Point(216, 41);
            this.REF_FACTURE.Name = "REF_FACTURE";
            this.REF_FACTURE.Size = new System.Drawing.Size(338, 34);
            this.REF_FACTURE.TabIndex = 39;
            this.REF_FACTURE.TextChanged += new System.EventHandler(this.REF_FACTURE_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(54, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(218, 29);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "Nom_Fournisseur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ref_Facture :";
            // 
            // DETAILFAC
            // 
            this.DETAILFAC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DETAILFAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DETAILFAC.Location = new System.Drawing.Point(59, 126);
            this.DETAILFAC.Name = "DETAILFAC";
            this.DETAILFAC.RowHeadersWidth = 51;
            this.DETAILFAC.RowTemplate.Height = 27;
            this.DETAILFAC.Size = new System.Drawing.Size(1030, 634);
            this.DETAILFAC.TabIndex = 48;
            // 
            // QteFacProd
            // 
            this.QteFacProd.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QteFacProd.ForeColor = System.Drawing.Color.Black;
            this.QteFacProd.Location = new System.Drawing.Point(403, 159);
            this.QteFacProd.Name = "QteFacProd";
            this.QteFacProd.Size = new System.Drawing.Size(278, 34);
            this.QteFacProd.TabIndex = 89;
            // 
            // PrixFacProd
            // 
            this.PrixFacProd.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PrixFacProd.ForeColor = System.Drawing.Color.Black;
            this.PrixFacProd.Location = new System.Drawing.Point(704, 159);
            this.PrixFacProd.Name = "PrixFacProd";
            this.PrixFacProd.Size = new System.Drawing.Size(278, 34);
            this.PrixFacProd.TabIndex = 105;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1005, 169);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 15);
            this.linkLabel1.TabIndex = 106;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Save";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 107;
            this.label3.Text = "Désignation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 108;
            this.label4.Text = "Quantité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(774, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 109;
            this.label5.Text = "Prix";
            // 
            // dESIGNATIONTableAdapter
            // 
            this.dESIGNATIONTableAdapter.ClearBeforeFill = true;
            // 
            // ADUQFacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 888);
            this.Controls.Add(this.DETAILFAC);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.DateFac);
            this.Controls.Add(this.DeleteFac);
            this.Controls.Add(this.UpdateFac);
            this.Controls.Add(this.WriteNewFac);
            this.Controls.Add(this.NOM_FOURNISSEUR);
            this.Controls.Add(this.REF_FACTURE);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrixFacProd);
            this.Controls.Add(this.QteFacProd);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADUQFacForm";
            this.Text = "ADUSFacForm";
            this.Load += new System.EventHandler(this.ADUSFacForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dESIGNATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kEEPKOOLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DETAILFAC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DateTimePicker DateFac;
        internal System.Windows.Forms.Button DeleteFac;
        internal System.Windows.Forms.Button UpdateFac;
        internal System.Windows.Forms.Button WriteNewFac;
        internal System.Windows.Forms.TextBox NOM_FOURNISSEUR;
        internal System.Windows.Forms.TextBox REF_FACTURE;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DETAILFAC;
        private System.Windows.Forms.TextBox QteFacProd;
        private System.Windows.Forms.TextBox PrixFacProd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private KEEPKOOLDataSet kEEPKOOLDataSet;
        private System.Windows.Forms.BindingSource dESIGNATIONBindingSource;
        private KEEPKOOLDataSetTableAdapters.DESIGNATIONTableAdapter dESIGNATIONTableAdapter;
    }
}