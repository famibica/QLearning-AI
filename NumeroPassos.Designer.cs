﻿namespace QLearningTrabalho
{
    partial class NumeroPassos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoPassos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graficoPassos)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoPassos
            // 
            this.graficoPassos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.graficoPassos.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.graficoPassos.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea1.Name = "ChartArea1";
            this.graficoPassos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoPassos.Legends.Add(legend1);
            this.graficoPassos.Location = new System.Drawing.Point(0, -1);
            this.graficoPassos.Name = "graficoPassos";
            this.graficoPassos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.graficoPassos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series1.Legend = "Legend1";
            series1.Name = "Passos";
            series1.XValueMember = "X";
            series1.YValueMembers = "Y";
            this.graficoPassos.Series.Add(series1);
            this.graficoPassos.Size = new System.Drawing.Size(951, 519);
            this.graficoPassos.TabIndex = 0;
            this.graficoPassos.Text = "Gráfico de Passos";
            // 
            // NumeroPassos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 515);
            this.Controls.Add(this.graficoPassos);
            this.Name = "NumeroPassos";
            this.Text = "NumeroPassos";
            ((System.ComponentModel.ISupportInitialize)(this.graficoPassos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart graficoPassos;

    }
}