using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModels
{
    public class FilmVM
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Producer { get; set; } = null!;

        public double Imdb { get; set; }

        public string Comment { get; set; } = null!;

        public string? Image { get; set; }

        public int Genreid { get; set; }
        public string GenreName { get; set; }

        
    }
}
