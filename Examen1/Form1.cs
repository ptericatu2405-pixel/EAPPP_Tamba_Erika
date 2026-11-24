using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Form1 : Form
    {
        decimal precioActual = 0;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.chkPostre.CheckedChanged += chkPostre_CheckedChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lvCatalogo.View = View.Details;
            lvCatalogo.FullRowSelect = true;
            lvCatalogo.Columns.Clear();
            lvCatalogo.Columns.Add("Producto", 180);
            lvCatalogo.Columns.Add("Precio", 80);

            AgregarProductoCatalogo("salchipapa", 1.25m);
            AgregarProductoCatalogo("Sánduche de pollo", 2.50m);
            AgregarProductoCatalogo("Bolón de verde mixto", 2.25m);
            AgregarProductoCatalogo("Humita ", 1.50m);
            AgregarProductoCatalogo("pan con queso", 1.00m);
            AgregarProductoCatalogo("Café con huevo y arroz", 0.85m);
           
            lvPedido.View = View.Details;
            lvPedido.FullRowSelect = true;
            lvPedido.Columns.Clear();
            lvPedido.Columns.Add("Producto", 160);
            lvPedido.Columns.Add("Cant.", 55);
            lvPedido.Columns.Add("Subtotal", 85);
      
            txtCantidad.Text = "1";
            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "eleccione un producto.";
        }

        private void AgregarProductoCatalogo(string nombre, decimal precio)
        {
            ListViewItem item = new ListViewItem(nombre);
            item.SubItems.Add(precio.ToString("$0.00", CultureInfo.InvariantCulture));
            item.Tag = precio;
            lvCatalogo.Items.Add(item);
        }

        private void ActualizarTotal()
        {
            decimal suma = 0;

            for (int i = 0; i < lvPedido.Items.Count; i++)
            {
                suma += (decimal)lvPedido.Items[i].Tag;
            }

            if (rbtnEntrega.Checked)
            {
                suma += 0.50m;
            }

            if (chkPostre.Checked)
            {
                suma += 1.00m;
            }

            lblTotal.Text = "Total: " + suma.ToString("$0.00", CultureInfo.InvariantCulture);
        }

        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count > 0)
            {
                btnQuitar.Enabled = true;
            }
            else
            {
                btnQuitar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                lblEstado.Text = "Ingrese el nombre del cliente.";
                txtCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                lblEstado.Text = "seleccione un producto del catálogo.";
                return;
            }

            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad < 1)
            {
                lblEstado.Text = "mayor a 1";
                txtCantidad.AcceptsReturn = true;
                return;
            }

        
            decimal subtotal = cantidad * precioActual;

            ListViewItem item = new ListViewItem(txtProducto.Text);
            item.SubItems.Add(cantidad.ToString());
            item.SubItems.Add(subtotal.ToString("$0.00", CultureInfo.InvariantCulture));
            item.Tag = subtotal;

            lvPedido.Items.Add(item);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count > 0)
            {
                lvPedido.Items.Remove(lvPedido.SelectedItems);
                btnQuitar.Enabled = false;
                lblEstado.Text = "Estado: Ítem eliminado del pedido.";
                ActualizarTotal();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Text = "1";
            precioActual = 0;

            lvCatalogo.SelectedItems.Clear();
            lvPedido.Items.Clear();

            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;

            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Seleccione un producto.";
            txtCliente.Focus();
        }

        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
            if (rbtnEntrega.Checked)
                lblEstado.Text = "Estado: Entrega en aula (+$0.50).";
            else
                lblEstado.Text = "Estado: Retiro en mostrador.";
        }

        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
            if (chkPostre.Checked)
                lblEstado.Text = "Estado: Postre del día agregado (+$1.00).";
            else
                lblEstado.Text = "Estado: Postre del día quitado.";
        }

        private void chkServilletas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkServilletas.Checked)
                lblEstado.Text = "EstadCon servilletas y cubiertos.";
            else
                lblEstado.Text = "Estadosin servilletas ni cubiertos.";
        }

    }
}