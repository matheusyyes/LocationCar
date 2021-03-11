using System;
using Npgsql;

namespace LocationCar {
    class Conexao {

        private static string Host = "ec2-54-162-119-125.compute-1.amazonaws.com";
        private static string User = "";
        private static string DBname = "d43pmvbviknle4";
        private static string Password = "";
        private static string Port = "5432";

        string connString =
                String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Require; Trust Server Certificate=true",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);



        public NpgsqlConnection openConnect() {

            NpgsqlConnection conn = new NpgsqlConnection(connString);

            if (conn.State == System.Data.ConnectionState.Closed) {
                conn.Open();

            }

            return conn;
        }

        public void closeConnect() {

            NpgsqlConnection conn = new NpgsqlConnection(connString);

            if (conn.State == System.Data.ConnectionState.Open) {
                conn.Close();
            }
        }





    }
}
