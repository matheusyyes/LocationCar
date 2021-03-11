using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model {
    class ModelCar {

        public int Id { get;}
        public string Brand{ get; set; }
        public string Model{ get; set; }
        public string Type { get; set; }
        public string Board { get; set; }
        public string Color { get; set; }
        public bool Avable { get; set; }

        public ModelCar() {

        }

        public ModelCar(TextBox brand, TextBox  model,ComboBox  type,MaskedTextBox  board,ComboBox color ) {
            Brand = brand.Text;
            Model = model.Text;
            Type = type.Text;
            Board = board.Text;
            Color = color.Text;
            Avable = true;
        }

        public override string ToString() {
            return "brand: "+Brand
                   +" model "+Model
                   +" type "+Type
                   + " board " + Board
                   + " Color "+Color;
        }
    }
}
