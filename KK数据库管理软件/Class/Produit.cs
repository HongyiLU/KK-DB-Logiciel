using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KK数据库管理软件.Class
{
    class Produit
    {

        public string VendorSKU;
        public List<string> Color;
        public List<string> VendorSize;
        public string Collection;
        public string Designation;
        public string Marque;
        public string Composition;
        public string Origine;
        public string PrixAchat;
        public string Cost;
        public string MSRP;
        public string Longeur;
        public string inseam;
        public string Poid;
        public string Adresse;
        public string Doublure;
        public string FabCons;
        public string DateAj;

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

        public void Delete()
        {
            try
            {
                string cmd = "DELETE FROM PRODUIT WHERE ID_PRODUIT LIKE '" + this.VendorSKU + "%'";
                OleDbCommand sqlcmd = new OleDbCommand(cmd, MainForm.DBKeepkool);
                //sqlcmd.Parameters.AddWithValue("?", this.VendorSKU);
                sqlcmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
