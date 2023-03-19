﻿using System;
using System.Collections.Generic;

namespace net_project.Models;

public partial class Video
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Playlist> Playlists { get; } = new List<Playlist>();
}
