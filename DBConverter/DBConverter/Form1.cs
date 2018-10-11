using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace DBConverter
{
    public partial class frmDBConverter : Form
    {
        public frmDBConverter()
        {
            InitializeComponent();
        }

        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            ofdSourceFile.ShowDialog();
        }

        private void ofdSourceFile_FileOk(object sender, CancelEventArgs e)
        {
            txtFileSource.Text = ofdSourceFile.FileName;
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            fbdTarget.ShowDialog();
            txtTarget.Text = fbdTarget.SelectedPath.ToString();
        }

        private void fbdTarget_HelpRequest(object sender, EventArgs e)
        {
            txtTarget.Text = fbdTarget.SelectedPath;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string strDBData = File.ReadAllText(txtFileSource.Text.ToString());
                string strConvertedData = string.Empty;
                DBConverter dbconv = new DBConverter();
                if(rdbMSSql_MySql.Checked)
                    strConvertedData = dbconv.MSSQL_MySQL(strDBData);
                if(rdbMySql_MSSql.Checked)
                    strConvertedData = dbconv.MySQL_MSSQL(strDBData);
                File.WriteAllText(txtTarget.Text.ToString() + "\\Converted_Scripts.sql", strConvertedData);
                MessageBox.Show("Conversion Completed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in conversion", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
