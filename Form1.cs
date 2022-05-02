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

        private void btnAlterarccurso_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarcursoPorId_Click(object sender, EventArgs e)
        {

        }

        private void btnListarCusrsos_Click(object sender, EventArgs e)
        {
            dgvCursos.Rows.Clear();
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
            }
        }

    }
}
