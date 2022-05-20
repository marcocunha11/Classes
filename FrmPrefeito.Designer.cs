namespace Classes_MarcoHenrique
{
    partial class FrmPrefeito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrefeito));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.dtp_nascimento = new System.Windows.Forms.DateTimePicker();
            this.lbl_dados = new System.Windows.Forms.Label();
            this.lbl_local = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_baixo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefeitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(16, 344);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(264, 47);
            this.btn_cadastrar.TabIndex = 50;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(13, 100);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(39, 13);
            this.lbl_nome.TabIndex = 24;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(237, 100);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 13);
            this.lbl_cpf.TabIndex = 25;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nascimento.Location = new System.Drawing.Point(449, 100);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(112, 13);
            this.lbl_nascimento.TabIndex = 26;
            this.lbl_nascimento.Text = "Dt. de Nascimento";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(13, 186);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(31, 13);
            this.lbl_cep.TabIndex = 27;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(13, 235);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(52, 13);
            this.lbl_rua.TabIndex = 28;
            this.lbl_rua.Text = "Rua/AV";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(12, 285);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(50, 13);
            this.lbl_numero.TabIndex = 29;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_complemento.Location = new System.Drawing.Point(234, 285);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(82, 13);
            this.lbl_complemento.TabIndex = 30;
            this.lbl_complemento.Text = "Complemento";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(484, 285);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(40, 13);
            this.lbl_bairro.TabIndex = 31;
            this.lbl_bairro.Text = "Bairro";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(524, 186);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(46, 13);
            this.lbl_cidade.TabIndex = 32;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(361, 186);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(46, 13);
            this.lbl_estado.TabIndex = 33;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pais.Location = new System.Drawing.Point(183, 186);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(33, 13);
            this.lbl_pais.TabIndex = 34;
            this.lbl_pais.Text = "País";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(15, 116);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(216, 20);
            this.txt_nome.TabIndex = 35;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(240, 116);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(206, 20);
            this.txt_cpf.TabIndex = 36;
            // 
            // dtp_nascimento
            // 
            this.dtp_nascimento.Location = new System.Drawing.Point(452, 116);
            this.dtp_nascimento.Name = "dtp_nascimento";
            this.dtp_nascimento.Size = new System.Drawing.Size(212, 20);
            this.dtp_nascimento.TabIndex = 37;
            // 
            // lbl_dados
            // 
            this.lbl_dados.AutoSize = true;
            this.lbl_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados.Location = new System.Drawing.Point(12, 65);
            this.lbl_dados.Name = "lbl_dados";
            this.lbl_dados.Size = new System.Drawing.Size(158, 24);
            this.lbl_dados.TabIndex = 38;
            this.lbl_dados.Text = "Dados Pessoais";
            // 
            // lbl_local
            // 
            this.lbl_local.AutoSize = true;
            this.lbl_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_local.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_local.Location = new System.Drawing.Point(11, 152);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(60, 24);
            this.lbl_local.TabIndex = 39;
            this.lbl_local.Text = "Local";
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(15, 202);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(155, 20);
            this.txt_cep.TabIndex = 40;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(186, 202);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(162, 20);
            this.txt_pais.TabIndex = 41;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(364, 202);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(147, 20);
            this.txt_estado.TabIndex = 42;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(527, 202);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(134, 20);
            this.txt_cidade.TabIndex = 43;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(15, 251);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(646, 20);
            this.txt_rua.TabIndex = 44;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(15, 301);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(134, 20);
            this.txt_numero.TabIndex = 45;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(240, 301);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(155, 20);
            this.txt_complemento.TabIndex = 46;
            // 
            // txt_baixo
            // 
            this.txt_baixo.Location = new System.Drawing.Point(486, 301);
            this.txt_baixo.Name = "txt_baixo";
            this.txt_baixo.Size = new System.Drawing.Size(174, 20);
            this.txt_baixo.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 44);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(168, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 44);
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 77;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.classesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prefeitoToolStripMenuItem,
            this.lojaToolStripMenuItem,
            this.alimentoToolStripMenuItem});
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // prefeitoToolStripMenuItem
            // 
            this.prefeitoToolStripMenuItem.Name = "prefeitoToolStripMenuItem";
            this.prefeitoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prefeitoToolStripMenuItem.Text = "Prefeito";
            this.prefeitoToolStripMenuItem.Click += new System.EventHandler(this.prefeitoToolStripMenuItem_Click);
            // 
            // lojaToolStripMenuItem
            // 
            this.lojaToolStripMenuItem.Name = "lojaToolStripMenuItem";
            this.lojaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lojaToolStripMenuItem.Text = "Loja";
            this.lojaToolStripMenuItem.Click += new System.EventHandler(this.lojaToolStripMenuItem_Click);
            // 
            // alimentoToolStripMenuItem
            // 
            this.alimentoToolStripMenuItem.Name = "alimentoToolStripMenuItem";
            this.alimentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alimentoToolStripMenuItem.Text = "Alimento";
            this.alimentoToolStripMenuItem.Click += new System.EventHandler(this.alimentoToolStripMenuItem_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(396, 344);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(264, 47);
            this.btn_limpar.TabIndex = 91;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // FrmPrefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 403);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_baixo);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.lbl_local);
            this.Controls.Add(this.lbl_dados);
            this.Controls.Add(this.dtp_nascimento);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_complemento);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrefeito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrefeito";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_complemento;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.DateTimePicker dtp_nascimento;
        private System.Windows.Forms.Label lbl_dados;
        private System.Windows.Forms.Label lbl_local;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_baixo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prefeitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentoToolStripMenuItem;
        private System.Windows.Forms.Button btn_limpar;
    }
}

