using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KK_DMS
{
    public partial class AnaAchatVente : Form
    {
        DateTime DateBegin;
        DateTime DateEnd;
        public AnaAchatVente()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateBegin = dateTimePicker1.Value.Date;
            FacVente.DataSource = null;
            FacAchat.DataSource = null;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateEnd = dateTimePicker2.Value.Date;
            FacVente.DataSource = null;
            FacAchat.DataSource = null;

        }

        private void AnaAchatVente_Load(object sender, EventArgs e)
        {
            DateBegin = dateTimePicker1.Value.Date;
            DateEnd = dateTimePicker2.Value.Date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateBegin <= DateEnd)
                {
                    //FacVente
                    string sql1 = "SELECT PRODUIT.DESIGNATION, Sum(FACVENTE_DETAIL.QUANTITE) AS QUANTITE, FACVENTE_DETAIL.PRIX AS PRIX_UNITAIRE FROM FAC_VENTE, FACVENTE_DETAIL INNER JOIN PRODUIT ON PRODUIT.ID_PRODUIT = FACVENTE_DETAIL.ID_PRODUIT WHERE((([FAC_VENTE].[DATE_FAC]) >=[?] And([FAC_VENTE].[DATE_FAC]) <=[?])) GROUP BY PRODUIT.DESIGNATION, FACVENTE_DETAIL.PRIX";
                    DataSet DS1 = new DataSet();
                    OleDbCommand DBcmd1 = new OleDbCommand(sql1, MainForm.DBKeepkool);
                    DBcmd1.Parameters.AddWithValue("?", DateBegin.ToString("yyyy/MM/dd"));
                    DBcmd1.Parameters.AddWithValue("?", DateEnd.ToString("yyyy/MM/dd"));
                    OleDbDataAdapter DA1 = new OleDbDataAdapter(DBcmd1);
                    if (DA1.Fill(DS1, "FAC_VENTE_ANA") == 0)
                    {
                        DS1 = null;
                        MessageBox.Show("Did not find any record in the table FAC_VENTE!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BindingSource bs = new BindingSource();
                        bs.DataMember = "FAC_VENTE_ANA";
                        bs.DataSource = DS1.Tables[0];
                        FacVente.DataSource = bs;
                    }

                    //SELECT FACACHAT_DETAIL.DESIGNATION FROM FAC_ACHAT,FACACHAT_DETAIL WHERE FAC_ACHAT.DATE_FAC > #01/01/2019# GROUP BY FACACHAT_DETAIL.DESIGNATION;
                    //FacAchat
                    string sql2 = "SELECT DESIGNATION, SUM(QUANTITE) AS QUANTITY, PRIX AS PRIX_UNITAIRE FROM FAC_ACHAT,FACACHAT_DETAIL  WHERE FAC_ACHAT.DATE_FAC >= ? AND FAC_ACHAT.DATE_FAC <= ? GROUP BY FACACHAT_DETAIL.DESIGNATION,FACACHAT_DETAIL.PRIX";
                    DataSet DS2 = new DataSet();
                    OleDbCommand DBcmd2 = new OleDbCommand(sql2, MainForm.DBKeepkool);
                    DBcmd2.Parameters.AddWithValue("?", DateBegin.ToString("yyyy/MM/dd"));
                    DBcmd2.Parameters.AddWithValue("?", DateEnd.ToString("yyyy/MM/dd"));
                    OleDbDataAdapter DA2 = new OleDbDataAdapter(DBcmd2);
                    if (DA2.Fill(DS2, "FAC_ACHAT_ANA") == 0)
                    {
                        DS2 = null;
                        MessageBox.Show("Did not find any record in the table FAC_ACHAT!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BindingSource bs = new BindingSource();
                        bs.DataMember = "FAC_ACHAT_ANA";
                        bs.DataSource = DS2.Tables[0];
                        FacAchat.DataSource = bs;
                    }
                }
                else
                {
                    MessageBox.Show("The beginning date should not be ahead of the end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
    }
}
