using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KK_DMS.Class
{
    public class SepUtilClass
    {
        public List<string> Fourni_Code;
        public List<string> Fourni_Name;
        public string dateTime;
        OleDbConnection DB;

        public SepUtilClass(OleDbConnection Database)
        {
            this.DB = Database;
            Fourni_Code = new List<string>();
            Fourni_Name = new List<string>();
        }


        public void FillFourni()
        {
            OleDbCommand Com;
            OleDbDataReader Dr;
            try
            {
                string DBcom = "SELECT ID_FOURNISSEUR,NOM_FOURNISSEUR FROM FOURNISSEUR";
                Com = new OleDbCommand(DBcom, DB);
                Dr = Com.ExecuteReader();
                if (Dr.HasRows == false)
                {
                    return;
                }

                while (Dr.Read())
                {
                    Fourni_Code.Add(Dr.GetString(0));
                    Fourni_Name.Add(Dr.GetString(1));
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void SaveTemps(Worksheet worksheet, List<Range> ListCode, List<Range> ListSize, List<Range> ListQuante, List<Range> ListPrix, int indexCode)
        {
            for (int i = 1; i <= worksheet.UsedRange.Rows.Count; i++)
            {
                Range MyCellsCode = worksheet.Cells[i, 10]; ;
                if (MyCellsCode.Text != "")
                {
                    string text1 = MyCellsCode.Text;
                    if (text1.Substring(0, 4).Contains(Fourni_Code[indexCode]))
                    {
                        ListCode.Add(worksheet.Cells[i, 10]);
                        ListSize.Add(worksheet.Cells[i, 13]);
                        ListQuante.Add(worksheet.Cells[i, 14]);
                        ListPrix.Add(worksheet.Cells[i, 15]);
                    }

                }
            }
        }

        public void SeperateDoc(string PathDocuments)
        {
            Microsoft.Office.Interop.Excel.Application xl1 = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
            string PathModel = System.IO.Directory.GetCurrentDirectory() + @"\Models\Modele Bon de commande - Fournisseur.xlsx";
            try
            {
                Workbook wb1;
                Workbook wb;
                List<Range> TempsCode = new List<Range>();
                List<Range> TempsSize = new List<Range>();
                List<Range> TempsQuante = new List<Range>();
                List<Range> TempsPrix = new List<Range>();
                wb1 = xl1.Workbooks.Open(PathDocuments);

                Worksheet mySheet1 = wb1.Worksheets[1];
                int Ref_Commande = 1;

                for (int i = 0; i < Fourni_Code.Count; i++)
                {
                    SaveTemps(mySheet1, TempsCode, TempsSize, TempsQuante, TempsPrix, i);
                    if (TempsCode.Count != 0)
                    {
                        wb = xl.Workbooks.Open(PathModel);
                        Worksheet mySheet = wb.Worksheets[1];
                        int TotalEach = 0, TotalQte = 0, y = 0, x = 0;
                        double TotalPrix = 0;
                        for (x = 0; x < TempsCode.Count; x++)
                        {
                            mySheet.Rows[x + 17].Insert();
                            mySheet.Rows[x + 17].ClearFormats();
                            mySheet.Cells[x + 17, 1] = TempsCode[x];
                            mySheet.Cells[x + 17, 2] = TempsSize[x];
                            mySheet.Cells[x + 17, 3] = TempsQuante[x];
                            if (TempsCode[x].Text == TempsCode[y].Text)
                            {
                                TotalEach += TempsQuante[x].Value;
                                mySheet.Range[mySheet.Cells[y + 17, 4], mySheet.Cells[x + 17, 4]].Merge();
                                mySheet.Range[mySheet.Cells[y + 17, 5], mySheet.Cells[x + 17, 5]].Merge();
                                mySheet.Cells[y + 17, 4] = TotalEach;
                                mySheet.Cells[y + 17, 5] = QueryPrice(TempsCode[x].Text);
                            }
                            else
                            {
                                y = x;
                                TotalEach = (int)TempsQuante[y].Value;
                                mySheet.Cells[y + 17, 4] = TotalEach;
                                mySheet.Cells[y + 17, 5] = QueryPrice(TempsCode[y].Text);
                                mySheet.Range[mySheet.Cells[x + 16, 1], mySheet.Cells[x + 16, 5]].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                            }
                            TotalQte += (int)TempsQuante[x].Value;
                            TotalPrix += (int)TempsQuante[x].Value * mySheet.Cells[y + 17, 5].Value;
                            mySheet.Cells[x + 18, 4] = TotalQte;
                            mySheet.Cells[x + 18, 5] = TotalPrix;

                        }

                        mySheet.Cells[2, 3] = "N°" + DateTime.Now.Year.ToString() + "KK" + Ref_Commande;
                        mySheet.Cells[11, 1] = DateTime.Now.ToString("yyyy/MM/dd");
                        mySheet.Cells[11, 2] = DateTime.Now.ToString("yyyy/MM/dd");
                        mySheet.Cells[11, 4] = Fourni_Name[i];
                        mySheet.Rows[17 + ":" + (x + 17)].AutoFit();
                        Ref_Commande += 1;
                        wb.SaveAs(wb1.Path + "/" + mySheet.Cells[2, 3].Text + " " + Fourni_Code[i] + " " + DateTime.Now.ToString("yyyyMMdd") + ".xlsx");
                        wb.Close();
                    }
                    TempsCode.Clear();
                    TempsSize.Clear();
                    TempsQuante.Clear();
                    TempsPrix.Clear();
                }
                xl.Quit();
                wb1.Close();
                xl1.Quit();
                GC.Collect();
                KillThreadExcel(xl1);
                KillThreadExcel(xl);


            }
            catch (System.Exception ex)
            {
                KillThreadExcel(xl1);
                KillThreadExcel(xl);
                MessageBox.Show(ex.Message);
            }


        }

        public void WriteDoc(string PathDocuments)
        {
            string Ref_Vente = System.IO.Path.GetFileNameWithoutExtension(PathDocuments);
            Microsoft.Office.Interop.Excel.Application xl1 = new Microsoft.Office.Interop.Excel.Application();
            try
            {

                Workbook wb1;
                int Ref_Commande = ReadAchatCount();
                if (Ref_Commande == -1)
                {
                    MessageBox.Show("Error!", "Error!", 0, System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    List<Range> TempsCode = new List<Range>();
                    List<Range> TempsSize = new List<Range>();
                    List<Range> TempsQuante = new List<Range>();
                    List<Range> TempsPrix = new List<Range>();
                    wb1 = xl1.Workbooks.Open(PathDocuments);
                    Worksheet mySheet1 = wb1.Worksheets[1];
                    WriteVente(Ref_Vente);

                    for (int i = 0; i < Fourni_Code.Count; i++)
                    {
                        SaveTemps(mySheet1, TempsCode, TempsSize, TempsQuante, TempsPrix, i);
                        if (TempsCode.Count != 0)
                        {
                            WriteAchat(Ref_Commande, Fourni_Code[i]);
                            for (int x = 0; x < TempsCode.Count; x++)
                            {
                                WriteDetailVente(Ref_Vente, TempsCode[x].Text, TempsSize[x].Text, TempsQuante[x].Text, TempsPrix[x].Text);
                                WriteDetailAchat(Ref_Commande, TempsCode[x].Text, TempsSize[x].Text, TempsQuante[x].Text);
                            }
                            Ref_Commande += 1;
                        }
                        TempsCode.Clear();
                        TempsSize.Clear();
                        TempsQuante.Clear();
                        TempsPrix.Clear();
                    }
                    wb1.Close();
                    xl1.Quit();
                    GC.Collect();
                    KillThreadExcel(xl1);
                }
            }
            catch (System.Exception ex)
            {
                KillThreadExcel(xl1);
                MessageBox.Show(ex.Message);
            }
        }

        public void WriteAndSeperateDoc(string PathDocuments)
        {
            string Ref_Vente = System.IO.Path.GetFileNameWithoutExtension(PathDocuments);
            Microsoft.Office.Interop.Excel.Application xl1 = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
            string PathModel = System.IO.Directory.GetCurrentDirectory() + @"\Models\Modele Bon de commande - Fournisseur.xlsx";
            try
            {

                Workbook wb1;
                Workbook wb;


                int Ref_Commande = ReadAchatCount();
                if (Ref_Commande == -1)
                {
                    MessageBox.Show("Error!", "Error!", 0, System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    List<Range> TempsCode = new List<Range>();
                    List<Range> TempsSize = new List<Range>();
                    List<Range> TempsQuante = new List<Range>();
                    List<Range> TempsPrix = new List<Range>();
                    wb1 = xl1.Workbooks.Open(PathDocuments);
                    Worksheet mySheet1 = wb1.Worksheets[1];
                    WriteVente(Ref_Vente);
                    for (int i = 0; i < Fourni_Code.Count; i++)
                    {
                        SaveTemps(mySheet1, TempsCode, TempsSize, TempsQuante, TempsPrix, i);
                        if (TempsCode.Count != 0)
                        {
                            wb = xl.Workbooks.Open(PathModel);
                            Worksheet mySheet = wb.Worksheets[1];
                            WriteAchat(Ref_Commande, Fourni_Code[i]);
                            int TotalEach = 0, TotalQte = 0, y = 0, x = 0;
                            double TotalPrix = 0;
                            for (x = 0; x < TempsCode.Count; x++)
                            {
                                mySheet.Rows[x + 17].Insert();
                                mySheet.Rows[x + 17].ClearFormats();
                                mySheet.Cells[x + 17, 1] = TempsCode[x];
                                mySheet.Cells[x + 17, 2] = TempsSize[x];
                                mySheet.Cells[x + 17, 3] = TempsQuante[x];
                                if (TempsCode[x].Text == TempsCode[y].Text)
                                {
                                    TotalEach += TempsQuante[x].Value;
                                    mySheet.Range[mySheet.Cells[y + 17, 4], mySheet.Cells[x + 17, 4]].Merge();
                                    mySheet.Range[mySheet.Cells[y + 17, 5], mySheet.Cells[x + 17, 5]].Merge();
                                    mySheet.Cells[y + 17, 4] = TotalEach;
                                    mySheet.Cells[y + 17, 5] = QueryPrice(TempsCode[x].Text);
                                }
                                else
                                {
                                    y = x;
                                    TotalEach = (int)TempsQuante[y].Value;
                                    mySheet.Cells[y + 17, 4] = TotalEach;
                                    mySheet.Cells[y + 17, 5] = QueryPrice(TempsCode[y].Text);
                                    mySheet.Range[mySheet.Cells[x + 16, 1], mySheet.Cells[x + 16, 5]].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                }
                                TotalQte += (int)TempsQuante[x].Value;
                                TotalPrix += (int)TempsQuante[x].Value * mySheet.Cells[y + 17, 5].Value;
                                WriteDetailAchat(Ref_Commande, TempsCode[x].Text, TempsSize[x].Text, TempsQuante[x].Text);
                                WriteDetailVente(Ref_Vente, TempsCode[x].Text, TempsSize[x].Text, TempsQuante[x].Text, TempsPrix[x].Text);
                                mySheet.Cells[x + 18, 4] = TotalQte;
                                mySheet.Cells[x + 18, 5] = TotalPrix;

                            }

                            mySheet.Cells[2, 3] = "N°" + DateTime.Now.Year.ToString() + "KK" + Ref_Commande;
                            mySheet.Cells[11, 1] = DateTime.Now.ToString("yyyy/MM/dd");
                            mySheet.Cells[11, 2] = DateTime.Now.ToString("yyyy/MM/dd");
                            mySheet.Cells[11, 4] = Fourni_Name[i];
                            mySheet.Rows[17 + ":" + (x + 17)].AutoFit();
                            Ref_Commande++;
                            wb.SaveAs(wb1.Path + "/" + mySheet.Cells[2, 3].Text + " " + Fourni_Code[i] + " " + DateTime.Now.ToString("yyyyMMdd") + ".xlsx");
                            wb.Close();
                        }
                        TempsCode.Clear();
                        TempsSize.Clear();
                        TempsQuante.Clear();
                        TempsPrix.Clear();
                    }
                    xl.Quit();
                    wb1.Close();
                    xl1.Quit();
                    GC.Collect();
                    KillThreadExcel(xl1);
                    KillThreadExcel(xl);
                }




            }
            catch (System.Exception ex)
            {
                KillThreadExcel(xl1);
                KillThreadExcel(xl);
                MessageBox.Show(ex.Message);
            }
        }

        public void WriteVente(string Ref_Vente)
        {
            string cmd = "INSERT INTO VENTE VALUES(?,?)";
            OleDbCommand DBcom = new OleDbCommand(cmd, DB);
            DBcom.Parameters.AddWithValue("?", Ref_Vente);
            DBcom.Parameters.AddWithValue("?", dateTime);
            DBcom.ExecuteNonQuery();
            DBcom.Dispose();
        }

        public void WriteAchat(int Ref_Commande, string FourniCode)
        {
            string cmd = "INSERT INTO ACHAT VALUES(?,'N°?KK?',?,?)";
            OleDbCommand DBcom = new OleDbCommand(cmd, DB);
            DBcom.Parameters.AddWithValue("?", Ref_Commande);
            DBcom.Parameters.AddWithValue("?", DateTime.Now.Year.ToString());
            DBcom.Parameters.AddWithValue("?", Ref_Commande);
            DBcom.Parameters.AddWithValue("?", FourniCode);
            DBcom.Parameters.AddWithValue("?", dateTime);
            DBcom.ExecuteNonQuery();
            DBcom.Dispose();
        }

        public void WriteDetailVente(string Ref_Vente, string ID_PRODUIT, string TAILLE, string QUANTITE, string PRIX)
        {
            string cmd = "INSERT INTO DETAIL_VENTE(ID_VENTE, ID_PRODUIT, TAILLE, QUANTITE, PRIX) VALUES(?,?,?,?,?)";
            OleDbCommand DBcom = new OleDbCommand(cmd, DB);
            DBcom.Parameters.AddWithValue("?", Ref_Vente);
            DBcom.Parameters.AddWithValue("?", ID_PRODUIT);
            DBcom.Parameters.AddWithValue("?", TAILLE);
            DBcom.Parameters.AddWithValue("?", QUANTITE);
            DBcom.Parameters.AddWithValue("?", PRIX);
            DBcom.ExecuteNonQuery();
            DBcom.Dispose();
        }

        public void WriteDetailAchat(int Ref_Commande, string FourniCode, string Size, string Quantity)
        {
            string cmd = "INSERT INTO DETAIL_ACHAT(ID_ACHAT,ID_PRODUIT,TAILLE,QUANTITE) VALUES(?,?,?,?)";
            OleDbCommand DBcom = new OleDbCommand(cmd, DB);
            DBcom.Parameters.AddWithValue("?", Ref_Commande);
            DBcom.Parameters.AddWithValue("?", FourniCode);
            DBcom.Parameters.AddWithValue("?", Size);
            DBcom.Parameters.AddWithValue("?", Quantity);
            DBcom.ExecuteNonQuery();
            DBcom.Dispose();
        }

        public void WriteFacVente(string ID_FAC, string DATE_FAC)
        {
            string sqlcmd1 = "INSERT INTO FAC_VENTE VALUES(?,?)";
            OleDbCommand DBcmd1 = new OleDbCommand(sqlcmd1, DB);
            DBcmd1.Parameters.AddWithValue("?", ID_FAC);
            DBcmd1.Parameters.AddWithValue("?", DATE_FAC);
            DBcmd1.ExecuteNonQuery();
            DBcmd1.Dispose();
        }

        public void WriteFacVenteDetail(string ID_FAC, string ID_PRODUIT, string QUANTITE, string PRIX)
        {
            string sqlcmd2 = "INSERT INTO FACVENTE_DETAIL VALUES(?,?,?,?)";
            OleDbCommand DBcmd2 = new OleDbCommand(sqlcmd2, DB);
            DBcmd2.Parameters.AddWithValue("?", ID_FAC);
            DBcmd2.Parameters.AddWithValue("?", ID_PRODUIT);
            DBcmd2.Parameters.AddWithValue("?", QUANTITE);
            DBcmd2.Parameters.AddWithValue("?", PRIX);
            DBcmd2.ExecuteNonQuery();
            DBcmd2.Dispose();
        }

        public void WriteDocFacVente(string PathDocuments)
        {
            string Ref_FacVente;
            Microsoft.Office.Interop.Excel.Application xl1 = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                Workbook wb1;
                List<Range> TempsCode = new List<Range>();
                List<Range> TempsQuante = new List<Range>();
                List<Range> TempsPrix = new List<Range>();
                wb1 = xl1.Workbooks.Open(PathDocuments);
                Worksheet mySheet1 = wb1.Worksheets[1];
                Ref_FacVente = mySheet1.Cells[3, 2].Text;
                WriteFacVente(Ref_FacVente, dateTime);
                for (int i = 26; i <= mySheet1.UsedRange.Rows.Count - 1; i++)
                {
                    if (mySheet1.Cells[i, 2].Text != "")
                    {
                        TempsCode.Add(mySheet1.Cells[i, 2]);
                        TempsQuante.Add(mySheet1.Cells[i, 7]);
                        TempsPrix.Add(mySheet1.Cells[i, 8]);
                    }

                }


                for (int i = 0; i < TempsCode.Count; i++)
                {
                    WriteFacVenteDetail(Ref_FacVente, TempsCode[i].Text, TempsQuante[i].Text, TempsPrix[i].Text);
                }
                wb1.Close();
                xl1.Quit();
                GC.Collect();
                KillThreadExcel(xl1);
            }
            catch (System.Exception ex)
            {
                KillThreadExcel(xl1);
                MessageBox.Show(ex.Message);
            }
        }

        public int ReadAchatCount()
        {
            try
            {
                string cmd = "SELECT ID_ACHAT FROM ACHAT WHERE ID_ACHAT = (SELECT MAX(ID_ACHAT) FROM ACHAT)";
                OleDbCommand DBcmd = new OleDbCommand(cmd, DB);
                OleDbDataReader Dr = DBcmd.ExecuteReader();
                Dr.Read();
                if (Dr.HasRows == false)
                {
                    return 1;
                }
                else
                {
                    int a = Dr.GetInt32(0) + 1;
                    return a;
                }
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
                return -1;
            }

        }


        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);

        public void KillThreadExcel(Microsoft.Office.Interop.Excel.Application excel)
        {
            IntPtr t = new IntPtr(excel.Hwnd);

            int k = 0;
            GetWindowThreadProcessId(t, out k);
            System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessById(k);
            p.Kill();
        }

        public double QueryPrice(string RefProduit)
        {
            double price;
            string cmd = "SELECT  PRIX_ACHAT FROM PRODUIT WHERE(ID_PRODUIT = ?)";
            OleDbCommand sqlcmd = new OleDbCommand(cmd, DB);
            sqlcmd.Parameters.AddWithValue("?", RefProduit);
            OleDbDataReader Dr = sqlcmd.ExecuteReader();
            Dr.Read();
            if (Dr.HasRows == true)
            {
                price = (double)Dr.GetValue(0);
                return price;
            }
            else
            {
                MessageBox.Show("Didn't find this product: " + RefProduit);
                return 0;
            }

        }
    }
}
