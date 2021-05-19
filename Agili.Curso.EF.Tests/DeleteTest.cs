using Agili.Curso.EF.Context;
using Agili.Curso.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Agili.Curso.EF.Tests
{
    public class DeleteTest
    {
        [Fact]
        public void Delete_com_referencia_do_objeto()
        {
            using (var con = new Contexto())
            {
                try
                {
                    //Remove através do objeto selecionado
                    var telefone = con.Set<Telefone>().FirstOrDefault();
                    con.Set<Telefone>().Remove(telefone);
                    con.SaveChanges();
                }catch(DbUpdateConcurrencyException e)
                {
                    Console.WriteLine(e);
                }
              
            }
        }

        [Fact]
        public void Delete_sem_objeto_retornado_do_banco()
        {
            using (var con = new Contexto())
            {
                try
                {
                    //Remove mesmo tendo somente o Id
                    var telefoneNew = new Telefone() { Id = 51 };
                    con.Entry(telefoneNew).State = System.Data.Entity.EntityState.Deleted;
                    con.SaveChanges();
                }catch(DbUpdateConcurrencyException e)
                {
                    Console.WriteLine(e);
                }
             
            }
        }
        [Fact]
        public void Delete_com_referencia_do_objeto_state()
        {
            using (var con = new Contexto())
            {
                //Esta é a forma que "internamente" é utilizado no Blue, pois para validar a Entidade fazer a busca dos dados
                //E depois setamos para excluído, isto se faz necessário, pois além das validações da regra de negócio, 
                //se necessitarmos saber o valor da entidade antes do delete do registros para fazer uma auditoria por exemplo, 
                //precisamos desta informação
                var telefone = con.Set<Telefone>().FirstOrDefault();
                con.Entry(telefone).State = System.Data.Entity.EntityState.Deleted;
                con.SaveChanges();
            }
        }
    }
}
