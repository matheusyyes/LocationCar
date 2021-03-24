using System;
using System.Windows.Forms;
using LocationCar.Model;
using Npgsql;

namespace LocationCar.DAO {
    class AddressDAO {
        int idAddress;

        public int insert(Address address) 
            {
            
            Conexao con = new Conexao();
            NpgsqlCommand cmd = new NpgsqlCommand();            

            cmd.CommandText = "insert into tb_address(cep, street, number, city, uf) values (@cep, @street, @number, @city, @uf);" +
                "SELECT currval(pg_get_serial_sequence('tb_address','id'));";
            cmd.Parameters.AddWithValue("@cep", address.cep);
            cmd.Parameters.AddWithValue("@street", address.logradouro);
            cmd.Parameters.AddWithValue("@number", address.numero);
            cmd.Parameters.AddWithValue("@city", address.localidade);
            cmd.Parameters.AddWithValue("@uf", address.uf);

            
            try {

                
                cmd.Connection = con.openConnect();

                NpgsqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read()) {

                    idAddress = dataReader.GetInt32(0);
                }

               

               

            }
            catch (Exception e ) {

                MessageBox.Show(e.Message);
            }
            finally
            {
                con.closeConnect();
            }

            return idAddress;
        }

    }
}
