using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class Genre
{
    public int Id { get; set; }

    public string GenreName { get; set; } = null!;

    public virtual ICollection<Film> Films { get; set; } = new List<Film>();
}
