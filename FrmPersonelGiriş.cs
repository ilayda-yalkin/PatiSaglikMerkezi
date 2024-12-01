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
using System.Data.SqlClient;

namespace Veteriner_web
{
    public partial class FrmPersonelGiriş : Form
    {
        public FrmPersonelGiriş()
        {
            InitializeComponent();
        }
        Connections connections = new Connections();
       
        private void btn_geri_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris frm = new FrmKullaniciGiris();
            frm.Show();
            this.Hide();
        }

        private void btn_PersonelGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * From Tbl_Personel Where Personel_mail=@personel_mail and Personel_sifre=@personel_sifre", connections.connect());
         
            cmd.Parameters.AddWithValue("@personel_mail", txtPersonelMail.Text);
            cmd.Parameters.AddWithValue("@personel_sifre", txtPersonelSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string bölüm = dr["Personel_Bölüm"].ToString();

                // manager_department değerini kontrol et
                if (bölüm == "Yönetici")
                {
                    // Yönetici ise, yönetici sayfasını aç
                    FrmYöneticiSayfasi frmYönetici = new FrmYöneticiSayfasi();
                    frmYönetici.Show();
                    this.Hide();
                }
                else
                {
                    // Yönetici değilse, farklı bir sayfayı aç veya bir mesaj göster
                    FrmPersonelSayfasi frmPersonel = new FrmPersonelSayfasi();
                    frmPersonel.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connections.connect().Close();
        }
    }
    }

