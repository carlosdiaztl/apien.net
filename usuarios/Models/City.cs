using System;
using System.Collections.Generic;

namespace usuarios.Models;

public partial class City
{
    public ulong Id { get; set; }

    public string CountryName { get; set; } = null!;

    public string Population { get; set; } = null!;

    public string CityName { get; set; } = null!;

    public string Latitude { get; set; } = null!;

    public string Longitude { get; set; } = null!;

    public string Capital { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CityUser> CityUsers { get; set; } = new List<CityUser>();
}
