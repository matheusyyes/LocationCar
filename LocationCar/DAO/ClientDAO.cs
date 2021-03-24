using System;
using Npgsql;
using LocationCar.Model;
using System.Windows.Forms;

namespace LocationCar.DAO {
    class ClientDAO {
        public void Insert(Cliente cliente) {
            NpgsqlCommand cmd = new NpgsqlCommand();
            Conexao conn = new Conexao();

            try {
                cmd.CommandText = "insert into tb_client(name, cpf, cnh, tb_address_id) values(@name, @cpf, @cnh, @tb_adress_id)";

                cmd.Parameters.AddWithValue("@name", cliente.Name);
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@cnh", cliente.Cnh);
                cmd.Parameters.AddWithValue("@tb_adress_id", cliente.Address.Id);

                cmd.Connection = conn.openConnect();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted");

            }
            catch (NpgsqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.closeConnect();
            }
        }
    }
}
