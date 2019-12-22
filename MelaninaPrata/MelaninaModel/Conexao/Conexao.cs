using Npgsql;
using System;
using System.Data;

namespace MelaninaModel.Conexao
{
    public class Conexao
    {
        private static string serverName = "localhost";
        private static string port = "5432";
        private static string userName = "postgres";
        private static string password = "melanina";
        private static string databaseName = "Melanina";

        public static void pDefineParametros(string ip, string porta, string usuario, string senha, string database)
        {
            serverName = ip;
            port = porta;
            userName = usuario;
            password = senha;
            databaseName = database;

            stringConexao = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                          serverName, port, userName, password, databaseName);
        }

        private static string stringConexao;
        public static DataSet fConsultaPostgreSQL(string sSQL)
        {
            using (NpgsqlConnection _conexao = new NpgsqlConnection(stringConexao))
            {
                NpgsqlDataAdapter da;

                try
                {
                    if (_conexao.State == ConnectionState.Open)
                    {
                        _conexao.Close();
                    }

                    _conexao.Open();
                    DataSet ds = new DataSet();
                    da = new NpgsqlDataAdapter(sSQL, _conexao);
                    ds.Tables.Clear();
                    da.Fill(ds);
                    da.Dispose();
                    return ds;
                }
                finally
                {
                    _conexao.Close();
                }
            }
        }
        public static void pManipulaPostgreSQL(string sSQL)
        {
            using (NpgsqlConnection _conexao = new NpgsqlConnection(stringConexao))
            {
                NpgsqlCommand cmd;
                try
                {
                    _conexao.Open();
                    cmd = new NpgsqlCommand(sSQL, _conexao);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd = null;
                    _conexao.Close();
                }
            }
        }
    }
}
