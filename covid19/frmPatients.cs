using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace covid19
{
    public partial class frmPatients : Form
    {
        public frmPatients()
        {
            InitializeComponent();
        }

        private void frmPatients_Load(object sender, EventArgs e)
        {

        }

        private void textIdNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textIdNo.Text = "";
            textCountry.Text = "";
            dtpDOB.Value= DateTime .Today;
            cmbGender.SelectedIndex = -1;
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
