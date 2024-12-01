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
    public partial class FrmKullaniciGiris : Form
    {
        public FrmKullaniciGiris()
        {
            InitializeComponent();
        }


        private void FrmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U1O92AP\\MSSQLSERVER01;Initial Catalog=Db_veteriner;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * From Tbl_Sahipler Where Sahip_tc=@s1 and Sahip_sifre=@s2", conn);
            cmd.Parameters.AddWithValue("@s1", mskTC.Text );
            cmd.Parameters.AddWithValue("@s2", txtSifre.Text );
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmKullaniciSsayfasi frm = new FrmKullaniciSsayfasi();
                frm.tc = mskTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC ya da şifre");
            }
            conn.Close();
        }

        private void mskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKayitEkrani frm1 = new FrmKayitEkrani();
            frm1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPersonelGiriş frm2 = new FrmPersonelGiriş();
            frm2.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
    }
}
