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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADUQFacForm));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_FAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DETAILFAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.DETAILFAC.Location = new System.Drawing.Point(59, 117);
            this.DETAILFAC.Name = "DETAILFAC";
            this.DETAILFAC.RowHeadersWidth = 51;
            this.DETAILFAC.RowTemplate.Height = 27;
            this.DETAILFAC.Size = new System.Drawing.Size(986, 650);
            this.DETAILFAC.TabIndex = 124;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_FAC,
            this.DESIGNATION,
            this.QUANTITE,
            this.PRIX});
            this.dataGridView1.Location = new System.Drawing.Point(59, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(986, 650);
            this.dataGridView1.TabIndex = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // ID_FAC
            // 
            this.ID_FAC.HeaderText = "ID_FAC";
            this.ID_FAC.MinimumWidth = 6;
            this.ID_FAC.Name = "ID_FAC";
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.HeaderText = "DESIGNATION";
            this.DESIGNATION.MinimumWidth = 6;
            this.DESIGNATION.Name = "DESIGNATION";
            // 
            // QUANTITE
            // 
            this.QUANTITE.HeaderText = "QUANTITE";
            this.QUANTITE.MinimumWidth = 6;
            this.QUANTITE.Name = "QUANTITE";
            // 
            // PRIX
            // 
            this.PRIX.HeaderText = "PRIX";
            this.PRIX.MinimumWidth = 6;
            this.PRIX.Name = "PRIX";
            // 
            // ADUQFacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 888);
            this.Controls.Add(this.DETAILFAC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.DateFac);
            this.Controls.Add(this.DeleteFac);
            this.Controls.Add(this.UpdateFac);
            this.Controls.Add(this.WriteNewFac);
            this.Controls.Add(this.NOM_FOURNISSEUR);
            this.Controls.Add(this.REF_FACTURE);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADUQFacForm";
            this.Text = "ADUSFacForm";
            this.Load += new System.EventHandler(this.ADUSFacForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DETAILFAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESIGNATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX;
    }
}