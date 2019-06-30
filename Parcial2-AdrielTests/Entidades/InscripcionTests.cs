using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_Adriel.BLL;
using Parcial2_Adriel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Adriel.Entidades.Tests
{
    [TestClass()]
    public class InscripcionTests
    {
        [TestMethod()]
        public void InscripcionGuardarTest()
        {
            Inscripcion i = new Inscripcion();
            i.InscripcionId = 1;
            i.EstudianteId = 1;
            i.Fecha = DateTime.Now;
            i.Monto = 200;


            RepositorioBase<Inscripcion> r = new RepositorioBase<Inscripcion>();
            bool paso = false;
            paso = r.Guardar(i);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void InscripcionModificarTest()
        {
            RepositorioBase<Inscripcion> repositorio = new RepositorioBase<Inscripcion>();
            bool paso = false;
            Inscripcion i = repositorio.Buscar(1);
            i.Monto = 100;
            paso = repositorio.Modificar(i);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void InscripcionBuscarTest()
        {
            RepositorioBase<Inscripcion> repositoriobase = new RepositorioBase<Inscripcion>();
            Inscripcion i = repositoriobase.Buscar(1);
            Assert.IsNotNull(i);
        }

        [TestMethod()]
        public void InscripcionGetListTest()
        {
            RepositorioBase<Inscripcion> repositorio = new RepositorioBase<Inscripcion>();
            List<Inscripcion> lista = new List<Inscripcion>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void InscripcionEliminarTest()
        {
            RepositorioBase<Inscripcion> repositoriobase = new RepositorioBase<Inscripcion>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }


    }
}