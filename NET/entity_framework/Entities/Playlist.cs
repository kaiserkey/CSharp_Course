using System;
using System.Collections.Generic;

namespace entity_framework.Entities;

public partial class Playlist
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int VideoId { get; set; }

    public virtual Video Video { get; set; } = null!;
}
