using Microsoft.EntityFrameworkCore;
using Service.Models;
using Service.ViewModels;

namespace Service.Classes
{
    public class FilmService
    {
        FinalContext _context;
        public FilmService() {
            _context = new FinalContext();
        }
        public List<FilmVM> GetFilms()
        {
            var result = new List<FilmVM>();
            var list = _context.Films.Include(a=>a.Genre).ToList();
            
            
            foreach (var fil in list)
            {
                
               FilmVM vm = new FilmVM();
                vm.Id = fil.Id;
                vm.Name = fil.Name;
                vm.Producer = fil.Producer;
                vm.Genreid = fil.Genreid;
                vm.GenreName = fil.Genre.GenreName;
                vm.Imdb = fil.Imdb ;
                vm.Comment = fil.Comment;
                vm.Image = fil.Image;
                result.Add(vm);
            }

            return result;

        }

        public FilmCE_VM getFilmCE_VM()
        {
            var result = new FilmCE_VM();
            result.GenreList=_context.Genres.ToList();
            return result;
        }
        public void AddFilm(FilmVM vm)
        {
            var model = new Film();
            model.Id = vm.Id;
            model.Name = vm.Name;
            model.Producer = vm.Producer;
            model.Genreid = vm.Genreid;

            model.Imdb = vm.Imdb;
            model.Comment = vm.Comment;
            model.Image = vm.Image;
            _context.Films.Add(model);
            _context.SaveChanges();
        }
        public bool DeleteFilm(int id)
        {
            var model =_context.Films.Find(id);
            if (model == null)
            {
                return false;
            }
            _context.Films.Remove(model);
            _context.SaveChanges(true);
            return true;

        }
        public FilmCE_VM getFilmEdit_VM(int id)
        {
            var model= _context.Films.Find(id);
            var result = new FilmCE_VM();
            result.GenreList = _context.Genres.ToList();
            result.Id = model.Id;
            result.Name=model.Name; 
            result.Producer = model.Producer;
            result.Imdb= model.Imdb;
            result.Comment = model.Comment;
            result.Image = model.Image;
            result.Genreid= model.Genreid;
            return result;
        }
        public void EditFilm(FilmVM vm)
        {
            var model = _context.Films.Find(vm.Id);
            
           
            model.Name = vm.Name;
            model.Producer = vm.Producer;
            model.Genreid = vm.Genreid;

            model.Imdb = vm.Imdb;
            model.Comment = vm.Comment;
            model.Image = vm.Image;
            _context.Entry(model).State=EntityState.Modified;
            _context.SaveChanges();
        }

    }
}
