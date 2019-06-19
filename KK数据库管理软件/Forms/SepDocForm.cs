using KK数据库管理软件.Class;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KK数据库管理软件.Forms
{
    public partial class SepDocForm : Form
    {
        SepUtilClass SepUtil1;
        string[] Ori_Comm;
        string[] Ori_FacVente;

        public SepDocForm()
        {
            InitializeComponent();
        }

        private void SepDocForm_Load(object sender, EventArgs e)
        {
            SepUtil1 = new SepUtilClass(MainForm.DBKeepkool);
            SepUtil1.dateTime = dateTimePicker1.Text;
            SepUtil1.FillFourni();
        }

        private void ChooseDoc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.DefaultExt = ".xlsx";
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = "C:\\";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Ori_Comm = openFileDialog1.FileNames;
            foreach (string path in Ori_Comm)
            {
                PathDoc.Text += System.IO.Path.GetFileName(path) + " ";
            }
        }

        private void SeperateDoc_Click(object sender, EventArgs e)
        {
            if (SeperateDocument.Checked)
            {
                if (WriteDB.Checked)
                {

                    if (Ori_Comm != null)
                    {
                        for (int i = 0; i < Ori_Comm.Length; i++)
                        {
                            SepUtil1.WriteAndSeperateDoc(Ori_Comm[i]);
                        }
                        PathDoc.Clear();
                        Array.Clear(Ori_Comm, 0, Ori_Comm.Length);
                    }
                }
                else
                {
                    for (int i = 0; i < Ori_Comm.Length; i++)
                    {
                        SepUtil1.SeperateDoc(Ori_Comm[i]);
                    }
                    PathDoc.Clear();
                    Array.Clear(Ori_Comm, 0, Ori_Comm.Length);
                }
            }
            else
            {
                if (WriteDB.Checked)
                {
                    if (Ori_Comm != null)
                    {
                        for (int i = 0; i < Ori_Comm.Length; i++)
                        {
                            SepUtil1.WriteDoc(Ori_Comm[i]);
                        }
                        PathDoc.Clear();
                        Array.Clear(Ori_Comm, 0, Ori_Comm.Length);
                    }
                    else
                    {
                        if (Ori_FacVente != null)
                        {
                            for (int i = 0; i < Ori_FacVente.Length; i++)
                            {
                                SepUtil1.WriteDocFacVente(Ori_FacVente[i]);
                            }
                            PathDocFac.Clear();
                            Array.Clear(Ori_FacVente, 0, Ori_FacVente.Length);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please choose at least an option!");
                    return;
                }
            }



            MessageBox.Show("Done!");
        }

        private void WriteDB_CheckedChanged(object sender, EventArgs e)
        {
            if (WriteDB.Checked == true)
            {
                MessageBox.Show("The document will be written into the database!", "Attention！", 0, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
        }

        private void ChooseDoc2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Multiselect = true;
            openFileDialog2.DefaultExt = ".xlsx";
            openFileDialog2.ShowDialog();
            openFileDialog2.InitialDirectory = "C:\\";
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            Ori_FacVente = openFileDialog2.FileNames;
            foreach (string path in Ori_FacVente)
            {
                PathDocFac.Text += System.IO.Path.GetFileName(path) + " ";
            }
            SeperateDocument.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SepUtil1.dateTime = dateTimePicker1.Text;
        }
    }
}
