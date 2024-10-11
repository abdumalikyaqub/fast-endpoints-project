using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastEndApp.Core.Common;

public abstract class BaseEntity
{
    /// <summary>
    /// User ID
    /// </summary>
    [Column("user_id")]
    [Key]
    public Guid Id { get; set; }

    [Column("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; } 
}
