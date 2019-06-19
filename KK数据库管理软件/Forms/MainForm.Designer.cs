namespace KK数据库管理软件
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.分割文件功能 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(102, 361);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(588, 99);
            this.Button3.TabIndex = 9;
            this.Button3.Text = "Gérer des Factures des commandes";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(102, 496);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(588, 99);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "Gérer des Fournisseurs";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // 分割文件功能
            // 
            this.分割文件功能.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.分割文件功能.Location = new System.Drawing.Point(102, 631);
            this.分割文件功能.Name = "分割文件功能";
            this.分割文件功能.Size = new System.Drawing.Size(588, 99);
            this.分割文件功能.TabIndex = 6;
            this.分割文件功能.Text = "Séparer des documents et les enregistrer dans DB";
            this.分割文件功能.UseVisualStyleBackColor = true;
            this.分割文件功能.Click += new System.EventHandler(this.分割文件功能_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(30, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(233, 29);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Choose a catalogue:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(102, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(588, 99);
            this.button4.TabIndex = 10;
            this.button4.Text = "Analyse d\'Achat et Vente";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(102, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(588, 99);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gérer des produits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(729, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 298);
            this.button5.TabIndex = 12;
            this.button5.Text = "Générer Offer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 787);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.分割文件功能);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button 分割文件功能;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button5;
    }
}

