using System;
using System.Windows.Forms;
using Controller;
using LocationCar.View;

namespace LocationCar
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {

            VehicleController vController = new VehicleController();

            vController.insert(txtFabricante, txtModelo, cmbTipo, mskPlaca, cmbCor);

        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            frmMenu menu = new frmMenu();
            menu.Show();


        }
    }
}
