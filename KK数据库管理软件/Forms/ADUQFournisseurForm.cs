using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KK_DMS.Forms
{
    public partial class ADUQFournisseurForm : Form
    {
        private string IDFourni = "";
        private string NameFourni = "";
        private string CateFourni = "";
        private string AdrFourni = "";
        private string TeleFourni = "";
        private string EmailFourni = "";

        public ADUQFournisseurForm()
        {
            InitializeComponent();
        }

        private void ID_FOURNISSEUR_TextChanged(object sender, EventArgs e)
        {
            IDFourni = ID_FOURNISSEUR.Text;
            string sqlcmd = "SELECT * FROM FOURNISSEUR WHERE ID_FOURNISSEUR=?";
            try
            {
                OleDbCommand cmd = new OleDbCommand(sqlcmd, MainForm.DBKeepkool);
                cmd.Parameters.AddWithValue("?", IDFourni);
                OleDbDataReader Dr = cmd.ExecuteReader();
                Dr.Read();
                if (Dr.HasRows == false)
                {
                    NOM_FOURNISSEUR.Text = "";
                    CATEGORIE_FOURNISSEUR.Text = "";
                    ADRESSE_FOURNISSEUR.Text = "";
                    TELEPHONE_FOURNISSEUR.Text = "";
                    EMAIL_FOURNISSEUR.Text = "";
                }
                else
                {
                    NOM_FOURNISSEUR.Text = Dr.GetString(1);
                    CATEGORIE_FOURNISSEUR.Text = Dr.GetString(2);
                    ADRESSE_FOURNISSEUR.Text = Dr.GetString(3);
                    TELEPHONE_FOURNISSEUR.Text = Dr.GetString(4);
                    EMAIL_FOURNISSEUR.Text = Dr.GetString(5);
                }
            }
            catch
            {
                return;
            }

        }

        private void NOM_FOURNISSEUR_TextChanged(object sender, EventArgs e)
        {
            NameFourni = NOM_FOURNISSEUR.Text;
            if (NOM_FOURNISSEUR.Text != "")
            {
                string sqlcmd = "SELECT * FROM FOURNISSEUR WHERE NOM_FOURNISSEUR=?";
                try
                {
                    OleDbCommand cmd = new OleDbCommand(sqlcmd, MainForm.DBKeepkool);
                    cmd.Parameters.AddWithValue("?", NameFourni);
                    OleDbDataReader Dr = cmd.ExecuteReader();
                    Dr.Read();
                    if (Dr.HasRows == true)
                    {
                        ID_FOURNISSEUR.Text = Dr.GetString(0);
                        CATEGORIE_FOURNISSEUR.Text = Dr.GetString(2);
                        ADRESSE_FOURNISSEUR.Text = Dr.GetString(3);
                        TELEPHONE_FOURNISSEUR.Text = Dr.GetString(4);
                        EMAIL_FOURNISSEUR.Text = Dr.GetString(5);
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private void CATEGORIE_FOURNISSEUR_TextChanged(object sender, EventArgs e)
        {
            CateFourni = CATEGORIE_FOURNISSEUR.Text;
        }

        private void ADRESSE_FOURNISSEUR_TextChanged(object sender, EventArgs e)
        {
            AdrFourni = ADRESSE_FOURNISSEUR.Text;
        }

        private void TELEPHONE_FOURNISSEUR_TextChanged(object sender, EventArgs e)
        {
            TeleFourni = TELEPHONE_FOURNISSEUR.Text;
            if (TELEPHONE_FOURNISSEUR.Text != "")
            {
                string sqlcmd = "SELECT * FROM FOURNISSEUR WHERE TELEPHONE=?";
                try
                {
                    OleDbCommand cmd = new OleDbCommand(sqlcmd, MainForm.DBKeepkool);
                    cmd.Parameters.AddWithValue("?", TeleFourni);
                    OleDbDataReader Dr = cmd.ExecuteReader();
                    Dr.Read();
                    if (Dr.HasRows == true)
                    {
                        ID_FOURNISSEUR.Text = Dr.GetString(0);
                        NOM_FOURNISSEUR.Text = Dr.GetString(1);
                        CATEGORIE_FOURNISSEUR.Text = Dr.GetString(2);
                        ADRESSE_FOURNISSEUR.Text = Dr.GetString(3);
                        TELEPHONE_FOURNISSEUR.Text = Dr.GetString(4);
                        EMAIL_FOURNISSEUR.Text = Dr.GetString(5);
                    }
                }
                catch
                {
                    return;
                }
            }

        }

        private void EMAIL_FOURNISSEUR_TextChanged(object sender, EventArgs e)
        {
            EmailFourni = EMAIL_FOURNISSEUR.Text;
            if (EMAIL_FOURNISSEUR.Text != "")
            {
                string sqlcmd = "SELECT * FROM FOURNISSEUR WHERE EMAIL=?";
                try
                {
                    OleDbCommand cmd = new OleDbCommand(sqlcmd, MainForm.DBKeepkool);
                    cmd.Parameters.AddWithValue("?", EmailFourni);
                    OleDbDataReader Dr = cmd.ExecuteReader();
                    Dr.Read();
                    if (Dr.HasRows == true)
                    {
                        ID_FOURNISSEUR.Text = Dr.GetString(0);
                        NOM_FOURNISSEUR.Text = Dr.GetString(1);
                        CATEGORIE_FOURNISSEUR.Text = Dr.GetString(2);
                        ADRESSE_FOURNISSEUR.Text = Dr.GetString(3);
                        TELEPHONE_FOURNISSEUR.Text = Dr.GetString(4);
                        EMAIL_FOURNISSEUR.Text = Dr.GetString(5);
                    }
                }
                catch
                {
                    return;
                }
            }

        }

        private void WriteNewSupplier_Click(object sender, EventArgs e)
        {
            if (IDFourni == "")
            {
                MessageBox.Show("Please enter the primary key!", "Warning", 0, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("ID_Fournisseur : " + IDFourni + "\r\n" +
                "NOM_FOURNISSEUR: " + NameFourni + "\r\n" +
                "Catégorie: " + CateFourni + "\r\n" +
                "Adresse_Fournisseur: " + AdrFourni + "\r\n" +
                "Téléphone_Fournisseur: " + TeleFourni + "\r\n" +
                "Email_Fournisseur: " + EmailFourni + "\r\n" +
                "Confirm to add？", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sqlcmd = "INSERT INTO FOURNISSEUR VALUES(?,?,?,?,?,?)";
                try
                {
                    OleDbCommand cmd = new OleDbCommand(sqlcmd, MainForm.DBKeepkool);
                    cmd.Parameters.AddWithValue("?", IDFourni);
                    cmd.Parameters.AddWithValue("?", NameFourni);
                    cmd.Parameters.AddWithValue("?", CateFourni);
                    cmd.Parameters.AddWithValue("?", AdrFourni);
                    cmd.Parameters.AddWithValue("?", TeleFourni);
                    cmd.Parameters.AddWithValue("?", EmailFourni);
                    cmd.ExecuteNonQuery();
                    ID_FOURNISSEUR.AutoCompleteCustomSource = FourniSuggestList();
                    MessageBox.Show("Insert successfully!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            if (IDFourni == "")
            {
                MessageBox.Show("Please enter the primary key!", "Warning", 0, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("ID_Fournisseur : " + IDFourni + "\r\n" +
                "NOM_FOURNISSEUR: " + NameFourni + "\r\n" +
                "Catégorie: " + CateFourni + "\r\n" +
                "Adresse_Fournisseur: " + AdrFourni + "\r\n" +
                "Téléphone_Fournisseur: " + TeleFourni + "\r\n" +
                "Email_Fournisseur: " + EmailFourni + "\r\n" +
                "Confirm to update？", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sqlcmd = "UPDATE FOURNISSEUR SET NOM_FOURNISSEUR=?,CATEGORIE=?,ADRESSE=?,TELEPHONE=?,EMAIL=? WHERE ID_FOURNISSEUR=?";
                try
                {
                    OleDbCommand cmd = new OleDbCommand(sqlcmd, MainForm.DBKeepkool);
                    cmd.Parameters.AddWithValue("?", NameFourni);
                    cmd.Parameters.AddWithValue("?", CateFourni);
                    cmd.Parameters.AddWithValue("?", AdrFourni);
                    cmd.Parameters.AddWithValue("?", TeleFourni);
                    cmd.Parameters.AddWithValue("?", EmailFourni);
                    cmd.Parameters.AddWithValue("?", IDFourni);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfully!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            if (IDFourni == "")
            {
                MessageBox.Show("Please enter the primary key!", "Warning", 0, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("ID_Fournisseur : " + IDFourni + "\r\n" +
                "NOM_FOURNISSEUR: " + NameFourni + "\r\n" +
                "Catégorie: " + CateFourni + "\r\n" +
                "Adresse_Fournisseur: " + AdrFourni + "\r\n" +
                "Téléphone_Fournisseur: " + TeleFourni + "\r\n" +
                "Email_Fournisseur: " + EmailFourni + "\r\n" +
                "Confirm to delete？", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sqlcmd = "DELETE FROM FOURNISSEUR WHERE ID_FOURNISSEUR=?";
                try
                {
                    OleDbCommand cmd = new OleDbCommand(sqlcmd, MainForm.DBKeepkool);
                    cmd.Parameters.AddWithValue("?", IDFourni);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete successfully!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void ADUQFournisseurForm_Load(object sender, EventArgs e)
        {
            ID_FOURNISSEUR.AutoCompleteCustomSource = FourniSuggestList();


        }

        private AutoCompleteStringCollection FourniSuggestList()
        {
            try
            {
                AutoCompleteStringCollection list = new AutoCompleteStringCollection();
                string cmd = "SELECT ID_FOURNISSEUR FROM FOURNISSEUR";
                OleDbCommand sqlcmd = new OleDbCommand(cmd, MainForm.DBKeepkool);
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
    }
}