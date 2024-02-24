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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTicketPromedio = new MaterialSkin.Controls.MaterialLabel();
            this.chartBarraMarcas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTop5Ventas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.chartBarraCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelFondo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarraMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarraCategorias)).BeginInit();
            this.panelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTicketPromedio
            // 
            this.lblTicketPromedio.AutoSize = true;
            this.lblTicketPromedio.Depth = 0;
            this.lblTicketPromedio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTicketPromedio.Location = new System.Drawing.Point(25, 19);
            this.lblTicketPromedio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTicketPromedio.Name = "lblTicketPromedio";
            this.lblTicketPromedio.Size = new System.Drawing.Size(123, 19);
            this.lblTicketPromedio.TabIndex = 2;
            this.lblTicketPromedio.Text = "Ticket promedio: ";
            // 
            // chartBarraMarcas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBarraMarcas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBarraMarcas.Legends.Add(legend1);
            this.chartBarraMarcas.Location = new System.Drawing.Point(463, 21);
            this.chartBarraMarcas.Name = "chartBarraMarcas";
            this.chartBarraMarcas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBarraMarcas.Series.Add(series1);
            this.chartBarraMarcas.Size = new System.Drawing.Size(433, 193);
            this.chartBarraMarcas.TabIndex = 1;
            this.chartBarraMarcas.Text = "chart2";
            // 
            // chartTop5Ventas
            // 
            this.chartTop5Ventas.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartTop5Ventas.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartTop5Ventas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTop5Ventas.Legends.Add(legend2);
            this.chartTop5Ventas.Location = new System.Drawing.Point(0, 74);
            this.chartTop5Ventas.Name = "chartTop5Ventas";
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.BackImageTransparentColor = System.Drawing.Color.White;
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderColor = System.Drawing.Color.White;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = System.Drawing.Color.White;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.SmartLabelStyle.Enabled = false;
            series2.YValuesPerPoint = 2;
            this.chartTop5Ventas.Series.Add(series2);
            this.chartTop5Ventas.Size = new System.Drawing.Size(474, 316);
            this.chartTop5Ventas.TabIndex = 0;
            this.chartTop5Ventas.Text = "chart1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(25, 50);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(176, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Productos más vendidos";
            // 
            // chartBarraCategorias
            // 
            chartArea3.Name = "ChartArea1";
            this.chartBarraCategorias.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartBarraCategorias.Legends.Add(legend3);
            this.chartBarraCategorias.Location = new System.Drawing.Point(463, 229);
            this.chartBarraCategorias.Name = "chartBarraCategorias";
            this.chartBarraCategorias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartBarraCategorias.Series.Add(series3);
            this.chartBarraCategorias.Size = new System.Drawing.Size(433, 193);
            this.chartBarraCategorias.TabIndex = 4;
            this.chartBarraCategorias.Text = "chart2";
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.White;
            this.panelFondo.Controls.Add(this.chartBarraCategorias);
            this.panelFondo.Controls.Add(this.lblTicketPromedio);
            this.panelFondo.Controls.Add(this.materialLabel1);
            this.panelFondo.Controls.Add(this.chartTop5Ventas);
            this.panelFondo.Controls.Add(this.chartBarraMarcas);
            this.panelFondo.Location = new System.Drawing.Point(-5, 61);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(935, 499);
            this.panelFondo.TabIndex = 4;
            // 
            // FrmVentas
            // 
            this.ClientSize = new System.Drawing.Size(918, 498);
            this.Controls.Add(this.panelFondo);
            this.MaximumSize = new System.Drawing.Size(918, 498);
            this.MinimumSize = new System.Drawing.Size(918, 498);
            this.Name = "FrmVentas";
            this.Sizable = false;
            this.Text = "Estadísticas de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.chartBarraMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarraCategorias)).EndInit();
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private MaterialSkin.Controls.MaterialLabel lblTicketPromedio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarraMarcas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5Ventas;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarraCategorias;
        private System.Windows.Forms.Panel panelFondo;
    }
}