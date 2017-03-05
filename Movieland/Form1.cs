using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Xml;
using System.Data.OleDb;
using MetroFramework;
using System.IO;


namespace Movieland
{
    public partial class Form1 : MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=movieland.accdb;");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter getir = new OleDbDataAdapter("Select * From eserarsivi", baglanti);
            
            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From eserarsivi" + " where(eserAd like'%" + txteserAdi.Text + "%') and (eserTur like'%" + txteserTur.Text + "%')", baglanti);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    lbleserAdi.Text = dr["eserAd"].ToString();
                    lblTur.Text = dr["eserTur"].ToString();
                    txtOyuncu.Text = dr["eserOyuncu"].ToString();
                    txtKonu.Text = dr["eserKonu"].ToString();
                    lblYonetmen.Text = dr["eserYonetmen"].ToString();
                    lblYapimci.Text = dr["eserYapimci"].ToString();
                    lblvizyonTarih.Text = dr["eserVizyonTarihi"].ToString();
                    lblPuan.Text = dr["imdbPuan"].ToString();
                    pictureBox3.Image = Image.FromFile(dr["eserResim"].ToString());
                    //Veya
                    //textBox1.Text = dr.GetString(0);
                    //textBox2.Text = dr.GetString(1);
                    //textBox3.Text = dr.GetString(2);

                }
                baglanti.Close();

            }
            catch { MetroMessageBox.Show(this,"Aradığınız Kayıt Bulunamadı...","UYARI !",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void rdbtnAlfabetik_CheckedChanged(object sender, EventArgs e)
        {
            lblDinamik.Visible = false;
            metroComboBox1.Visible = false;
            btnSirala.Visible = false;
            baglanti.Open();
            OleDbDataAdapter getir = new OleDbDataAdapter("Select * From eserarsivi order by eserAd ASC", baglanti);
            DataSet goster = new DataSet();
            getir.Fill(goster, "eserarsivi");
            metroGrid1.DataSource = goster.Tables["eserarsivi"];
            getir.Dispose();
            baglanti.Close();
        }

        private void rdbtnTur_CheckedChanged(object sender, EventArgs e)
        {
            lblDinamik.Visible = true;
            metroComboBox1.Visible = true;
            btnSirala.Visible = true;
           
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter getir = new OleDbDataAdapter("Select * From eserarsivi " + " where(eserTur like'%" + metroComboBox1.Text + "%')  ", baglanti);
            DataSet goster = new DataSet();
            getir.Fill(goster, "eserarsivi");
            metroGrid1.DataSource = goster.Tables["eserarsivi"];
            getir.Dispose();
            baglanti.Close();
        }

        private void rdbtnFilm_CheckedChanged(object sender, EventArgs e)
        {
            lblDinamik.Visible = false;
            metroComboBox1.Visible = false;
            btnSirala.Visible = false;
            baglanti.Open();
            OleDbDataAdapter getir = new OleDbDataAdapter("Select * From eserarsivi " + " where(eserTip like'%" + "film" + "%')  ", baglanti);
            DataSet goster = new DataSet();
            getir.Fill(goster, "eserarsivi");
            metroGrid1.DataSource = goster.Tables["eserarsivi"];
            getir.Dispose();
            baglanti.Close();
        }

        private void rdbtnDizi_CheckedChanged(object sender, EventArgs e)
        {
            lblDinamik.Visible = false;
            metroComboBox1.Visible = false;
            btnSirala.Visible = false;
            baglanti.Open();
            OleDbDataAdapter getir = new OleDbDataAdapter("Select * From eserarsivi " + " where(eserTip like'%" + "dizi" + "%')  ", baglanti);
            DataSet goster = new DataSet();
            getir.Fill(goster, "eserarsivi");
            metroGrid1.DataSource = goster.Tables["eserarsivi"];
            getir.Dispose();
            baglanti.Close();
        }

        
    }
}
