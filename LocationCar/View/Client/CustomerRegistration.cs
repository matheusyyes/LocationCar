using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using LocationCar.Model;
using Newtonsoft.Json;
using LocationCar.DAO;

namespace LocationCar.View.Client
{
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = String.Format("http://viacep.com.br/ws/{0}/json/", mskCEP.Text);
                var request = WebRequest.CreateHttp(url);
                request.Method = "GET";
                try
                {
                    WebResponse DataRequest = request.GetResponse();
                    Stream strem = DataRequest.GetResponseStream();
                    StreamReader sr = new StreamReader(strem);
                    string add = sr.ReadToEnd();
                    Address address = JsonConvert.DeserializeObject<Address>(add);

                    txtEndereco.Text = address.logradouro;
                    txtBairro.Text = address.bairro;
                    txtUF.Text = address.uf;
                    txtCidade.Text = address.localidade;
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.Message);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {

            Address address = new Address();

            Cliente cli = new Cliente(txtNome, mskCpf, txtCnh, address);

            address.logradouro = txtEndereco.Text;
            address.bairro = txtBairro.Text ;
            address.uf = txtUF.Text;
            address.localidade = txtCidade.Text;
            address.numero =int.Parse(txtNumero.Text);
            address.cep = mskCEP.Text;

            AddressDAO addressDAO = new AddressDAO();
            cli.Address.Id = addressDAO.insert(address);

            ClientDAO clientDAO = new ClientDAO();

            clientDAO.Insert(cli);


            

        }
    }
}
