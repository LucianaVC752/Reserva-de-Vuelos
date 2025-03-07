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

        ErrorProvider errorP = new ErrorProvider();
        Vuelo vueloSeleccionado = null;
        public Reservas()
        {
            InitializeComponent();
             dataGridView2.AutoGenerateColumns = true;
            CargarData();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
           
        }

        private void CargarData()
        {
            var vuelosDisponibles = VuelosLista.ListaVuelos
                           .Where(v => v.CantidadPuestos > 0)
                           .ToList();
            dataGridView2.DataSource = null;  
            dataGridView2.DataSource = vuelosDisponibles;

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
                    errorP.SetError(control, "");
                }
            }
            return true;
        }

        private bool ValidarFecha()
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            DateTime fechaPorDefecto = DateTime.Now; // 

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
                if (ValidarTextBoxEnPanel(panel1) && ValidarFecha() && (cantidadPuestos > 0))
                {
                    RegistrarVuelo(cantidadPuestos);
                    MessageBox.Show("Vuelo registrado");
                    CargarData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el vuelo " + ex);
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
                CargarData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al hacer la reserva: " + ex);
            }


        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                vueloSeleccionado = dataGridView2.SelectedRows[0].DataBoundItem as Vuelo;

                if (vueloSeleccionado != null)
                {
                    MessageBox.Show($"Vuelo seleccionado: {vueloSeleccionado.OrigenVuelo} → {vueloSeleccionado.DestinoVuelo}");
                }
            }
        }
    }
}
