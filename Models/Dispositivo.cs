using System.Collections.Generic;

#nullable disable

namespace ProjetoGAOS.Models
{
    public partial class Dispositivo
    {
        public Dispositivo()
        {
            OrdemDeServicos = new HashSet<OrdemDeServico>();
        }

        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Categoria { get; set; }
        public string Identificador { get; set; }

        public virtual ICollection<OrdemDeServico> OrdemDeServicos { get; set; }
    }
}
