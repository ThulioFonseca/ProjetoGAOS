using System;
using System.Collections.Generic;


#nullable disable

namespace ProjetoGAOS.Models
{
    public partial class OrdemDeServico
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Status { get; set; }
        public string Identificador { get; set; }
        public string Cliente { get; set; }
        public string Orcamento { get; set; }
        public string Tipo { get; set; }
        public string Motivo { get; set; }

        public virtual Cliente ClienteNavigation { get; set; }
        public virtual Dispositivo IdentificadorNavigation { get; set; }
    }



    
}
