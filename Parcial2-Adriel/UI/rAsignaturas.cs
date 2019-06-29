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
using Parcial2_Adriel.BLL;
using Parcial2_Adriel.Entidades;
using Parcial2_Adriel.DAL;


namespace Parcial2_Adriel.UI
{
    public partial class rAsignaturas : Form
    {
        public rAsignaturas()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            CreditosnumericUpDown.Value = 0;
            Descripcion.Text = string.Empty;
            AsignaturaIdnumericUpDown.Value = 0;
          
            MyErrorProvider.Clear();
        }

        private Asignaturas LlenaClase()
        {
            Asignaturas asignatura = new Asignaturas();
            asignatura.AsignaturaId = Convert.ToInt32(AsignaturaIdnumericUpDown.Value);
            asignatura.Descripcion = DescripciontextBox.Text;
            asignatura.Creditos = Convert.ToInt32(CreditosnumericUpDown.Value);

            return asignatura;
        }
        private void LlenarCampo(Asignaturas asignatura)
        {
            AsignaturaIdnumericUpDown.Value = asignatura.AsignaturaId;
            DescripciontextBox.Text = asignatura.Descripcion;
            CreditosnumericUpDown.Value = asignatura.Creditos;
         
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (Descripcion.Text == string.Empty)
            {
                MyErrorProvider.SetError(Descripcion, "El campo Descripcion no puede estar vacio");
                Descripcion.Focus();
                paso = false;
            }

            if (CreditosnumericUpDown.Value < 1)
            {
                MyErrorProvider.SetError(CreditosnumericUpDown, "El campo Usuario no puede ser 0");
                CreditosnumericUpDown.Focus();
                paso = false;
            }

           
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaturas> rp = new RepositorioBase<Asignaturas>(new DAL.Contexto());
            Asignaturas asignaturas = rp.Buscar((int)AsignaturaIdnumericUpDown.Value);
            return (asignaturas != null);

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> rp = new RepositorioBase<Asignaturas>(new DAL.Contexto());
            Asignaturas asignaturas;
            bool paso = false;

            if (!Validar())
                return;
            asignaturas = LlenaClase();


            if (AsignaturaIdnumericUpDown.Value == 0)
            {
                paso = rp.Guardar(asignaturas);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = rp.Modificar(asignaturas);
            }
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            RepositorioBase<Asignaturas> rp = new RepositorioBase<Asignaturas>(new DAL.Contexto());
            int id;
            int.TryParse(AsignaturaIdnumericUpDown.Text, out id);

            Limpiar();

            if (rp.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(AsignaturaIdnumericUpDown, "No se puede eliminar que no existe");

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>(new DAL.Contexto());
            int id;
            Asignaturas asignaturas = new Asignaturas();

            int.TryParse(AsignaturaIdnumericUpDown.Text, out id);
            Limpiar();

            asignaturas = db.Buscar(id);

            if (asignaturas != null)
            {
                MessageBox.Show("Asignatura escontrada");
                LlenarCampo(asignaturas);

            }
            else
            {
                MessageBox.Show("Asignatura  no existe");
            }
        }
    }
}
