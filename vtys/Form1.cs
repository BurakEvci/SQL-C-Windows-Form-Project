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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbproje; user ID=postgres; password=123456");
        DataSet daset = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFutbolcular_Click(object sender, EventArgs e)
        {
            frmFutbolcular listele = new frmFutbolcular();
            listele.ShowDialog();
        }

        private void btnTakimlar_Click(object sender, EventArgs e)
        {
            frmTakimlar listele = new frmTakimlar();
            listele.ShowDialog();
        }
    }
}
