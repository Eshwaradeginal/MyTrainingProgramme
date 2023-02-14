using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesWebApp.MovieComponent
{
    public class MovieRepo : IMovieRepo
    {
        public readonly MovieDbDataContext _context = new MovieDbDataContext();

       

        public List<MVCMOVy> fGetAllMovies()
        {
            return GetAllMovies();
            
        }
        public List<MVCACTOR> fGetAllActor()
        {
            return GetAllActor();
            
            
          
        }
        public List<MVCDIRECTOR> fGetAllDirector()
        {
            
            return GetAllDirector();
            
            
        }
        public List<MVCMOVIECAST> fGetAllCasting()
        {
           
            return GetAllCast();
        }
        List<MVCACTOR> GetAllActor() => _context.MVCACTORs.ToList();
        List<MVCDIRECTOR> GetAllDirector() => _context.MVCDIRECTORs.ToList();
        List<MVCMOVy> GetAllMovies() => _context.MVCMOVies.ToList();
        List<MVCMOVIECAST> GetAllCast() => _context.MVCMOVIECASTs.ToList();


        public void AddMovie(MovieEntity _allmoviesDetails)
        {
            AddNewActor(_allmoviesDetails._actor);
            AddNewDirector(_allmoviesDetails._director);
            AddNewMovies(_allmoviesDetails._movies);
            AddNewMoviecast(_allmoviesDetails._moviecast,_allmoviesDetails._actor,_allmoviesDetails._movies);
        }

        private void  AddNewMoviecast(MVCMOVIECAST moviecast, MVCACTOR actid, MVCMOVy movid)
        {
            List<MVCMOVIECAST> movcst = new List<MVCMOVIECAST>();
            movcst.Add(new MVCMOVIECAST {
                ACTID=actid.ACTID,MOVID=movid.MOVID,ROLE=moviecast.ROLE
            });
           _context.MVCMOVIECASTs.InsertAllOnSubmit(movcst);
            _context.SubmitChanges();
        }

        private void AddNewMovies(MVCMOVy movies)
        {
            _context.MVCMOVies.InsertOnSubmit(movies);
            _context.SubmitChanges();
        }

        private void AddNewDirector(MVCDIRECTOR director)
        {

            _context.MVCDIRECTORs.InsertOnSubmit(director);
            _context.SubmitChanges();

        }

        private void AddNewActor(MVCACTOR actor)
        {
            _context.MVCACTORs.InsertOnSubmit(actor);
            _context.SubmitChanges();
        }

        public List<MVCMOVy> GetAllMoviesDetails()
        {
            throw new NotImplementedException();
        }
    }
}