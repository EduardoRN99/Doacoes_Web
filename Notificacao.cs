using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Notificacao
    {
        public int IdNotificacao { get; set; }
        public string Mensagem { get; set; }
        public string? Observacao { get; set; }
        public string tipoNotificacao { get; set; }
    }
}
