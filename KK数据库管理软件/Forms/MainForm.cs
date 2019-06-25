using KK_DMS.Forms;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KK_DMS
{
    public partial class MainForm : Form
    {
        public static OleDbConnection DBKeepkool;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void 分割文件功能_Click(object sender, EventArgs e)
        {
            SepDocForm Form2 = new SepDocForm();
            Form2.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string DBpath = "Provider=microsoft.ace.oledb.12.0;Data Source="+ System.IO.Directory.GetCurrentDirectory() + @"\KEEPKOOL.accdb";
                DBKeepkool = new OleDbConnection(DBpath);
                DBKeepkool.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Closing(object sender, EventArgs e)
        {
            GC.Collect();
            DBKeepkool.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ADUQFournisseurForm Form3 = new ADUQFournisseurForm();
            Form3.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ADUQFacForm Form4 = new ADUQFacForm();
            Form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaAchatVente Form5 = new AnaAchatVente();
            Form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADUQProduit Form6 = new ADUQProduit();
            Form6.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            GeneOfferForm Form7 = new GeneOfferForm();
            Form7.Show();
        }
    }
}
