using System.Collections.Generic;

#nullable disable

namespace ProjetoGAOS.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            OrdemDeServicos = new HashSet<OrdemDeServico>();
        }

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public virtual ICollection<OrdemDeServico> OrdemDeServicos { get; set; }
    }
}
