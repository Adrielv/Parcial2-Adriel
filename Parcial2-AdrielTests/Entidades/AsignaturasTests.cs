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
    public class AsignaturasTests
    {
        [TestMethod()]
        public void AsignaturaGuardarTest()
        {
            Asignaturas a = new Asignaturas();
            a.AsignaturaId = 1;
            a.Descripcion = "Matematicas";
            a.Creditos = 5;

            RepositorioBase<Asignaturas> r = new RepositorioBase<Asignaturas>();
            bool paso = false;
            paso = r.Guardar(a);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void AsignaturaModificarTest()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            bool paso = false;
            Asignaturas a = repositorio.Buscar(2);
            a.Creditos = 4;
            paso = repositorio.Modificar(a);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void AsignaturasBuscarTest()
        {
            RepositorioBase<Asignaturas> repositoriobase = new RepositorioBase<Asignaturas>();
            Asignaturas a = repositoriobase.Buscar(2);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void AsignaturasGetListTest()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            List<Asignaturas> lista = new List<Asignaturas>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void AsignaturaEliminarTest()
        {
            RepositorioBase<Asignaturas> repositoriobase = new RepositorioBase<Asignaturas>();
            bool paso = false;
            paso = repositoriobase.Eliminar(2);
            Assert.AreEqual(true, paso);
        }
    }
}