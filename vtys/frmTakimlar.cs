using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtys
{
    public partial class frmTakimlar : Form
    {
        public frmTakimlar()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database= dbproje; user ID=postgres; password=123456");

        private void frmTakimlar_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into takimlar(takimid,takimadi,oyuncusayisi,yasortalamasi,kadrodegeri,ulkesi,ligi,stat,ligsirasi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtTakimId.Text));
            komut1.Parameters.AddWithValue("@p2", txtTakimAdi.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(txtOyuncuSayisi.Text));
            komut1.Parameters.AddWithValue("@p4", int.Parse(txtYasOrtalamasi.Text));
            komut1.Parameters.AddWithValue("@p5", int.Parse(txtKadroDegeri.Text));
            komut1.Parameters.AddWithValue("@p6", txtTakimUlkesi.Text);
            komut1.Parameters.AddWithValue("@p7", txtTakimLigi.Text);
            komut1.Parameters.AddWithValue("@p8", txtStatAdi.Text);
            komut1.Parameters.AddWithValue("@p9", int.Parse(txtLigSirasi.Text));


            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme işlemi başarılı bir şekilde gerçekleşti.");
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir giriş yapınız...");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update takimlar set takimadi=@p1,oyuncusayisi=@p2,yasortalamasi=@p3,kadrodegeri=@p4,ulkesi=@p5,ligi=@p6,stat=@p7,ligsirasi=@p8 where takimid=@p9", baglanti);




            komut3.Parameters.AddWithValue("@p1", txtTakimAdi.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtOyuncuSayisi.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(txtYasOrtalamasi.Text));
            komut3.Parameters.AddWithValue("@p4", int.Parse(txtKadroDegeri.Text));
            komut3.Parameters.AddWithValue("@p5", txtTakimUlkesi.Text);
            komut3.Parameters.AddWithValue("@p6", txtTakimLigi.Text);
            komut3.Parameters.AddWithValue("@p7", txtStatAdi.Text);
            komut3.Parameters.AddWithValue("@p8", int.Parse(txtLigSirasi.Text));
            komut3.Parameters.AddWithValue("@p9", int.Parse(txtTakimId.Text));

            komut3.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılı oldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir giriş yapınız...");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                NpgsqlCommand komut2 = new NpgsqlCommand("delete from takimlar where takimid=@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(txtTakimId.Text));
                komut2.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarılı oldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir giriş yapınız...");
            }
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from takimlar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from takimlar where takimid::character varying like '%" + txtAra.Text + "%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }
    }
}
