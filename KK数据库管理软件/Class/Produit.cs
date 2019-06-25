using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KK_DMS.Class
{
    class Produit
    {

        public string VendorSKU { get; set; }
        public List<string> Color { get; set; }
        public List<string> VendorSize { get; set; }
        public string Collection { get; set; }
        public string Designation { get; set; }
        public string Marque { get; set; }
        public string Composition { get; set; }
        public string Origine { get; set; }
        public string PrixAchat { get; set; }
        public string Cost { get; set; }
        public string MSRP { get; set; }
        public string Longeur { get; set; }
        public string inseam { get; set; }
        public string Poid { get; set; }
        public string Adresse { get; set; }
        public string Doublure { get; set; }
        public string FabCons { get; set; }
        public string DateAj { get; set; }

        public Produit()
        {
            this.VendorSKU = "";
            this.Collection = "";
            this.Color = new List<string>();
            this.VendorSize = new List<string>();
            this.Designation = "";
            this.Marque = "";
            this.Composition = "";
            this.Origine = "";
            this.PrixAchat = "0";
            this.Cost = "0";
            this.MSRP = "0";
            this.Longeur = "0";
            this.inseam = "0";
            this.Poid = "0";
            this.Adresse = "";
            this.Doublure = "";
            this.FabCons = "";
            this.DateAj = DateTime.Now.ToString("yyyy/MM/dd");
        }

        public bool Add()
        {
            try
            {
                
                
                bool result = false;
                for (int i = 0; i < Color.Count; i++)
                {
                    string cmd = "INSERT INTO PRODUIT VALUES(?,?,?,?,?,?,?,?,?,?)";
                    OleDbCommand sqlcmd = new OleDbCommand(cmd, MainForm.DBKeepkool);
                    sqlcmd.Parameters.AddWithValue("?", this.VendorSKU + "-" + this.Color[i]);
                    sqlcmd.Parameters.AddWithValue("?", this.Collection);
                    sqlcmd.Parameters.AddWithValue("?", this.Designation);
                    sqlcmd.Parameters.AddWithValue("?", this.Origine);
                    sqlcmd.Parameters.AddWithValue("?", this.Composition);
                    sqlcmd.Parameters.AddWithValue("?", this.Longeur);
                    sqlcmd.Parameters.AddWithValue("?", this.Poid);
                    sqlcmd.Parameters.AddWithValue("?", this.DateAj);
                    sqlcmd.Parameters.AddWithValue("?", this.PrixAchat);
                    sqlcmd.Parameters.AddWithValue("?", this.Marque);
                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        result = true;
                    }
                    for (int j = 0; j < VendorSize.Count; j++)
                    {
                        string cmd2 = "INSERT INTO TAILLE_PRODUIT VALUES(?,?)";

                        OleDbCommand sqlcmd2 = new OleDbCommand(cmd2, MainForm.DBKeepkool);
                        sqlcmd2.Parameters.AddWithValue("?", this.VendorSKU + "-" + this.Color[i]);  
                        sqlcmd2.Parameters.AddWithValue("?", this.VendorSize[j]);
                        if (sqlcmd2.ExecuteNonQuery() > 0)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }

                }
                return result;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Update()
        {
            this.Delete();
            if (Color.Count > 0)
            {
                try
                {

                    for (int i = 0; i < Color.Count; i++)
                    {
                        string cmd = "INSERT INTO PRODUIT VALUES(?,?,?,?,?,?,?,?,?,?)";
                        OleDbCommand sqlcmd = new OleDbCommand(cmd, MainForm.DBKeepkool);
                        sqlcmd.Parameters.AddWithValue("?", this.VendorSKU + "-" + this.Color[i]);
                        sqlcmd.Parameters.AddWithValue("?", this.Collection);
                        sqlcmd.Parameters.AddWithValue("?", this.Designation);
                        sqlcmd.Parameters.AddWithValue("?", this.Origine);
                        sqlcmd.Parameters.AddWithValue("?", this.Composition);
                        sqlcmd.Parameters.AddWithValue("?", this.Longeur);
                        sqlcmd.Parameters.AddWithValue("?", this.Poid);
                        sqlcmd.Parameters.AddWithValue("?", this.DateAj);
                        sqlcmd.Parameters.AddWithValue("?", this.PrixAchat);
                        sqlcmd.Parameters.AddWithValue("?", this.Marque);
                        sqlcmd.ExecuteNonQuery();
                        for (int j = 0; j < VendorSize.Count; j++)
                        {
                            string cmd2 = "INSERT INTO TAILLE_PRODUIT VALUES(?,?)";
                            OleDbCommand sqlcmd2 = new OleDbCommand(cmd2, MainForm.DBKeepkool);
                            sqlcmd2.Parameters.AddWithValue("?", this.VendorSKU + "-" + this.Color[i]);
                            sqlcmd2.Parameters.AddWithValue("?", this.VendorSize[j]);
                            sqlcmd2.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                string cmd = "INSERT INTO PRODUIT VALUES(?,?,?,?,?,?,?,?,?,?)";
                OleDbCommand sqlcmd = new OleDbCommand(cmd, MainForm.DBKeepkool);
                sqlcmd.Parameters.AddWithValue("?", this.VendorSKU);
                sqlcmd.Parameters.AddWithValue("?", this.Collection);
                sqlcmd.Parameters.AddWithValue("?", this.Designation);
                sqlcmd.Parameters.AddWithValue("?", this.Origine);
                sqlcmd.Parameters.AddWithValue("?", this.Composition);
                sqlcmd.Parameters.AddWithValue("?", this.Longeur);
                sqlcmd.Parameters.AddWithValue("?", this.Poid);
                sqlcmd.Parameters.AddWithValue("?", this.DateAj);
                sqlcmd.Parameters.AddWithValue("?", this.PrixAchat);
                sqlcmd.Parameters.AddWithValue("?", this.Marque);
                sqlcmd.ExecuteNonQuery();
                for (int j = 0; j < VendorSize.Count; j++)
                {
                    string cmd2 = "INSERT INTO TAILLE_PRODUIT VALUES(?,?)";
                    OleDbCommand sqlcmd2 = new OleDbCommand(cmd2, MainForm.DBKeepkool);
                    sqlcmd2.Parameters.AddWithValue("?", this.VendorSKU);
                    sqlcmd2.Parameters.AddWithValue("?", this.VendorSize[j]);
                    sqlcmd2.ExecuteNonQuery();
                }
                return true;
            }
        }

        public bool Delete()
        {
            bool result = false;
            try
            {
                string cmd = "DELETE FROM PRODUIT WHERE ID_PRODUIT =?";
                OleDbCommand sqlcmd = new OleDbCommand(cmd, MainForm.DBKeepkool);
                sqlcmd.Parameters.AddWithValue("?", this.VendorSKU);
                if (sqlcmd.ExecuteNonQuery() < 1)
                {

                    for(int i = 0; i < this.Color.Count; i++)
                    {
                        OleDbCommand sqlcmd1 = new OleDbCommand(cmd, MainForm.DBKeepkool);
                        string Ref_Pro = this.VendorSKU + "-" + this.Color[i];
                        sqlcmd1.Parameters.AddWithValue("?", Ref_Pro);
                        if (sqlcmd1.ExecuteNonQuery() > 0)
                        {
                            result = true;
                        }
                    }
                }
                else
                {
                    result = true;
                }
                return result;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
