using LocationCar.Model;
using Npgsql;
using System.Windows.Forms;

namespace LocationCar.DAO {
    class LocationDAO {

        public void insert(Location car) {

            Conexao con = new Conexao();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.CommandText= "insert into tb_location (time, price, tb_model_car_id, tb_client_id) " +
                             "values (@time,@price,@model_car_id,@tb_client_id);";

            

            try {
                cmd.Connection = con.openConnect();
                cmd.Parameters.AddWithValue("@time",car.Date);
                cmd.Parameters.AddWithValue("@price", car.Price);
                cmd.Parameters.AddWithValue("@model", car.Car.Id);
                cmd.Parameters.AddWithValue("@model", car.Cliente.Id);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException e) {

                MessageBox.Show(e.Message);
            }finally {
                con.closeConnect();
            }

        }

    }
}
