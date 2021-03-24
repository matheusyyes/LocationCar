using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationCar.Model {
    public class Cliente {

        public int Id  { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public Address Address { get; set; }

        public Cliente()
        {            
        }

        public Cliente(TextBox name, MaskedTextBox cpf, TextBox cnh, Address address)
        {            
            Name = name.Text;
            Cpf = cpf.Text;
            Cnh = cnh.Text;
            Address = address;
        }

    }
}
