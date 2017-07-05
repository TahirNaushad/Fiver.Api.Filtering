using Fiver.Api.Filtering.Lib;
using System.Collections.Generic;

namespace Fiver.Api.Filtering.OtherLayers
{
    public interface IMovieService
    {
        List<Movie> GetMovies(FilteringParams filteringParams);
    }
}
