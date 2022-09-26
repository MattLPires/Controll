using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controll.Models
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        [Display(Name="Codigo")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name="Tipo Usuário")]
        [Column("NomeTipoUsuario")]
        public string NomeTipoUsuario { get; set; }
    }
}
