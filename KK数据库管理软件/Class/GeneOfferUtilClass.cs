using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK数据库管理软件.Class
{

    class GeneOfferUtilClass
    {
        public Microsoft.Office.Interop.Excel.Application excel;
        public Workbook workbook;
        public Worksheet worksheet;

        public GeneOfferUtilClass()
        {
            excel = new Microsoft.Office.Interop.Excel.Application();
            workbook = excel.Workbooks.Open(System.IO.Directory.GetCurrentDirectory() + @"\Models\Offer - Prix d'achat.xlsx");
            worksheet = workbook.Worksheets[1];
        }

        public AutoCompleteStringCollection SKUSuggestList(OleDbConnection DB)
        {
            try
            {
                AutoCompleteStringCollection list = new AutoCompleteStringCollection();
                string cmd = "SELECT ID_PRODUIT FROM PRODUIT";
                OleDbCommand sqlcmd = new OleDbCommand(cmd, DB);
                OleDbDataReader Dr = sqlcmd.ExecuteReader();
                while (Dr.Read())
                {
                    list.Add(Dr.GetString(0));
                }
                return list;
            }
            catch
            {
                return null;
            }
        }

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);

        public void KillThreadExcel()
        {
            try
            {
                IntPtr t = new IntPtr(this.excel.Hwnd);
                int k = 0;
                GetWindowThreadProcessId(t, out k);
                System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessById(k);
                p.Kill();
            }
            catch
            {

            }

        }

        public Produit QueryProduit(OleDbConnection DB,string SKUProduit)
        {
            Produit Pro = new Produit();
            string cmd1 = "SELECT * FROM PRODUIT WHERE ID_PRODUIT=?";
            string cmd2 = "SELECT * FROM TAILLE_PRODUIT WHERE ID_PRODUIT=?";
            try
            {
                OleDbCommand sqlcmd1 = new OleDbCommand(cmd1, DB);
                sqlcmd1.Parameters.AddWithValue("?", SKUProduit);
                OleDbDataReader Dr1 = sqlcmd1.ExecuteReader();
                Dr1.Read();
                Pro.VendorSKU = Dr1.GetString(0);
                Pro.Collection = Dr1.GetString(1);
                Pro.Designation = Dr1.GetString(2);
                Pro.Origine = Dr1.GetString(3);
                Pro.Composition = Dr1.GetString(4);
                Pro.Longeur = Dr1.GetInt32(5).ToString();
                Pro.Poid = Dr1.GetDouble(6).ToString();
                Pro.PrixAchat = Dr1.GetDouble(8).ToString();
                Pro.Marque = Dr1.GetString(9);


                OleDbCommand sqlcmd2 = new OleDbCommand(cmd2, DB);
                sqlcmd2.Parameters.AddWithValue("?", SKUProduit);
                OleDbDataReader Dr2 = sqlcmd2.ExecuteReader();
                while (Dr2.Read())
                {
                    Pro.VendorSize.Add(Dr2.GetString(1));
                }

                return Pro;
            }catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            
        }
    }
}
