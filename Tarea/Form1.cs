using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea.Data;


namespace Tarea
{
    public partial class Form1 : Form
    {
        private BindingSource BindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDistrito.Items.Add("Distrito A");
            comboBoxDistrito.Items.Add("Distrito B");

            
        }

        
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    var nuevoPedido = new Pedidos
                    {
                        Fecha = dateTimePickerFecha.Value,
                        NombreCliente = textBoxNombreCliente.Text,
                        MontoPedido = decimal.Parse(textBoxMontoPedido.Text),
                        Distrito = (comboBoxDistrito.SelectedItem != null) ? comboBoxDistrito.SelectedItem.ToString() : string.Empty
                    };

                    context.Pedido.Add(nuevoPedido);
                    
                }

                MessageBox.Show("Pedido registrado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            using (var context = new Context())
            {
                context.SaveChanges();
            }
        }

        private void CargarDatosEnDataGridView()
        {
            using (var context = new Context())
            {
                var pedidos = context.Pedido.ToList();

                dataGridViewdbTarea.DataSource = pedidos;
            }
        }

        private void LimpiarCampos()
        {
            dateTimePickerFecha.Value = DateTime.Now;
            textBoxNombreCliente.Clear();
            textBoxMontoPedido.Clear();
            comboBoxDistrito.SelectedIndex = -1;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            this.pedidosTableAdapter.Fill(this.dbTareaDataSetchi.Pedidos);
          
            this.pedidosTableAdapter.Fill(this.dbTareaDataSetchi.Pedidos);
           
            this.pedidosTableAdapter.Fill(this.dbTareaDataSetchi.Pedidos);

        }

        
    }
}
