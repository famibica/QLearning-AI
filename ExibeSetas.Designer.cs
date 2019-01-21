namespace QLearningTrabalho
{
    partial class ExibeSetas
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
            this.dataGridSetas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSetas
            // 
            this.dataGridSetas.AllowUserToAddRows = false;
            this.dataGridSetas.AllowUserToDeleteRows = false;
            this.dataGridSetas.AllowUserToResizeColumns = false;
            this.dataGridSetas.AllowUserToResizeRows = false;
            this.dataGridSetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSetas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridSetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridSetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSetas.ColumnHeadersVisible = false;
            this.dataGridSetas.Location = new System.Drawing.Point(1, -3);
            this.dataGridSetas.Name = "dataGridSetas";
            this.dataGridSetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridSetas.RowHeadersVisible = false;
            this.dataGridSetas.RowHeadersWidth = 10;
            this.dataGridSetas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSetas.Size = new System.Drawing.Size(1077, 628);
            this.dataGridSetas.TabIndex = 2;
            // 
            // ExibeSetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 620);
            this.Controls.Add(this.dataGridSetas);
            this.Name = "ExibeSetas";
            this.Text = "ExibeSetas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridSetas;
    }
}