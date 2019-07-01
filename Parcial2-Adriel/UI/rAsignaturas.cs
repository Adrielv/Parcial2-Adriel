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
            DescripciontextBox.Text = string.Empty;
            IdnumericUpDown.Value = 0;
          
            MyErrorProvider.Clear();
        }

        private Asignaturas LlenaClase()
        {
            Asignaturas asignatura = new Asignaturas();
            asignatura.AsignaturaId = Convert.ToInt32(IdnumericUpDown.Value);
            asignatura.Descripcion = DescripciontextBox.Text;
            asignatura.Creditos = Convert.ToInt32(CreditosnumericUpDown.Value);

            return asignatura;
        }
        private void LlenarCampo(Asignaturas asignatura)
        {
            IdnumericUpDown.Value = asignatura.AsignaturaId;
            DescripciontextBox.Text = asignatura.Descripcion;
            CreditosnumericUpDown.Value = asignatura.Creditos;
         
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripciontextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripciontextBox, "El campo Descripcion no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }

            if (CreditosnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CreditosnumericUpDown, "El campo Creditos no puede ser 0");
                CreditosnumericUpDown.Focus();
                paso = false;
            }
            if (NoDuplicado(DescripciontextBox.Text))
            {
                MyErrorProvider.SetError(DescripciontextBox, "No se permite tener materias con el mismo nombre");
                paso = false;

            }


            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaturas> rp = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas = rp.Buscar((int)IdnumericUpDown.Value);
            return (asignaturas != null);

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public static bool NoDuplicado(string descripcion)
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            bool paso = false;
            Contexto dbq = new Contexto();

            try
            {
                if (dbq.Asignaturas.Any(p => p.Descripcion.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> rp = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas;
            bool paso = false;

            if (!Validar())
                return;
            asignaturas = LlenaClase();


            if (IdnumericUpDown.Value == 0)
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
            RepositorioBase<Asignaturas> rp = new RepositorioBase<Asignaturas>();
      
     
            if (IdnumericUpDown.Value > 0)
            {
                if (rp.Eliminar((int)IdnumericUpDown.Value))
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MyErrorProvider.SetError(IdnumericUpDown, "No se puede eliminar que no existe");
            }
            else
            {
                MyErrorProvider.SetError(IdnumericUpDown, "Selecione a que asignatura eliminar");
                IdnumericUpDown.Focus();
            }
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            int id;
            Asignaturas asignaturas = new Asignaturas();

            int.TryParse(IdnumericUpDown.Text, out id);
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
