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
using Negocio;

namespace Presentacion
{
    public partial class FrmVentas : MaterialForm
    {
        

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

        public FrmVentas()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.LightBlue900, Primary.LightBlue900,
            Primary.Grey100, Accent.LightBlue200, TextShade.WHITE);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            cargarDatos();

        }

        private void cargarDatos()
        {

            TicketNegocio tn = new TicketNegocio();
            ProductoNegocio pn = new ProductoNegocio();
            List<Producto> listTop5 = pn.top5();
            lblTicketPromedio.Text = "Ticket promedio:  $" + tn.obtenerPromedio().ToString() + ".-";
            foreach (var producto in listTop5)
            {
                chartTop5Ventas.Series[0].Points.AddXY(producto.Nombre, producto.CantidadVentas);

            }

            foreach (var point in chartTop5Ventas.Series[0].Points)
            {
                point["PieLabelStyle"] = "Disabled";
            }
        }
    }
}
