using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RaporDeger
{
    public int Id { get; set; }

    public int? KayId { get; set; }

    public string? RapKod { get; set; }

    public string? Ack { get; set; }

    public int? MasId { get; set; }

    public int? ParId { get; set; }

    public double? Deger { get; set; }

    public string? TableName { get; set; }

    public int? TableId { get; set; }

    public int? GrpNo { get; set; }
}
