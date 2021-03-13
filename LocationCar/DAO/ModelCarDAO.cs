using LocationCar;
using Model;
using Npgsql;
using System.Windows.Forms;


namespace DAO {
    class ModelCarDAO {

        public void Insert(ModelCar car) {

            NpgsqlCommand cmd = new NpgsqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "insert into tb_model_car (brand, model, type, board, color, avable) " +
                              "values (@brand, @model, @type, @board, @color, @avable)";

            cmd.Parameters.AddWithValue("@brand", car.Brand);
            cmd.Parameters.AddWithValue("@model", car.Model);
            cmd.Parameters.AddWithValue("@type", car.Type);
            cmd.Parameters.AddWithValue("@board", car.Board);
            cmd.Parameters.AddWithValue("@color", car.Color);
            cmd.Parameters.AddWithValue("@avable", car.Avable);

            try {
                cmd.Connection = con.openConnect();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted");
            }
            catch (NpgsqlException ex) {

                if(ex.Message.Contains("duplicate key")) {
                    MessageBox.Show("Placa já registrada", "Ateção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else {
                    MessageBox.Show(ex.Message, "Ateção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                

            }
            finally {
                con.closeConnect();
            }
        }

    }
}
