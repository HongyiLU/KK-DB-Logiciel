using KK数据库管理软件.Class;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KK数据库管理软件.Forms
{
    public partial class ADUQProduit : Form
    {

        ProUtilClass proUtilClass;
        List<Produit> ListProduits;
        public ADUQProduit()
        {
            InitializeComponent();
        }

        private void ADUQProduit_Load(object sender, EventArgs e)
        {

            try
            {
                ListProduits = new List<Produit>();
                proUtilClass = new ProUtilClass();
                // TODO: 这行代码将数据加载到表“kEEPKOOLDataSet.COLOR”中。您可以根据需要移动或删除它。
                this.cOLORTableAdapter.Fill(this.kEEPKOOLDataSet.COLOR);
                // TODO: 这行代码将数据加载到表“kEEPKOOLDataSet.TAILLE”中。您可以根据需要移动或删除它。
                this.tAILLETableAdapter.Fill(this.kEEPKOOLDataSet.TAILLE);
                // TODO: 这行代码将数据加载到表“kEEPKOOLDataSet.DESIGNATION”中。您可以根据需要移动或删除它。
                this.dESIGNATIONTableAdapter.Fill(this.kEEPKOOLDataSet.DESIGNATION);
                SKUProduit.AutoCompleteCustomSource = proUtilClass.SKUSuggestList(MainForm.DBKeepkool);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void AddProduit_Click(object sender, EventArgs e)
        {
            Produit Pro = new Produit();
            Pro.VendorSKU = SKUProduit.Text;
            Pro.Collection = CollePro.Text;
            Pro.Designation = ComboBox1.Text;
            Pro.Marque = MarqueProduit.Text;
            Pro.Composition = OriProduit.Text;
            Pro.Origine = CompoProduit.Text;
            Pro.PrixAchat = PrixAchatProduit.Text;
            Pro.Cost = CostProduit.Text;
            Pro.MSRP = MSRPProduit.Text;
            Pro.Longeur = LongProduit.Text;
            Pro.inseam = InseamProduit.Text;
            Pro.Poid = PoidProduit.Text;
            Pro.Adresse = AdrProduit.Text;
            Pro.Doublure = DoubProduit.Text;
            Pro.FabCons = FabricConsProduit.Text;

            for (int i = 0; i < checkedListBoxColor.CheckedItems.Count; i++)
            {
                Pro.Color.Add(checkedListBoxColor.GetItemText(checkedListBoxColor.CheckedItems[i]));
            }

            for (int i = 0; i < checkedListBoxSize.CheckedItems.Count; i++)
            {
                Pro.VendorSize.Add(checkedListBoxSize.GetItemText(checkedListBoxSize.CheckedItems[i]));
            }

            try
            {
                ListProduits.Add(Pro);
                if (Pro.Add() == true)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = Pro.VendorSKU;
                    SKUProduit.AutoCompleteCustomSource = proUtilClass.SKUSuggestList(MainForm.DBKeepkool);
                    MessageBox.Show("Product added");
                    for (int i = 0; i < checkedListBoxColor.Items.Count; i++)
                    {
                        checkedListBoxColor.SetItemChecked(i, false);
                    }
                    for (int i = 0; i < checkedListBoxSize.Items.Count; i++)
                    {
                        checkedListBoxSize.SetItemChecked(i, false);
                    }
                    SKUProduit.Clear();
                    PrixAchatProduit.Text = "0";
                    CostProduit.Text = "0";
                    MSRPProduit.Text = "0";
                    LongProduit.Text = "0";
                    InseamProduit.Text = "0";
                    PoidProduit.Text = "0";
                    DoubProduit.Text = "";
                    ShowColorChosen.Clear();
                    ShowSizeChosen.Clear();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void UpdateProduit_Click(object sender, EventArgs e)
        {
            Produit Pro = new Produit();
            Pro.VendorSKU = SKUProduit.Text;
            Pro.Collection = CollePro.Text;
            Pro.Designation = ComboBox1.Text;
            Pro.Marque = MarqueProduit.Text;
            Pro.Composition = OriProduit.Text;
            Pro.Origine = CompoProduit.Text;
            Pro.PrixAchat = PrixAchatProduit.Text;
            Pro.Longeur = LongProduit.Text;
            Pro.Poid = PoidProduit.Text;

            if(checkedListBoxColor.Enabled == true)
            {
                for (int i = 0; i < checkedListBoxColor.CheckedItems.Count; i++)
                {
                    Pro.Color.Add(checkedListBoxColor.GetItemText(checkedListBoxColor.CheckedItems[i]));
                }
            }

            for (int i = 0; i < checkedListBoxSize.CheckedItems.Count; i++)
            {
                Pro.VendorSize.Add(checkedListBoxSize.GetItemText(checkedListBoxSize.CheckedItems[i]));
            }

            try
            {
                Pro.Update();
                MessageBox.Show("Product Updated!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteProduit_Click(object sender, EventArgs e)
        {
            Produit Pro = new Produit();
            Pro.VendorSKU = SKUProduit.Text;
            for (int i = 0; i < checkedListBoxColor.CheckedItems.Count; i++)
            {
                Pro.Color.Add(checkedListBoxColor.GetItemText(checkedListBoxColor.CheckedItems[i]));
            }

            try
            {
                Pro.Delete();
                MessageBox.Show("Product deleted!");
                this.Controls.Clear();
                InitializeComponent();
                SKUProduit.AutoCompleteCustomSource = proUtilClass.SKUSuggestList(MainForm.DBKeepkool);
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel files (*.xlsm)|*.xlsm";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Please choose the file you want to save in";
            for (int i = 0; i < ListProduits.Count; i++)
            {
                string st2 = "";
                string st1 = "";
                proUtilClass.worksheet.Cells[i + 2, 1] = ListProduits[i].VendorSKU;
                for (int j = 0; j < ListProduits[i].Color.Count; j++)
                {
                    if(j == ListProduits[i].Color.Count - 1)
                    {
                        st1 += ListProduits[i].Color[j];
                    }
                    else
                    {
                        st1 += ListProduits[i].Color[j] + ",";
                    }
                    proUtilClass.worksheet.Cells[i + 2, 2] = st1;
                }
                for (int j = 0; j < ListProduits[i].VendorSize.Count; j++)
                {
                    if (j == ListProduits[i].Color.Count - 1)
                    {
                        st2 += ListProduits[i].VendorSize[j];
                    }
                    else
                    {
                        st2 += ListProduits[i].VendorSize[j] + ",";
                    }
                        
                    proUtilClass.worksheet.Cells[i + 2, 3] = st2;
                }
                proUtilClass.worksheet.Cells[i + 2, 2] = st1;
                proUtilClass.worksheet.Cells[i + 2, 3] = st2;
                proUtilClass.worksheet.Cells[i + 2, 4] = 20;
                proUtilClass.worksheet.Cells[i + 2, 5] = ListProduits[i].Designation;
                proUtilClass.worksheet.Cells[i + 2, 6] = ListProduits[i].Marque;
                proUtilClass.worksheet.Cells[i + 2, 7] = ListProduits[i].Composition;
                proUtilClass.worksheet.Cells[i + 2, 8] = ListProduits[i].Origine;
                proUtilClass.worksheet.Cells[i + 2, 9] = ListProduits[i].PrixAchat;
                proUtilClass.worksheet.Cells[i + 2, 10] = ListProduits[i].Cost;
                proUtilClass.worksheet.Cells[i + 2, 11] = ListProduits[i].MSRP;
                proUtilClass.worksheet.Cells[i + 2, 12] = ListProduits[i].Longeur;
                proUtilClass.worksheet.Cells[i + 2, 13] = ListProduits[i].inseam;
                proUtilClass.worksheet.Cells[i + 2, 14] = "Machine wash; hang dry";
                proUtilClass.worksheet.Cells[i + 2, 15] = ModolMeasu.Text;
                proUtilClass.worksheet.Cells[i + 2, 16] = ListProduits[i].Doublure;
                proUtilClass.worksheet.Cells[i + 2, 19] = ListProduits[i].Adresse;
                proUtilClass.worksheet.Cells[i + 2, 20] = ListProduits[i].Poid;
                proUtilClass.worksheet.Cells[i + 2, 21] = ListProduits[i].FabCons;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                proUtilClass.workbook.SaveAs(fileName);
                proUtilClass.workbook.Close();
                proUtilClass.excel.Quit();
            }
        }

        private void ADUQProduit_OnClosing(object sender, EventArgs e)
        {
            proUtilClass.KillThreadExcel();
        }

        private void PrixAchatProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(System.Threading.Thread.CurrentThread.CurrentCulture.Name == "fr-FR")
            {
                if (e.KeyChar == (char)('.'))
                {
                    e.KeyChar = (char)(',');
                }
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)(','))
                {
                    e.Handled = true;
                }
            }
            else
            {
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)('.'))
                {
                    e.Handled = true;
                }
            }
            
        }

        private void MSRPProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "fr-FR")
            {
                if (e.KeyChar == (char)('.'))
                {
                    e.KeyChar = (char)(',');
                }
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)(','))
                {
                    e.Handled = true;
                }
            }
            else
            {
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)('.'))
                {
                    e.Handled = true;
                }
            }

        }

        private void CostProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "fr-FR")
            {
                if (e.KeyChar == (char)('.'))
                {
                    e.KeyChar = (char)(',');
                }
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)(','))
                {
                    e.Handled = true;
                }
            }
            else
            {
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)('.'))
                {
                    e.Handled = true;
                }
            }

        }

        private void LongProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "fr-FR")
            {
                if (e.KeyChar == (char)('.'))
                {
                    e.KeyChar = (char)(',');
                }
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)(','))
                {
                    e.Handled = true;
                }
            }
            else
            {
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)('.'))
                {
                    e.Handled = true;
                }
            }

        }

        private void InseamProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "fr-FR")
            {
                if (e.KeyChar == (char)('.'))
                {
                    e.KeyChar = (char)(',');
                }
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)(','))
                {
                    e.Handled = true;
                }
            }
            else
            {
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)('.'))
                {
                    e.Handled = true;
                }
            }

        }

        private void PoidProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "fr-FR")
            {
                if (e.KeyChar == (char)('.'))
                {
                    e.KeyChar = (char)(',');
                }
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)(','))
                {
                    e.Handled = true;
                }
            }
            else
            {
                //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)('.'))
                {
                    e.Handled = true;
                }
            }

        }

        private void SKUProduit_KeyPress(object sender, KeyEventArgs e)
        {

            if(e.KeyValue == 13)
            {
                AddProduit.Enabled = false;
                OleDbDataReader Dr1 = proUtilClass.QueryProduct(MainForm.DBKeepkool, SKUProduit.Text);
                
                try
                {
                    //if product exist
                    if (Dr1.HasRows)
                    {
                        Dr1.Read();
                        CollePro.Text = Dr1.GetString(1);
                        ComboBox1.Text = Dr1.GetString(2);
                        CompoProduit.Text = Dr1.GetString(3);
                        OriProduit.Text = Dr1.GetString(4);
                        LongProduit.Text = Dr1.GetInt32(5).ToString();
                        PoidProduit.Text = Dr1.GetDouble(6).ToString();
                        PrixAchatProduit.Text = Dr1.GetDouble(8).ToString();
                        MarqueProduit.Text = Dr1.GetString(9);

                        do
                        {
                            for (int i = 0; i < checkedListBoxColor.Items.Count; i++)
                            {
                                if(SKUProduit.Text== Dr1.GetString(0))
                                {
                                    checkedListBoxColor.Enabled = false;
                                    OleDbDataReader Dr2 = proUtilClass.QuerySize(MainForm.DBKeepkool, SKUProduit.Text);
                                    if (Dr2.HasRows)
                                    {
                                        Dr2.Read();
                                        do
                                        {
                                            for (int j = 0; j < checkedListBoxSize.Items.Count; j++)
                                            {
                                                if (checkedListBoxSize.GetItemText(checkedListBoxSize.Items[j]) == Dr2.GetString(1))
                                                {
                                                    checkedListBoxSize.SetItemChecked(j, true);
                                                }
                                            }
                                        } while (Dr2.Read());
                                    }
                                }
                                else
                                {
                                    if (SKUProduit.Text + "-" + checkedListBoxColor.GetItemText(checkedListBoxColor.Items[i]) == Dr1.GetString(0))
                                    {
                                        checkedListBoxColor.SetItemChecked(i, true);
                                        OleDbDataReader Dr2 = proUtilClass.QuerySize(MainForm.DBKeepkool, SKUProduit.Text + "-" + checkedListBoxColor.GetItemText(checkedListBoxColor.Items[i]));
                                        if (Dr2.HasRows)
                                        {
                                            Dr2.Read();
                                            do
                                            {
                                                for (int j = 0; j < checkedListBoxSize.Items.Count; j++)
                                                {
                                                    if (checkedListBoxSize.GetItemText(checkedListBoxSize.Items[j]) == Dr2.GetString(1))
                                                    {
                                                        checkedListBoxSize.SetItemChecked(j, true);
                                                    }
                                                }
                                            } while (Dr2.Read());
                                        }
                                    }
                                }
                                
                            }
                        } while (Dr1.Read());
                    }

                    



                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                e.Handled = false;
            }
            

            
        }

        private void SKUProduit_TextChanged(object sender, EventArgs e)
        {
            AddProduit.Enabled = true;
            checkedListBoxColor.Enabled = true;
            checkedListBoxSize.Enabled = true;
        }

        private void CheckedListBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowColorChosen.Clear();
            for(int i = 0; i < checkedListBoxColor.CheckedItems.Count; i++)
            {
                ShowColorChosen.Text += checkedListBoxColor.GetItemText(checkedListBoxColor.CheckedItems[i]) + ";\r\n";
            }
        }

        private void CheckedListBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSizeChosen.Clear();
            for (int i = 0; i < checkedListBoxSize.CheckedItems.Count; i++)
            {
                ShowSizeChosen.Text += checkedListBoxSize.GetItemText(checkedListBoxSize.CheckedItems[i]) + ";\r\n";
            }
        }
    }
}
