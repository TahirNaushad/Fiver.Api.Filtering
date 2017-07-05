﻿using System;
using System.Collections.Generic;

namespace Fiver.Api.Filtering.Models.Movies
{
    public class MovieOutputModel
    {
        public int Count { get; set; }
        public List<MovieInfo> Items { get; set; }
    }

    public class MovieInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Summary { get; set; }
        public string LeadActor { get; set; }
        public DateTime LastReadAt { get; set; }
    }
}
