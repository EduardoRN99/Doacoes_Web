using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public string Nome {get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string SenhaHash { get; set; }
        public string? Cpf {  get; set; }
    }
}
