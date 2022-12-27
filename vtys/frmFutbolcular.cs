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
    public partial class frmFutbolcular : Form
    {
        public frmFutbolcular()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database= dbproje; user ID=postgres; password=123456");

        private void frmFutbolcular_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
            baglanti.Open();

            NpgsqlCommand komut1 = new NpgsqlCommand("insert into futbolcular(insanid,adi,yasi,ulkesi,gorevi,takimi,mevkisi,boyu,piyasadegeri) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);

            komut1.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut1.Parameters.AddWithValue("@p2", txtAdi.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(txtYasi.Text));
            komut1.Parameters.AddWithValue("@p4", txtUlkesi.Text);
            komut1.Parameters.AddWithValue("@p5", txtGorevi.Text);
            komut1.Parameters.AddWithValue("@p6", txtTakimi.Text);
            komut1.Parameters.AddWithValue("@p7", txtMevkisi.Text);
            komut1.Parameters.AddWithValue("@p8", int.Parse(txtBoyu.Text));
            komut1.Parameters.AddWithValue("@p9", int.Parse(txtPiyasaDegeri.Text));

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
            NpgsqlCommand komut3 = new NpgsqlCommand("update futbolcular set adi=@p1,yasi=@p2,ulkesi=@p3,gorevi=@p4,takimi=@p5,mevkisi=@p6,boyu=@p7,piyasadegeri=@p8 where insanid=@p9", baglanti);


            komut3.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtYasi.Text));
            komut3.Parameters.AddWithValue("@p3", txtUlkesi.Text);
            komut3.Parameters.AddWithValue("@p4", txtGorevi.Text);
            komut3.Parameters.AddWithValue("@p5", txtTakimi.Text);
            komut3.Parameters.AddWithValue("@p6", txtMevkisi.Text);
            komut3.Parameters.AddWithValue("@p7", int.Parse(txtBoyu.Text));
            komut3.Parameters.AddWithValue("@p8", int.Parse(txtPiyasaDegeri.Text));
            komut3.Parameters.AddWithValue("@p9", int.Parse(txtId.Text));

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
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from futbolcular where insanid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
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
            string sorgu = "select * from futbolcular";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from futbolcular where insanid::character varying like '%" + txtAra.Text + "%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
