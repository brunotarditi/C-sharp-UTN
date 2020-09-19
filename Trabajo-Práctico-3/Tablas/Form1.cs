using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtCampo.Text;
            cargarTabla(dato);

        }

        private void cargarTabla(string dato)
        {

            List<Productos> lista = new List<Productos>();
            ControladorProductos _controladorProductos = new ControladorProductos();
            dataGridView1.DataSource = _controladorProductos.consulta(dato);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            Productos _producto = new Productos();
            _producto.Codigo = txtCodigo.Text;
            _producto.Nombre = txtNombre.Text;
            _producto.Descripcion = txtDescripcion.Text;
            _producto.Precio_publico = Convert.ToDouble(txtPrecioPublico.Text);
            _producto.Existencias = int.Parse(txtExistencias.Text);

            ControladorProductos _controlador = new ControladorProductos();

            if (txtId.Text != "")
            {
                _producto.Id = int.Parse(txtId.Text);
                bandera = _controlador.editar(_producto);
            }
            else
            {
                bandera = _controlador.insertar(_producto);
            }

            if (bandera)
            {
                MessageBox.Show("Registro guardado.");
                limpiar();
                cargarTabla(null);
            }

        }

        private void limpiar()
        {
            txtId.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecioPublico.Text = "";
            txtExistencias.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPrecioPublico.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtExistencias.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Salir", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                ControladorProductos _controlador = new ControladorProductos();
                bandera = _controlador.eliminar(id);

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado.");
                    limpiar();
                    cargarTabla(null);
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
