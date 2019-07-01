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
    public partial class cInscripcion : Form
    {
        public cInscripcion()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Inscripcion>();
            RepositorioBase<Inscripcion> rb = new RepositorioBase<Inscripcion>();

            if (checkBox.Checked == true) 
            {
                try
                {


                    if (CriteriotextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltrocomboBox.Text)
                        {
                            case "Todo":
                                listado = rb.GetList(p => true);
                                break;

                            case "Id":
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = rb.GetList(p => p.InscripcionId == id);
                                break;

                            case "Estudiante Id":
                                int est = Convert.ToInt32(CriteriotextBox.Text);
                                listado = rb.GetList(p => p.EstudianteId == est);
                                break;

                            case "Monto":
                                decimal monto = Convert.ToInt32(CriteriotextBox.Text);
                                listado = rb.GetList(p => p.Monto == monto);
                                break;

                            default:
                                break;
                        }
                        listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                    
                   
                        MyErrorProvider.Clear();
                        if (FiltrocomboBox.Text == string.Empty)
                        {
                            MyErrorProvider.SetError(FiltrocomboBox, "El campo Filtro no puede estar vacio");
                            FiltrocomboBox.Focus();

                        }
                        else
                            if (FiltrocomboBox.Text != "Todo")
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
                            listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                        }

                        ConsultadataGridView.DataSource = null;
                        ConsultadataGridView.DataSource = listado;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Introdujo un dato incorrecto");

                }
            }
            else
            {
                try
                {

                    if (CriteriotextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltrocomboBox.Text)
                        {
                            case "Todo":
                                listado = rb.GetList(p => true);
                                break;

                            case "Id":
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = rb.GetList(p => p.InscripcionId == id);
                                break;

                            case "Estudiante Id":
                                int est = Convert.ToInt32(CriteriotextBox.Text);
                                listado = rb.GetList(p => p.EstudianteId == est);
                                break;

                            case "Monto":
                                decimal monto = Convert.ToInt32(CriteriotextBox.Text);
                                listado = rb.GetList(p => p.Monto == monto);
                                break;

                            default:
                                break;
                        }
                    } else
                    {
                        listado = rb.GetList(p => true);
                    }
                    MyErrorProvider.Clear();
                    if (FiltrocomboBox.Text == string.Empty)
                    {
                        MyErrorProvider.SetError(FiltrocomboBox, "El campo Filtro no puede estar vacio");
                        FiltrocomboBox.Focus();

                    }
                    else
                        if (FiltrocomboBox.Text != "Todo")
                         {
                        if (CriteriotextBox.Text == string.Empty)
                        {
                            MyErrorProvider.SetError(CriteriotextBox, "El campo Criterio no puede estar vacio");
                            CriteriotextBox.Focus();
                        }
                    }
                    {
                        listado = rb.GetList(p => true);
                    }

                    ConsultadataGridView.DataSource = null;
                    ConsultadataGridView.DataSource = listado;              
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Introdujo un dato incorrecto");

                }

            }


        }
    }
    }

