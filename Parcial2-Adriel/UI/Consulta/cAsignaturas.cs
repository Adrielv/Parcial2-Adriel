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

namespace Parcial2_Adriel.UI.Consulta
{
    public partial class cAsignaturas : Form
    {
        public cAsignaturas()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Asignaturas>();
            RepositorioBase<Asignaturas> rb = new RepositorioBase<Asignaturas>();


            try
            {
                if (CriteriotextBox.Text.Trim().Length > 0)
                {
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todos":
                            listado = rb.GetList(A => true);
                            break;

                        case "Id":
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = rb.GetList(p => p.AsignaturaId == id);
                            break;

                        case "Descripcion":
                            listado = rb.GetList(A => A.Descripcion.Contains(CriteriotextBox.Text));
                            break;

                        case "Creditos":
                            decimal c = decimal.Parse(CriteriotextBox.Text);
                            listado = rb.GetList(p => p.Creditos == c);
                            break;


                    }
                }
                else
                {
                    MyErrorProvider.Clear();
                    if (FiltrocomboBox.Text == string.Empty)
                    {
                        MyErrorProvider.SetError(FiltrocomboBox, "El campo Filtro no puede estar vacio");
                        FiltrocomboBox.Focus();
                      
                    }
                    else
                        if ((string)FiltrocomboBox.Text != "Todos")
                        {
                            if (CriteriotextBox.Text == string.Empty)
                            {
                            MyErrorProvider.SetError(CriteriotextBox, "El campo Criterio no puede estar vacio");
                             CriteriotextBox.Focus();                         
                            }
                         }
                    else
                    {
                        listado = rb.GetList(p => true);
                    }
                }
            }
            catch (Exception)
            {

            }      

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
