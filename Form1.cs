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


            curso.Inserir();
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
            catch (Exception ex )
            {

                MessageBox.Show("Erro na Inserção do curso " + Text, ex.Message);
            }
        }

        private void btnAlterarccurso_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarcursoPorId_Click(object sender, EventArgs e)
        {

        }
    }
}
