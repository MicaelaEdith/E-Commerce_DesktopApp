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

namespace Presentacion
{
    public partial class FrmAltaProducto : Form
    {
        private Producto producto = null;

        public FrmAltaProducto()
        {
            InitializeComponent();
        }

        public FrmAltaProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            Text = "Modificar producto";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarAlta()
        {

            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == ""|| txtPrecio.Text == "")
            {
                MessageBox.Show("Por favor complete todas las características del producto.");
                return false;
            }
            if (cbxCategoria.SelectedIndex < 0 || cbxMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione categoria y marca.");
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
                        
            try
            {
                if (!validarAlta())
                    return;
               
                if (producto == null)
                    producto = new Producto();

                    producto.Codigo = txtCodigo.Text;
                    producto.Nombre = txtNombre.Text;
                    producto.Descripcion = txtDescripcion.Text;
                    producto.Marca = (Marca)cbxMarca.SelectedItem;
                    producto.Categoria = (Categoria)cbxCategoria.SelectedItem;
                    producto.Precio = decimal.Parse(txtPrecio.Text);
                    producto.ImagenUrl = txtUrlImagen.Text;


                if (producto.Id != 0)
                {
                    negocio.modificar(producto);
                    MessageBox.Show("El producto fue modificado exitosamente.");
                    Close();
                }
                else
                {
                    negocio.agregar(producto);
                    MessageBox.Show("El producto fue agregado exitosamente.");
                    Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor complete todos los campos.");
            }

        }

        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cbxCategoria.DataSource = categoriaNegocio.listaCategorias();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.DataSource = marcaNegocio.listaMarcas();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.SelectedIndex = -1;
                cbxMarca.SelectedIndex = -1;

                if(producto!=null)
                {
                    txtCodigo.Text = producto.Codigo;
                    txtNombre.Text = producto.Nombre;
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecio.Text = producto.Precio.ToString();
                    txtUrlImagen.Text = producto.ImagenUrl;
                    cbxCategoria.SelectedValue = producto.Categoria.Id;
                    cbxMarca.SelectedValue = producto.Marca.Id;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            if (!negocio.validarPrecio(txtPrecio.ToString()))
                txtPrecio.Clear();

        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenAlta.Load(imagen);
            }
            catch (Exception ex)
            {

               pbxImagenAlta.Load("https://plantillasdememes.com/img/plantillas/imagen-no-disponible01601774755.jpg");
            }

        }

    }
}
