using System;
using System.Windows.Forms;

namespace PracticaRefactoring
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmComanda formComanda = new frmComanda();
            formComanda.Show();
            formComanda.zona = cmbZona.Text;
            formComanda.representant = txtNom.Text;
        }
    }
}
