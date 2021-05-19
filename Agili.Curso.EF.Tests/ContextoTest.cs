using Agili.Curso.EF.Models;
using Agili.Curso.EF.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Curso.EF.Tests
{
    [TestClass]
    public class ContextoTest
    {
        [TestMethod]
        public void InserirContexto()
        {
            using (var con = new Contexto())
            {
                var item = new Item() { Nome = "Item1" };
                con.Set<Item>().Add(item);
                var qtde = con.SaveChanges();
            }
        }
        [TestMethod]
        public void Get_all()
        {
            using (var con = new Contexto())
            {
                var dados = con.Set<Item>().ToList();
            }
        }
    }
}
