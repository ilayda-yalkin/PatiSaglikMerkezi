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
using System.Reflection.Emit;

namespace Veteriner_web
{
    public partial class FrmKullaniciSsayfasi : Form
    {
        public FrmKullaniciSsayfasi()
        {
            InitializeComponent();
        }
        public string tc;
        Connections connections = new Connections();

        public void Clear()
        {
            txtHastaAdi.Clear();
            txtHastaCinsi.Clear();
            txtHastaCipNo.Clear();
            txtHastaid.Clear();
            mskSahipTc.Clear();
            cmbHastaCinsiyet.Text = "";
            cmbHastaTuru.Text="";
       
        }
        private void FrmKullaniciSsayfasi_Load(object sender, EventArgs e)
        {
            
            label2.Text = tc;
      
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Tbl_hastalar where Hasta_sahip_tc=@Hasta_sahip_tc", connections.connect());
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Hasta_sahip_tc", label2.Text);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            
            SqlCommand sqlCommand = new SqlCommand("Select Sahip_ad,Sahip_soyad,Sahip_tc from Tbl_Sahipler where Sahip_tc=@Sahip_tc", connections.connect());
            sqlCommand.Parameters.AddWithValue("@Sahip_tc", label2.Text);

            using (SqlDataReader reader = sqlCommand.ExecuteReader()) 
            {
                while (reader.Read())
                {
                    LblAd.Text = reader["Sahip_ad"].ToString();
                    LblSoyad.Text = reader["Sahip_soyad"].ToString(); 
                }
            }

          
            SqlCommand sqlCommand1 = new SqlCommand("Select Sahip_ad, Sahip_soyad, Sahip_tc, Sahip_tel_no, Sahip_sifre from Tbl_Sahipler where Sahip_tc=@Sahip_tc", connections.connect());
            sqlCommand1.Parameters.AddWithValue("@Sahip_tc", mskSahipTc.Text);
            connections.connect().Close(); 
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtHastaid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtHastaCipNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtHastaAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbHastaTuru.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtHastaCinsi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbHastaCinsiyet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskSahipTc.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
       
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_hastalar (Hasta_ad, Hasta_cipno, Hasta_tür, Hasta_cins, Hasta_cinsiyet, Hasta_sahip_tc) VALUES (@p1, @p2, @p3, @p4, @p5, @p6) ", connections.connect());
            cmd.Parameters.AddWithValue("@p1", txtHastaAdi.Text);
            cmd.Parameters.AddWithValue("@p2", txtHastaCipNo.Text);
            cmd.Parameters.AddWithValue("@p3", cmbHastaTuru.Text);
            cmd.Parameters.AddWithValue("@p4", txtHastaCinsi.Text);
            cmd.Parameters.AddWithValue("@p5", cmbHastaCinsiyet.Text);
            cmd.Parameters.AddWithValue("@p6", mskSahipTc.Text);
            cmd.ExecuteNonQuery();
           

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Tbl_hastalar where Hasta_sahip_tc=@Sahip_tc",connections.connect());
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Sahip_tc", mskSahipTc.Text);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connections.connect().Close();
            Clear();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris frmKullaniciGiris = new FrmKullaniciGiris();
            frmKullaniciGiris.Show();
            this.Hide();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
           

            SqlCommand cmd1 = new SqlCommand( "UPDATE Tbl_hastalar SET Hasta_ad = @p1,  Hasta_tür = @p3, Hasta_cins = @p4, Hasta_cinsiyet = @p5 WHERE Hasta_cipno = @p6", connections.connect());
            cmd1.Parameters.AddWithValue("@p1", txtHastaAdi.Text);
            
            cmd1.Parameters.AddWithValue("@p3", cmbHastaTuru.Text);
            cmd1.Parameters.AddWithValue("@p4", txtHastaCinsi.Text);
            cmd1.Parameters.AddWithValue("@p5", cmbHastaCinsiyet.Text);
            cmd1.Parameters.AddWithValue("@p6", txtHastaCipNo.Text);
            cmd1.ExecuteNonQuery();
            

            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("Select * from Tbl_hastalar where Hasta_sahip_tc=@Sahip_tc", connections.connect());
            sqlDataAdapter1.SelectCommand.Parameters.AddWithValue("@Sahip_tc", mskSahipTc.Text);

            DataTable dt1 = new DataTable();
            sqlDataAdapter1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            connections.connect().Close();
            Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("DELETE FROM Tbl_hastalar where Hasta_cipno=@p1", connections.connect());
            cmd2.Parameters.AddWithValue("@p1", txtHastaCipNo.Text);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter( "SELECT * FROM Tbl_hastalar WHERE Hasta_sahip_tc = @Sahip_tc", connections.connect() );
            sqlDataAdapter2.SelectCommand.Parameters.AddWithValue("@Sahip_tc", mskSahipTc.Text);

            DataTable dt2 = new DataTable();
            sqlDataAdapter2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
