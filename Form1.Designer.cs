namespace TrabajoLaboratorio;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.lblProducto = new System.Windows.Forms.Label();
        this.lblCantidad = new System.Windows.Forms.Label();
        this.lblPrecioUnitario = new System.Windows.Forms.Label();
        this.txtProducto = new System.Windows.Forms.TextBox();
        this.txtCantidad = new System.Windows.Forms.TextBox();
        this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
        this.btnAgregar = new System.Windows.Forms.Button();
        this.btnCalcular = new System.Windows.Forms.Button();
        this.btnLimpiar = new System.Windows.Forms.Button();
        this.dgvVentas = new System.Windows.Forms.DataGridView();
        this.lblValorVenta = new System.Windows.Forms.Label();
        this.lblIGV = new System.Windows.Forms.Label();
        this.lblTotal = new System.Windows.Forms.Label();
        this.txtValorVenta = new System.Windows.Forms.TextBox();
        this.txtIGV = new System.Windows.Forms.TextBox();
        this.txtTotal = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
        this.SuspendLayout();
        
        // lblProducto
        this.lblProducto.AutoSize = true;
        this.lblProducto.Location = new System.Drawing.Point(50, 40);
        this.lblProducto.Name = "lblProducto";
        this.lblProducto.Size = new System.Drawing.Size(210, 20);
        this.lblProducto.Text = "Ingresar nombre del producto:";
        
        // lblCantidad
        this.lblCantidad.AutoSize = true;
        this.lblCantidad.Location = new System.Drawing.Point(50, 80);
        this.lblCantidad.Name = "lblCantidad";
        this.lblCantidad.Size = new System.Drawing.Size(126, 20);
        this.lblCantidad.Text = "Ingresar cantidad:";
        
        // lblPrecioUnitario
        this.lblPrecioUnitario.AutoSize = true;
        this.lblPrecioUnitario.Location = new System.Drawing.Point(50, 120);
        this.lblPrecioUnitario.Name = "lblPrecioUnitario";
        this.lblPrecioUnitario.Size = new System.Drawing.Size(159, 20);
        this.lblPrecioUnitario.Text = "Ingresar precio unitario:";
        
        // txtProducto
        this.txtProducto.Location = new System.Drawing.Point(280, 37);
        this.txtProducto.Name = "txtProducto";
        this.txtProducto.Size = new System.Drawing.Size(200, 27);
        
        // txtCantidad
        this.txtCantidad.Location = new System.Drawing.Point(280, 77);
        this.txtCantidad.Name = "txtCantidad";
        this.txtCantidad.Size = new System.Drawing.Size(200, 27);
        
        // txtPrecioUnitario
        this.txtPrecioUnitario.Location = new System.Drawing.Point(280, 117);
        this.txtPrecioUnitario.Name = "txtPrecioUnitario";
        this.txtPrecioUnitario.Size = new System.Drawing.Size(200, 27);
        
        // btnAgregar
        this.btnAgregar.Location = new System.Drawing.Point(50, 170);
        this.btnAgregar.Name = "btnAgregar";
        this.btnAgregar.Size = new System.Drawing.Size(100, 35);
        this.btnAgregar.Text = "Agregar";
        this.btnAgregar.UseVisualStyleBackColor = true;
        this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
        
        // btnCalcular
        this.btnCalcular.Location = new System.Drawing.Point(170, 170);
        this.btnCalcular.Name = "btnCalcular";
        this.btnCalcular.Size = new System.Drawing.Size(100, 35);
        this.btnCalcular.Text = "Calcular";
        this.btnCalcular.UseVisualStyleBackColor = true;
        this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
        
        // btnLimpiar
        this.btnLimpiar.Location = new System.Drawing.Point(290, 170);
        this.btnLimpiar.Name = "btnLimpiar";
        this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
        this.btnLimpiar.Text = "Limpiar";
        this.btnLimpiar.UseVisualStyleBackColor = true;
        this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
        
        // dgvVentas
        this.dgvVentas.AllowUserToAddRows = false;
        this.dgvVentas.AllowUserToDeleteRows = false;
        this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvVentas.Location = new System.Drawing.Point(50, 230);
        this.dgvVentas.Name = "dgvVentas";
        this.dgvVentas.ReadOnly = true;
        this.dgvVentas.RowHeadersWidth = 51;
        this.dgvVentas.RowTemplate.Height = 29;
        this.dgvVentas.Size = new System.Drawing.Size(700, 220);
        
        // lblValorVenta
        this.lblValorVenta.AutoSize = true;
        this.lblValorVenta.Location = new System.Drawing.Point(50, 480);
        this.lblValorVenta.Name = "lblValorVenta";
        this.lblValorVenta.Size = new System.Drawing.Size(140, 20);
        this.lblValorVenta.Text = "Mostrar valor venta:";
        
        // lblIGV
        this.lblIGV.AutoSize = true;
        this.lblIGV.Location = new System.Drawing.Point(50, 520);
        this.lblIGV.Name = "lblIGV";
        this.lblIGV.Size = new System.Drawing.Size(95, 20);
        this.lblIGV.Text = "Mostrar IGV:";
        
        // lblTotal
        this.lblTotal.AutoSize = true;
        this.lblTotal.Location = new System.Drawing.Point(50, 560);
        this.lblTotal.Name = "lblTotal";
        this.lblTotal.Size = new System.Drawing.Size(99, 20);
        this.lblTotal.Text = "Mostrar total:";
        
        // txtValorVenta
        this.txtValorVenta.Location = new System.Drawing.Point(280, 477);
        this.txtValorVenta.Name = "txtValorVenta";
        this.txtValorVenta.ReadOnly = true;
        this.txtValorVenta.Size = new System.Drawing.Size(150, 27);
        this.txtValorVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        
        // txtIGV
        this.txtIGV.Location = new System.Drawing.Point(280, 517);
        this.txtIGV.Name = "txtIGV";
        this.txtIGV.ReadOnly = true;
        this.txtIGV.Size = new System.Drawing.Size(150, 27);
        this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        
        // txtTotal
        this.txtTotal.Location = new System.Drawing.Point(280, 557);
        this.txtTotal.Name = "txtTotal";
        this.txtTotal.ReadOnly = true;
        this.txtTotal.Size = new System.Drawing.Size(150, 27);
        this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        
        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 620);
        this.Controls.Add(this.txtTotal);
        this.Controls.Add(this.txtIGV);
        this.Controls.Add(this.txtValorVenta);
        this.Controls.Add(this.lblTotal);
        this.Controls.Add(this.lblIGV);
        this.Controls.Add(this.lblValorVenta);
        this.Controls.Add(this.dgvVentas);
        this.Controls.Add(this.btnLimpiar);
        this.Controls.Add(this.btnCalcular);
        this.Controls.Add(this.btnAgregar);
        this.Controls.Add(this.txtPrecioUnitario);
        this.Controls.Add(this.txtCantidad);
        this.Controls.Add(this.txtProducto);
        this.Controls.Add(this.lblPrecioUnitario);
        this.Controls.Add(this.lblCantidad);
        this.Controls.Add(this.lblProducto);
        this.Name = "Form1";
        this.Text = "Registro de Ventas - UPN";
        ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblProducto;
    private System.Windows.Forms.Label lblCantidad;
    private System.Windows.Forms.Label lblPrecioUnitario;
    private System.Windows.Forms.TextBox txtProducto;
    private System.Windows.Forms.TextBox txtCantidad;
    private System.Windows.Forms.TextBox txtPrecioUnitario;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.DataGridView dgvVentas;
    private System.Windows.Forms.Label lblValorVenta;
    private System.Windows.Forms.Label lblIGV;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.TextBox txtValorVenta;
    private System.Windows.Forms.TextBox txtIGV;
    private System.Windows.Forms.TextBox txtTotal;
}
