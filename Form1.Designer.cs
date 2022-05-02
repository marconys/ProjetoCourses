namespace ProjetoCourses
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textCodigoDoCurso = new System.Windows.Forms.TextBox();
            this.textNomedoCurso = new System.Windows.Forms.TextBox();
            this.textcategoriaDoCurso = new System.Windows.Forms.TextBox();
            this.textCargaHorariaDoCurso = new System.Windows.Forms.TextBox();
            this.textBuscaporNomeDoCurso = new System.Windows.Forms.TextBox();
            this.textvalorDoCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnConsultarcursoPorId = new System.Windows.Forms.Button();
            this.btnAlterarccurso = new System.Windows.Forms.Button();
            this.btnExcluirCurso = new System.Windows.Forms.Button();
            this.btnListarCusrsos = new System.Windows.Forms.Button();
            this.btnInserirCurso = new System.Windows.Forms.Button();
            this.Columcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCarga_Horaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // textCodigoDoCurso
            // 
            this.textCodigoDoCurso.Location = new System.Drawing.Point(178, 11);
            this.textCodigoDoCurso.Name = "textCodigoDoCurso";
            this.textCodigoDoCurso.Size = new System.Drawing.Size(100, 20);
            this.textCodigoDoCurso.TabIndex = 0;
            // 
            // textNomedoCurso
            // 
            this.textNomedoCurso.Location = new System.Drawing.Point(178, 37);
            this.textNomedoCurso.Name = "textNomedoCurso";
            this.textNomedoCurso.Size = new System.Drawing.Size(368, 20);
            this.textNomedoCurso.TabIndex = 1;
            // 
            // textcategoriaDoCurso
            // 
            this.textcategoriaDoCurso.Location = new System.Drawing.Point(178, 63);
            this.textcategoriaDoCurso.Name = "textcategoriaDoCurso";
            this.textcategoriaDoCurso.Size = new System.Drawing.Size(266, 20);
            this.textcategoriaDoCurso.TabIndex = 2;
            // 
            // textCargaHorariaDoCurso
            // 
            this.textCargaHorariaDoCurso.Location = new System.Drawing.Point(178, 89);
            this.textCargaHorariaDoCurso.Name = "textCargaHorariaDoCurso";
            this.textCargaHorariaDoCurso.Size = new System.Drawing.Size(100, 20);
            this.textCargaHorariaDoCurso.TabIndex = 3;
            // 
            // textBuscaporNomeDoCurso
            // 
            this.textBuscaporNomeDoCurso.Location = new System.Drawing.Point(0, 211);
            this.textBuscaporNomeDoCurso.Name = "textBuscaporNomeDoCurso";
            this.textBuscaporNomeDoCurso.Size = new System.Drawing.Size(638, 20);
            this.textBuscaporNomeDoCurso.TabIndex = 4;
            // 
            // textvalorDoCurso
            // 
            this.textvalorDoCurso.Location = new System.Drawing.Point(178, 115);
            this.textvalorDoCurso.Name = "textvalorDoCurso";
            this.textvalorDoCurso.Size = new System.Drawing.Size(100, 20);
            this.textvalorDoCurso.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CATEGORIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CARGA HORARIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pesquisa por Nome do Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "VALOR";
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columcodigo,
            this.ColumnNome,
            this.ColumnCategoria,
            this.ColumnCarga_Horaria,
            this.ColumnValor,
            this.Columnstatus});
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCursos.Location = new System.Drawing.Point(0, 228);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(638, 222);
            this.dgvCursos.TabIndex = 12;
            // 
            // btnConsultarcursoPorId
            // 
            this.btnConsultarcursoPorId.Location = new System.Drawing.Point(140, 150);
            this.btnConsultarcursoPorId.Name = "btnConsultarcursoPorId";
            this.btnConsultarcursoPorId.Size = new System.Drawing.Size(87, 32);
            this.btnConsultarcursoPorId.TabIndex = 14;
            this.btnConsultarcursoPorId.Text = "Consultar";
            this.btnConsultarcursoPorId.UseVisualStyleBackColor = true;
            this.btnConsultarcursoPorId.Click += new System.EventHandler(this.btnConsultarcursoPorId_Click);
            // 
            // btnAlterarccurso
            // 
            this.btnAlterarccurso.Location = new System.Drawing.Point(270, 150);
            this.btnAlterarccurso.Name = "btnAlterarccurso";
            this.btnAlterarccurso.Size = new System.Drawing.Size(87, 32);
            this.btnAlterarccurso.TabIndex = 15;
            this.btnAlterarccurso.Text = "Alterar";
            this.btnAlterarccurso.UseVisualStyleBackColor = true;
            this.btnAlterarccurso.Click += new System.EventHandler(this.btnAlterarccurso_Click);
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.Location = new System.Drawing.Point(399, 150);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(87, 32);
            this.btnExcluirCurso.TabIndex = 16;
            this.btnExcluirCurso.Text = "Excluir";
            this.btnExcluirCurso.UseVisualStyleBackColor = true;
            // 
            // btnListarCusrsos
            // 
            this.btnListarCusrsos.Location = new System.Drawing.Point(527, 150);
            this.btnListarCusrsos.Name = "btnListarCusrsos";
            this.btnListarCusrsos.Size = new System.Drawing.Size(87, 32);
            this.btnListarCusrsos.TabIndex = 17;
            this.btnListarCusrsos.Text = "Listar";
            this.btnListarCusrsos.UseVisualStyleBackColor = true;
            this.btnListarCusrsos.Click += new System.EventHandler(this.btnListarCusrsos_Click);
            // 
            // btnInserirCurso
            // 
            this.btnInserirCurso.Location = new System.Drawing.Point(15, 150);
            this.btnInserirCurso.Name = "btnInserirCurso";
            this.btnInserirCurso.Size = new System.Drawing.Size(87, 32);
            this.btnInserirCurso.TabIndex = 18;
            this.btnInserirCurso.Text = "Inserir";
            this.btnInserirCurso.UseVisualStyleBackColor = true;
            this.btnInserirCurso.Click += new System.EventHandler(this.btnInserirCurso_Click);
            // 
            // Columcodigo
            // 
            this.Columcodigo.HeaderText = "Codigo";
            this.Columcodigo.Name = "Columcodigo";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.HeaderText = "Categoria";
            this.ColumnCategoria.Name = "ColumnCategoria";
            // 
            // ColumnCarga_Horaria
            // 
            this.ColumnCarga_Horaria.HeaderText = "Carga_Horaria";
            this.ColumnCarga_Horaria.Name = "ColumnCarga_Horaria";
            // 
            // ColumnValor
            // 
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            // 
            // Columnstatus
            // 
            this.Columnstatus.HeaderText = "Status";
            this.Columnstatus.Name = "Columnstatus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.btnInserirCurso);
            this.Controls.Add(this.btnListarCusrsos);
            this.Controls.Add(this.btnExcluirCurso);
            this.Controls.Add(this.btnAlterarccurso);
            this.Controls.Add(this.btnConsultarcursoPorId);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textvalorDoCurso);
            this.Controls.Add(this.textBuscaporNomeDoCurso);
            this.Controls.Add(this.textCargaHorariaDoCurso);
            this.Controls.Add(this.textcategoriaDoCurso);
            this.Controls.Add(this.textNomedoCurso);
            this.Controls.Add(this.textCodigoDoCurso);
            this.Name = "Form1";
            this.Text = "Cadastro Curso";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCodigoDoCurso;
        private System.Windows.Forms.TextBox textNomedoCurso;
        private System.Windows.Forms.TextBox textcategoriaDoCurso;
        private System.Windows.Forms.TextBox textCargaHorariaDoCurso;
        private System.Windows.Forms.TextBox textBuscaporNomeDoCurso;
        private System.Windows.Forms.TextBox textvalorDoCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnConsultarcursoPorId;
        private System.Windows.Forms.Button btnAlterarccurso;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.Button btnListarCusrsos;
        private System.Windows.Forms.Button btnInserirCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCarga_Horaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnstatus;
    }
}

