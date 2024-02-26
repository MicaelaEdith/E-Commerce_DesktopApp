namespace Presentacion
{
    partial class FrmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.AllowUserToAddRows = false;
            this.dgvFacturacion.AllowUserToDeleteRows = false;
            this.dgvFacturacion.AllowUserToResizeColumns = false;
            this.dgvFacturacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvFacturacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFacturacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturacion.ColumnHeadersHeight = 40;
            this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFacturacion.EnableHeadersVisualStyles = false;
            this.dgvFacturacion.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFacturacion.Location = new System.Drawing.Point(22, 78);
            this.dgvFacturacion.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.RowHeadersVisible = false;
            this.dgvFacturacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFacturacion.RowTemplate.Height = 28;
            this.dgvFacturacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturacion.Size = new System.Drawing.Size(252, 204);
            this.dgvFacturacion.StandardTab = true;
            this.dgvFacturacion.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(56, 292);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(129, 19);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Facturación total: ";
            // 
            // FrmFacturacion
            // 
            this.ClientSize = new System.Drawing.Size(300, 318);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvFacturacion);
            this.Name = "FrmFacturacion";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvFacturacion;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
    }

    #endregion
}