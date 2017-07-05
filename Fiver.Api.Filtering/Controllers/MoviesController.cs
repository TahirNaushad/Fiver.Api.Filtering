using Fiver.Api.Filtering.Lib;
using Fiver.Api.Filtering.Models.Movies;
using Fiver.Api.Filtering.OtherLayers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiver.Api.Filtering.Controllers
{
    [Route("movies")]
    public class MoviesController : Controller
    {
        private readonly IMovieService service;

        public MoviesController(IMovieService service)
        {
            this.service = service;
        }

        [HttpGet(Name = "GetMovies")]
        public IActionResult Get(FilteringParams filteringParams)
        {
            var model = service.GetMovies(filteringParams);
            
            var outputModel = new MovieOutputModel
            {
                Count = model.Count,
                Items = model.Select(m => ToMovieInfo(m)).ToList(),
            };
            return Ok(outputModel);
        }
        
        #region " Mappings "

        private MovieInfo ToMovieInfo(Movie model)
        {
            return new MovieInfo
            {
                Id = model.Id,
                Title = model.Title,
                ReleaseYear = model.ReleaseYear,
                Summary = model.Summary,
                LeadActor = model.LeadActor,
                LastReadAt = DateTime.Now
            };
        }

        #endregion
    }
}
