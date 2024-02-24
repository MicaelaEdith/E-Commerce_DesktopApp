using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class FrmVentas : MaterialForm
    {

        int color;
        Helper h = new Helper();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public FrmVentas(int color)
        {
            this.color = color;
            InitializeComponent();
            cargarDatosCircular();
            cargarDatosBarraMarcas();
            cargarDatosBarraCategorias();
            establecerModo();


        }

        private void cargarDatosCircular()
        {
            TicketNegocio tn = new TicketNegocio();
            ProductoNegocio pn = new ProductoNegocio();
            List<Producto> listTop5 = pn.top5();
            lblTicketPromedio.Visible = true;
            lblTicketPromedio.BringToFront();
            lblTicketPromedio.Text = "Ticket promedio:  $" + tn.obtenerPromedio().ToString() + ".-";

            chartTop5Ventas.Series[0].Points.Clear();

            foreach (var producto in listTop5)
            {

                chartTop5Ventas.Series[0].Points.AddXY(producto.Nombre, producto.CantidadVentas);

                DataPoint dataPoint = chartTop5Ventas.Series[0].Points.Last();

                dataPoint.Label = $"{producto.Nombre}: {producto.CantidadVentas} ventas";
            }

            foreach (var point in chartTop5Ventas.Series[0].Points)
            {
                point["PieLabelStyle"] = "Disabled";
            }

        }

        private void cargarDatosBarraMarcas()
        {
            Dictionary<string, decimal> porcentajes = h.ObtenerPorcentajeVentasPorMarca();

            chartBarraMarcas.Series.Clear();
            chartBarraMarcas.Legends.Clear();

            Series serieVentas = new Series("Porcentaje de Ventas");
            serieVentas.ChartType = SeriesChartType.Column;

            foreach (var kvp in porcentajes)
            {
                string nombreGrupo = kvp.Key;
                decimal porcentaje = kvp.Value;

                DataPoint punto = new DataPoint();
                punto.AxisLabel = nombreGrupo;
                punto.YValues = new double[] { (double)porcentaje };
                serieVentas.Points.Add(punto);
            }

            chartBarraMarcas.Series.Add(serieVentas);

            chartBarraMarcas.ChartAreas[0].AxisX.Interval = 1;
            chartBarraMarcas.ChartAreas[0].AxisX.Title = "Grupos";
            chartBarraMarcas.ChartAreas[0].AxisY.Title = "Porcentaje de Ventas";
        }

        private void cargarDatosBarraCategorias()
        {
            Dictionary<string, decimal> porcentajes = h.ObtenerPorcentajeVentasPorCategoria();

            chartBarraCategorias.Series.Clear();
            chartBarraCategorias.Legends.Clear();

            Series serieVentas = new Series("Porcentaje de Ventas");
            serieVentas.ChartType = SeriesChartType.Column;

            foreach (var kvp in porcentajes)
            {
                string nombreGrupo = kvp.Key;
                decimal porcentaje = kvp.Value;

                DataPoint punto = new DataPoint();
                punto.AxisLabel = nombreGrupo;
                punto.YValues = new double[] { (double)porcentaje };
                serieVentas.Points.Add(punto);
            }

            chartBarraCategorias.Series.Add(serieVentas);

            chartBarraCategorias.ChartAreas[0].AxisX.Interval = 1;
            chartBarraCategorias.ChartAreas[0].AxisX.Title = "Grupos";
            chartBarraCategorias.ChartAreas[0].AxisY.Title = "Porcentaje de Ventas";
        }

        public void establecerModo()
        {

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            panelFondo.BackColor = Color.White;
            chartTop5Ventas.BackColor = Color.FromArgb(255, 255, 255);

            if (color == 0)
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightBlue900, Primary.LightBlue900,
                Primary.Grey100, Accent.LightBlue200, TextShade.WHITE);
            }
            else if (color == 1)
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green400,
                Primary.Grey100, Accent.LightBlue200, TextShade.WHITE);
            }
            else if (color == 2)
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink400, Primary.Pink400,
                Primary.Grey100, Accent.LightBlue200, TextShade.WHITE);
            }
            else if (color == 3)
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Amber600, Primary.Amber600,
                Primary.Grey100, Accent.LightBlue200, TextShade.WHITE);
            }
            else if (color == 4)
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey800,
                Primary.Grey100, Accent.LightBlue200, TextShade.WHITE);
            }

        }

    }
}
