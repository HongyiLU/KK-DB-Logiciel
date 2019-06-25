namespace KK_DMS.Forms
{
    partial class ADUQProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADUQProduit));
            this.checkedListBoxColor = new System.Windows.Forms.CheckedListBox();
            this.cOLORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kEEPKOOLDataSet = new KK_DMS.KEEPKOOLDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.SKUProduit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxSize = new System.Windows.Forms.CheckedListBox();
            this.tAILLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.dESIGNATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MarqueProduit = new System.Windows.Forms.TextBox();
            this.OriProduit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CompoProduit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PrixAchatProduit = new System.Windows.Forms.TextBox();
            this.MSRPProduit = new System.Windows.Forms.TextBox();
            this.CostProduit = new System.Windows.Forms.TextBox();
            this.LongProduit = new System.Windows.Forms.TextBox();
            this.InseamProduit = new System.Windows.Forms.TextBox();
            this.PoidProduit = new System.Windows.Forms.TextBox();
            this.AdrProduit = new System.Windows.Forms.TextBox();
            this.AddProduit = new System.Windows.Forms.Button();
            this.UpdateProduit = new System.Windows.Forms.Button();
            this.DeleteProduit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CollePro = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dESIGNATIONTableAdapter = new KK_DMS.KEEPKOOLDataSetTableAdapters.DESIGNATIONTableAdapter();
            this.tAILLETableAdapter = new KK_DMS.KEEPKOOLDataSetTableAdapters.TAILLETableAdapter();
            this.cOLORTableAdapter = new KK_DMS.KEEPKOOLDataSetTableAdapters.COLORTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label17 = new System.Windows.Forms.Label();
            this.DoubProduit = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.FabricConsProduit = new System.Windows.Forms.TextBox();
            this.ShowSizeChosen = new System.Windows.Forms.TextBox();
            this.ShowColorChosen = new System.Windows.Forms.TextBox();
            this.ModolMeasu = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cOLORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kEEPKOOLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAILLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESIGNATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxColor
            // 
            this.checkedListBoxColor.CheckOnClick = true;
            this.checkedListBoxColor.DataSource = this.cOLORBindingSource;
            this.checkedListBoxColor.DisplayMember = "COLOR";
            this.checkedListBoxColor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxColor.FormattingEnabled = true;
            this.checkedListBoxColor.Location = new System.Drawing.Point(167, 77);
            this.checkedListBoxColor.MultiColumn = true;
            this.checkedListBoxColor.Name = "checkedListBoxColor";
            this.checkedListBoxColor.Size = new System.Drawing.Size(337, 204);
            this.checkedListBoxColor.Sorted = true;
            this.checkedListBoxColor.TabIndex = 0;
            this.checkedListBoxColor.ValueMember = "COLOR";
            this.checkedListBoxColor.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxColor_SelectedIndexChanged);
            // 
            // cOLORBindingSource
            // 
            this.cOLORBindingSource.DataMember = "COLOR";
            this.cOLORBindingSource.DataSource = this.kEEPKOOLDataSet;
            // 
            // kEEPKOOLDataSet
            // 
            this.kEEPKOOLDataSet.DataSetName = "KEEPKOOLDataSet";
            this.kEEPKOOLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendor SKU";
            // 
            // SKUProduit
            // 
            this.SKUProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SKUProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SKUProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SKUProduit.Location = new System.Drawing.Point(167, 23);
            this.SKUProduit.Name = "SKUProduit";
            this.SKUProduit.Size = new System.Drawing.Size(337, 34);
            this.SKUProduit.TabIndex = 2;
            this.SKUProduit.TextChanged += new System.EventHandler(this.SKUProduit_TextChanged);
            this.SKUProduit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SKUProduit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendor Size";
            // 
            // checkedListBoxSize
            // 
            this.checkedListBoxSize.CheckOnClick = true;
            this.checkedListBoxSize.DataSource = this.tAILLEBindingSource;
            this.checkedListBoxSize.DisplayMember = "TAILLE";
            this.checkedListBoxSize.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxSize.FormattingEnabled = true;
            this.checkedListBoxSize.Location = new System.Drawing.Point(167, 301);
            this.checkedListBoxSize.MultiColumn = true;
            this.checkedListBoxSize.Name = "checkedListBoxSize";
            this.checkedListBoxSize.Size = new System.Drawing.Size(337, 124);
            this.checkedListBoxSize.TabIndex = 5;
            this.checkedListBoxSize.ValueMember = "TAILLE";
            this.checkedListBoxSize.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxSize_SelectedIndexChanged);
            // 
            // tAILLEBindingSource
            // 
            this.tAILLEBindingSource.DataMember = "TAILLE";
            this.tAILLEBindingSource.DataSource = this.kEEPKOOLDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 27);
            this.label4.TabIndex = 48;
            this.label4.Text = "Désignation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 27);
            this.label5.TabIndex = 49;
            this.label5.Text = "Marque";
            // 
            // ComboBox1
            // 
            this.ComboBox1.DataSource = this.dESIGNATIONBindingSource;
            this.ComboBox1.DisplayMember = "DESIGNATION";
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox1.Location = new System.Drawing.Point(167, 445);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(337, 36);
            this.ComboBox1.TabIndex = 47;
            this.ComboBox1.ValueMember = "DESIGNATION";
            // 
            // dESIGNATIONBindingSource
            // 
            this.dESIGNATIONBindingSource.DataMember = "DESIGNATION";
            this.dESIGNATIONBindingSource.DataSource = this.kEEPKOOLDataSet;
            // 
            // MarqueProduit
            // 
            this.MarqueProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarqueProduit.Location = new System.Drawing.Point(167, 501);
            this.MarqueProduit.Name = "MarqueProduit";
            this.MarqueProduit.Size = new System.Drawing.Size(337, 34);
            this.MarqueProduit.TabIndex = 50;
            // 
            // OriProduit
            // 
            this.OriProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriProduit.Location = new System.Drawing.Point(167, 609);
            this.OriProduit.Name = "OriProduit";
            this.OriProduit.Size = new System.Drawing.Size(337, 34);
            this.OriProduit.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 27);
            this.label6.TabIndex = 52;
            this.label6.Text = "Composition";
            // 
            // CompoProduit
            // 
            this.CompoProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompoProduit.Location = new System.Drawing.Point(167, 555);
            this.CompoProduit.Name = "CompoProduit";
            this.CompoProduit.Size = new System.Drawing.Size(337, 34);
            this.CompoProduit.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 27);
            this.label7.TabIndex = 54;
            this.label7.Text = "Origine";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(538, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 27);
            this.label8.TabIndex = 55;
            this.label8.Text = "Prix d\'achat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 27);
            this.label9.TabIndex = 56;
            this.label9.Text = "Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(538, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 27);
            this.label10.TabIndex = 57;
            this.label10.Text = "MSRP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(538, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 27);
            this.label11.TabIndex = 58;
            this.label11.Text = "Longeur";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(538, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 27);
            this.label12.TabIndex = 59;
            this.label12.Text = "Inseam";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(538, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 27);
            this.label13.TabIndex = 60;
            this.label13.Text = "Poid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(538, 388);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(248, 27);
            this.label14.TabIndex = 61;
            this.label14.Text = "Manufacturer Address";
            // 
            // PrixAchatProduit
            // 
            this.PrixAchatProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixAchatProduit.Location = new System.Drawing.Point(698, 109);
            this.PrixAchatProduit.Name = "PrixAchatProduit";
            this.PrixAchatProduit.Size = new System.Drawing.Size(115, 34);
            this.PrixAchatProduit.TabIndex = 62;
            this.PrixAchatProduit.Text = "0";
            this.PrixAchatProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrixAchatProduit_KeyPress);
            // 
            // MSRPProduit
            // 
            this.MSRPProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSRPProduit.Location = new System.Drawing.Point(698, 201);
            this.MSRPProduit.Name = "MSRPProduit";
            this.MSRPProduit.Size = new System.Drawing.Size(115, 34);
            this.MSRPProduit.TabIndex = 63;
            this.MSRPProduit.Text = "0";
            this.MSRPProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MSRPProduit_KeyPress);
            // 
            // CostProduit
            // 
            this.CostProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostProduit.Location = new System.Drawing.Point(698, 155);
            this.CostProduit.Name = "CostProduit";
            this.CostProduit.Size = new System.Drawing.Size(115, 34);
            this.CostProduit.TabIndex = 64;
            this.CostProduit.Text = "0";
            this.CostProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostProduit_KeyPress);
            // 
            // LongProduit
            // 
            this.LongProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongProduit.Location = new System.Drawing.Point(698, 247);
            this.LongProduit.Name = "LongProduit";
            this.LongProduit.Size = new System.Drawing.Size(115, 34);
            this.LongProduit.TabIndex = 65;
            this.LongProduit.Text = "0";
            this.LongProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LongProduit_KeyPress);
            // 
            // InseamProduit
            // 
            this.InseamProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InseamProduit.Location = new System.Drawing.Point(698, 293);
            this.InseamProduit.Name = "InseamProduit";
            this.InseamProduit.Size = new System.Drawing.Size(115, 34);
            this.InseamProduit.TabIndex = 66;
            this.InseamProduit.Text = "0";
            this.InseamProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InseamProduit_KeyPress);
            // 
            // PoidProduit
            // 
            this.PoidProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoidProduit.Location = new System.Drawing.Point(698, 339);
            this.PoidProduit.Name = "PoidProduit";
            this.PoidProduit.Size = new System.Drawing.Size(115, 34);
            this.PoidProduit.TabIndex = 67;
            this.PoidProduit.Text = "0";
            this.PoidProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PoidProduit_KeyPress);
            // 
            // AdrProduit
            // 
            this.AdrProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdrProduit.Location = new System.Drawing.Point(543, 418);
            this.AdrProduit.Multiline = true;
            this.AdrProduit.Name = "AdrProduit";
            this.AdrProduit.Size = new System.Drawing.Size(270, 117);
            this.AdrProduit.TabIndex = 68;
            // 
            // AddProduit
            // 
            this.AddProduit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduit.Location = new System.Drawing.Point(546, 569);
            this.AddProduit.Name = "AddProduit";
            this.AddProduit.Size = new System.Drawing.Size(267, 48);
            this.AddProduit.TabIndex = 69;
            this.AddProduit.Text = "Add";
            this.AddProduit.UseVisualStyleBackColor = false;
            this.AddProduit.Click += new System.EventHandler(this.AddProduit_Click);
            // 
            // UpdateProduit
            // 
            this.UpdateProduit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProduit.Location = new System.Drawing.Point(546, 637);
            this.UpdateProduit.Name = "UpdateProduit";
            this.UpdateProduit.Size = new System.Drawing.Size(267, 48);
            this.UpdateProduit.TabIndex = 70;
            this.UpdateProduit.Text = "Update";
            this.UpdateProduit.UseVisualStyleBackColor = false;
            this.UpdateProduit.Click += new System.EventHandler(this.UpdateProduit_Click);
            // 
            // DeleteProduit
            // 
            this.DeleteProduit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProduit.Location = new System.Drawing.Point(546, 705);
            this.DeleteProduit.Name = "DeleteProduit";
            this.DeleteProduit.Size = new System.Drawing.Size(267, 48);
            this.DeleteProduit.TabIndex = 71;
            this.DeleteProduit.Text = "Delete";
            this.DeleteProduit.UseVisualStyleBackColor = false;
            this.DeleteProduit.Click += new System.EventHandler(this.DeleteProduit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(853, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(288, 674);
            this.dataGridView1.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(848, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 27);
            this.label15.TabIndex = 73;
            this.label15.Text = "Produit ajouté";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(853, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 54);
            this.button1.TabIndex = 74;
            this.button1.Text = "Générer offer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CollePro
            // 
            this.CollePro.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollePro.Location = new System.Drawing.Point(167, 663);
            this.CollePro.Name = "CollePro";
            this.CollePro.Size = new System.Drawing.Size(337, 34);
            this.CollePro.TabIndex = 75;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 666);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 27);
            this.label16.TabIndex = 76;
            this.label16.Text = "Collection";
            // 
            // dESIGNATIONTableAdapter
            // 
            this.dESIGNATIONTableAdapter.ClearBeforeFill = true;
            // 
            // tAILLETableAdapter
            // 
            this.tAILLETableAdapter.ClearBeforeFill = true;
            // 
            // cOLORTableAdapter
            // 
            this.cOLORTableAdapter.ClearBeforeFill = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 720);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 27);
            this.label17.TabIndex = 77;
            this.label17.Text = "Doublure";
            // 
            // DoubProduit
            // 
            this.DoubProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubProduit.Location = new System.Drawing.Point(167, 717);
            this.DoubProduit.Name = "DoubProduit";
            this.DoubProduit.Size = new System.Drawing.Size(337, 34);
            this.DoubProduit.TabIndex = 78;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 775);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(222, 27);
            this.label18.TabIndex = 79;
            this.label18.Text = "Fabric Construction";
            // 
            // FabricConsProduit
            // 
            this.FabricConsProduit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FabricConsProduit.Location = new System.Drawing.Point(240, 772);
            this.FabricConsProduit.Name = "FabricConsProduit";
            this.FabricConsProduit.Size = new System.Drawing.Size(264, 34);
            this.FabricConsProduit.TabIndex = 80;
            // 
            // ShowSizeChosen
            // 
            this.ShowSizeChosen.Location = new System.Drawing.Point(17, 331);
            this.ShowSizeChosen.Multiline = true;
            this.ShowSizeChosen.Name = "ShowSizeChosen";
            this.ShowSizeChosen.ReadOnly = true;
            this.ShowSizeChosen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowSizeChosen.Size = new System.Drawing.Size(134, 94);
            this.ShowSizeChosen.TabIndex = 81;
            // 
            // ShowColorChosen
            // 
            this.ShowColorChosen.Location = new System.Drawing.Point(17, 110);
            this.ShowColorChosen.Multiline = true;
            this.ShowColorChosen.Name = "ShowColorChosen";
            this.ShowColorChosen.ReadOnly = true;
            this.ShowColorChosen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowColorChosen.Size = new System.Drawing.Size(139, 171);
            this.ShowColorChosen.TabIndex = 82;
            // 
            // ModolMeasu
            // 
            this.ModolMeasu.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModolMeasu.Location = new System.Drawing.Point(543, 56);
            this.ModolMeasu.Name = "ModolMeasu";
            this.ModolMeasu.Size = new System.Drawing.Size(270, 34);
            this.ModolMeasu.TabIndex = 83;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(538, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(242, 27);
            this.label19.TabIndex = 84;
            this.label19.Text = "Model Measurements";
            // 
            // ADUQProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 834);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ModolMeasu);
            this.Controls.Add(this.ShowColorChosen);
            this.Controls.Add(this.ShowSizeChosen);
            this.Controls.Add(this.FabricConsProduit);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.DoubProduit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CollePro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteProduit);
            this.Controls.Add(this.UpdateProduit);
            this.Controls.Add(this.AddProduit);
            this.Controls.Add(this.AdrProduit);
            this.Controls.Add(this.PoidProduit);
            this.Controls.Add(this.InseamProduit);
            this.Controls.Add(this.LongProduit);
            this.Controls.Add(this.CostProduit);
            this.Controls.Add(this.MSRPProduit);
            this.Controls.Add(this.PrixAchatProduit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CompoProduit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OriProduit);
            this.Controls.Add(this.MarqueProduit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.checkedListBoxSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SKUProduit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADUQProduit";
            this.Text = "ADUQProduit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADUQProduit_OnClosing);
            this.Load += new System.EventHandler(this.ADUQProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOLORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kEEPKOOLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAILLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESIGNATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SKUProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.TextBox MarqueProduit;
        private System.Windows.Forms.TextBox OriProduit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CompoProduit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PrixAchatProduit;
        private System.Windows.Forms.TextBox MSRPProduit;
        private System.Windows.Forms.TextBox CostProduit;
        private System.Windows.Forms.TextBox LongProduit;
        private System.Windows.Forms.TextBox InseamProduit;
        private System.Windows.Forms.TextBox PoidProduit;
        private System.Windows.Forms.TextBox AdrProduit;
        private System.Windows.Forms.Button AddProduit;
        private System.Windows.Forms.Button UpdateProduit;
        private System.Windows.Forms.Button DeleteProduit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CollePro;
        private System.Windows.Forms.Label label16;
        private KEEPKOOLDataSet kEEPKOOLDataSet;
        private System.Windows.Forms.BindingSource dESIGNATIONBindingSource;
        private KEEPKOOLDataSetTableAdapters.DESIGNATIONTableAdapter dESIGNATIONTableAdapter;
        private System.Windows.Forms.BindingSource tAILLEBindingSource;
        private KEEPKOOLDataSetTableAdapters.TAILLETableAdapter tAILLETableAdapter;
        private System.Windows.Forms.BindingSource cOLORBindingSource;
        private KEEPKOOLDataSetTableAdapters.COLORTableAdapter cOLORTableAdapter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox DoubProduit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox FabricConsProduit;
        private System.Windows.Forms.TextBox ShowSizeChosen;
        private System.Windows.Forms.TextBox ShowColorChosen;
        private System.Windows.Forms.TextBox ModolMeasu;
        private System.Windows.Forms.Label label19;
    }
}