using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCourses
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Chama o método inserir cursos
        private void btnInserirCurso_Click(object sender, EventArgs e)
        {            
            try
            {
                Cursos curso = new Cursos(textNomedoCurso.Text,
                    textcategoriaDoCurso.Text,
                    Int32.Parse(textCargaHorariaDoCurso.Text),
                    double.Parse(textvalorDoCurso.Text));

                curso.Inserir();  

                               

                textNomedoCurso.Clear();
                textcategoriaDoCurso.Clear();
                textCargaHorariaDoCurso.Clear();
                textvalorDoCurso.Clear();

                MessageBox.Show("Curso inserido Com sucesso");
            }
            catch (Exception)
            {

                MessageBox.Show("Erro na Inserção do Curso");
            }       
                

        }
        
        // Chama o método Alterar curso
        private void btnAlterarccurso_Click(object sender, EventArgs e)
        {

            Cursos cursos = new Cursos();

            if (cursos.alterar(int.Parse(textCodigoDoCurso.Text), textNomedoCurso.Text,
                textcategoriaDoCurso.Text,
                double.Parse(textvalorDoCurso.Text),
                int.Parse(textCargaHorariaDoCurso.Text)))

            {
                MessageBox.Show("Curso alterado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na alteração do Curso!");
            }
        }

        // Chama o método consultar por ID
        private void btnConsultarcursoPorId_Click(object sender, EventArgs e)
        {
            
            Cursos cursos = Cursos.ConsultarPorID(Int32.Parse(textCodigoDoCurso.Text));
            

            if (cursos.codigo > 0)
            {
                textCodigoDoCurso.Text = cursos.codigo.ToString();
                textNomedoCurso.Text = cursos.nome.ToString();
                textcategoriaDoCurso.Text = cursos.categoria.ToString();
                textCargaHorariaDoCurso.Text = cursos.cargahoraria.ToString();
                textvalorDoCurso.Text = cursos.valor.ToString();


            }
        }
        // Chama o método Listar todos
        private void btnListarCusrsos_Click(object sender, EventArgs e)
        {                        
            Cursos cursos = new Cursos();
            var lista = Cursos.ListarTodos();
            dgvCursos.DataSource = lista;


            //Chama o método listar sendo necessário a inserção de colunas no DataGridVew onde na ultima coluna será mostrado o status do curso listado
            
            /* dgvCursos.Rows.Clear();
             List<Cursos> listadecursos = Cursos.Listar();
             int cont = 0;

             foreach (Cursos cursos in listadecursos)
             {



             dgvCursos.Rows.Add();
             dgvCursos.Rows[cont].Cells[0].Value = cursos.codigo.ToString();
             dgvCursos.Rows[cont].Cells[1].Value = cursos.nome.ToString();
             dgvCursos.Rows[cont].Cells[2].Value = cursos.categoria.ToString();
             dgvCursos.Rows[cont].Cells[3].Value = cursos.cargahoraria.ToString();
             dgvCursos.Rows[cont].Cells[4].Value = cursos.valor.ToString();
             dgvCursos.Rows[cont].Cells[5].Value = cursos.ativo; 

             Condição que retorna com o status do curso listado
            if (cursos.ativo)
            {
                dgvCursos.Rows[cont].Cells[5].Value = "Ativo";
            }
            else
            {
                dgvCursos.Rows[cont].Cells[5].Value = "Inativo";
            }

             cont ++;
            } */
        }
        // Chama o método Excluir curso
        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            try
            {
                
                Cursos cursos = new Cursos();
                Cursos.Excluir(int.Parse(textCodigoDoCurso.Text));

                MessageBox.Show("Curso Excluido com Sucesso!");
            }
            catch (Exception)
            {

                MessageBox.Show("Falha na alteração do Curso!");
            } 
                


        }
        //Chama o método ListarTodos e busca por partes do nome do curso;
        private void textBuscaporNomeDoCurso_TextChanged(object sender, EventArgs e)
        {
            if (textBuscaporNomeDoCurso.TextLength >= 3)
            {
                
                Cursos cursos = new Cursos();
                var lista = Cursos.ListarTodos(textBuscaporNomeDoCurso.Text);
                dgvCursos.DataSource = lista;
            }
        }
    }
}
