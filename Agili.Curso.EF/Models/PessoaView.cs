﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Curso.EF.Models
{
    public class PessoaView : IEntityId
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
