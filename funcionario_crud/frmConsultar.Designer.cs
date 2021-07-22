
namespace funcionario_crud
{
    partial class frmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.btnBuscaRg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.dgvFuncionarioConsultar = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDadosCadastraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioConsultar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarTodos);
            this.groupBox2.Controls.Add(this.btnBuscaRg);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mskRg);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 94);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar funcionário:";
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnBuscarTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarTodos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTodos.Location = new System.Drawing.Point(382, 38);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Padding = new System.Windows.Forms.Padding(2);
            this.btnBuscarTodos.Size = new System.Drawing.Size(115, 46);
            this.btnBuscarTodos.TabIndex = 54;
            this.btnBuscarTodos.Text = "CONSULTAR TODOS";
            this.btnBuscarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTodos.UseVisualStyleBackColor = false;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // btnBuscaRg
            // 
            this.btnBuscaRg.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnBuscaRg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscaRg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaRg.Location = new System.Drawing.Point(261, 38);
            this.btnBuscaRg.Name = "btnBuscaRg";
            this.btnBuscaRg.Padding = new System.Windows.Forms.Padding(2);
            this.btnBuscaRg.Size = new System.Drawing.Size(115, 46);
            this.btnBuscaRg.TabIndex = 53;
            this.btnBuscaRg.Text = "CONSULTAR RG";
            this.btnBuscaRg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscaRg.UseVisualStyleBackColor = false;
            this.btnBuscaRg.Click += new System.EventHandler(this.btnBuscaRg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "RG do funcionário:";
            // 
            // mskRg
            // 
            this.mskRg.Location = new System.Drawing.Point(103, 59);
            this.mskRg.Mask = "00.000.000-0";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(94, 25);
            this.mskRg.TabIndex = 39;
            // 
            // dgvFuncionarioConsultar
            // 
            this.dgvFuncionarioConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarioConsultar.Location = new System.Drawing.Point(12, 142);
            this.dgvFuncionarioConsultar.Name = "dgvFuncionarioConsultar";
            this.dgvFuncionarioConsultar.Size = new System.Drawing.Size(527, 169);
            this.dgvFuncionarioConsultar.TabIndex = 56;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 39);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionárioToolStripMenuItem,
            this.alterarDadosCadastraisToolStripMenuItem,
            this.excluirFuncionárioToolStripMenuItem});
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 35);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            this.cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            this.cadastrarFuncionárioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.cadastrarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            this.cadastrarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFuncionárioToolStripMenuItem_Click);
            // 
            // alterarDadosCadastraisToolStripMenuItem
            // 
            this.alterarDadosCadastraisToolStripMenuItem.Name = "alterarDadosCadastraisToolStripMenuItem";
            this.alterarDadosCadastraisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.alterarDadosCadastraisToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.alterarDadosCadastraisToolStripMenuItem.Text = "Alterar dados cadastrais";
            this.alterarDadosCadastraisToolStripMenuItem.Click += new System.EventHandler(this.alterarDadosCadastraisToolStripMenuItem_Click);
            // 
            // excluirFuncionárioToolStripMenuItem
            // 
            this.excluirFuncionárioToolStripMenuItem.Name = "excluirFuncionárioToolStripMenuItem";
            this.excluirFuncionárioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.excluirFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.excluirFuncionárioToolStripMenuItem.Text = "Excluir funcionário";
            this.excluirFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.excluirFuncionárioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharSistemaToolStripMenuItem});
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 35);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // fecharSistemaToolStripMenuItem
            // 
            this.fecharSistemaToolStripMenuItem.Name = "fecharSistemaToolStripMenuItem";
            this.fecharSistemaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fecharSistemaToolStripMenuItem.Text = "Fechar Sistema";
            this.fecharSistemaToolStripMenuItem.Click += new System.EventHandler(this.fecharSistemaToolStripMenuItem_Click);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 322);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvFuncionarioConsultar);
            this.Name = "frmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DELTA SYSTEM";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioConsultar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscaRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.DataGridView dgvFuncionarioConsultar;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarDadosCadastraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharSistemaToolStripMenuItem;
    }
}