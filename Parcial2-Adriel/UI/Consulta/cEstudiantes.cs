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
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Estudiantes>();
            RepositorioBase<Estudiantes> rb = new RepositorioBase<Estudiantes>();

            if (checkBox.Checked == true)
            {


                try
                {
                    if (CriteriotextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltrocomboBox.Text)
                        {
                            case "Todos":
                                listado = rb.GetList(A => true);
                                break;

                            case "ID":
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = rb.GetList(E => E.EstudianteId == id);
                                break;

                            case "Nombres":
                                listado = rb.GetList(E => E.Nombres.Contains(CriteriotextBox.Text));
                                break;
                            case "Balance":
                                decimal balan = Convert.ToDecimal(CriteriotextBox.Text);
                                listado = rb.GetList(E => E.Balance == balan);
                                break;
                        }
                        listado = listado.Where(c => c.FechaIngresos.Date >= DesdedateTimePicker.Value.Date && c.FechaIngresos.Date <= HastadateTimePicker.Value.Date).ToList();
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
                    ConsultadataGridView.DataSource = null;
                    ConsultadataGridView.DataSource = listado;
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
                                listado = rb.GetList(p => p.EstudianteId == id);
                                break;

                            case "Nombre":
                                listado = rb.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                                break;


                            case "Balance":
                                decimal monto = Convert.ToInt32(CriteriotextBox.Text);
                                listado = rb.GetList(p => p.Balance == monto);
                                break;

                            default:
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
                        {
                            if ((string)FiltrocomboBox.Text != "Todos")
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
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Introdujo un dato incorrecto");

                }

                }
            }

        }
    }


