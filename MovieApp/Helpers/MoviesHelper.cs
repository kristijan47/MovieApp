using MovieApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Helpers
{
   public class MoviesHelper
    {
        public static List<Movie> GetAllMarvelMovies()
        {
            return new List<Movie>()
            {
                new Movie(){ Title = "Iron Man", Year = 2008, Rating = 8.9f, Duration = 135 },
                new Movie(){ Title = "The Incredible Hulk", Year = 2008, Rating = 6.7f, Duration = 112 },
                new Movie(){ Title = "Iron Man 2", Year = 2010, Rating = 7, Duration = 124 },
                new Movie(){ Title = "Thor,", Year = 2011, Rating = 7, Duration = 115},
                new Movie(){ Title = "Captain America: The First Avenger", Year = 2011, Rating = 6.9f, Duration = 124},
                new Movie(){ Title = "The Avengers",Year = 2012, Rating = 8, Duration = 143},
                new Movie(){ Title = "Iron Man 3", Year = 2013, Rating = 7.2f, Duration =130 },
                new Movie(){ Title = "Thor: The Dark World", Year = 2013, Rating = 6.9f, Duration = 112},
                new Movie(){ Title = "Captain America: The Winter Soldier", Year = 2014, Rating = 7.7f, Duration = 136},
                new Movie(){ Title = "Guardians of the Galaxy", Year = 2014, Rating = 8, Duration = 121},
                new Movie(){ Title = "Avengers: Age of Ultron", Year = 2015, Rating = 7.3f, Duration = 141},
                new Movie(){ Title = "Ant-Man", Year = 2015, Rating = 7.3f, Duration = 117},
                new Movie(){ Title = "Captain America: Civil War", Year = 2016, Rating = 7.8f, Duration = 147},
                new Movie(){ Title = "Doctor Strange", Year = 2016, Rating = 7.5f, Duration = 115},
                new Movie(){ Title = "Guardians of the Galaxy Vol. 2", Year = 2017, Rating = 7.6f, Duration = 136},
                new Movie(){ Title = "Spider-Man: Homecoming", Year = 2017, Rating = 7.4f, Duration = 133},
                new Movie(){ Title = "Thor: Ragnarok", Year = 2017, Rating = 7.9f, Duration = 130},
                new Movie(){ Title = "Black Panther", Year = 2018, Rating = 7.3f, Duration = 134},
                new Movie(){ Title = "Avengers: Infinity War", Year = 2018, Rating = 8.5f,  Duration = 149},
                new Movie(){ Title = "Ant-Man and the Wasp", Year = 2018, Rating = 7.1f, Duration = 118},
                new Movie(){ Title = "Captain Marvel", Year = 2019, Rating = 6.9f, Duration = 123},
                new Movie(){ Title = "Avengers: Endgame", Year = 2019, Rating = 8.4f, Duration = 181},
                new Movie(){ Title = "Spider-Man: Far from Home", Year = 2019, Rating = 7.5f, Duration = 129}
                 

            };
        }

    }
}
