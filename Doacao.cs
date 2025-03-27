using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Doacao
    {
        public int IdDoacao { get; set; }
        public string Descricao { get; set; }
        //public int Quantidade { get; set; }
        //public UnidadeMedida UnidadeMedida { get; set; }
        //public CategoriaAlimento CategoriaAlimento { get; set; }
        public DateTime DataDoacao { get; set; } = DateTime.Now;
        public int? DoadorId { get; set; }
        public Doador? Doador { get; set; }
        public StatusDoacao StatusDoacao { get; set; }


        
    }
}
