using System;
using System.Collections.Generic;

namespace usuarios.Models;

public partial class CityUser
{
    public ulong Id { get; set; }

    public ulong UserId { get; set; }

    public ulong CityId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
