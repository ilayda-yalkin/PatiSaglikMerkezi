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
    public partial class FrmKayitEkrani : Form
    {
        public FrmKayitEkrani()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtHastaAdi.Clear();
            txtHastaCipNo.Clear();
            cmbHastaTuru.Text = "";
            txtHastaCinsi.Clear();
            cmbHastaCinsiyet.Text = "";
            txtSahipAd.Clear();
            txtSahipSoyad.Clear();
            mskSahipTel.Clear();
            mskSahipTc.Clear();
            txtSifre.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Gerekli alanların boş olup olmadığını kontrol et
            if (IsFormValid())
            {
                string tcKimlik = mskSahipTc.Text;

                // TC Kimlik numarasının veritabanında mevcut olup olmadığını kontrol et
                if (IsTcAlreadyExists(tcKimlik))
                {
                    MessageBox.Show("Bu TC Kimlik Numarası zaten kayıtlı.");
                    return; // Eğer TC numarası varsa, kaydetmeyi durdurur
                }

                // Veritabanına veri ekleme işlemi
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U1O92AP\\MSSQLSERVER01;Initial Catalog=Db_veteriner;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_hastalar (Hasta_ad, Hasta_cipno, Hasta_tür, Hasta_cins, Hasta_cinsiyet, Hasta_sahip_tc) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", conn);
                cmd.Parameters.AddWithValue("@p1", txtHastaAdi.Text);
                cmd.Parameters.AddWithValue("@p2", txtHastaCipNo.Text);
                cmd.Parameters.AddWithValue("@p3", cmbHastaTuru.Text);
                cmd.Parameters.AddWithValue("@p4", txtHastaCinsi.Text);
                cmd.Parameters.AddWithValue("@p5", cmbHastaCinsiyet.Text);
                cmd.Parameters.AddWithValue("@p6", mskSahipTc.Text);
                cmd.ExecuteNonQuery();
                
                SqlCommand cmd1 = new SqlCommand("INSERT INTO Tbl_Sahipler (Sahip_tc, Sahip_ad, Sahip_soyad, Sahip_tel_no, Sahip_sifre) VALUES (@s1, @s2, @s3, @s4, @s5)", conn);
                cmd1.Parameters.AddWithValue("@s1", mskSahipTc.Text);
                cmd1.Parameters.AddWithValue("@s2", txtSahipAd.Text);
                cmd1.Parameters.AddWithValue("@s3", txtSahipSoyad.Text);
                cmd1.Parameters.AddWithValue("@s4", mskSahipTel.Text);
                cmd1.Parameters.AddWithValue("@s5", txtSifre.Text);
                cmd1.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Hasta Eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
        }

        // Gerekli alanların dolu olup olmadığını kontrol eden fonksiyon
        private bool IsFormValid()
        {
            // TextBox'lar ve ComboBox'lar için gerekli kontroller
            if (string.IsNullOrEmpty(txtHastaAdi.Text) ||
                string.IsNullOrEmpty(txtHastaCipNo.Text) ||
                string.IsNullOrEmpty(txtHastaCinsi.Text) ||
                string.IsNullOrEmpty(txtSahipAd.Text) ||
                string.IsNullOrEmpty(txtSahipSoyad.Text) ||
                string.IsNullOrEmpty(mskSahipTc.Text) ||
                string.IsNullOrEmpty(mskSahipTel.Text) ||
                string.IsNullOrEmpty(txtSifre.Text) ||
                string.IsNullOrEmpty(cmbHastaTuru.Text) ||
                string.IsNullOrEmpty(cmbHastaCinsiyet.Text))
            {
                return false; // Eğer herhangi bir alan boşsa, false döner
            }

            return true; // Eğer tüm alanlar doluysa, true döner
        }

        // TC Kimlik numarasının veritabanında olup olmadığını kontrol eden fonksiyon
        private bool IsTcAlreadyExists(string tc)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U1O92AP\\MSSQLSERVER01;Initial Catalog=Db_veteriner;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tbl_hastalar WHERE Hasta_sahip_tc = @tc";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    int count = (int)cmd.ExecuteScalar();  // TC Kimlik numarasının kaç defa geçtiğini sayar
                    return count > 0; // Eğer TC numarası zaten varsa, true döner
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris frmKullaniciGiris = new FrmKullaniciGiris();
            frmKullaniciGiris.Show();
            this.Hide();
        }

        private void FrmKayitEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
