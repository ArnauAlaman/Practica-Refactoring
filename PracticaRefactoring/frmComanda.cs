using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaRefactoring
{
    public partial class frmComanda : Form
    {
        List<Detall> Cistella = new List<Detall>();
        Comanda comanda = new Comanda();
        DadesComanda dadesComanda;
        double importBrut, iva, despesa, descompte, importNet;
        string numComanda, client, estat;
        int numComandes = 0;
        public string representant;
        public string zona;
        bool novaComanda = false;

        public frmComanda()
        {
            InitializeComponent();
        }
        private void btnDetall_Click(object sender, EventArgs e)
        {          

            Detall compra = new Detall();
            compra.Producte = cmbProductes.Text;
            compra.Preu = double.Parse(txtPreu.Text);
            compra.Quantitat = int.Parse(txtQuantitat.Text);
            Cistella.Add(compra);

            dtgProductes.DataSource = Cistella;

            txtPreu.Text = "";
            txtQuantitat.Text = "";
        }
        private void btnBrut_Click(object sender, EventArgs e)
        {
            importBrut = comanda.CalcularBrut(Cistella);
            importBrut = Math.Round(importBrut, 2, MidpointRounding.AwayFromZero);
            lblBrut.Text = importBrut.ToString();
        }

        private void btnIVA_Click(object sender, EventArgs e)
        {
            iva = comanda.CalcularIVA(Cistella);
            iva = Math.Round(iva, 2, MidpointRounding.AwayFromZero);
            lblIva.Text = iva.ToString();
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            despesa = comanda.CalcularDespesa(Cistella, client);
            despesa = Math.Round(despesa, 2, MidpointRounding.AwayFromZero);
            lblDespesa.Text = despesa.ToString();
        }


        private void btnDescompte_Click(object sender, EventArgs e)
        {
            descompte = comanda.CalcularDescompte(Cistella, client);
            descompte = Math.Round(descompte, 2, MidpointRounding.AwayFromZero);
            lbldescompte.Text = descompte.ToString();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            importNet = comanda.CalcularTotal(Cistella, client);
            importNet = Math.Round(importNet, 2, MidpointRounding.AwayFromZero);
            lblTotal.Text = importNet.ToString();
            grpResum.Visible = true;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            novaComanda = true;
            numComandes++;
            //DadesComanda = new string[7];
            int dia = DateTime.Today.DayOfYear;
            numComanda = dia.ToString() + "-" + numComandes.ToString();
            lblComanda.Text = numComanda;

        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(novaComanda) client = cmbClients.Text;
        }

        private void cmbEstat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] estats = { "En espera", "Retinguda", "Condicionada", "Confirmada" };
            estat = estats[cmbEstat.SelectedIndex];
            IntroduirDetallsComanda(estats[cmbEstat.SelectedIndex]);
        }
        private void IntroduirDetallsComanda(string state)
        {
            dadesComanda = new DadesComanda(importBrut:importBrut,client:client,descompte:descompte,despesa:despesa,iva:iva,id:numComanda,estat:estat);
        }
        private void btnResum_Click(object sender, EventArgs e)
        {
            frmResum frm = new frmResum();
            frm.Zona = zona;
            frm.Detall = Cistella;
            frm.Dades = dadesComanda;
            frm.Show();
        }

        private void frmComanda_Load(object sender, EventArgs e)
        {
            lblRepresentant.Text = representant;
        }
    }
}
