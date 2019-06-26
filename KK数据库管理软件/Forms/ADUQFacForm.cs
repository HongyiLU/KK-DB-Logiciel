using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KK_DMS.Forms
{
    public partial class ADUQFacForm : Form
    {
        string RefFac;
        DataSet ds;
        OleDbDataAdapter Da;
        public ADUQFacForm()
        {
            InitializeComponent();
        }

        public OleDbDataAdapter CreateCustomerAdapter(OleDbConnection DB)
        {
            OleDbDataAdapter Da = new OleDbDataAdapter();
            OleDbCommand cmd;
            OleDbParameter parameter;

            cmd = new OleDbCommand("SELECT ID AS ID, ID_FAC AS ID_FAC, DESIGNATION AS DESIGNATION, QUANTITE AS QUANTITE, PRIX AS PRIX FROM FACACHAT_DETAIL WHERE ID_FAC=?", DB);
            cmd.Parameters.AddWithValue("?", REF_FACTURE.Text);
            Da.SelectCommand = cmd;

            cmd = new OleDbCommand("INSERT INTO FACACHAT_DETAIL VALUES(?,?,?,?,?)", DB);
            cmd.Parameters.Add("ID", OleDbType.WChar, 0, "ID");
            cmd.Parameters.Add("ID_FAC", OleDbType.WChar, 0, "ID_FAC");
            cmd.Parameters.Add("DESIGNATION", OleDbType.WChar, 255, "DESIGNATION");
            cmd.Parameters.Add("QUANTITE", OleDbType.Integer, 10, "QUANTITE");
            cmd.Parameters.Add("PRIX", OleDbType.Double, 15, "PRIX");
            Da.InsertCommand = cmd;

            cmd = new OleDbCommand("DELETE FROM FACACHAT_DETAIL WHERE ID=?",DB);
            cmd.Parameters.Add("ID", OleDbType.WChar, 0, "ID");
            Da.DeleteCommand = cmd;

            cmd = new OleDbCommand("UPDATE FACACHAT_DETAIL SET QUANTITE=?, ID_FAC=?, DESIGNATION=?, PRIX=? WHERE ID=?", DB);
            cmd.Parameters.Add("QUANTITE", OleDbType.Integer, 10, "QUANTITE");
            cmd.Parameters.Add("ID_FAC", OleDbType.WChar, 0, "ID_FAC");
            cmd.Parameters.Add("DESIGNATION", OleDbType.WChar, 255, "DESIGNATION");
            cmd.Parameters.Add("PRIX", OleDbType.Double, 15, "PRIX");
            parameter = cmd.Parameters.Add("ID", OleDbType.WChar, 255, "ID");
            Da.UpdateCommand = cmd;
            return Da;
        }

        private void REF_FACTURE_TextChanged(object sender, EventArgs e)
        {
            RefFac = REF_FACTURE.Text;
            string sqlcmd = "SELECT * FROM FAC_ACHAT WHERE ID_FAC=?";

            try
            {

                OleDbCommand cmd = new OleDbCommand(sqlcmd, MainForm.DBKeepkool);
                cmd.Parameters.AddWithValue("?", RefFac);
                OleDbDataReader DrFac = cmd.ExecuteReader();
                DrFac.Read();


                if (DrFac.HasRows == false)
                {
                    DETAILFAC.Hide();
                    NOM_FOURNISSEUR.Text = "";
                    DateFac.Value = DateTime.Now;
                    dataGridView1.DataSource = ds;
                    DETAILFAC.DataSource = null;
                }
                else
                {
                    NOM_FOURNISSEUR.Text = DrFac.GetString(2);
                    DateFac.Value = (DateTime)DrFac.GetValue(1);
                    double TotalPrix = 0;
                    int TotalQuante = 0;
                    DETAILFAC.Show();
                    ds = new DataSet();

                    Da = CreateCustomerAdapter(MainForm.DBKeepkool);
                    OleDbCommandBuilder CmdBuilder = new OleDbCommandBuilder(Da);
                    Da.Fill(ds, "FACACHAT_DETAIL");
                    DETAILFAC.DataSource = ds;
                    DETAILFAC.DataMember = "FACACHAT_DETAIL";
                    int index = DETAILFAC.Rows.Add();
                    for (int i = 0; i < DETAILFAC.RowCount; i++)
                    {
                        TotalQuante += (int)DETAILFAC.Rows[i].Cells[2].Value;
                        TotalPrix += (int)DETAILFAC.Rows[i].Cells[2].Value * (double)DETAILFAC.Rows[i].Cells[3].Value;
                    }
                    DETAILFAC.Rows[index].Cells[2].Value = TotalQuante;
                    DETAILFAC.Rows[index].Cells[3].Value = TotalPrix;
                }

            }
            catch
            {

                return;
            }


        }

        private void ADUSFacForm_Load(object sender, EventArgs e)
        {
            REF_FACTURE.AutoCompleteCustomSource = FacSuggestList();
            Da = new OleDbDataAdapter();
            DETAILFAC.Hide();
        }

        private void WriteNewFac_Click(object sender, EventArgs e)
        {
            try
            {

                if (REF_FACTURE.Text == "")
                {
                    MessageBox.Show("Please enter the primary key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Are you sure to add this facture?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //向FAC_ACHAT添加新的数据
                    string cmd1 = "INSERT INTO FAC_ACHAT VALUES(?,?,?)";
                    OleDbCommand DBcmd1 = new OleDbCommand(cmd1, MainForm.DBKeepkool);
                    DBcmd1.Parameters.AddWithValue("?", REF_FACTURE.Text);
                    DBcmd1.Parameters.AddWithValue("?", DateFac.Value.ToString("yyyy/MM/dd"));
                    DBcmd1.Parameters.AddWithValue("?", NOM_FOURNISSEUR.Text);
                    DBcmd1.ExecuteNonQuery();
                    //向FACACHAT_DETAIL添加新数据
                    string cmd2 = "INSERT INTO FACACHAT_DETAIL VALUES(?,?,?,?,?)";
                    
                    foreach(DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                    {
                        OleDbCommand DBcmd2 = new OleDbCommand(cmd2, MainForm.DBKeepkool);
                        DBcmd2.Parameters.AddWithValue("?",dataGridViewRow.Cells[0].Value.ToString());
                        DBcmd2.Parameters.AddWithValue("?", dataGridViewRow.Cells[1].Value.ToString());
                        DBcmd2.Parameters.AddWithValue("?", dataGridViewRow.Cells[2].Value.ToString());
                        DBcmd2.Parameters.AddWithValue("?", dataGridViewRow.Cells[3].Value.ToString());
                        DBcmd2.Parameters.AddWithValue("?", dataGridViewRow.Cells[4].Value.ToString());
                        DBcmd2.ExecuteNonQuery();
                    }
                    
                    MessageBox.Show("Facture has been Added!");
                }
            }
            catch 
            {
            }
            this.Controls.Clear();
            InitializeComponent();
            REF_FACTURE.AutoCompleteCustomSource = FacSuggestList();
        }

        private void UpdateFac_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to update this facture?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    OleDbCommandBuilder CmdBuilder = new OleDbCommandBuilder(Da);
                    if (CreateCustomerAdapter(MainForm.DBKeepkool).Update(ds, "FACACHAT_DETAIL") > 0)
                    {
                        MessageBox.Show("Update succes!");
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void DeleteFac_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this facture?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    string cmd = "DELETE FROM FAC_ACHAT WHERE ID_FAC=?";
                    OleDbCommand DBcmd = new OleDbCommand(cmd, MainForm.DBKeepkool);
                    DBcmd.Parameters.AddWithValue("?", REF_FACTURE.Text);
                    DBcmd.ExecuteNonQuery();
                    MessageBox.Show("Facture has been deleted!");
                    this.Controls.Clear();
                    InitializeComponent();
                    DETAILFAC.Hide();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private AutoCompleteStringCollection FacSuggestList()
        {
            try
            {
                AutoCompleteStringCollection list = new AutoCompleteStringCollection();
                string cmd = "SELECT ID_FAC FROM FAC_ACHAT";
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
