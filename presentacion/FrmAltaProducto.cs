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
    public partial class FrmAltaProducto : MaterialForm
    {
        private Producto producto = null;
        private int color;

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
        #region Constructores y Load
        public FrmAltaProducto(int color)
        {
            this.color = color;
            InitializeComponent();
            establecerModo();
        }

        public FrmAltaProducto(Producto producto, int color)
        {
            this.color = color;
            InitializeComponent();
            this.producto = producto;
            Text = "Modificar producto";

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
                this.FormBorderStyle = FormBorderStyle.None;
                this.ForeColor = Color.FromArgb(19, 19, 19);
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
                txtCodigo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCodigo.Width, txtCodigo.Height, 5, 5));
                txtNombre.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCodigo.Width, txtCodigo.Height, 5, 5));
                txtDescripcion.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCodigo.Width, txtCodigo.Height, 5, 5));
                txtPrecio.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCodigo.Width, txtCodigo.Height, 5, 5));
                txtStock.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtStock.Width, txtStock.Height, 5, 5));
                txtUrlImagen.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCodigo.Width, txtCodigo.Height, 5, 5));
                cbxCategoria.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxCategoria.Width, cbxCategoria.Height, 5, 5));
                cbxMarca.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbxMarca.Width, cbxMarca.Height, 5, 5));
            

                if (producto!=null)
                {
                    txtCodigo.Text = producto.Codigo;
                    txtNombre.Text = producto.Nombre;
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecio.Text = producto.Precio.ToString();
                    txtStock.Text = producto.Stock.ToString();
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

        #endregion


        #region Validaciones

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            if (!negocio.validarPrecio(txtPrecio.ToString()))
                txtPrecio.Clear();

        }       
        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            if (!negocio.validarPrecio(txtStock.ToString()))
                txtPrecio.Clear();

        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        
        private bool validarAlta()
        {

            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == ""|| txtPrecio.Text == ""||txtStock.Text=="")
            {
                MessageBox.Show("Por favor complete todas las características del producto.");
                return false;
            }
            if (cbxCategoria.SelectedIndex < 0 || cbxMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione categoria y marca.");
                return false;
            }
            if (decimal.Parse(txtPrecio.Text) < 0 || int.Parse(txtStock.Text) < 0) {
                MessageBox.Show("No puede ingresar números menores a 0.");
                return false;

            }

            return true;
        }

        #endregion


        #region Acciones
        private void btnAceptar_Click_1(object sender, EventArgs e)
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
                producto.Stock = int.Parse(txtStock.Text);


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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        public void establecerModo()
        {

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
          

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

        #endregion

        private void btnSeleccionarImagen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            openFileDialog.Title = "Seleccionar imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagenSeleccionada = openFileDialog.FileName;
                string nombreArchivo = Path.GetFileName(rutaImagenSeleccionada);
                string carpetaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes");
                string nuevaRuta = Path.Combine(carpetaImagenes, nombreArchivo);

                try
                {
                    // Verificar si la carpeta "imagenes" existe, si no, crearla.
                    if (!Directory.Exists(carpetaImagenes))
                    {
                        Directory.CreateDirectory(carpetaImagenes);
                    }

                    File.Copy(rutaImagenSeleccionada, nuevaRuta, true);

                    txtUrlImagen.Text = nuevaRuta;

                    cargarImagen(nuevaRuta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al copiar la imagen: " + ex.Message);
                }
            }
        }

    }
}
