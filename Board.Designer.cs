namespace QLearningTrabalho
{
    partial class Board
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
            this.dataGridQL = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeroDePassosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarVisualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alfaText = new System.Windows.Forms.TextBox();
            this.gamaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoRodar = new System.Windows.Forms.Button();
            this.numero_iteracoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.divisorIteracoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mostrarQuantas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQL)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridQL
            // 
            this.dataGridQL.AllowUserToAddRows = false;
            this.dataGridQL.AllowUserToDeleteRows = false;
            this.dataGridQL.AllowUserToResizeColumns = false;
            this.dataGridQL.AllowUserToResizeRows = false;
            this.dataGridQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridQL.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridQL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQL.ColumnHeadersVisible = false;
            this.dataGridQL.Location = new System.Drawing.Point(12, 27);
            this.dataGridQL.Name = "dataGridQL";
            this.dataGridQL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridQL.RowHeadersVisible = false;
            this.dataGridQL.RowHeadersWidth = 10;
            this.dataGridQL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridQL.Size = new System.Drawing.Size(1046, 615);
            this.dataGridQL.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exportarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "Arquivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarArquivoToolStripMenuItem,
            this.salvarResultadoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Arquivo";
            // 
            // carregarArquivoToolStripMenuItem
            // 
            this.carregarArquivoToolStripMenuItem.Name = "carregarArquivoToolStripMenuItem";
            this.carregarArquivoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.carregarArquivoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.carregarArquivoToolStripMenuItem.Text = "Carregar Arquivo";
            this.carregarArquivoToolStripMenuItem.Click += new System.EventHandler(this.carregarArquivoToolStripMenuItem_Click);
            // 
            // salvarResultadoToolStripMenuItem
            // 
            this.salvarResultadoToolStripMenuItem.Name = "salvarResultadoToolStripMenuItem";
            this.salvarResultadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarResultadoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.salvarResultadoToolStripMenuItem.Text = "Salvar Resultado";
            this.salvarResultadoToolStripMenuItem.Click += new System.EventHandler(this.salvarResultadoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeroDePassosToolStripMenuItem,
            this.gerarVisualizaçãoToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // numeroDePassosToolStripMenuItem
            // 
            this.numeroDePassosToolStripMenuItem.Name = "numeroDePassosToolStripMenuItem";
            this.numeroDePassosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.numeroDePassosToolStripMenuItem.Text = "Numero de Passos";
            this.numeroDePassosToolStripMenuItem.Click += new System.EventHandler(this.numeroDePassosToolStripMenuItem_Click);
            // 
            // gerarVisualizaçãoToolStripMenuItem
            // 
            this.gerarVisualizaçãoToolStripMenuItem.Name = "gerarVisualizaçãoToolStripMenuItem";
            this.gerarVisualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gerarVisualizaçãoToolStripMenuItem.Text = "Gerar Visualização";
            this.gerarVisualizaçãoToolStripMenuItem.Click += new System.EventHandler(this.gerarVisualizaçãoToolStripMenuItem_Click);
            // 
            // alfaText
            // 
            this.alfaText.Location = new System.Drawing.Point(507, 4);
            this.alfaText.Name = "alfaText";
            this.alfaText.Size = new System.Drawing.Size(26, 20);
            this.alfaText.TabIndex = 3;
            this.alfaText.Text = "1";
            // 
            // gamaText
            // 
            this.gamaText.Location = new System.Drawing.Point(579, 4);
            this.gamaText.Name = "gamaText";
            this.gamaText.Size = new System.Drawing.Size(26, 20);
            this.gamaText.TabIndex = 3;
            this.gamaText.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alfa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gama";
            // 
            // botaoRodar
            // 
            this.botaoRodar.Location = new System.Drawing.Point(731, 2);
            this.botaoRodar.Name = "botaoRodar";
            this.botaoRodar.Size = new System.Drawing.Size(46, 23);
            this.botaoRodar.TabIndex = 5;
            this.botaoRodar.Text = "Rodar";
            this.botaoRodar.UseVisualStyleBackColor = true;
            this.botaoRodar.Click += new System.EventHandler(this.botaoRodar_Click);
            // 
            // numero_iteracoes
            // 
            this.numero_iteracoes.Location = new System.Drawing.Point(315, 4);
            this.numero_iteracoes.Name = "numero_iteracoes";
            this.numero_iteracoes.Size = new System.Drawing.Size(37, 20);
            this.numero_iteracoes.TabIndex = 6;
            this.numero_iteracoes.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Número de Iterações";
            // 
            // divisorIteracoes
            // 
            this.divisorIteracoes.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.divisorIteracoes.Location = new System.Drawing.Point(449, 4);
            this.divisorIteracoes.Name = "divisorIteracoes";
            this.divisorIteracoes.Size = new System.Drawing.Size(22, 20);
            this.divisorIteracoes.TabIndex = 8;
            this.divisorIteracoes.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Divisor Iterações";
            // 
            // mostrarQuantas
            // 
            this.mostrarQuantas.Location = new System.Drawing.Point(699, 4);
            this.mostrarQuantas.Name = "mostrarQuantas";
            this.mostrarQuantas.Size = new System.Drawing.Size(26, 20);
            this.mostrarQuantas.TabIndex = 10;
            this.mostrarQuantas.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mostrar Quantas";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 654);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mostrarQuantas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.divisorIteracoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero_iteracoes);
            this.Controls.Add(this.botaoRodar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamaText);
            this.Controls.Add(this.alfaText);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridQL);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Board";
            this.Text = "QLearning  - Matheus C. Bica - Alexandre Santos Jr.";
            this.Load += new System.EventHandler(this.Board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQL)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridQL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem carregarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarResultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeroDePassosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarVisualizaçãoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoRodar;
        public System.Windows.Forms.TextBox alfaText;
        public System.Windows.Forms.TextBox gamaText;
        public System.Windows.Forms.TextBox numero_iteracoes;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox divisorIteracoes;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox mostrarQuantas;
        private System.Windows.Forms.Label label5;





    }
}

