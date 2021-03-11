using System;
using System.Windows.Forms;
using Model;
using DAO;
namespace LocationCar {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e) {

            ModelCarDAO daoCar = new ModelCarDAO();

            ModelCar car = new ModelCar(txtFabricante, txtModelo,cmbTipo,mskPlaca,cmbCor);

            daoCar.Insert(car);

            
        }



    }
}
