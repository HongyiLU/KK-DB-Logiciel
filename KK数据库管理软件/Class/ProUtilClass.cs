using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KK数据库管理软件.Class
{
    class ProUtilClass
    {

        public Microsoft.Office.Interop.Excel.Application excel;
        public Workbook workbook;
        public Worksheet worksheet;
        public ProUtilClass()
        {
            excel = new Microsoft.Office.Interop.Excel.Application();
            workbook = excel.Workbooks.Open(System.IO.Directory.GetCurrentDirectory() + @"\Models\模板 Offer - Prix d'achat.xlsm");
            worksheet = workbook.Worksheets[1];
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
            }catch
            {
                return null;
            }
            
            
        }
           
        public OleDbDataReader QueryProduct(OleDbConnection DB,string Ref_Pro)
        {
            try
            {
                string cmd = "SELECT * FROM PRODUIT WHERE ID_PRODUIT LIKE '"+ Ref_Pro +"%'";
                OleDbCommand sqlcmd = new OleDbCommand(cmd, DB);
                //sqlcmd.Parameters.AddWithValue("?", Ref_Pro);
                OleDbDataReader Dr = sqlcmd.ExecuteReader();
                return Dr;
            }
            catch
            {
                return null;
            }
            
        }

        public OleDbDataReader QuerySize(OleDbConnection DB, string Ref_Pro)
        {
            try
            {
                string cmd = "SELECT * FROM TAILLE_PRODUIT WHERE ID_PRODUIT=?";
                OleDbCommand sqlcmd = new OleDbCommand(cmd, DB);
                sqlcmd.Parameters.AddWithValue("?", Ref_Pro);
                OleDbDataReader Dr = sqlcmd.ExecuteReader();
                return Dr;
            }
            catch
            {
                return null;
            }

        }
    }
}
