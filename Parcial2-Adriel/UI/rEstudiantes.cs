using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2_Adriel.BLL;
using Parcial2_Adriel.Entidades;

namespace Parcial2_Adriel.UI
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombrestextBox.Text = string.Empty;
            BalancenumericUpDown.Value = 0;

            MyErrorProvider.Clear();
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.EstudianteId = Convert.ToInt32(IdnumericUpDown.Value);
            estudiantes.Nombres = NombrestextBox.Text;
            estudiantes.Balance = Convert.ToInt32(BalancenumericUpDown.Value);

            return estudiantes;
        }
        private void LlenarCampo(Estudiantes estudiantes)
        {
            IdnumericUpDown.Value = estudiantes.EstudianteId;
            FechaIngresodateTimePicker.Value = estudiantes.FechaIngresos;
            NombrestextBox.Text = estudiantes.Nombres;
            BalancenumericUpDown.Value = estudiantes.Balance;

        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombrestextBox.Text))
            {
                MyErrorProvider.SetError(NombrestextBox, "El campo Nombres no puede estar vacio");
                NombrestextBox.Focus();
                paso = false;
            }
            if (FechaIngresodateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaIngresodateTimePicker, "No se puede registrar esta fecha.");
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiantes> rb = new RepositorioBase<Estudiantes>();
            Estudiantes estudiantes = rb.Buscar((int)IdnumericUpDown.Value);
            return (estudiantes != null);

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> rb = new RepositorioBase<Estudiantes>();
            Estudiantes estudiantes;
            bool paso = false;

            if (!Validar())
                return;
            estudiantes = LlenaClase();


            if (IdnumericUpDown.Value == 0)
            {
                paso = rb.Guardar(estudiantes);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = rb.Modificar(estudiantes);
            }
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            RepositorioBase<Estudiantes> rb = new RepositorioBase<Estudiantes>();
  
         
            Limpiar();

            if (IdnumericUpDown.Value > 0)
            {

                if (rb.Eliminar((int)IdnumericUpDown.Value))
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MyErrorProvider.SetError(IdnumericUpDown, "No se puede eliminar una persona que no existe");
            }
            else
            {
                MyErrorProvider.SetError(IdnumericUpDown, "Selecione a quien quiere eliminar");
                IdnumericUpDown.Focus();
            }

        }
       

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();
            int id;
            Estudiantes estudiante = new Estudiantes();

            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();

            estudiante = db.Buscar(id);

            if (estudiante != null)
            {
                MessageBox.Show("Estudiante encontrado");
                LlenarCampo(estudiante);

            }
            else
            {
                MessageBox.Show("Estudiante  no existe");
            }
        }

        private void NombrestextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
