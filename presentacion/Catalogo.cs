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
        public Catalogo()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue900, Primary.Blue900,
            Primary.BlueGrey800, Accent.LightBlue200, TextShade.WHITE);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            
        }

        private void cargar()
        {
            ProductoNegocio negocio = new ProductoNegocio();

            try
            {
                listaProductos = negocio.listaProductos();
                dgvProductos.DataSource = listaProductos;
                dgvProductos.Columns["imagenUrl"].Visible = false;
                dgvProductos.Columns["Id"].Visible = false;
                dgvProductos.Columns["Descripcion"].Visible = false;
                dgvProductos.ClearSelection();
                cargaImagen(listaProductos[0].ImagenUrl);
                txtDescripcion.Text = (string)listaProductos[0].Nombre + ": \n" + (string)listaProductos[0].Descripcion;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            cargar();
            cargarCampos();
            txtPrecioMin.BackColor = Color.LightSteelBlue;
            txtPrecioMax.BackColor = Color.LightSteelBlue;
            txtBusqueda.BackColor = Color.LightSteelBlue;
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

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaProducto alta = new FrmAltaProducto();
            alta.ShowDialog();
            cargar();
        }

        private void cargarCampos()
        {
            MarcaNegocio mn = new MarcaNegocio();
            CategoriaNegocio cn = new CategoriaNegocio();

            List<Marca> listaMarcas = mn.listaMarcas();
            List<Categoria> listaCategoria = cn.listaCategorias();
            

            foreach (var marca in listaMarcas) {
                cbxMarca.Items.Add(marca.Descripcion);

            }
            foreach (var categoria in listaCategoria)
            {
                cbxCategorias.Items.Add(categoria.Descripcion);

            }

        }

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
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaFiltrada;
            dgvProductos.Columns["imagenUrl"].Visible = false;
            dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.Columns["Descripcion"].Visible = false;
        }

    private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try

            {
                Producto seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                FrmAltaProducto alta = new FrmAltaProducto(seleccionado);
                alta.ShowDialog();
                cargar();
            }

            catch (Exception)
            {

                MessageBox.Show("Por favor seleccione de la grilla el artículo para modificar.");

            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            try
            {
                Producto seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("En caso que presione 'SI' el producto seleccionado será eliminado permanentemente. \n¿Desea eliminar el Producto seleccionado?", "¡Precaución!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor seleccione de la grilla el artículo que desea eliminar.");
                cargar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
                dgvProductos.DataSource = listaProductos;
            }
            else
                MessageBox.Show("El precio mínimo no debe superar al precio máximo de búsqueda.");
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbxCategorias.SelectedIndex = -1;
            cbxMarca.SelectedIndex = -1;
            txtBusqueda.Clear();
            txtPrecioMin.Clear();
            txtPrecioMax.Clear();
            cargar();
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

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionGrilla();
        }

        private void seleccionGrilla()
        {
            Producto seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            cargaImagen(seleccionado.ImagenUrl);
            string NombreDescripcion = (string)seleccionado.Nombre + ": " +(string)seleccionado.Descripcion;
            txtDescripcion.Text = NombreDescripcion;
        }

    }

}

