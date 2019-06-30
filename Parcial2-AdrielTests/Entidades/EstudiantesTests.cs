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
    public class EstudiantesTests
    {
        [TestMethod()]
        public void EstudianteGuardarTest()
        {
            Estudiantes e = new Estudiantes();
            e.EstudianteId = 1;
            e.FechaIngresos = DateTime.Now;
            e.Nombres = "Adriel";
            e.Balance = 1000;

            RepositorioBase<Estudiantes> r = new RepositorioBase<Estudiantes>();
            bool paso = false;
            paso = r.Guardar(e);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EstudianteModificarTest()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            bool paso = false;
            Estudiantes e = repositorio.Buscar(1);
            e.Nombres = "Pedro";
            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EstudianteBuscarTest()
        {
            RepositorioBase<Estudiantes> repositoriobase = new RepositorioBase<Estudiantes>();
            Estudiantes e = repositoriobase.Buscar(1);
            Assert.IsNotNull(e);
        }

        [TestMethod()]
        public void EstudianteGetListTest()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            List<Estudiantes> lista = new List<Estudiantes>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EstudiantesEliminarTest()
        {
            RepositorioBase<Estudiantes> repositoriobase = new RepositorioBase<Estudiantes>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }

    }
}