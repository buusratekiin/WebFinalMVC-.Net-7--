using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class Film
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Producer { get; set; } = null!;

    public double Imdb { get; set; }

    public string Comment { get; set; } = null!;

    public string? Image { get; set; }

    public int Genreid { get; set; }

    public virtual ICollection<Award> Awards { get; set; } = new List<Award>();

    public virtual Genre Genre { get; set; } = null!;
}
