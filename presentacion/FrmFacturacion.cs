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

namespace Presentacion
{
    public partial class FrmFacturacion : MaterialForm
    {
        private int color;
        List<decimal> facturacion = new List<decimal>();

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

        public FrmFacturacion(int color, List<decimal> facturacion)
        {
            this.facturacion = facturacion;
            this.color = color;
            InitializeComponent();
            establecerModo();
            if (facturacion != null)
            {
                cargarDatos();
            }

        }


        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            
                this.FormBorderStyle = FormBorderStyle.None;
                this.ForeColor = Color.FromArgb(19, 19, 19);
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
               
        }

        private void establecerModo()
        {

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            dgvFacturacion.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dgvFacturacion.Width,dgvFacturacion.Height, 5, 5));

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
            else if (color == 5)
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Purple400, Primary.Purple400,
                Primary.Grey100, Accent.LightBlue200, TextShade.WHITE);

            }

        }

        private void cargarDatos() {

            dgvFacturacion.ColumnCount = 2;

            dgvFacturacion.Columns[0].HeaderText = "   N° de Ventas";
            dgvFacturacion.Columns[1].HeaderText = "Valor Ticket";

            int numeroTicket = 1;
            decimal totalVenta = 0;

            foreach (decimal monto in facturacion)
            {
                dgvFacturacion.Rows.Add(numeroTicket, monto);
                numeroTicket++;
                totalVenta += monto;
            }
            totalVenta = Math.Round((decimal)totalVenta, 2);
            lblTotal.Text = "Facturación total: $" + totalVenta.ToString()+".-";
        }

    }
}
