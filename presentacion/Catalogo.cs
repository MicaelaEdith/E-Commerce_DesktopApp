using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Negocio;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class Catalogo : MaterialForm
    {

        private List<Producto> listaProductos;
        private List<Producto> listaCarrito = new List<Producto>();
        private List<decimal> listaTickets = new List<decimal>();
        private decimal precioFinal;
        private bool addCategoria = false;
        private bool addMarca = false;
        private bool confirmarVenta = false;
        private bool cerrandoCaja = false;


        Helper helper = new Helper();
        private int color;  //0 azul, 1 verde, 2 rosa, 3 amarillo, 4 negro, 5 violeta;
       

        Producto seleccionado;


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

        #region Constructos y carga de componentes

        public Catalogo()
        {
            this.FormClosing += Catalogo_FormClosing;
            color =helper.seleccionarColor();
            InitializeComponent();
            establecerModo();

        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            cargar();
            cargarCampos();
            establecerColor();
        }


        private void cargar()
        {
            ProductoNegocio negocio = new ProductoNegocio();

            try
            {
                listaProductos = negocio.listaProductos();
                if (listaProductos.Count > 0)
                {
                    btnAgregarMarca.DataSource = listaProductos;
                    btnAgregarMarca.Columns["imagenUrl"].Visible = false;
                    btnAgregarMarca.Columns["Id"].Visible = false;
                    btnAgregarMarca.Columns["Descripcion"].Visible = false;
                    btnAgregarMarca.Columns["CantidadVentas"].Visible = false;
                    btnAgregarMarca.Columns["CantidadEnticket"].Visible = false;
                    btnAgregarMarca.ClearSelection();
                    cargaImagen(listaProductos[0].ImagenUrl);
                }

                }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargaImagen(string imagen)
        {

            try
            {
                pbxImagen.Load(imagen);

            }
            catch (Exception ex)
            {
                pbxImagen.Image = null;
            }

        }

        private void cargarCampos()
        {
            MarcaNegocio mn = new MarcaNegocio();
            CategoriaNegocio cn = new CategoriaNegocio();

            List<Marca> listaMarcas = mn.listaMarcas();
            List<Categoria> listaCategoria = cn.listaCategorias();


            foreach (var marca in listaMarcas)
            {
                cbxMarca.Items.Add(marca.Descripcion);

            }
            foreach (var categoria in listaCategoria)
            {
                cbxCategorias.Items.Add(categoria.Descripcion);

            }

        }

        private void establecerModo() {

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            txtPrecioMin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPrecioMin.Width, txtPrecioMin.Height, 5, 5));
            txtPrecioMax.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPrecioMax.Width, txtPrecioMax.Height, 5, 5));
            txtBusqueda.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtBusqueda.Width, txtBusqueda.Height, 5, 5));
            btnAgregarMarca.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAgregarMarca.Width, btnAgregarMarca.Height, 5, 5));
            txtCarrito.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCarrito.Width, txtCarrito.Height, 5, 5));
            cbxCategorias.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxCategorias.Width, cbxCategorias.Height, 5, 5));
            cbxMarca.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxMarca.Width, cbxMarca.Height, 5, 5));
            btnAgregarMarca.ForeColor = Color.FromArgb(20, 20, 20);
            panelEliminar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelEliminar.Width, panelEliminar.Height, 5, 5));
            pnlMarcaNueva1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlMarcaNueva1.Width, pnlMarcaNueva1.Height, 5, 5));
            pnlMarcaNueva2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlMarcaNueva2.Width, pnlMarcaNueva2.Height, 5, 5));
            txtNuevaMarca.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtNuevaMarca.Width, txtNuevaMarca.Height, 5, 5));

            panelFondo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelFondo.Width, panelFondo.Height, 5, 5));
            panelEliminar.Visible = false;
            panelFondo.Visible = false;
            lblSeEliminará.Visible = false;
            lblProductoEliminar.Visible = false;
            pnlMarcaNueva1.Visible = false;
            pnlMarcaNueva2.Visible = false;
            lblIngreseMarca.Visible = false;
            txtNuevaMarca.Visible = false;

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
            else if(color == 5)
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Purple400, Primary.Purple400,
                Primary.Grey100, Accent.LightBlue200, TextShade.WHITE);

            }
        }
        private void establecerColor()
        {
            txtPrecioMin.BackColor = Color.LightGray;
            txtPrecioMax.BackColor = Color.LightGray;
            txtBusqueda.BackColor = Color.LightGray;
            menuStrip1.BackColor = Color.LightGray;
            panelEliminar.BackColor = Color.White;
            panelFondo.BackColor = Color.IndianRed;
            pnlMarcaNueva1.BackColor = Color.Gray;

        }


        #endregion

        #region Busqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaFiltrada;
            string filtro = txtBusqueda.Text;

            if (filtro != "")
            {
                listaFiltrada = listaProductos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaProductos;
            }
            btnAgregarMarca.DataSource = null;
            btnAgregarMarca.DataSource = listaFiltrada;
            btnAgregarMarca.Columns["imagenUrl"].Visible = false;
            btnAgregarMarca.Columns["Id"].Visible = false;
            btnAgregarMarca.Columns["Descripcion"].Visible = false;
        }

        private void txtPrecioMin_TextChanged(object sender, EventArgs e)

        {
            ProductoNegocio negocio = new ProductoNegocio();
            if (!negocio.validarPrecio(txtPrecioMin.ToString()))
                txtPrecioMin.Clear();
        }

        private void txtPrecioMax_TextChanged(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            if (!negocio.validarPrecio(txtPrecioMax.ToString()))
                txtPrecioMax.Clear();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            string categoria, marca;
            string minimo = txtPrecioMin.Text;
            string maximo = txtPrecioMax.Text;

            if (cbxCategorias.SelectedIndex != -1)
                categoria = cbxCategorias.SelectedItem.ToString();
            else categoria = "";

            if (cbxMarca.SelectedIndex != -1)
                marca = cbxMarca.SelectedItem.ToString();
            else marca = "";

            if (negocio.validarBusqueda(minimo, maximo))
            {
                listaProductos = negocio.buscar(minimo, maximo, categoria, marca);
                btnAgregarMarca.DataSource = listaProductos;
            }
            else
                MessageBox.Show("El precio mínimo no debe superar al precio máximo de búsqueda.");
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            cbxCategorias.SelectedIndex = -1;
            cbxMarca.SelectedIndex = -1;
            txtBusqueda.Clear();
            txtPrecioMin.Clear();
            txtPrecioMax.Clear();
            cargar();

        }


        #endregion

        #region Menu ToolStrip - Paneles (marca - categoria - confirmar venta)
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaProducto alta = new FrmAltaProducto(color);
            establecerColor();
            alta.ShowDialog();
            cargar();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnAgregarMarca.SelectedRows.Count > 0)
            {

                try

                {
                    Producto seleccionado = (Producto)btnAgregarMarca.CurrentRow.DataBoundItem;
                    establecerColor();
                    FrmAltaProducto alta = new FrmAltaProducto(seleccionado, color);
                    alta.ShowDialog();
                    cargar();
                }

                catch (Exception)
                {

                    MessageBox.Show("Por favor seleccione de la grilla el artículo para modificar.");

                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnAgregarMarca.SelectedRows.Count > 0)
            {

                establecerColor();
                Producto seleccionado = (Producto)btnAgregarMarca.CurrentRow.DataBoundItem;
                panelEliminar.Visible = true;
                panelFondo.Visible = true;
                lblSeEliminará.Visible = true;
                lblProductoEliminar.Text = seleccionado.Nombre;
                lblProductoEliminar.Visible = true;
                panelFondo.BringToFront();

            }
        }

        private void btnAceptarEliminar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            negocio.eliminar(seleccionado.Id);
            panelEliminar.Visible = false;
            panelFondo.Visible = false;
            lblSeEliminará.Visible = false;
            lblProductoEliminar.Visible = false;
            lblProductoEliminar.Text = "";
            cargar();
        }

        private void btnCancelarEliminar_Click(object sender, EventArgs e)
        {
            panelEliminar.Visible = false;
            panelFondo.Visible = false;
            lblSeEliminará.Visible = false;
            lblProductoEliminar.Visible = false;
            lblProductoEliminar.Text = "";
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e) //Agregar Marca
        {
            addMarca = true;
            addCategoria = false;
            pnlMarcaNueva1.Visible = true;
            pnlMarcaNueva2.Visible = true;
            lblIngreseMarca.Visible = true;
            txtNuevaMarca.Visible = true;
            lblIngreseMarca.Text = "  Ingrese nombre de la marca";
            pnlMarcaNueva1.BringToFront();

        }

        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            pnlMarcaNueva1.Visible = false;
            pnlMarcaNueva2.Visible = false;
            lblIngreseMarca.Visible = false;
            txtNuevaMarca.Visible = false;
            addMarca = false;
            addCategoria = false;
            confirmarVenta = false;
            txtNuevaMarca.Text = "";
        }

        private void btnAgregarM_Click(object sender, EventArgs e) //agregar Marca - Categoria - ConfirmarVenta
        {
            string valor = txtNuevaMarca.Text;
            if (addMarca)
            {
                MarcaNegocio mn = new MarcaNegocio();
                mn.agregar(valor);
                txtNuevaMarca.Text = "";
            }
            if (addCategoria)
            {
                CategoriaNegocio cn = new CategoriaNegocio();
                cn.agregar(valor);
                txtNuevaMarca.Text = "";
            }
            if (confirmarVenta)
            {
                ProductoNegocio pn = new ProductoNegocio();
                TicketNegocio tn = new TicketNegocio();

                tn.facturar(precioFinal);
                listaTickets.Add(precioFinal);

                foreach (var producto in listaCarrito)
                {

                    pn.agregarVenta(producto);
                    producto.ToString();
                }

                listaCarrito.Clear();
                precioFinal = 0;
                txtCarrito.Text = "";
                lblPrecioFinal.Visible = false;
                btnAgregarMarca.ClearSelection();
                txtNuevaMarca.Text = "";
                
            }
            pnlMarcaNueva1.Visible = false;
            pnlMarcaNueva2.Visible = false;
            lblIngreseMarca.Visible = false;
            txtNuevaMarca.Visible = false;
            addMarca = false;
            addCategoria = false;
            confirmarVenta = false;
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)//Agregar Categoria
        {
            addCategoria = true;
            addMarca = false;
            pnlMarcaNueva1.Visible = true;
            pnlMarcaNueva2.Visible = true;
            lblIngreseMarca.Visible = true;
            txtNuevaMarca.Visible = true;
            lblIngreseMarca.Text = "Ingrese nombre de la Categoria";
            pnlMarcaNueva1.BringToFront();
        }

        private void estadísticasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            decimal totalActual = 0;
            
            foreach (var monto in listaTickets) {

                totalActual += monto;
            
            }
            FrmVentas ventas = new FrmVentas(color, totalActual, listaTickets.Count);
            establecerColor();
            ventas.ShowDialog();
            cargar();
        }

        private void cerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarCaja();
            cerrandoCaja = true;
        }

        private void verFacturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listaTickets);
            FrmFacturacion alta = new FrmFacturacion(color, listaTickets);
            establecerColor();
            alta.ShowDialog();
            cargar();
        }

        #endregion

        #region Selección de productos & Carrito

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGrilla();
        }

        private void seleccionGrilla()
        {
            seleccionado = (Producto)btnAgregarMarca.CurrentRow.DataBoundItem;
            cargaImagen(seleccionado.ImagenUrl);
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (seleccionado != null && (seleccionado.Stock-seleccionado.CantidadEnticket>0))
            {
                Producto productoEnCarrito = listaCarrito.Find(p => p.Id == seleccionado.Id);

                if (productoEnCarrito != null)
                {
                    productoEnCarrito.CantidadEnticket++;

                }
                else
                {
                    seleccionado.CantidadEnticket = 1;
                    listaCarrito.Add(seleccionado);

                }
                txtCarrito.Text += seleccionado.Nombre + " - $" + seleccionado.Precio + "\n";
                precioFinal += seleccionado.Precio;
                lblPrecioFinal.Text = "Precio Final: $" + Math.Round(precioFinal, 2).ToString();
                lblPrecioFinal.Visible = true;

            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            txtCarrito.Text = "";
            lblPrecioFinal.Visible = false;
            precioFinal = 0;
            listaCarrito.Clear();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (listaCarrito.Count > 0)
            {

                confirmarVenta = true;
                addMarca = false;
                addCategoria = false;
                pnlMarcaNueva1.Visible = true;
                pnlMarcaNueva2.Visible = true;
                lblIngreseMarca.Visible = true;
                lblIngreseMarca.Text = "   ¿Desea confirmar la venta?";
                pnlMarcaNueva1.BringToFront();

            }


        }




        #endregion

        #region Cierre de Caja

        

        private void Catalogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!cerrandoCaja)
                {
                    if (listaTickets.Count>0)
                    {
                        cerrarCaja();
                    }
                    cerrandoCaja = true;
                }
            }
        }


        private void cerrarCaja()
        {

            cerrandoCaja = true;
            if (listaTickets.Count > 0)
            {

                TicketNegocio tn = new TicketNegocio();

                decimal totalFacturado = 0;

                foreach (var venta in listaTickets)
                {

                    totalFacturado += venta;
                }

                tn.cierreCaja(totalFacturado, DateTime.Now);

                Console.WriteLine(totalFacturado);
            }

            this.Close();

        }


            #endregion

        #region Modo Color
            private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = 0;
            establecerModo();
            establecerColor();
            Helper hn = new Helper();
            hn.setearColor(color);

        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = 1;
            establecerModo();
            establecerColor();
            Helper hn = new Helper();
            hn.setearColor(color);
        }

        private void rosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = 2;
            establecerModo();
            establecerColor();
            Helper hn = new Helper();
            hn.setearColor(color);

        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = 3;
            establecerModo();
            establecerColor();
            Helper hn = new Helper();
            hn.setearColor(color);

        }


        private void violetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = 5;
            establecerModo();
            establecerColor();
            Helper hn = new Helper();
            hn.setearColor(color);
        }

        private void negroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            color = 4;
            establecerModo();
            establecerColor();
            Helper hn = new Helper();
            hn.setearColor(color);
        }


        #endregion


    }

}