using Agili.Curso.EF.Context;
using Agili.Curso.EF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Curso.EF.Tests
{
    [TestClass]
    public class ComMapTest
    {
        [TestMethod]
        public void InsertComConfiguracao()
        {
            using (var con = new ComConfiguraçaoContext())
            {
                var item = new Item() { Nome = "Item1" };
                con.Set<Item>().Add(item);
                 _ = con.SaveChanges();
            }
        }
    }
}
