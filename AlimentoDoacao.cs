using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Enums;

namespace Domain.Entities.Models
{
    public class AlimentoDoacao
    {
        public int IdAlimentoDoacao { get; set; }
        public int IdDoacao { get; set; }
        public int IdAlimento {  get; set; }
        public string DataValidade { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public CategoriaAlimento CategoriaAlimento { get; set; }
        public int Quantidade { get; set; }

    }
}
