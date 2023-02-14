using System.Collections.Generic;

namespace MoviesWebApp.MovieComponent
{
    public interface IMovieRepo
    {
       

        void AddMovie(MovieEntity _allmoviesDetails);
        List<MVCMOVy> GetAllMoviesDetails();
        //List<MVCMOVy> fGetAllMovies();
    
        List<MVCACTOR> fGetAllActor();
        List<MVCDIRECTOR> fGetAllDirector();
        List<MVCMOVIECAST> fGetAllCasting();

    }
}