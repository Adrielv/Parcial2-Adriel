using Parcial2_Adriel.BLL;
using Parcial2_Adriel.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Adriel.UI
{
    public partial class rIncripcion : Form
    {
        public List<InscripcionDetalle> Detalle { get; set; }
        public rIncripcion()
        {
            InitializeComponent();
            LlenarComboBox();
            LLenarComboBox2();
            EstudiantecomboBox.Text = null;
            AsignaturacomboBox.Text = null;
            this.Detalle = new List<InscripcionDetalle>();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            MontoTotaltextBox.Text = string.Empty;
            EstudiantecomboBox.Text = string.Empty;
            AsignaturacomboBox.Text = string.Empty;
            MontoCreditosnumericUpDown.Value = 0;
            this.Detalle = new List<InscripcionDetalle>();
            MyerrorProvider.Clear();
            CargarGrid();
        }

        private Inscripcion LlenaClase()
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.Asignaturas = this.Detalle;
            if (IdnumericUpDown.Value == 0)
            {
                inscripcion.EstudianteId = Convert.ToInt32(EstudiantecomboBox.SelectedValue);
            }
            else
            {
                inscripcion.EstudianteId = Convert.ToInt32(EstudiantecomboBox.Text);

            }
            inscripcion.InscripcionId = Convert.ToInt32(IdnumericUpDown.Value);
            inscripcion.Monto = MontoCreditosnumericUpDown.Value;
            inscripcion.CalcularMonto();
            inscripcion.Fecha = FechaInscripciondateTimePicker.Value;

            return inscripcion;

        }

        private void LlenaCampo(Inscripcion inscripcion)
        {
            IdnumericUpDown.Value = inscripcion.InscripcionId;
            EstudiantecomboBox.Text = inscripcion.EstudianteId.ToString();
            MontoTotaltextBox.Text = inscripcion.MontoTotal.ToString();
            MontoCreditosnumericUpDown.Value = inscripcion.Monto;
            FechaInscripciondateTimePicker.Value = inscripcion.Fecha;
            this.Detalle = inscripcion.Asignaturas;
            CargarGrid();

        }

        private void CargarGrid()
        {
            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = Detalle;
        }

        private bool Validar()
        {

            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(EstudiantecomboBox.Text))
            {
                MyerrorProvider.SetError(EstudiantecomboBox, "El campo Estudiante no puede estar vacio");
                EstudiantecomboBox.Focus();
                paso = false;

            }

            if (MontoCreditosnumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(MontoCreditosnumericUpDown, "El Monto de los creditos no puede estar ser 0");
                MontoCreditosnumericUpDown.Focus();
                paso = false;

            }

            if (Detalle.Count == 0)
            {
                MyerrorProvider.SetError(AsignaturacomboBox, "La inscripcion por lo menos debe tener una asignatura");
                AsignaturacomboBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Inscripcion> db = new RepositorioBase<Inscripcion>();
            Inscripcion inscripcion = db.Buscar((int)IdnumericUpDown.Value);
            return (inscripcion != null);
        }

        private void LlenarComboBox()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            var listado2 = new List<Asignaturas>();
            listado2 = db.GetList(p => true);
            AsignaturacomboBox.DataSource = listado2;
            AsignaturacomboBox.DisplayMember = "Descripcion";
            AsignaturacomboBox.ValueMember = "AsignaturaId";

        }

        private void LLenarComboBox2()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();
            var listado = new List<Estudiantes>();
            listado = db.GetList(l => true);
            EstudiantecomboBox.DataSource = listado;
            EstudiantecomboBox.DisplayMember = "Nombres";
            EstudiantecomboBox.ValueMember = "EstudianteId";
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion;
            bool paso = false;

            if (!Validar())
                return;

            inscripcion = LlenaClase();
            inscripcion.CalcularMonto();
            if (IdnumericUpDown.Value == 0)
            {
                paso = InscripcionBLL.Guardar(inscripcion);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Estudiante que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = InscripcionBLL.Modificar(inscripcion);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LlenaClase();
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Inscripcion> db = new RepositorioBase<Inscripcion>();
            MyerrorProvider.Clear();
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();

            if (IdnumericUpDown.Value > 0)
            {
                        if (InscripcionBLL.Eliminar(id))
                    {
                        MessageBox.Show("Eliminado");
                    }
                    else
                    {
                        MyerrorProvider.SetError(IdnumericUpDown, "No se puede elimina, porque no existe");
                    }
            }
            else
            {
                MyerrorProvider.SetError(IdnumericUpDown, "Selecione a quien quiere eliminar");
                IdnumericUpDown.Focus();
            }
        }

        private void EliminarLineabutton_Click(object sender, EventArgs e)
        {
            if (detalleDataGridView.Rows.Count > 0 && detalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(detalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = db.Buscar((int)AsignaturacomboBox.SelectedValue);
            if (detalleDataGridView.DataSource != null)
                this.Detalle = (List<InscripcionDetalle>)detalleDataGridView.DataSource;



            this.Detalle.Add(new InscripcionDetalle()
            {
                InscripcionId = (int)IdnumericUpDown.Value,
                AsignaturaId = (int)AsignaturacomboBox.SelectedValue,
                Id = 0,
                SubTotal = (asignatura.Creditos * MontoCreditosnumericUpDown.Value)
            });

            CargarGrid();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Inscripcion> db = new RepositorioBase<Inscripcion>();
            int id;
            Inscripcion inscripcion = new Inscripcion();

            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();

            inscripcion = db.Buscar(id);

            if (inscripcion != null)
            {
                LlenaCampo(inscripcion);
            }
            else
            {
                MessageBox.Show("Inscripcion no existe");
            }
        }
    }
}
