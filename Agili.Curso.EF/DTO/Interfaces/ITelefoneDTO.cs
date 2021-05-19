using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Curso.EF.DTO.Interfaces
{
    public interface ITelefoneDto
    {
        long Id { get; set; }
        string Numero { get; set; }
        string TipoTelefone { get; set; }
    }
}
