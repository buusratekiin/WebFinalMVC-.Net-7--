﻿using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class Register
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Paswordd { get; set; } = null!;
}
