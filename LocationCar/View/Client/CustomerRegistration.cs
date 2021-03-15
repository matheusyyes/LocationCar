using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using LocationCar.Model;
using Newtonsoft.Json;

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
                    
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.Message);
                }
            }
        }
    }
}
