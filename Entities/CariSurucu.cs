using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariSurucu
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? CartipId { get; set; }

    public string? CarKod { get; set; }

    public int? CarId { get; set; }

    public string? Ad { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
