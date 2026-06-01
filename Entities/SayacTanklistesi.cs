using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class SayacTanklistesi
{
    public decimal Id { get; set; }

    public string SayacKod { get; set; } = null!;

    public string? SayacAd { get; set; }

    public string TankKod { get; set; } = null!;

    public string? TankAd { get; set; }

    public string Bagak { get; set; } = null!;
}
