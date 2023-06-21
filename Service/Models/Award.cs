using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class Award
{
    public int Id { get; set; }

    public string Awardname { get; set; } = null!;

    public int Filmid { get; set; }

    public int Year { get; set; }

    public virtual Film Film { get; set; } = null!;
}
