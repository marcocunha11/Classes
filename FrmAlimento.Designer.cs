namespace Classes_MarcoHenrique
{
    partial class FrmAlimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefeitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_alimento = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_ingrediente = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_caloria = new System.Windows.Forms.TextBox();
            this.lbl_calorias = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_10 = new System.Windows.Forms.TextBox();
            this.lbl_10 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
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
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classesToolStripMenuItem_Click);
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
            // lbl_alimento
            // 
            this.lbl_alimento.AutoSize = true;
            this.lbl_alimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alimento.Location = new System.Drawing.Point(9, 36);
            this.lbl_alimento.Name = "lbl_alimento";
            this.lbl_alimento.Size = new System.Drawing.Size(92, 24);
            this.lbl_alimento.TabIndex = 82;
            this.lbl_alimento.Text = "Alimento";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(361, 87);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(296, 20);
            this.txt_cpf.TabIndex = 81;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 87);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(301, 20);
            this.txt_nome.TabIndex = 80;
            // 
            // lbl_ingrediente
            // 
            this.lbl_ingrediente.AutoSize = true;
            this.lbl_ingrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingrediente.Location = new System.Drawing.Point(358, 71);
            this.lbl_ingrediente.Name = "lbl_ingrediente";
            this.lbl_ingrediente.Size = new System.Drawing.Size(71, 13);
            this.lbl_ingrediente.TabIndex = 79;
            this.lbl_ingrediente.Text = "Ingrediente";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(10, 71);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(39, 13);
            this.lbl_nome.TabIndex = 78;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_caloria
            // 
            this.txt_caloria.Location = new System.Drawing.Point(13, 142);
            this.txt_caloria.Name = "txt_caloria";
            this.txt_caloria.Size = new System.Drawing.Size(206, 20);
            this.txt_caloria.TabIndex = 84;
            // 
            // lbl_calorias
            // 
            this.lbl_calorias.AutoSize = true;
            this.lbl_calorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calorias.Location = new System.Drawing.Point(11, 126);
            this.lbl_calorias.Name = "lbl_calorias";
            this.lbl_calorias.Size = new System.Drawing.Size(52, 13);
            this.lbl_calorias.TabIndex = 83;
            this.lbl_calorias.Text = "Calorias";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(234, 142);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(204, 20);
            this.txt_valor.TabIndex = 86;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(231, 126);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(36, 13);
            this.lbl_valor.TabIndex = 85;
            this.lbl_valor.Text = "Valor";
            // 
            // txt_10
            // 
            this.txt_10.Location = new System.Drawing.Point(453, 142);
            this.txt_10.Name = "txt_10";
            this.txt_10.Size = new System.Drawing.Size(204, 20);
            this.txt_10.TabIndex = 88;
            // 
            // lbl_10
            // 
            this.lbl_10.AutoSize = true;
            this.lbl_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_10.Location = new System.Drawing.Point(450, 126);
            this.lbl_10.Name = "lbl_10";
            this.lbl_10.Size = new System.Drawing.Size(160, 13);
            this.lbl_10.TabIndex = 87;
            this.lbl_10.Text = "Valor com 10% de aumento";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(13, 183);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(264, 47);
            this.btn_cadastrar.TabIndex = 89;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(394, 183);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(264, 47);
            this.btn_limpar.TabIndex = 90;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // FrmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 242);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_10);
            this.Controls.Add(this.lbl_10);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_caloria);
            this.Controls.Add(this.lbl_calorias);
            this.Controls.Add(this.lbl_alimento);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_ingrediente);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlimento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prefeitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentoToolStripMenuItem;
        private System.Windows.Forms.Label lbl_alimento;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_ingrediente;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_caloria;
        private System.Windows.Forms.Label lbl_calorias;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_10;
        private System.Windows.Forms.Label lbl_10;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_limpar;
    }
}