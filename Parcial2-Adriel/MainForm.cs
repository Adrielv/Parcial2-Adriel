using Parcial2_Adriel.UI;
using Parcial2_Adriel.UI.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Adriel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignaturas ra = new rAsignaturas();
            ra.Show(); 
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes re = new rEstudiantes();
            re.Show();
        }

        private void InscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rIncripcion ri = new rIncripcion();
            ri.Show();
        }

        private void AsignaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cAsignaturas ca = new  cAsignaturas();
            ca.Show();

        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEstudiantes ce = new cEstudiantes();
            ce.Show();
        }

        private void InscripcionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cInscripcion ci = new cInscripcion();
            ci.Show();
        }
    }
}
