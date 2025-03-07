using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reserva_de_Vuelos
{
    public partial class Reservas : Form
    {
        BindingSource bs = new BindingSource();
        ErrorProvider errorP = new ErrorProvider();
        Vuelo vueloSeleccionado = null;
        public Reservas()
        {
            InitializeComponent();
            CargarData();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            
        }

        private void CargarData()
        {
            //bs.DataSource = VuelosLista.ListaVuelos;
            //origenCb.DataSource = bs;
            //origenCb.DisplayMember = "OrigenVuelo";
            //DestinoCb.DataSource = bs;
            //DestinoCb.DisplayMember = "DestinoVuelo";
            dataGridView1.Rows.Clear();
            var vuelosDisponibles = VuelosLista.ListaVuelos
                                   .Where(v => v.CantidadPuestos > 0) 
                                   .ToList();
          
            foreach (var vuelo in vuelosDisponibles)
            {
                dataGridView1.Rows.Add(vuelo.Codigo,vuelo.OrigenVuelo,vuelo.DestinoVuelo, vuelo.FechaSalida);
            }
        }
        


        private bool ValidarTextBoxEnPanel(Panel panel)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox txt && string.IsNullOrWhiteSpace(txt.Text))
                {
                    errorP.SetError(txt, "Este campo no puede estar vacío");
                    return false;
                }
                else
                {
                    errorP.SetError(control, ""); // Limpia el error si está lleno
                }
            }
            return true;
        }

        private bool ValidarFecha()
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            DateTime fechaPorDefecto = DateTime.Now; // O cualquier otra fecha inicial

            if (fechaSeleccionada == fechaPorDefecto)
            {
                errorP.SetError(dateTimePicker1, "Debe seleccionar una fecha diferente.");
                return false;
            }

            errorP.Clear();
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadPuestos = Convert.ToInt32(numericUpDown1.Value);
                if (ValidarTextBoxEnPanel(panel1) && ValidarFecha() &&(cantidadPuestos>0))
                {
                    RegistrarVuelo(cantidadPuestos);
                    MessageBox.Show("Vuelo registrado");
                    CargarData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el vuelo "+ex);
            }
        }

        private void RegistrarVuelo(int cantidad)
        {
            string codigoARegistrar = codigo.Text;
            string origenRegistrar = origen.Text;
            string destinoRegistrar = destino.Text;
            DateTime fechaVueloRegistrar = dateTimePicker1.Value;

            Vuelo vueloRegistrar = new Vuelo
                (
                    codigo: codigoARegistrar,
                    origenVuelo: origenRegistrar,
                    destinoVuelo: destinoRegistrar,
                    fechaSalida: fechaVueloRegistrar,
                    cantidadPuestos: cantidad
                );
            VuelosLista.ListaVuelos.Add(vueloRegistrar);
        }

        private bool cbVacio()
        {
            if (string.IsNullOrEmpty(origenCb.Text) || origenCb.SelectedIndex == -1)
            {
                origenCb.Focus();
                errorP.SetError(origenCb, "No puede dejar vacio");
                return false;
            }
            if (string.IsNullOrEmpty(DestinoCb.Text) || DestinoCb.SelectedIndex == -1)
            {
                origenCb.Focus();
                errorP.SetError(DestinoCb, "No puede dejar vacio");
                return false;
            }
            return true;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadPuestos = Convert.ToInt32(cantidasAsientoNup.Value);
                ValidarReserva(cantidadPuestos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al hacer la reserva: " + ex);
            }
            
        }

        private void ValidarReserva(int cantidadVuelos)
        {
            try
            {
                //var resultado = VuelosLista.ListaVuelos.Where(e => e.OrigenVuelo.Contains(origenVuelo.OrigenVuelo) && e.DestinoVuelo.Contains(destinoVuelo.DestinoVuelo)).ToList();

                int cantidadPuestos = Convert.ToInt32(cantidasAsientoNup.Value);
                if (vueloSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un vuelo antes de reservar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(cantidasAsientoNup.Value.ToString(), out int asientosReservados) || asientosReservados < 1)
                {
                    MessageBox.Show("Ingrese una cantidad válida de asientos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cantidadPuestos > vueloSeleccionado.CantidadPuestos)
                {
                    MessageBox.Show("No hay suficientes asientos disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                vueloSeleccionado.CantidadPuestos -= asientosReservados;

                MessageBox.Show($"Reserva realizada con éxito. {asientosReservados} asientos reservados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar el DataGridView
                CargarData();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error al hacer la reserva: " + ex);
            }
            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                vueloSeleccionado = (Vuelo)dataGridView1.SelectedRows[0].DataBoundItem;  
            }
        }

      
    }
}
