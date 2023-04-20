using System.ComponentModel.DataAnnotations;

namespace ModeloBase
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }

        [MaxLength(400)]
        public string Observacao { get; set; } = string.Empty;
    }
}
