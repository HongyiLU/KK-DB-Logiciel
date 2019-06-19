using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KK数据库管理软件.Forms
{
    public partial class ADUQFacForm : Form
    {
        string RefFac;
        List<string> ListDesignation = new List<string>();
        List<string> ListQuante = new List<string>();
        List<string> ListPrix = new List<string>();
        OleDbDataAdapter DrDetail;
        DataSet ds;

        public ADUQFacForm()
        {
            InitializeComponent();
        }

        private void REF_FACTURE_TextChanged(object sender, EventArgs e)
        {
            RefFac = REF_FACTURE.Text;
            string sqlcmd = "SELECT * FROM FAC_ACHAT WHERE ID_FAC=?";
            string sqlcmd2 = "SELECT * FROM FACACHAT_DETAIL WHERE ID_FAC=?";
            try
            {
                OleDbCommand cmd = new OleDbCommand(sqlcmd, MainForm.DBKeepkool);
                OleDbCommand cmd2 = new OleDbCommand(sqlcmd2, MainForm.DBKeepkool);
                cmd.Parameters.AddWithValue("?", RefFac);
                cmd2.Parameters.AddWithValue("?", RefFac);
                DrDetail = new OleDbDataAdapter(cmd2);
                OleDbDataReader DrFac = cmd.ExecuteReader();
                DrFac.Read();
                if (DrFac.HasRows == false)
                {
                    DETAILFAC.Hide();
                    NOM_FOURNISSEUR.Text = "";
                    DateFac.Value = DateTime.Now;
                }
                else
                {
                    NOM_FOURNISSEUR.Text = DrFac.GetString(2);
                    DateFac.Value = (DateTime)DrFac.GetValue(1);
                    double TotalPrix = 0;
                    int TotalQuante = 0;
                    DETAILFAC.Show();
                    ds = new DataSet();
                    DrDetail = new OleDbDataAdapter(cmd2);
                    DrDetail.Fill(ds, "DETAILFAC");
                    DETAILFAC.DataSource = ds;
                    DETAILFAC.DataMember = "DETAILFAC";
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
            // TODO: 这行代码将数据加载到表“kEEPKOOLDataSet.DESIGNATION”中。您可以根据需要移动或删除它。
            this.dESIGNATIONTableAdapter.Fill(this.kEEPKOOLDataSet.DESIGNATION);
            this.ComboBox1.SelectedIndex = -1;
            REF_FACTURE.AutoCompleteCustomSource = FacSuggestList();
            DETAILFAC.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to save?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ListDesignation.Add(ComboBox1.Text);
                    ListQuante.Add(QteFacProd.Text);
                    ListPrix.Add(PrixFacProd.Text);

                    TextBox textBox1 = new TextBox();
                    textBox1.Location = new System.Drawing.Point(ComboBox1.Location.X, ComboBox1.Location.Y);
                    textBox1.Text = ComboBox1.Text;
                    textBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    textBox1.Size = new System.Drawing.Size(242, 33);
                    textBox1.ForeColor = System.Drawing.Color.Black;
                    textBox1.TabIndex = 278;
                    textBox1.Enabled = false;
                    this.Controls.Add(textBox1);

                    TextBox textBox2 = new TextBox();
                    textBox2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    textBox2.ForeColor = System.Drawing.Color.Black;
                    textBox2.Location = new System.Drawing.Point(QteFacProd.Location.X, QteFacProd.Location.Y);
                    textBox2.Size = new System.Drawing.Size(210, 33);
                    textBox2.TabIndex = 279;
                    textBox2.Text = QteFacProd.Text;
                    textBox2.Enabled = false;
                    this.Controls.Add(textBox2);

                    TextBox textBox3 = new TextBox();
                    textBox3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    textBox3.ForeColor = System.Drawing.Color.Black;
                    textBox3.Location = new System.Drawing.Point(PrixFacProd.Location.X, PrixFacProd.Location.Y);
                    textBox3.Size = new System.Drawing.Size(210, 33);
                    textBox3.TabIndex = 280;
                    textBox3.Enabled = false;
                    textBox3.Text = PrixFacProd.Text;
                    this.Controls.Add(textBox3);

                    linkLabel1.Location = new System.Drawing.Point(linkLabel1.Location.X, linkLabel1.Location.Y + 40);
                    ComboBox1.Location = new System.Drawing.Point(ComboBox1.Location.X, ComboBox1.Location.Y + 40);
                    QteFacProd.Location = new System.Drawing.Point(QteFacProd.Location.X, QteFacProd.Location.Y + 40);
                    QteFacProd.Clear();
                    PrixFacProd.Location = new System.Drawing.Point(PrixFacProd.Location.X, PrixFacProd.Location.Y + 40);
                    PrixFacProd.Clear();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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
                    string cmd1 = "INSERT INTO FAC_ACHAT VALUES(?,?,?)";
                    string cmd2 = "INSERT INTO FACACHAT_DETAIL VALUES(?,?,?,?)";
                    OleDbCommand DBcmd1 = new OleDbCommand(cmd1, MainForm.DBKeepkool);

                    DBcmd1.Parameters.AddWithValue("?", REF_FACTURE.Text);
                    DBcmd1.Parameters.AddWithValue("?", DateFac.Value.ToString("yyyy/MM/dd"));
                    DBcmd1.Parameters.AddWithValue("?", NOM_FOURNISSEUR.Text);
                    DBcmd1.ExecuteNonQuery();

                    for (int i = 0; i < ListDesignation.Count; i++)
                    {
                        OleDbCommand DBcmd2 = new OleDbCommand(cmd2, MainForm.DBKeepkool);
                        DBcmd2.Parameters.AddWithValue("?", REF_FACTURE.Text);
                        DBcmd2.Parameters.AddWithValue("?", ListDesignation[i]);
                        DBcmd2.Parameters.AddWithValue("?", ListQuante[i]);
                        DBcmd2.Parameters.AddWithValue("?", ListPrix[i]);
                        DBcmd2.ExecuteNonQuery();
                    }
                    REF_FACTURE.AutoCompleteCustomSource = FacSuggestList();
                    MessageBox.Show("Facture has been Added!");
                    this.Controls.Clear();
                    InitializeComponent();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void UpdateFac_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to update this facture?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    OleDbCommandBuilder CmdBuilder = new OleDbCommandBuilder(DrDetail);
                    DrDetail.Update(ds, "DETAILFAC");
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
