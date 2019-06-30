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
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {

                try
                {
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todos": 
                            listado = db.GetList(A => true);
                            break;

                        case "Id":
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.AsignaturaId == id);
                            break;

                        case "Descripcion":
                            listado = db.GetList(A => A.Descripcion.Contains(CriteriotextBox.Text));
                            break;
                     /*   case "Creditos":
                            
                            listado = db.GetList(p => p.Creditos);
                            break;
                            */
                    }
                }
                catch (Exception)
                {

                }

            }
            else
            {
                listado = db.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
