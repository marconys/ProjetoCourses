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

        public int codigo { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public int cargaHoraria { get; set; }
        public double valor { get; set; }
        public bool ativo { get; set; }



        // Métodos construtores

        public Cursos()
        {

        }
        public Cursos(int codigo, string nome, string categoria, int cargaHoraria, double valor, bool ativo)

        {
            this.codigo = codigo;
            this.nome = nome;
            this.categoria = categoria;
            this.cargaHoraria = cargaHoraria;
            this.valor = valor;
            this.ativo = ativo;
        }

        public Cursos(string nome, string categoria, int cargaHoraria, double valor)

        {

            this.nome = nome;
            this.categoria = categoria;
            this.cargaHoraria = cargaHoraria;
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
            cmd.Parameters.AddWithValue("_crc_carga_horaria", cargaHoraria);
            cmd.Parameters.AddWithValue("_crc_valor", valor);
            cmd.Parameters.AddWithValue("_crc_ativo", ativo);
            codigo = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }

        public static List<Cursos> Listar()
        {
            List<Cursos> produtos = new List<Cursos>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tb_cursos order by crs_codigo";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new Cursos(
                  Convert.ToInt32(dr.GetInt32(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    Convert.ToInt32(dr.GetInt32(3)),
                    dr.GetDouble(4),
                    dr.GetBoolean(5)
                    ));
            }
            return produtos;
        }

        public bool alterar(int _crs_codigo, string _crs_nome, string _crc_valor, int _crc_carga_horaria)
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

        public static Cursos consultarPorID(int _crs_codigo)
        {
            Cursos cursos = new Cursos();
            return cursos;
        }
        public static List<Cursos> Listar2()
        {
            List<Cursos> cursos = new List<Cursos>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios order by nome";
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


       
        }
    }
