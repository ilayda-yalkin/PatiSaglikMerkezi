using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Veteriner_web
{
    public partial class FrmYöneticiPersonel : Form
    {
        public FrmYöneticiPersonel()
        {
            InitializeComponent();
        }
        Connections conn = new Connections();
        public void Clear()
        {
            txtId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtMaas.Clear();
            txtBolum.Clear();
            txtMail.Clear();
            txtSifre.Clear();
            mskTc.Clear();
            mskTel.Clear();
        }

        private void FrmYöneticiPersonel_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Tbl_Personel";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn.connect());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmYöneticiSayfasi frmYöneticiSayfası = new FrmYöneticiSayfasi();
            frmYöneticiSayfası.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtBolum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Personel (Personel_tc_no, Personel_ad, Personel_soyad, Personel_tel_no, Personel_maas, Personel_Bölüm,Personel_mail, Personel_sifre) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", conn.connect());
            cmd.Parameters.AddWithValue("@p1", mskTc.Text);
            cmd.Parameters.AddWithValue("@p2", txtAd.Text);
            cmd.Parameters.AddWithValue("@p3", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p4", mskTel.Text);
            cmd.Parameters.AddWithValue("@p5", txtMaas.Text);
            cmd.Parameters.AddWithValue("@p6", txtBolum.Text);
            cmd.Parameters.AddWithValue("@p7", txtMail.Text);
            cmd.Parameters.AddWithValue("@p8", txtSifre.Text);
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Tbl_Personel", conn.connect());
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.connect().Close();
            Clear();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("UPDATE Tbl_Personel SET Personel_ad=@p2, Personel_soyad = @p3, Personel_tel_no = @p4, Personel_maas = @p5, Personel_Bölüm = @p6, Personel_mail = @p7, Personel_sifre = @p8 WHERE Personel_tc_no = @p1 ", conn.connect());
            cmd1.Parameters.AddWithValue("@p1", mskTc.Text);
            cmd1.Parameters.AddWithValue("@p2", txtAd.Text);
            cmd1.Parameters.AddWithValue("@p3", txtSoyad.Text);
            cmd1.Parameters.AddWithValue("@p4", mskTel.Text);
            cmd1.Parameters.AddWithValue("@p5", txtMaas.Text);
            cmd1.Parameters.AddWithValue("@p6", txtBolum.Text);
            cmd1.Parameters.AddWithValue("@p7", txtMail.Text);
            cmd1.Parameters.AddWithValue("@p8", txtSifre.Text);
            cmd1.ExecuteNonQuery();


            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("Select * from Tbl_Personel", conn.connect());
            DataTable dt1 = new DataTable();
            sqlDataAdapter1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            conn.connect().Close();
            Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("DELETE FROM Tbl_Personel where Personel_mail=@p1", conn.connect());
            cmd2.Parameters.AddWithValue("@p1", txtMail.Text);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("SELECT * FROM Tbl_Personel", conn.connect());
            DataTable dt2 = new DataTable();
            sqlDataAdapter2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
