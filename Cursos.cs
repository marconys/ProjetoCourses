using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoCourses
{
    public class Cursos
    {
        // Propriedades & Atribuos
        public int codigo { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public int cargahoraria { get; set; }
        public double valor { get; set; }
        public bool ativo { get; set; }



        // Métodos construtores
        public Cursos()
        {

        }

        public Cursos(int codigo)
        {
            this.codigo = codigo;
        }
        public Cursos(int codigo, string nome, string categoria, int cargaHoraria, double valor, bool ativo)

        {
            this.codigo = codigo;
            this.nome = nome;
            this.categoria = categoria;
            this.cargahoraria = cargaHoraria;
            this.valor = valor;
            this.ativo = ativo;
        }

        public Cursos(int codigo, string nome, string categoria, int cargaHoraria, double valor)

        {
            this.codigo = codigo;
            this.nome = nome;
            this.categoria = categoria;
            this.cargahoraria = cargaHoraria;
            this.valor = valor;

        }

        public Cursos(string nome, string categoria, int cargaHoraria, double valor)

        {

            this.nome = nome;
            this.categoria = categoria;
            this.cargahoraria = cargaHoraria;
            this.valor = valor;

        }

        // Métodos / funções da classe
        public void Inserir()
        {
            // Abrindo a conexão com o banco
            MySqlCommand cmd = Banco.Abrir();

            // Comando SQL

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_NovoCurso";

            cmd.Parameters.AddWithValue("_crs_nome", nome);
            cmd.Parameters.AddWithValue("_crs_categoria", categoria);
            cmd.Parameters.AddWithValue("_crc_carga_horaria", cargahoraria);
            cmd.Parameters.AddWithValue("_crc_valor", valor);
            cmd.Parameters.AddWithValue("_crc_ativo", ativo);
            codigo = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }

        // Método Listar
        public static List<Cursos> Listar()
        {
            List<Cursos> cursos = new List<Cursos>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tb_cursos order by crs_codigo";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cursos.Add(new Cursos(
                  Convert.ToInt32(dr.GetInt32(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    Convert.ToInt32(dr.GetInt32(3)),
                    dr.GetDouble(4),
                    dr.GetBoolean(5)
                    ));
            }
            return cursos;
        }

        // Método ListarTodos
        public static List<Cursos> ListarTodos(string descriParte = null)
        {
            List<Cursos> cursos = new List<Cursos>();
            // conecta banco e realiza consulta retornando todos produtos
            MySqlCommand cmd = Banco.Abrir();
            if (descriParte == null)
            { // lista produtos ativos ordenados alfabéticamente
                cmd.CommandText = "select * from tb_cursos where crc_ativo = 1 order by 2";
            }
            else
            { // lista produtos ativos, por parte da descriação e ordenados alfabéticamente
                cmd.CommandText = "select * from tb_cursos where crc_ativo = 1 and crs_nome like '%" + descriParte + "%' order by 2";
            }
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cursos.Add(new Cursos(
                  Convert.ToInt32(dr.GetInt32(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    Convert.ToInt32(dr.GetInt32(3)),
                    dr.GetDouble(4),
                    dr.GetBoolean(5)
                    ));
            }
            cmd.Connection.Close();
            return cursos;
        }

        // Método Alterar
        public bool alterar(int _crs_codigo, string _crs_nome,string categoria, double _crc_valor, int _crc_carga_horaria)
        {
            bool resultado = false;
            try
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                // recebe o nome da procedure
                cmd.CommandText = "SP_AtualizaCurso";

                cmd.Parameters.AddWithValue("_crs_codigo", _crs_codigo);
                cmd.Parameters.AddWithValue("_crs_nome", _crs_nome);
                cmd.Parameters.AddWithValue("_crs_categoria", categoria);
                cmd.Parameters.AddWithValue("_crc_valor", _crc_valor);
                cmd.Parameters.AddWithValue("_crc_carga_horaria", _crc_carga_horaria);
                cmd.ExecuteNonQuery();
                resultado = true;
                cmd.Connection.Close();
            }
            catch
            {

            }
            return resultado;
        }

        // Método ConsultarPorID
        public static Cursos ConsultarPorID(int _crs_codigo)
        {
            Cursos cursos = new Cursos();
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tb_cursos where crs_codigo= " + _crs_codigo;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cursos.codigo = Convert.ToInt32(dr["crs_codigo"]);
                cursos.nome = dr.GetString(1);
                cursos.categoria = dr.GetString(2);
                cursos.cargahoraria = Convert.ToInt32(dr["crc_carga_horaria"]);
                cursos.valor = Convert.ToDouble(dr["crc_valor"]);
                cursos.ativo = dr.GetBoolean(5);
            }
            return cursos;
        }

        // Método Desativar 
        public static void Desativar(int _crs_codigo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update tb_cursos set crc_ativo = 0 where crs_codigo = " + _crs_codigo;
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }

        // Método Reativar
        public static void Reativar(int _crs_codigo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update tb_cursos set crc_ativo = 1 where crs_codigo = " + _crs_codigo;
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }

        // Método Excluir
        public static void Excluir(int _crs_codigo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tb_cursos  where crs_codigo = " + _crs_codigo;
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }

    }

}
