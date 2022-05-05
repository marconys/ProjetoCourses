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
            else
            {
                MessageBox.Show("O Código Digitado Não Existe!");
            }
        }
        // Chama o método Listar todos
        private void btnListarCusrsos_Click(object sender, EventArgs e)
        {   
            dgv_disponivel.Visible = false;

            Cursos cursos = new Cursos();
            var lista = Cursos.ListarTodos();
            dgvCursos.DataSource = lista;

            
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

        // Chama o método Desativar curso
        private void btndesativarCurso_Click(object sender, EventArgs e)
        {
            try
            {

                Cursos cursos = new Cursos();
                Cursos.Desativar(int.Parse(textCodigoDoCurso.Text));

                MessageBox.Show("Curso Desativado com Sucesso!");
            }
            catch (Exception)
            {

                MessageBox.Show("Falha na Desativação do Curso!");
            }
        }

        // Chama o método Reativar curso
        private void btn_reativarCurso_Click(object sender, EventArgs e)
        {
            try
            {

                Cursos cursos = new Cursos();
                Cursos.Reativar(int.Parse(textCodigoDoCurso.Text));

                MessageBox.Show("Curso Reativado com Sucesso!");
            }
            catch (Exception)
            {

                MessageBox.Show("Falha na Reativação do Curso!");
            }
        }
        // Chama o Método listar
        private void btn_status_Click(object sender, EventArgs e)
        {
            //Chama o método listar sendo necessário a inserção de colunas no DataGridVew onde na ultima coluna será mostrado o status do curso listado
                 dgv_disponivel.Visible = true;

                 dgv_disponivel.Rows.Clear();
                 List<Cursos> listadecursos = Cursos.Listar();
                 int cont = 0;

             foreach (Cursos cursos in listadecursos)
             {



                dgv_disponivel.Rows.Add();
                dgv_disponivel.Rows[cont].Cells[0].Value = cursos.codigo.ToString();
                dgv_disponivel.Rows[cont].Cells[1].Value = cursos.nome.ToString();
                dgv_disponivel.Rows[cont].Cells[2].Value = cursos.categoria.ToString();
                dgv_disponivel.Rows[cont].Cells[3].Value = cursos.cargahoraria.ToString();
                dgv_disponivel.Rows[cont].Cells[4].Value = cursos.valor.ToString();
                dgv_disponivel.Rows[cont].Cells[5].Value = cursos.ativo; 

            // Condição que retorna com o status do curso listado
            if (cursos.ativo)
            {
                    dgv_disponivel.Rows[cont].Cells[5].Value = " Curso Ativo";
            }
            else
            {
                    dgv_disponivel.Rows[cont].Cells[5].Value = "Curso Inativo";
            }

             cont ++;
            } 
        }
    }
    
}
