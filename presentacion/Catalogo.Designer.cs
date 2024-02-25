namespace Presentacion
{
    partial class Catalogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.label1 = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estiloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amarilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.violetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarMarca = new System.Windows.Forms.DataGridView();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.lblGuion = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.cbxCategorias = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxMarca = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAgregarItem = new MaterialSkin.Controls.MaterialButton();
            this.btnVaciar = new MaterialSkin.Controls.MaterialButton();
            this.btnConfirmarVenta = new MaterialSkin.Controls.MaterialButton();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.txtCarrito = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.panelEliminar = new System.Windows.Forms.Panel();
            this.btnCancelarEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnAceptarEliminar = new MaterialSkin.Controls.MaterialButton();
            this.lblProductoEliminar = new MaterialSkin.Controls.MaterialLabel();
            this.lblSeEliminará = new MaterialSkin.Controls.MaterialLabel();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.pnlMarcaNueva1 = new System.Windows.Forms.Panel();
            this.pnlMarcaNueva2 = new System.Windows.Forms.Panel();
            this.txtNuevaMarca = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelarM = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarM = new MaterialSkin.Controls.MaterialButton();
            this.lblIngreseMarca = new MaterialSkin.Controls.MaterialLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.panelEliminar.SuspendLayout();
            this.panelFondo.SuspendLayout();
            this.pnlMarcaNueva1.SuspendLayout();
            this.pnlMarcaNueva2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Selección de nuevo elemento";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.SlateGray;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniToolStrip.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.miniToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.miniToolStrip.Location = new System.Drawing.Point(77, 6);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.miniToolStrip.Size = new System.Drawing.Size(929, 34);
            this.miniToolStrip.TabIndex = 0;
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(69, 34);
            this.articulosToolStripMenuItem.Text = "Artículos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 12);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.categoriasMenuItem,
            this.marcasMenuItem,
            this.ventasMenuItem,
            this.estiloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(970, 34);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriasMenuItem
            // 
            this.categoriasMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1});
            this.categoriasMenuItem.Name = "categoriasMenuItem";
            this.categoriasMenuItem.Size = new System.Drawing.Size(76, 34);
            this.categoriasMenuItem.Text = "Categorias";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar Categoria";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // marcasMenuItem
            // 
            this.marcasMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2});
            this.marcasMenuItem.Name = "marcasMenuItem";
            this.marcasMenuItem.Size = new System.Drawing.Size(57, 34);
            this.marcasMenuItem.Text = "Marcas";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.agregarToolStripMenuItem2.Text = "Agregar Marca";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // ventasMenuItem
            // 
            this.ventasMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadísticasToolStripMenuItem});
            this.ventasMenuItem.Name = "ventasMenuItem";
            this.ventasMenuItem.Size = new System.Drawing.Size(56, 34);
            this.ventasMenuItem.Text = "Ventas";
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            this.estadísticasToolStripMenuItem.Click += new System.EventHandler(this.estadísticasToolStripMenuItem_Click_1);
            // 
            // estiloToolStripMenuItem
            // 
            this.estiloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azulToolStripMenuItem,
            this.verdeToolStripMenuItem,
            this.rosaToolStripMenuItem,
            this.amarilloToolStripMenuItem,
            this.violetaToolStripMenuItem,
            this.negroToolStripMenuItem});
            this.estiloToolStripMenuItem.Name = "estiloToolStripMenuItem";
            this.estiloToolStripMenuItem.Size = new System.Drawing.Size(48, 34);
            this.estiloToolStripMenuItem.Text = "Estilo";
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.verdeToolStripMenuItem_Click);
            // 
            // rosaToolStripMenuItem
            // 
            this.rosaToolStripMenuItem.Name = "rosaToolStripMenuItem";
            this.rosaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.rosaToolStripMenuItem.Text = "Rosa";
            this.rosaToolStripMenuItem.Click += new System.EventHandler(this.rosaToolStripMenuItem_Click);
            // 
            // amarilloToolStripMenuItem
            // 
            this.amarilloToolStripMenuItem.Name = "amarilloToolStripMenuItem";
            this.amarilloToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.amarilloToolStripMenuItem.Text = "Amarillo";
            this.amarilloToolStripMenuItem.Click += new System.EventHandler(this.amarilloToolStripMenuItem_Click);
            // 
            // violetaToolStripMenuItem
            // 
            this.violetaToolStripMenuItem.Name = "violetaToolStripMenuItem";
            this.violetaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.violetaToolStripMenuItem.Text = "Violeta";
            this.violetaToolStripMenuItem.Click += new System.EventHandler(this.violetaToolStripMenuItem_Click);
            // 
            // negroToolStripMenuItem
            // 
            this.negroToolStripMenuItem.Name = "negroToolStripMenuItem";
            this.negroToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.negroToolStripMenuItem.Text = "Gris";
            this.negroToolStripMenuItem.Click += new System.EventHandler(this.negroToolStripMenuItem_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.AllowUserToAddRows = false;
            this.btnAgregarMarca.AllowUserToDeleteRows = false;
            this.btnAgregarMarca.AllowUserToResizeColumns = false;
            this.btnAgregarMarca.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAgregarMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.btnAgregarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.btnAgregarMarca.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAgregarMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnAgregarMarca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.btnAgregarMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.btnAgregarMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.btnAgregarMarca.ColumnHeadersHeight = 40;
            this.btnAgregarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.btnAgregarMarca.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnAgregarMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.btnAgregarMarca.EnableHeadersVisualStyles = false;
            this.btnAgregarMarca.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarMarca.Location = new System.Drawing.Point(28, 155);
            this.btnAgregarMarca.MultiSelect = false;
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.btnAgregarMarca.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.btnAgregarMarca.RowHeadersVisible = false;
            this.btnAgregarMarca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregarMarca.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.btnAgregarMarca.RowTemplate.Height = 30;
            this.btnAgregarMarca.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnAgregarMarca.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.btnAgregarMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.btnAgregarMarca.Size = new System.Drawing.Size(707, 355);
            this.btnAgregarMarca.StandardTab = true;
            this.btnAgregarMarca.TabIndex = 7;
            this.btnAgregarMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(40, 122);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(335, 122);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(623, 120);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(90, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Rango de Precio:";
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrecioMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioMin.Location = new System.Drawing.Point(751, 112);
            this.txtPrecioMin.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(92, 13);
            this.txtPrecioMin.TabIndex = 3;
            this.txtPrecioMin.TextChanged += new System.EventHandler(this.txtPrecioMin_TextChanged);
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrecioMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioMax.Location = new System.Drawing.Point(857, 112);
            this.txtPrecioMax.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(91, 13);
            this.txtPrecioMax.TabIndex = 4;
            this.txtPrecioMax.TextChanged += new System.EventHandler(this.txtPrecioMax_TextChanged);
            // 
            // lblGuion
            // 
            this.lblGuion.AutoSize = true;
            this.lblGuion.BackColor = System.Drawing.Color.Transparent;
            this.lblGuion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGuion.Location = new System.Drawing.Point(844, 115);
            this.lblGuion.Name = "lblGuion";
            this.lblGuion.Size = new System.Drawing.Size(14, 20);
            this.lblGuion.TabIndex = 11;
            this.lblGuion.Text = "-";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(757, 196);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(194, 177);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 12;
            this.pbxImagen.TabStop = false;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(40, 551);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(90, 13);
            this.lblBusqueda.TabIndex = 14;
            this.lblBusqueda.Text = "Busqueda rápida:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.ForeColor = System.Drawing.Color.Gray;
            this.txtBusqueda.Location = new System.Drawing.Point(161, 541);
            this.txtBusqueda.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(254, 13);
            this.txtBusqueda.TabIndex = 8;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(754, 155);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(95, 29);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = false;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(856, 155);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Size = new System.Drawing.Size(95, 29);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.AutoResize = true;
            this.cbxCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCategorias.Depth = 0;
            this.cbxCategorias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxCategorias.DropDownHeight = 118;
            this.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorias.DropDownWidth = 121;
            this.cbxCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.IntegralHeight = false;
            this.cbxCategorias.ItemHeight = 29;
            this.cbxCategorias.Location = new System.Drawing.Point(116, 111);
            this.cbxCategorias.MaxDropDownItems = 4;
            this.cbxCategorias.MinimumSize = new System.Drawing.Size(180, 0);
            this.cbxCategorias.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(180, 35);
            this.cbxCategorias.StartIndex = 0;
            this.cbxCategorias.TabIndex = 1;
            this.cbxCategorias.UseAccent = false;
            this.cbxCategorias.UseTallSize = false;
            // 
            // cbxMarca
            // 
            this.cbxMarca.AutoResize = true;
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
            this.cbxMarca.Location = new System.Drawing.Point(398, 111);
            this.cbxMarca.MaxDropDownItems = 4;
            this.cbxMarca.MinimumSize = new System.Drawing.Size(180, 0);
            this.cbxMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(180, 35);
            this.cbxMarca.StartIndex = 0;
            this.cbxMarca.TabIndex = 2;
            this.cbxMarca.UseAccent = false;
            this.cbxMarca.UseTallSize = false;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarItem.Depth = 0;
            this.btnAgregarItem.HighEmphasis = true;
            this.btnAgregarItem.Icon = null;
            this.btnAgregarItem.Location = new System.Drawing.Point(460, 539);
            this.btnAgregarItem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarItem.Size = new System.Drawing.Size(126, 36);
            this.btnAgregarItem.TabIndex = 9;
            this.btnAgregarItem.Text = "Agregar Item";
            this.btnAgregarItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarItem.UseAccentColor = false;
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVaciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVaciar.Depth = 0;
            this.btnVaciar.HighEmphasis = true;
            this.btnVaciar.Icon = null;
            this.btnVaciar.Location = new System.Drawing.Point(597, 539);
            this.btnVaciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVaciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVaciar.Size = new System.Drawing.Size(138, 36);
            this.btnVaciar.TabIndex = 10;
            this.btnVaciar.Text = "Vaciar Carrito";
            this.btnVaciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVaciar.UseAccentColor = false;
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmarVenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmarVenta.Depth = 0;
            this.btnConfirmarVenta.HighEmphasis = true;
            this.btnConfirmarVenta.Icon = null;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(767, 539);
            this.btnConfirmarVenta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmarVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmarVenta.Size = new System.Drawing.Size(156, 36);
            this.btnConfirmarVenta.TabIndex = 11;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmarVenta.UseAccentColor = false;
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrecioFinal.Location = new System.Drawing.Point(765, 516);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(90, 13);
            this.lblPrecioFinal.TabIndex = 23;
            this.lblPrecioFinal.Text = "Precio Final :  ";
            this.lblPrecioFinal.Visible = false;
            // 
            // txtCarrito
            // 
            this.txtCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarrito.Depth = 0;
            this.txtCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCarrito.Location = new System.Drawing.Point(762, 389);
            this.txtCarrito.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCarrito.Name = "txtCarrito";
            this.txtCarrito.ReadOnly = true;
            this.txtCarrito.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCarrito.Size = new System.Drawing.Size(189, 121);
            this.txtCarrito.TabIndex = 24;
            this.txtCarrito.TabStop = false;
            this.txtCarrito.Text = "";
            // 
            // panelEliminar
            // 
            this.panelEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelEliminar.Controls.Add(this.btnCancelarEliminar);
            this.panelEliminar.Controls.Add(this.btnAceptarEliminar);
            this.panelEliminar.Controls.Add(this.lblProductoEliminar);
            this.panelEliminar.Controls.Add(this.lblSeEliminará);
            this.panelEliminar.Location = new System.Drawing.Point(5, 5);
            this.panelEliminar.Name = "panelEliminar";
            this.panelEliminar.Size = new System.Drawing.Size(277, 192);
            this.panelEliminar.TabIndex = 25;
            // 
            // btnCancelarEliminar
            // 
            this.btnCancelarEliminar.AutoSize = false;
            this.btnCancelarEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelarEliminar.Depth = 0;
            this.btnCancelarEliminar.HighEmphasis = true;
            this.btnCancelarEliminar.Icon = null;
            this.btnCancelarEliminar.Location = new System.Drawing.Point(152, 122);
            this.btnCancelarEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarEliminar.Name = "btnCancelarEliminar";
            this.btnCancelarEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelarEliminar.Size = new System.Drawing.Size(98, 32);
            this.btnCancelarEliminar.TabIndex = 3;
            this.btnCancelarEliminar.TabStop = false;
            this.btnCancelarEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelarEliminar.UseAccentColor = false;
            this.btnCancelarEliminar.UseVisualStyleBackColor = true;
            this.btnCancelarEliminar.Click += new System.EventHandler(this.btnCancelarEliminar_Click);
            // 
            // btnAceptarEliminar
            // 
            this.btnAceptarEliminar.AutoSize = false;
            this.btnAceptarEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptarEliminar.Depth = 0;
            this.btnAceptarEliminar.HighEmphasis = true;
            this.btnAceptarEliminar.Icon = null;
            this.btnAceptarEliminar.Location = new System.Drawing.Point(26, 122);
            this.btnAceptarEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptarEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptarEliminar.Name = "btnAceptarEliminar";
            this.btnAceptarEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptarEliminar.Size = new System.Drawing.Size(98, 32);
            this.btnAceptarEliminar.TabIndex = 2;
            this.btnAceptarEliminar.TabStop = false;
            this.btnAceptarEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptarEliminar.UseAccentColor = false;
            this.btnAceptarEliminar.UseVisualStyleBackColor = true;
            this.btnAceptarEliminar.Click += new System.EventHandler(this.btnAceptarEliminar_Click);
            // 
            // lblProductoEliminar
            // 
            this.lblProductoEliminar.AutoSize = true;
            this.lblProductoEliminar.Depth = 0;
            this.lblProductoEliminar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductoEliminar.Location = new System.Drawing.Point(73, 63);
            this.lblProductoEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductoEliminar.Name = "lblProductoEliminar";
            this.lblProductoEliminar.Size = new System.Drawing.Size(119, 19);
            this.lblProductoEliminar.TabIndex = 1;
            this.lblProductoEliminar.Text = "nombreProducto";
            // 
            // lblSeEliminará
            // 
            this.lblSeEliminará.AutoSize = true;
            this.lblSeEliminará.Depth = 0;
            this.lblSeEliminará.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSeEliminará.Location = new System.Drawing.Point(48, 14);
            this.lblSeEliminará.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeEliminará.Name = "lblSeEliminará";
            this.lblSeEliminará.Size = new System.Drawing.Size(173, 19);
            this.lblSeEliminará.TabIndex = 0;
            this.lblSeEliminará.Text = "Se Eliminará el producto";
            // 
            // panelFondo
            // 
            this.panelFondo.Controls.Add(this.panelEliminar);
            this.panelFondo.Location = new System.Drawing.Point(323, 166);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(287, 203);
            this.panelFondo.TabIndex = 26;
            // 
            // pnlMarcaNueva1
            // 
            this.pnlMarcaNueva1.Controls.Add(this.pnlMarcaNueva2);
            this.pnlMarcaNueva1.Location = new System.Drawing.Point(290, 107);
            this.pnlMarcaNueva1.Name = "pnlMarcaNueva1";
            this.pnlMarcaNueva1.Size = new System.Drawing.Size(287, 203);
            this.pnlMarcaNueva1.TabIndex = 27;
            // 
            // pnlMarcaNueva2
            // 
            this.pnlMarcaNueva2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlMarcaNueva2.Controls.Add(this.txtNuevaMarca);
            this.pnlMarcaNueva2.Controls.Add(this.btnCancelarM);
            this.pnlMarcaNueva2.Controls.Add(this.btnAgregarM);
            this.pnlMarcaNueva2.Controls.Add(this.lblIngreseMarca);
            this.pnlMarcaNueva2.Location = new System.Drawing.Point(5, 5);
            this.pnlMarcaNueva2.Name = "pnlMarcaNueva2";
            this.pnlMarcaNueva2.Size = new System.Drawing.Size(277, 192);
            this.pnlMarcaNueva2.TabIndex = 25;
            // 
            // txtNuevaMarca
            // 
            this.txtNuevaMarca.AnimateReadOnly = false;
            this.txtNuevaMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevaMarca.Depth = 0;
            this.txtNuevaMarca.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNuevaMarca.LeadingIcon = null;
            this.txtNuevaMarca.Location = new System.Drawing.Point(34, 69);
            this.txtNuevaMarca.MaxLength = 50;
            this.txtNuevaMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNuevaMarca.Multiline = false;
            this.txtNuevaMarca.Name = "txtNuevaMarca";
            this.txtNuevaMarca.Size = new System.Drawing.Size(208, 36);
            this.txtNuevaMarca.TabIndex = 4;
            this.txtNuevaMarca.TabStop = false;
            this.txtNuevaMarca.Text = "";
            this.txtNuevaMarca.TrailingIcon = null;
            this.txtNuevaMarca.UseTallSize = false;
            // 
            // btnCancelarM
            // 
            this.btnCancelarM.AutoSize = false;
            this.btnCancelarM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelarM.Depth = 0;
            this.btnCancelarM.HighEmphasis = true;
            this.btnCancelarM.Icon = null;
            this.btnCancelarM.Location = new System.Drawing.Point(152, 122);
            this.btnCancelarM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarM.Name = "btnCancelarM";
            this.btnCancelarM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelarM.Size = new System.Drawing.Size(98, 32);
            this.btnCancelarM.TabIndex = 3;
            this.btnCancelarM.TabStop = false;
            this.btnCancelarM.Text = "cancelar";
            this.btnCancelarM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelarM.UseAccentColor = false;
            this.btnCancelarM.UseVisualStyleBackColor = true;
            this.btnCancelarM.Click += new System.EventHandler(this.btnCancelarM_Click);
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.AutoSize = false;
            this.btnAgregarM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarM.Depth = 0;
            this.btnAgregarM.HighEmphasis = true;
            this.btnAgregarM.Icon = null;
            this.btnAgregarM.Location = new System.Drawing.Point(26, 122);
            this.btnAgregarM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarM.Size = new System.Drawing.Size(98, 32);
            this.btnAgregarM.TabIndex = 2;
            this.btnAgregarM.TabStop = false;
            this.btnAgregarM.Text = "Aceptar";
            this.btnAgregarM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarM.UseAccentColor = false;
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // lblIngreseMarca
            // 
            this.lblIngreseMarca.AutoSize = true;
            this.lblIngreseMarca.Depth = 0;
            this.lblIngreseMarca.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIngreseMarca.Location = new System.Drawing.Point(27, 34);
            this.lblIngreseMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIngreseMarca.Name = "lblIngreseMarca";
            this.lblIngreseMarca.Size = new System.Drawing.Size(1, 0);
            this.lblIngreseMarca.TabIndex = 0;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(970, 604);
            this.Controls.Add(this.pnlMarcaNueva1);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.txtCarrito);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.lblGuion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecioMax);
            this.Controls.Add(this.txtPrecioMin);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(970, 604);
            this.MinimumSize = new System.Drawing.Size(970, 604);
            this.Name = "Catalogo";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockFlow";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.panelEliminar.ResumeLayout(false);
            this.panelEliminar.PerformLayout();
            this.panelFondo.ResumeLayout(false);
            this.pnlMarcaNueva1.ResumeLayout(false);
            this.pnlMarcaNueva2.ResumeLayout(false);
            this.pnlMarcaNueva2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridView btnAgregarMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecioMin;
        private System.Windows.Forms.TextBox txtPrecioMax;
        private System.Windows.Forms.Label lblGuion;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblBusqueda;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        public MaterialSkin.Controls.MaterialComboBox cbxCategorias;
        public MaterialSkin.Controls.MaterialComboBox cbxMarca;
        private System.Windows.Forms.ToolStripMenuItem categoriasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasMenuItem;
        private MaterialSkin.Controls.MaterialButton btnAgregarItem;
        private MaterialSkin.Controls.MaterialButton btnVaciar;
        private MaterialSkin.Controls.MaterialButton btnConfirmarVenta;
        public System.Windows.Forms.Label lblPrecioFinal;
        public System.Windows.Forms.TextBox txtBusqueda;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtCarrito;
        private System.Windows.Forms.Panel panelEliminar;
        private System.Windows.Forms.Panel panelFondo;
        private MaterialSkin.Controls.MaterialLabel lblSeEliminará;
        private MaterialSkin.Controls.MaterialButton btnCancelarEliminar;
        private MaterialSkin.Controls.MaterialButton btnAceptarEliminar;
        private MaterialSkin.Controls.MaterialLabel lblProductoEliminar;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.Panel pnlMarcaNueva1;
        private System.Windows.Forms.Panel pnlMarcaNueva2;
        private MaterialSkin.Controls.MaterialButton btnCancelarM;
        private MaterialSkin.Controls.MaterialButton btnAgregarM;
        private MaterialSkin.Controls.MaterialLabel lblIngreseMarca;
        private MaterialSkin.Controls.MaterialTextBox txtNuevaMarca;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estiloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amarilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem violetaToolStripMenuItem;
    }
}

