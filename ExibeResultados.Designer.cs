namespace QLearningTrabalho
{
    partial class ExibeResultados
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
            this.dataGridValoresEstados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValoresEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridValoresEstados
            // 
            this.dataGridValoresEstados.AllowUserToAddRows = false;
            this.dataGridValoresEstados.AllowUserToDeleteRows = false;
            this.dataGridValoresEstados.AllowUserToResizeColumns = false;
            this.dataGridValoresEstados.AllowUserToResizeRows = false;
            this.dataGridValoresEstados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridValoresEstados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridValoresEstados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridValoresEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridValoresEstados.ColumnHeadersVisible = false;
            this.dataGridValoresEstados.Location = new System.Drawing.Point(1, 3);
            this.dataGridValoresEstados.Name = "dataGridValoresEstados";
            this.dataGridValoresEstados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridValoresEstados.RowHeadersVisible = false;
            this.dataGridValoresEstados.RowHeadersWidth = 10;
            this.dataGridValoresEstados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridValoresEstados.Size = new System.Drawing.Size(1077, 628);
            this.dataGridValoresEstados.TabIndex = 1;
            // 
            // ExibeResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 630);
            this.Controls.Add(this.dataGridValoresEstados);
            this.Name = "ExibeResultados";
            this.Text = "ExibeResultados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValoresEstados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridValoresEstados;
    }
}