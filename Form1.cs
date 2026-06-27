using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace TrabajoLaboratorio;

public partial class Form1 : Form
{
    private BindingList<Venta> _ventas = new BindingList<Venta>();

    public Form1(bool demoMode = false)
    {
        InitializeComponent();
        ConfigureDataGridView();
        
        if (demoMode)
        {
            LoadDemoData();
        }
    }

    private void LoadDemoData()
    {
        _ventas.Add(new Venta { Producto = "Monitor Gamer", Cantidad = 1, PrecioUnitario = 650m });
        _ventas.Add(new Venta { Producto = "Auriculares HyperX", Cantidad = 2, PrecioUnitario = 120m });
        _ventas.Add(new Venta { Producto = "Silla Ergonomica", Cantidad = 1, PrecioUnitario = 450m });
        
        // Trigger calculation
        btnCalcular_Click(this, EventArgs.Empty);
    }

    private void ConfigureDataGridView()
    {
        dgvVentas.AutoGenerateColumns = false;
        dgvVentas.Columns.Clear();

        dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Producto",
            DataPropertyName = "Producto",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });

        dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Cantidad",
            DataPropertyName = "Cantidad",
            Width = 100
        });

        dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Precio Unitario",
            DataPropertyName = "PrecioUnitario",
            Width = 150
        });

        dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Subtotal",
            DataPropertyName = "Subtotal",
            Width = 150
        });

        dgvVentas.DataSource = _ventas;
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        string producto = txtProducto.Text.Trim();

        // Validaciones
        if (string.IsNullOrWhiteSpace(producto))
        {
            MessageBox.Show("El nombre del producto no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtProducto.Focus();
            return;
        }

        if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
        {
            MessageBox.Show("La cantidad debe ser un número entero mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCantidad.Focus();
            return;
        }

        // Parseo del precio unitario (flexible para soportar ',' y '.')
        if (!decimal.TryParse(txtPrecioUnitario.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal precioUnitario) &&
            !decimal.TryParse(txtPrecioUnitario.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out precioUnitario) || precioUnitario <= 0)
        {
            MessageBox.Show("El precio unitario debe ser un número mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPrecioUnitario.Focus();
            return;
        }

        // Agregar venta
        var nuevaVenta = new Venta
        {
            Producto = producto,
            Cantidad = cantidad,
            PrecioUnitario = precioUnitario
        };

        _ventas.Add(nuevaVenta);

        // Limpiar campos de entrada y enfocar
        txtProducto.Clear();
        txtCantidad.Clear();
        txtPrecioUnitario.Clear();
        txtProducto.Focus();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        if (_ventas.Count == 0)
        {
            MessageBox.Show("Debe agregar al menos una venta para poder realizar los cálculos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        decimal total = 0;
        foreach (var venta in _ventas)
        {
            total += venta.Subtotal;
        }

        // Fórmulas
        // Total = Valor Venta + IGV
        // IGV = Valor Venta * 0.18
        // Total = Valor Venta * 1.18 => Valor Venta = Total / 1.18
        decimal valorVenta = Math.Round(total / 1.18m, 2, MidpointRounding.AwayFromZero);
        decimal igv = total - valorVenta;

        // Mostrar en pantalla formateado a 2 decimales
        txtValorVenta.Text = valorVenta.ToString("0.00", CultureInfo.InvariantCulture);
        txtIGV.Text = igv.ToString("0.00", CultureInfo.InvariantCulture);
        txtTotal.Text = total.ToString("0.00", CultureInfo.InvariantCulture);
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        // Limpiar controles de texto
        txtProducto.Clear();
        txtCantidad.Clear();
        txtPrecioUnitario.Clear();
        
        txtValorVenta.Clear();
        txtIGV.Clear();
        txtTotal.Clear();

        // Limpiar lista de ventas
        _ventas.Clear();

        // Enfocar primer campo
        txtProducto.Focus();
    }
}
