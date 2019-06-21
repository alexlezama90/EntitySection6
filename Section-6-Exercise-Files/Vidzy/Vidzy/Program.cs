using System;
using System.Linq;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            #region Exercise 1
            //var actionMoviesSortedByName =
            //    context.Videos.Where(v => v.Genre.Name == "Action").OrderBy(v => v.Name);

            //foreach (var actionMovie in actionMoviesSortedByName)
            //{
            //    Console.WriteLine(actionMovie.Name);
            //}
            #endregion

            #region Exercise 2
            //var goldDramaMoviesSortedByReleaseDate =
            //    context.Videos
            //    .Where(v => v.Classification == Classification.Gold && v.Genre.Name == "Drama")
            //    .OrderByDescending(v => v.ReleaseDate);

            //foreach(var movie in goldDramaMoviesSortedByReleaseDate)
            //    Console.WriteLine(movie.Name);
            #endregion

            #region Exercise 3
            //var moviesProjectedIntoAnonymousType =
            //    context.Videos.Select(v => new
            //    {
            //        MovieName = v.Name,
            //        Genre = v.Genre
            //    });

            //foreach(var movie in moviesProjectedIntoAnonymousType)
            //    Console.WriteLine("Movie: {0}, Genre: {1}", movie.MovieName, movie.Genre.Name);          
            #endregion

            #region Exercise 4      //Repasar esto!!!
            //var groupsOfMoviesGroupedByClassification =
            //    context.Videos.GroupBy(v => v.Classification).Select(g => new
            //    {
            //        Classification = g.Key.ToString(),
            //        Videos = g.OrderBy(v => v.Name)
            //    });

            //foreach (var group in groupsOfMoviesGroupedByClassification)
            //{
            //    Console.WriteLine("Classification: " + group.Classification);

            //    foreach(var video in group.Videos)
            //        Console.WriteLine("\t" + video.Name);
            //}
            #endregion

            #region Exercise5 //Repasar tambien
            //var classificationsOrderedByNameWithNumberOfMovies =
            //    context.Videos.GroupBy(v => v.Classification).Select(g => new
            //    {
            //        Name = g.Key.ToString(),
            //        VideosCount = g.Count()
            //    })
            //    .OrderBy(c=>c.Name);

            //foreach(var classification in classificationsOrderedByNameWithNumberOfMovies)
            //    Console.WriteLine("{0} ({1})", classification.Name, classification.VideosCount);
            #endregion

            #region Exercise 6 //Repasar
            //var genresWithNumberOfVideosTheyIncludeSortedByNumberOfVideos =
            //    context.Genres
            //    .GroupJoin(context.Videos, g => g.Id, v => v.GenreId, (genre, videos) => new
            //    {
            //        Name = genre.Name,
            //        VideosCount = videos.Count()
            //    })
            //    .OrderByDescending(a => a.VideosCount);

            //foreach(var genre in genresWithNumberOfVideosTheyIncludeSortedByNumberOfVideos)
            //    Console.WriteLine("{0} ({1})", genre.Name, genre.VideosCount);
            #endregion
        }
    }
}
