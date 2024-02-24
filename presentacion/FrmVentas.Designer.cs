namespace Presentacion
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTop5Ventas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTicketPromedio = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTop5Ventas
            // 
            this.chartTop5Ventas.BackColor = System.Drawing.Color.Transparent;
            this.chartTop5Ventas.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartTop5Ventas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTop5Ventas.Legends.Add(legend1);
            this.chartTop5Ventas.Location = new System.Drawing.Point(29, 113);
            this.chartTop5Ventas.Name = "chartTop5Ventas";
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Transparent;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.Enabled = false;
            this.chartTop5Ventas.Series.Add(series1);
            this.chartTop5Ventas.Size = new System.Drawing.Size(428, 316);
            this.chartTop5Ventas.TabIndex = 0;
            this.chartTop5Ventas.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(484, 125);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(301, 247);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // lblTicketPromedio
            // 
            this.lblTicketPromedio.AutoSize = true;
            this.lblTicketPromedio.Depth = 0;
            this.lblTicketPromedio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTicketPromedio.Location = new System.Drawing.Point(45, 77);
            this.lblTicketPromedio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTicketPromedio.Name = "lblTicketPromedio";
            this.lblTicketPromedio.Size = new System.Drawing.Size(123, 19);
            this.lblTicketPromedio.TabIndex = 2;
            this.lblTicketPromedio.Text = "Ticket promedio: ";
            // 
            // FrmVentas
            // 
            this.ClientSize = new System.Drawing.Size(838, 475);
            this.Controls.Add(this.lblTicketPromedio);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chartTop5Ventas);
            this.Name = "FrmVentas";
            this.Text = "Estadísticas de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5Ventas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private MaterialSkin.Controls.MaterialLabel lblTicketPromedio;
    }
}