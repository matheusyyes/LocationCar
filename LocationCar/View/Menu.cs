using System;
using System.Windows.Forms;
using LocationCar.View.Client;

namespace LocationCar.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
              

        private void cadastroCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro frmCadastro = new Cadastro();
            frmCadastro.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerRegistration client = new CustomerRegistration();
            client.Show();
            this.Hide();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {            
                Application.Exit();            
        }
    }
}
