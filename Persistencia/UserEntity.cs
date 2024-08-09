using System.ComponentModel.DataAnnotations.Schema;

namespace AppConsole.Persistence;
[Table("USER_MODEL")]
public class UserEntity
{
    [Column("ID")]
    public int Id{get;set;}
    [Column("NOME")]
    public string Nome{get;set;}
}