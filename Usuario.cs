using System.ComponentModel.DataAnnotations;

namespace ModeloBase
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Senha { get; set; }
    }
}
