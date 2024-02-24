namespace Presentacion
{
    partial class FrmAltaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.pbxImagenAlta = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUrlImagen = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecio = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxMarca = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.txtStock = new MaterialSkin.Controls.MaterialTextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnSeleccionarImagen = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(38, 93);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 179);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(325, 371);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(22, 371);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(40, 222);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Location = new System.Drawing.Point(17, 315);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(61, 13);
            this.lblImagenUrl.TabIndex = 6;
            this.lblImagenUrl.Text = "Url Imagen:";
            // 
            // pbxImagenAlta
            // 
            this.pbxImagenAlta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbxImagenAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxImagenAlta.Location = new System.Drawing.Point(375, 87);
            this.pbxImagenAlta.Name = "pbxImagenAlta";
            this.pbxImagenAlta.Size = new System.Drawing.Size(214, 252);
            this.pbxImagenAlta.TabIndex = 17;
            this.pbxImagenAlta.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(107, 87);
            this.txtCodigo.MaximumSize = new System.Drawing.Size(250, 25);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MinimumSize = new System.Drawing.Size(250, 25);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(250, 25);
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.UseTallSize = false;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(107, 130);
            this.txtNombre.MaximumSize = new System.Drawing.Size(250, 25);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MinimumSize = new System.Drawing.Size(250, 25);
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 25);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseTallSize = false;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.AnimateReadOnly = false;
            this.txtUrlImagen.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUrlImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrlImagen.Depth = 0;
            this.txtUrlImagen.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrlImagen.LeadingIcon = null;
            this.txtUrlImagen.Location = new System.Drawing.Point(107, 314);
            this.txtUrlImagen.MaximumSize = new System.Drawing.Size(150, 25);
            this.txtUrlImagen.MaxLength = 50;
            this.txtUrlImagen.MinimumSize = new System.Drawing.Size(150, 25);
            this.txtUrlImagen.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUrlImagen.Multiline = false;
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(150, 25);
            this.txtUrlImagen.TabIndex = 20;
            this.txtUrlImagen.Text = "";
            this.txtUrlImagen.TrailingIcon = null;
            this.txtUrlImagen.UseTallSize = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AnimateReadOnly = false;
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcion.LeadingIcon = null;
            this.txtDescripcion.Location = new System.Drawing.Point(107, 175);
            this.txtDescripcion.MaximumSize = new System.Drawing.Size(250, 25);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(250, 25);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(250, 25);
            this.txtDescripcion.TabIndex = 21;
            this.txtDescripcion.Text = "";
            this.txtDescripcion.TrailingIcon = null;
            this.txtDescripcion.UseTallSize = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AnimateReadOnly = false;
            this.txtPrecio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.LeadingIcon = null;
            this.txtPrecio.Location = new System.Drawing.Point(107, 220);
            this.txtPrecio.MaximumSize = new System.Drawing.Size(250, 25);
            this.txtPrecio.MaxLength = 50;
            this.txtPrecio.MinimumSize = new System.Drawing.Size(250, 25);
            this.txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(250, 25);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.Text = "";
            this.txtPrecio.TrailingIcon = null;
            this.txtPrecio.UseTallSize = false;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.AutoResize = false;
            this.cbxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCategoria.Depth = 0;
            this.cbxCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxCategoria.DropDownHeight = 118;
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.DropDownWidth = 121;
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.IntegralHeight = false;
            this.cbxCategoria.ItemHeight = 29;
            this.cbxCategoria.Location = new System.Drawing.Point(109, 360);
            this.cbxCategoria.MaxDropDownItems = 4;
            this.cbxCategoria.MinimumSize = new System.Drawing.Size(180, 0);
            this.cbxCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(198, 35);
            this.cbxCategoria.StartIndex = 0;
            this.cbxCategoria.TabIndex = 24;
            this.cbxCategoria.UseAccent = false;
            this.cbxCategoria.UseTallSize = false;
            // 
            // cbxMarca
            // 
            this.cbxMarca.AutoResize = false;
            this.cbxMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxMarca.Depth = 0;
            this.cbxMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxMarca.DropDownHeight = 118;
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.DropDownWidth = 121;
            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.IntegralHeight = false;
            this.cbxMarca.ItemHeight = 29;
            this.cbxMarca.Location = new System.Drawing.Point(379, 361);
            this.cbxMarca.MaxDropDownItems = 4;
            this.cbxMarca.MinimumSize = new System.Drawing.Size(180, 0);
            this.cbxMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(198, 35);
            this.cbxMarca.StartIndex = 0;
            this.cbxMarca.TabIndex = 25;
            this.cbxMarca.UseAccent = false;
            this.cbxMarca.UseTallSize = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = false;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(337, 418);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(110, 39);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(463, 418);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(110, 39);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // txtStock
            // 
            this.txtStock.AnimateReadOnly = false;
            this.txtStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Depth = 0;
            this.txtStock.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStock.LeadingIcon = null;
            this.txtStock.Location = new System.Drawing.Point(107, 267);
            this.txtStock.MaximumSize = new System.Drawing.Size(250, 25);
            this.txtStock.MaxLength = 50;
            this.txtStock.MinimumSize = new System.Drawing.Size(250, 25);
            this.txtStock.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStock.Multiline = false;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(250, 25);
            this.txtStock.TabIndex = 29;
            this.txtStock.Text = "";
            this.txtStock.TrailingIcon = null;
            this.txtStock.UseTallSize = false;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(40, 269);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 28;
            this.lblStock.Text = "Stock:";
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.AutoSize = false;
            this.btnSeleccionarImagen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeleccionarImagen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSeleccionarImagen.Depth = 0;
            this.btnSeleccionarImagen.HighEmphasis = true;
            this.btnSeleccionarImagen.Icon = null;
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(264, 314);
            this.btnSeleccionarImagen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSeleccionarImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(93, 25);
            this.btnSeleccionarImagen.TabIndex = 30;
            this.btnSeleccionarImagen.Text = "agregar";
            this.btnSeleccionarImagen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSeleccionarImagen.UseAccentColor = false;
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click_1);
            // 
            // FrmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 507);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pbxImagenAlta);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmAltaProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.FrmAltaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.PictureBox pbxImagenAlta;
        public MaterialSkin.Controls.MaterialTextBox txtCodigo;
        public MaterialSkin.Controls.MaterialTextBox txtNombre;
        public MaterialSkin.Controls.MaterialTextBox txtUrlImagen;
        public MaterialSkin.Controls.MaterialTextBox txtDescripcion;
        public MaterialSkin.Controls.MaterialTextBox txtPrecio;
        public MaterialSkin.Controls.MaterialComboBox cbxCategoria;
        public MaterialSkin.Controls.MaterialComboBox cbxMarca;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        public MaterialSkin.Controls.MaterialTextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private MaterialSkin.Controls.MaterialButton btnSeleccionarImagen;
    }
}