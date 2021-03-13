using DAO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller {
    class VehicleController {

        public void insert(TextBox brand, TextBox model, ComboBox type, MaskedTextBox board, ComboBox color) {

            ModelCarDAO daoCar = new ModelCarDAO();

            ModelCar car = new ModelCar(brand, model, type, board, color);

            if(car.Board == "   -" || car.Model == ""|| car.Brand == "" || car.Color == "") {
                MessageBox.Show("Favor preencher todos os campos!!", "Atenção!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else { 
            daoCar.Insert(car);
            }

        }

    }
}
