using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoCourses
{
    public static class Banco 
    {
        public static string Conexao { get; set; }

        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            Conexao = @"server=127.0.0.1;database=cursos;user id=root;password=;port=3306";
            MySqlConnection cn = new MySqlConnection(Conexao);
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                throw;
            }

            cmd.Connection = cn;
            return cmd;
        }
    }
}
