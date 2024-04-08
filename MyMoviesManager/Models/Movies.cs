﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MyMoviesManager.Models;

public partial class Movies
{


    public int MovieId { get; set; }

    public string Title { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string Category { get; set; }

    public string Availability { get; set; }

    public double? Imdbrating { get; set; }

    public string ImagePath { get; set; }

    public bool? Watched { get; set; }

    public DateTime? WatchedDate { get; set; }

    public virtual ICollection<Actors> Actors { get; set; } = new List<Actors>();

    
}