using System;
using System.Windows.Forms;
using Controller;
namespace LocationCar {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e) {

            VehicleController vController = new VehicleController();

            vController.insert(txtFabricante, txtModelo, cmbTipo, mskPlaca, cmbCor);
            
        }

        
    }
}
