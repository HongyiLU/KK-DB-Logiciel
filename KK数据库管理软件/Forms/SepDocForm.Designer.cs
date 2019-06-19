namespace KK数据库管理软件.Forms
{
    partial class SepDocForm
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
            System.Windows.Forms.Button ChooseDoc;
            System.Windows.Forms.Button ChooseDoc2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SepDocForm));
            this.SeperateDocument = new System.Windows.Forms.CheckBox();
            this.WriteDB = new System.Windows.Forms.CheckBox();
            this.SeperateDoc = new System.Windows.Forms.Button();
            this.PathDoc = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PathDocFac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ChooseDoc = new System.Windows.Forms.Button();
            ChooseDoc2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseDoc
            // 
            ChooseDoc.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChooseDoc.Location = new System.Drawing.Point(746, 150);
            ChooseDoc.Name = "ChooseDoc";
            ChooseDoc.Size = new System.Drawing.Size(231, 61);
            ChooseDoc.TabIndex = 9;
            ChooseDoc.Text = "Choose File";
            ChooseDoc.UseVisualStyleBackColor = true;
            ChooseDoc.Click += new System.EventHandler(this.ChooseDoc_Click);
            // 
            // ChooseDoc2
            // 
            ChooseDoc2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChooseDoc2.Location = new System.Drawing.Point(746, 270);
            ChooseDoc2.Name = "ChooseDoc2";
            ChooseDoc2.Size = new System.Drawing.Size(231, 61);
            ChooseDoc2.TabIndex = 14;
            ChooseDoc2.Text = "Choose File";
            ChooseDoc2.UseVisualStyleBackColor = true;
            ChooseDoc2.Click += new System.EventHandler(this.ChooseDoc2_Click);
            // 
            // SeperateDocument
            // 
            this.SeperateDocument.AutoSize = true;
            this.SeperateDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeperateDocument.Location = new System.Drawing.Point(662, 542);
            this.SeperateDocument.Name = "SeperateDocument";
            this.SeperateDocument.Size = new System.Drawing.Size(289, 33);
            this.SeperateDocument.TabIndex = 12;
            this.SeperateDocument.Text = "Seperate this douments";
            this.SeperateDocument.UseVisualStyleBackColor = true;
            // 
            // WriteDB
            // 
            this.WriteDB.AutoSize = true;
            this.WriteDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteDB.Location = new System.Drawing.Point(662, 487);
            this.WriteDB.Name = "WriteDB";
            this.WriteDB.Size = new System.Drawing.Size(244, 33);
            this.WriteDB.TabIndex = 11;
            this.WriteDB.Text = "Write into Database";
            this.WriteDB.UseVisualStyleBackColor = true;
            this.WriteDB.CheckedChanged += new System.EventHandler(this.WriteDB_CheckedChanged);
            // 
            // SeperateDoc
            // 
            this.SeperateDoc.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeperateDoc.Location = new System.Drawing.Point(350, 487);
            this.SeperateDoc.Name = "SeperateDoc";
            this.SeperateDoc.Size = new System.Drawing.Size(276, 88);
            this.SeperateDoc.TabIndex = 10;
            this.SeperateDoc.Text = "Run";
            this.SeperateDoc.UseVisualStyleBackColor = true;
            this.SeperateDoc.Click += new System.EventHandler(this.SeperateDoc_Click);
            // 
            // PathDoc
            // 
            this.PathDoc.Enabled = false;
            this.PathDoc.Location = new System.Drawing.Point(81, 150);
            this.PathDoc.Multiline = true;
            this.PathDoc.Name = "PathDoc";
            this.PathDoc.Size = new System.Drawing.Size(659, 61);
            this.PathDoc.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // PathDocFac
            // 
            this.PathDocFac.Enabled = false;
            this.PathDocFac.Location = new System.Drawing.Point(81, 270);
            this.PathDocFac.Multiline = true;
            this.PathDocFac.Name = "PathDocFac";
            this.PathDocFac.Size = new System.Drawing.Size(659, 61);
            this.PathDocFac.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Facture Vente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Commande:";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(783, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 25);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // SepDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 690);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(ChooseDoc2);
            this.Controls.Add(this.PathDocFac);
            this.Controls.Add(this.SeperateDocument);
            this.Controls.Add(this.WriteDB);
            this.Controls.Add(this.SeperateDoc);
            this.Controls.Add(ChooseDoc);
            this.Controls.Add(this.PathDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SepDocForm";
            this.Text = "SepDocForm";
            this.Load += new System.EventHandler(this.SepDocForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox SeperateDocument;
        internal System.Windows.Forms.CheckBox WriteDB;
        internal System.Windows.Forms.Button SeperateDoc;
        internal System.Windows.Forms.TextBox PathDoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.TextBox PathDocFac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}