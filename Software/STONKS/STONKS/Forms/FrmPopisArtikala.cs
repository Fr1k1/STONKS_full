﻿using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STONKS.Forms
{
    public partial class FrmPopisArtikala : Form
    {

        public FrmPopisArtikala()
        {
            InitializeComponent();
        }

        private ArtikliServices services = new ArtikliServices();


        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();

            FrmPocetniIzbornikVoditelj frmPocetniIzbornik = new FrmPocetniIzbornikVoditelj();
            frmPocetniIzbornik.ShowDialog();

            Close();
        }

        private void dgvRacuni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPopisArtikala_Load(object sender, EventArgs e)
        {
            PrikaziArtikle();
        }

        private void PrikaziArtikle()
        {
            var artikli = services.GetArtikli();
            dgvArtikli.DataSource = artikli;
            dgvArtikli.Columns[8].Visible = false;
            dgvArtikli.Columns[7].Visible = false;
            dgvArtikli.Columns[10].Visible = false;

        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            FrmUnosArtikla frmUnosArtikla = new FrmUnosArtikla();
            Hide();
            frmUnosArtikla.ShowDialog();
            Close();
        }
    }
}
