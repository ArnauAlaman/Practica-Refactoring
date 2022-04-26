using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaRefactoring
{
    public partial class frmResum : Form
    {
        public frmResum()
        {
            InitializeComponent();
        }
        private string zona;
        private List<Detall> detall;
        public DadesComanda Dades { get; set; }
        public List<Detall> Detall { get => detall; set => detall = value; }
        public string Zona { get => zona; set => zona = value; }



        private void frmResum_Load(object sender, EventArgs e)
        {
            if (zona=="Insular")
            {
                lblObservacions.Text = "Observacions: Pendent de confiormació des de la central";
            }

            lblBrut.Text = Dades.ImportBrut.ToString();
            lblIva.Text = Dades.Iva.ToString();
            lblDespesa.Text = Dades.Despesa.ToString();
            lbldescompte.Text = Dades.Descompte.ToString();

            lblComanda.Text = Dades.Id;
            lblClient.Text = Dades.Client;
            lblestat.Text = Dades.Estat;
            double total = 0.0;

            total = Dades.ImportBrut + Dades.Iva + Dades.Despesa - Dades.Descompte;
            lblTotal.Text = total.ToString();

            dtgProductes.DataSource = detall;
        }
    }
}
