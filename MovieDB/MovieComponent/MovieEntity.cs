using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesWebApp.MovieComponent
{
    public class MovieEntity
    {

        public MVCACTOR _actor { get; set; }
        public MVCDIRECTOR _director { get; set; }
        public MVCMOVy _movies { get; set; }
        public MVCMOVIECAST _moviecast { get; set; }
        public MVCMovieImage _movieimage { get; set; }

        //List<MVCMOVy> fGetAllMovies { get; }
        //List<MVCACTOR> fGetAllActor { get; }
        //List<MVCDIRECTOR> fGetAllDirector { get; }
        //List<MVCMOVIECAST> fGetAllCasting { get; }
    }
}