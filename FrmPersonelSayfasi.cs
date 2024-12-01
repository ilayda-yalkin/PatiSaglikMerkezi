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
using System.Runtime.CompilerServices;

namespace Veteriner_web
{
    public partial class FrmPersonelSayfasi : Form
    {
        public FrmPersonelSayfasi()
        {
            InitializeComponent();
        }
        public string mail;
        Connections connections = new Connections();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPersonelSayfasi_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-U1O92AP\\MSSQLSERVER01;Initial Catalog=Db_veteriner;Integrated Security=True");
            
                try
                {
                    connection.Open();
                    string query = "SELECT Personel_ad, Personel_soyad, Personel_tel_no, Personel_bölüm, Personel_mail FROM Tbl_Personel"; // Sorgunuzu ihtiyacınıza göre özelleştirin
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri çekme sırasında bir hata oluştu: " + ex.Message);
                }
            connection.Close();

            /*lblMail.Text = mail;
                SqlCommand sqlCommand = new SqlCommand("Select Personel_ad, Personel_soyad, Personel_tc_no from Tbl_Personel where Personel_mail=@personel_mail", connection);
                sqlCommand.Parameters.AddWithValue("@Personel_mail", lblMail.Text);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lblAd.Text = reader["Personel_ad"].ToString();
                        lblSoyad.Text = reader["Personel_soyad"].ToString();
                        lblTc.Text = reader["Personel_tc_no"].ToString();
                        lblMail.Text = reader["Personel_mail"].ToString();
                    }
                }*/
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U1O92AP\\MSSQLSERVER01;Initial Catalog=Db_veteriner;Integrated Security=True");

            try
            {
                conn.Open();
                string query = "SELECT h1.Hasta_cipno, h1.Hasta_ad, h1.Hasta_tür, h1.Hasta_cins, h1.Hasta_cinsiyet, s1.Sahip_tc, s1.Sahip_ad, s1.Sahip_soyad, Sahip_tel_no, s1.Sahip_sifre FROM Tbl_hastalar h1 LEFT JOIN Tbl_Sahipler s1 ON h1.Hasta_sahip_tc=s1.Sahip_tc"; // Sorgunuzu ihtiyacınıza göre özelleştirin
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable1 = new DataTable();
                sqlDataAdapter.Fill(dataTable1);
                dataGridView2.DataSource = dataTable1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme sırasında bir hata oluştu: " + ex.Message);
            }
            connection.Close();

        }

        private void LoadDataByEmail(string email)
        {
          
            using (SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-U1O92AP\\MSSQLSERVER01;Initial Catalog=Db_veteriner;Integrated Security=True"))
            {
                try
                {
                    connection1.Open();
                    string query = "SELECT Personel_ad, Personel_soyad, Personel_tc_no, Personel_mail FROM Tbl_Personel WHERE Personel_mail = @personel_mail";
                    SqlCommand command = new SqlCommand(query, connection1);
                    command.Parameters.AddWithValue("@personel_mail", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            lblAd.Text = reader["Personel_ad"].ToString();
                            lblSoyad.Text = reader["Personel_soyad"].ToString();
                            lblTc.Text = reader["Personel_tc_no"].ToString();
                            lblMail.Text = reader["Personel_mail"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri çekme sırasında bir hata oluştu: " + ex.Message);
                }
            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmPersonelGiriş frmPersonelGiris = new FrmPersonelGiriş();
            frmPersonelGiris.Show();
            this.Hide();
        }

    }
    }

