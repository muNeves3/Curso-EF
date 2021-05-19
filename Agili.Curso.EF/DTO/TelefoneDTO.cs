using Agili.Curso.EF.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Curso.EF.DTO
{
    public class TelefoneDTO : ITelefoneDto
    {
            public long Id { get; set; }
            public string Numero { get; set; }
            public string TipoTelefone { get; set; }
    }
}
