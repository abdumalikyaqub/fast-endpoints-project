using FastEndApp.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastEndApp.Core.Entities;

[Table("users")]
public class User : BaseEntity
{
    [Column("firstname")]
    public string FirstName { get; set; } = default!;

    [Column("lastname")]
    public string LastName { get; set; } = default!;

    [Column("age")]
    public int Age { get; set; } = default!;
}
