using KK_DMS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK_DMS.Forms
{
    public partial class GeneOfferForm : Form
    {
        GeneOfferUtilClass OfferUtilClass;
        List<Produit> listProduit;
        public GeneOfferForm()
        {
            listProduit = new List<Produit>();
            OfferUtilClass = new GeneOfferUtilClass();
            InitializeComponent();
        }

        private void GeneOfferForm_Load(object sender, EventArgs e)
        {
            SKUProduit.AutoCompleteCustomSource = OfferUtilClass.SKUSuggestList(MainForm.DBKeepkool);
        }

        private void GeneOfferForm_OnClosing(object sender, EventArgs e)
        {
            OfferUtilClass.KillThreadExcel();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Choose this product?","",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    listProduit.Add(OfferUtilClass.QueryProduit(MainForm.DBKeepkool, SKUProduit.Text));
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = listProduit[listProduit.Count - 1].VendorSKU;
                    for (int i = 0; i < listProduit[listProduit.Count - 1].VendorSize.Count; i++)
                    {
                        if(i == listProduit[listProduit.Count - 1].VendorSize.Count - 1)
                        {
                            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value += listProduit[listProduit.Count - 1].VendorSize[i];
                        }
                        else
                        {
                            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value += listProduit[listProduit.Count - 1].VendorSize[i] + ",";
                        }
                    }
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = listProduit[listProduit.Count - 1].Collection;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = listProduit[listProduit.Count - 1].Designation;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[4].Value = listProduit[listProduit.Count - 1].Marque;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[5].Value = listProduit[listProduit.Count - 1].Composition;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[6].Value = listProduit[listProduit.Count - 1].Origine;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[7].Value = listProduit[listProduit.Count - 1].PrixAchat;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[8].Value = listProduit[listProduit.Count - 1].Longeur;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[9].Value = listProduit[listProduit.Count - 1].Poid;
                    SKUProduit.Clear();
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Please choose the file you want to save in";
            try
            {
                for (int i = 0; i < listProduit.Count; i++)
                {
                    OfferUtilClass.worksheet.Cells[i + 2, 1] = listProduit[i].VendorSKU;
                    string st = "";
                    for (int j = 0; j< listProduit[i].VendorSize.Count; j++)
                    {
                       
                        if(j== listProduit[i].VendorSize.Count - 1)
                        {
                            st += listProduit[i].VendorSize[j];
                        }
                        else
                        {
                            st += listProduit[i].VendorSize[j]+",";
                        }
                        
                    }
                    OfferUtilClass.worksheet.Cells[i + 2, 2] = st;
                    OfferUtilClass.worksheet.Cells[i + 2, 3] = listProduit[i].Collection;
                    OfferUtilClass.worksheet.Cells[i + 2, 4] = listProduit[i].Designation;
                    OfferUtilClass.worksheet.Cells[i + 2, 5] = listProduit[i].Marque;
                    OfferUtilClass.worksheet.Cells[i + 2, 6] = listProduit[i].Composition;
                    OfferUtilClass.worksheet.Cells[i + 2, 7] = listProduit[i].Origine;
                    OfferUtilClass.worksheet.Cells[i + 2, 8] = listProduit[i].PrixAchat;
                    OfferUtilClass.worksheet.Cells[i + 2, 9] = listProduit[i].Longeur;
                    OfferUtilClass.worksheet.Cells[i + 2, 10] = listProduit[i].Poid;
                }

            }
            catch(System .Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }



            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                OfferUtilClass.workbook.SaveAs(fileName);
                OfferUtilClass.workbook.Close();
                OfferUtilClass.excel.Quit();
            }
        }
    }
}
