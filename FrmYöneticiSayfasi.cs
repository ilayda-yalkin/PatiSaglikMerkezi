using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veteriner_web
{
    public partial class FrmYöneticiSayfasi : Form
    {
        public FrmYöneticiSayfasi()
        {
            InitializeComponent();
        }
        Connections conn = new Connections();

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void FrmYöneticiSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaListele_Click(object sender, EventArgs e)
        {

            try
            {              
                string query = "SELECT * FROM Tbl_hastalar"; 
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn.connect());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme sırasında bir hata oluştu: " + ex.Message);
            }
            conn.connect().Close();
        }

        private void btnSahipListele_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT * FROM Tbl_Sahipler"; 
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn.connect());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme sırasında bir hata oluştu: " + ex.Message);
            }
            conn.connect().Close();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Tbl_Personel";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn.connect());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme sırasında bir hata oluştu: " + ex.Message);
            }
            conn.connect().Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmPersonelGiriş frmPersonelGiris = new FrmPersonelGiriş();
            frmPersonelGiris.Show();
            this.Hide();
        }

        private void lnkPersonel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmYöneticiPersonel frmYöneticiPersonel = new FrmYöneticiPersonel();
            frmYöneticiPersonel.Show();
            this.Hide();    
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
