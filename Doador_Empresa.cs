using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Doador_Empresa
    {
        public int IdDoador_Empresa { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Cep { get; set; }
        public string? Endereco { get; set; }
        //public int? NumeroEndereco { get; set; }
        public string? Complemento { get; set; }
        public string NomeResponsavel { get; set; }
    }
}
