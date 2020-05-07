using MovieApp.Entities;
using MovieApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = MoviesHelper.GetAllMarvelMovies();
            #region 1
            ////* Find all movies that their titles starts with "L"

            //var allMoviesStartingWithL = movies.
            //                             Where(movie => movie.Title.StartsWith("L")).ToList();

            //foreach (var item in allMoviesStartingWithL)
            //{                            
            //    Console.WriteLine(item.Title);
            //}

            // Query Syntax

            //var querySyntaxOne = (from movie in movies
            //                      where movie.Title.StartsWith("L")
            //                      select movie.Title).ToList();

            //foreach (var item in querySyntaxOne)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            //* Find the NUMBER of movies that have rating higher than 7.5
            #region 2
            //var moviesWithRatingHigher = movies.
            //                             Count(movie => movie.Rating >= 7.5f);

            // Query Syntax

            //var querySyntaxTwo = (from movie in movies
            //                      where movie.Rating >= 7.5
            //                      select movie.Rating).Count();


            //Console.WriteLine(querySyntaxTwo);


            //Console.WriteLine(moviesWithRatingHigher);
            #endregion
            //* Find all movies TITLES with year of production before 2005

            #region 3
            //var movieTitlesBefore2005 = movies.
            //                            Where(movie => movie.Year <= 2005).ToList();
            //foreach (var item in movieTitlesBefore2005)
            //{
            //    Console.WriteLine(item.Title);
            //}

            // Query Syntax

            //var querySyntaxThree = (from movie in movies
            //                        where movie.Year <= 2005
            //                        select movie.Title
            //    );
            //foreach (var item in querySyntaxThree)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4
            //* Find all movies TITLES and RATING that have rating higher then 8.0

            //var movieTitlesAndRating = movies.
            //                            Where(movie => movie.Rating > 8.0).
            //                            Select(movie => new { Title = movie.Title, Rating = movie.Rating }).
            //                            ToList();

            //foreach (var item in movieTitlesAndRating)
            //{
            //    Console.WriteLine($"{item.Title} Rating:  {item.Rating}");
            //}

            // Query Syntax

            //var querySyntaxFour = (from movie in movies
            //                       where movie.Rating > 8.0
            //                       select movie.Title
            //                       ).ToList();

            //foreach (var item in querySyntaxFour)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 5


            //* Find first 5 movies that have duration time longer then 2 hours

            //var firstFiveMoviesLongerThan2Hours = movies.
            //                            Where(movie => movie.Duration > 120).
            //                            Take(5).ToList();
            //foreach (var item in firstFiveMoviesLongerThan2Hours)
            //{
            //    Console.WriteLine(item.Title);
            //}

            // Query Syntax

            //var querySyntaxFive = (from movie in movies
            //                       where movie.Duration > 120
            //                       select movie.Title)
            //                       .Take(5).ToList();
            //foreach (var item in querySyntaxFive)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 6

            //* Find last 3 movies TITLES and DURATION that have duration less then 2 hours

            //var lastThreeMovies = movies.
            //                        Where(movie => movie.Duration <= 120).
            //                        TakeLast(3).ToList();
            //foreach (var item in lastThreeMovies)
            //{
            //    Console.WriteLine($"{item.Title}, {item.Duration}");
            //}

            // Query Syntax

            //var querySyntaxSeven = (from movie in movies
            //                        where movie.Duration <= 120
            //                        select movie.Title).TakeLast(3).ToList();

            //foreach (var item in querySyntaxSeven)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 7
            //*Find all movies TITLES and RATING and order them by DURATION(DESC) -no condition needed

            //var moviesSortedByDurationDescending = movies.
            //                         OrderByDescending(movie => movie.Duration).
            //                         Select(movie => new { Title = movie.Title, Rating = movie.Rating , Duration = movie.Duration}).
            //                         ToList();
            //foreach (var item in moviesSortedByDurationDescending)
            //{
            //    Console.WriteLine($"Title: {item.Title}, Movie Rating: {item.Rating}, Movie Duration: {item.Duration}");
            //}
            // Query Syntax

            //var querySyntaxSeven = (from movie in movies
            //                        orderby movie.Duration descending
            //                        select movie).Select(movie => new { movie.Title, movie.Rating, movie.Duration}).ToList();
            //querySyntaxSeven.ForEach(movie => Console.WriteLine(movie));
            #endregion
            #region 8

            //* Find all movies with TITLES that don't start with A and TITLES include more than 7 characters
            //var movieTitlesDontStartWithA = movies.
            //                            Where(movie => !movie.Title.StartsWith("A") && movie.Title.Length > 7);
            //foreach (var item in movieTitlesDontStartWithA)
            //{
            //    Console.WriteLine(item.Title);
            //}

            //Query Syntax 
            //var querySyntaxEight = (from movie in movies
            //                        where !movie.Title.StartsWith('A') &&
            //                        movie.Title.Length > 7
            //                        select movie.Title
            //                        ).ToList();
            //foreach (var item in querySyntaxEight)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 9
            //* Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour and 50min

            //var moviesRatingDuration = movies.
            //                           Where(movie => movie.Rating > 7.2 && movie.Duration < 110).
            //                           Select(movie => new { Title = movie.Title , Rating = movie.Rating, Duration = movie.Duration}).
            //                           ToList();
            //foreach (var item in moviesRatingDuration)
            //{
            //    Console.WriteLine($"{item.Title}, {item.Rating}, {item.Duration}");
            //}

            //Query Syntax 
            //var querySyntaxNine = (from movie in movies
            //                       where movie.Rating > 7.2 && movie.Duration < 110
            //                       select movie).Select(movie => new { movie.Title, movie.Rating });

            //foreach (var item in querySyntaxNine)
            //{
            //    Console.WriteLine(item);
            //}

            //* Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION
            //longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)
            #endregion

            #region 10
            //var complexMovieSorting = movies.
            //                         Where(movie => movie.Title.Length < 10 &&
            //                         movie.Duration > 120 &&
            //                         movie.Rating > 6.7).
            //                         Select(movie => movie.Title).
            //                         OrderBy(title => title).
            //                         ToList();

            //foreach (var item in complexMovieSorting)
            //{
            //    Console.WriteLine(item);
            //}

            //var querySyntaxTen = (from movie in movies
            //                      where movie.Title.Length < 10 &&
            //                      movie.Duration > 120 &&
            //                      movie.Rating > 6.7
            //                      select movie).OrderBy(title => title).ToList();

            //querySyntaxTen.ForEach(movie => Console.WriteLine($"{movie.Title} Rating: {movie.Rating}"));
            #endregion
            //Console.ReadLine();



        }
    }
}
