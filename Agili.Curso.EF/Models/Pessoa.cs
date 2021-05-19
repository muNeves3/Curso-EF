using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Curso.EF.Models
{
    public class Pessoa : IEntityId
    {
        public long Id { get; set; }
        public string Nome{ get; set; }
        public DateTime? Data{ get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Telefone> Telefones{ get; set; }

        public Pessoa()
        {
            Telefones = new List<Telefone>();
        }
    }
}
