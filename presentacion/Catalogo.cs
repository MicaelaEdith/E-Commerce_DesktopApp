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

namespace Presentacion
{
    public partial class Catalogo : Form
    {

        private List<Producto> listaProductos;

        public Catalogo()
        {
            InitializeComponent();
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
        }

        private void cargaImagen(string imagen)
        {

            try
            {
            pbxImagen.Load(imagen);

            }
            catch (Exception ex)
            {

                //pbxImagen.Load("https://lh3.googleusercontent.com/vCK2TrgcCQ_FC6BjBWxE9dPsl9QN6sZ9qhM57lwxYRWLPaWarAY4pKX1mbhZ0PisOg1VOp2fKTF-UrwGGKP5WDeUUQ89PWEOu9Bnw4n8rVQE9lXJLtUhM4o2q6PRGvelkBk5T29jGe7hCvZtLxMcb6D4rPHp-S_KcUG8suJbS35ViRIdZVl2KsVmu_Ug8PuCdMAfQ8GaE1146jjEu1a2wkl1Wf5pRInnua3w6eIcJWAungweFsv_ZTU3PFeLDbFAFbpY1HfecqqzT_0D-5HfGVA1bzVITXIM-YB5M9CtMaQSkwzloiZKT2CsU447bT5GSRT-L_c2KDI807LVRUU0mDqCgFFky1OAn3npZOrEQmYdf9Is6CQOPT0eXPcV_f_rpxqHk4-2BXShSUaB_1JPaIKXsniEgzsaaMGdJBOEFsqpudyI0Wy4GL-BHMzqSAB9BlAmRPOkF-2lbZSTb-GIiEBYIMFedKlTbDeI8F0Kq9db9kkT8U8XqbS9PxluihQcY4nffc_Bj-sDXxyZrNoxRwDMf1YxwE2JaiFBH35aiT6Y97itHOkPY7-kWWX_MseS4LeQ8WkYLyi3YMpSctaGKbwwAqvh8joCX8-ZflYgNg5uE2Sa5vOxlsw_vZ7fkuwTIoOriXTspiVwW5DE6ZRH5DTC_v_Nh_hqT2h32exu8VwVigfOG66zTbIQf25UURP_gslCQOTcO3l5EIFCe1bTxhGjYSIud4pdujezMgrcpBDLZYPRrqJtr0KFMw=s309-no?authuser=0");
                 pbxImagen.Image = null;
                 lblNoDisponible.Visible = true;
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
            cbxCategoria.Items.Add("Celulares");
            cbxCategoria.Items.Add("Televisores");
            cbxCategoria.Items.Add("Media");
            cbxCategoria.Items.Add("Audio");
            cbxMarca.Items.Add("Samsung");
            cbxMarca.Items.Add("Apple");
            cbxMarca.Items.Add("Sony");
            cbxMarca.Items.Add("Huawei");
            cbxMarca.Items.Add("Motorola");
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaFiltrada;
            string filtro = txtBusqueda.Text;

            if(filtro!= "")
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

            if (cbxCategoria.SelectedIndex != -1)
                 categoria = cbxCategoria.SelectedItem.ToString();
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
            cbxCategoria.SelectedIndex = -1;
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

