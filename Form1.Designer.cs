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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btndesativarCurso = new System.Windows.Forms.Button();
            this.btn_reativarCurso = new System.Windows.Forms.Button();
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
            this.textBuscaporNomeDoCurso.TextChanged += new System.EventHandler(this.textBuscaporNomeDoCurso_TextChanged);
            // 
            // textvalorDoCurso
            // 
            this.textvalorDoCurso.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Location = new System.Drawing.Point(129, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "VALOR";
            // 
            // dgvCursos
            // 
            this.dgvCursos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCursos.Location = new System.Drawing.Point(0, 231);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(638, 219);
            this.dgvCursos.TabIndex = 12;
            // 
            // btnConsultarcursoPorId
            // 
            this.btnConsultarcursoPorId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarcursoPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarcursoPorId.Location = new System.Drawing.Point(133, 153);
            this.btnConsultarcursoPorId.Name = "btnConsultarcursoPorId";
            this.btnConsultarcursoPorId.Size = new System.Drawing.Size(69, 32);
            this.btnConsultarcursoPorId.TabIndex = 14;
            this.btnConsultarcursoPorId.Text = "Consultar";
            this.btnConsultarcursoPorId.UseVisualStyleBackColor = true;
            this.btnConsultarcursoPorId.Click += new System.EventHandler(this.btnConsultarcursoPorId_Click);
            // 
            // btnAlterarccurso
            // 
            this.btnAlterarccurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarccurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarccurso.Location = new System.Drawing.Point(208, 153);
            this.btnAlterarccurso.Name = "btnAlterarccurso";
            this.btnAlterarccurso.Size = new System.Drawing.Size(70, 32);
            this.btnAlterarccurso.TabIndex = 15;
            this.btnAlterarccurso.Text = "Alterar";
            this.btnAlterarccurso.UseVisualStyleBackColor = true;
            this.btnAlterarccurso.Click += new System.EventHandler(this.btnAlterarccurso_Click);
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCurso.Location = new System.Drawing.Point(284, 153);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(70, 32);
            this.btnExcluirCurso.TabIndex = 16;
            this.btnExcluirCurso.Text = "Excluir";
            this.btnExcluirCurso.UseVisualStyleBackColor = true;
            this.btnExcluirCurso.Click += new System.EventHandler(this.btnExcluirCurso_Click);
            // 
            // btnListarCusrsos
            // 
            this.btnListarCusrsos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarCusrsos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCusrsos.Location = new System.Drawing.Point(512, 153);
            this.btnListarCusrsos.Name = "btnListarCusrsos";
            this.btnListarCusrsos.Size = new System.Drawing.Size(70, 32);
            this.btnListarCusrsos.TabIndex = 17;
            this.btnListarCusrsos.Text = "Listar";
            this.btnListarCusrsos.UseVisualStyleBackColor = true;
            this.btnListarCusrsos.Click += new System.EventHandler(this.btnListarCusrsos_Click);
            // 
            // btnInserirCurso
            // 
            this.btnInserirCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirCurso.Location = new System.Drawing.Point(58, 153);
            this.btnInserirCurso.Name = "btnInserirCurso";
            this.btnInserirCurso.Size = new System.Drawing.Size(69, 32);
            this.btnInserirCurso.TabIndex = 18;
            this.btnInserirCurso.Text = "Inserir";
            this.btnInserirCurso.UseVisualStyleBackColor = true;
            this.btnInserirCurso.Click += new System.EventHandler(this.btnInserirCurso_Click);
            // 
            // btndesativarCurso
            // 
            this.btndesativarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndesativarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesativarCurso.Location = new System.Drawing.Point(360, 153);
            this.btndesativarCurso.Name = "btndesativarCurso";
            this.btndesativarCurso.Size = new System.Drawing.Size(70, 32);
            this.btndesativarCurso.TabIndex = 19;
            this.btndesativarCurso.Text = "Desativar";
            this.btndesativarCurso.UseVisualStyleBackColor = true;
            this.btndesativarCurso.Click += new System.EventHandler(this.btndesativarCurso_Click);
            // 
            // btn_reativarCurso
            // 
            this.btn_reativarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reativarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reativarCurso.Location = new System.Drawing.Point(436, 153);
            this.btn_reativarCurso.Name = "btn_reativarCurso";
            this.btn_reativarCurso.Size = new System.Drawing.Size(70, 32);
            this.btn_reativarCurso.TabIndex = 20;
            this.btn_reativarCurso.Text = "Reativar";
            this.btn_reativarCurso.UseVisualStyleBackColor = true;
            this.btn_reativarCurso.Click += new System.EventHandler(this.btn_reativarCurso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.btn_reativarCurso);
            this.Controls.Add(this.btndesativarCurso);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btndesativarCurso;
        private System.Windows.Forms.Button btn_reativarCurso;
    }
}

